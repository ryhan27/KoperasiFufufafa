using KoperasiFufufafa.Models;   // contoh: tempat class Loan, Member, LoanMaster, dll
using KoperasiFufufafa.Services; // contoh: tempat class AppDbContext, LoanService, ProductService, dll
using KoperasiFufufafa.Utils;    // contoh: tempat class FileHelper, RandomNumberGenerator, dll
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KoperasiFufufafa.Forms
{
    public partial class LoanPage : UserControl
    {
        Member loggedMember;
        InstallmentForm installmentForm;

        public LoanPage(Member member)
        {
            loggedMember = member;
            InitializeComponent();
        }

        private void LoanPage_Load(object sender, EventArgs e)
        {
            AppDbContext db = new AppDbContext();

            SetLoanDropdown(db);
            SetDefaultField();
            ResetField();
            LoadLoanGrid(db);
            HideInstallment();
        }

        // === UPLOAD DOKUMEN ===
        private void btnBrowseKTP_Click(object sender, EventArgs e)
        {
            txtKTP.Text = FileHelper.UploadDocument("KTP");
        }

        private void btnBrowseKK_Click(object sender, EventArgs e)
        {
            txtKK.Text = FileHelper.UploadDocument("KK");
        }

        private void btnBrowseGaji_Click(object sender, EventArgs e)
        {
            txtGaji.Text = FileHelper.UploadDocument("Slip Gaji");
        }

        // === COMBOBOX DROPDOWN LOAN TYPE ===
        private void SetLoanDropdown(AppDbContext db)
        {
            ProductService productService = new ProductService(db);
            cmbType.DataSource = productService.SetDropdownLoan();
            cmbType.DisplayMember = "DisplayName";
            cmbType.ValueMember = "Id";
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            SetDefaultField();
            btnApply.Enabled = true;
            cmbType.Enabled = true;
            HideInstallment();
        }

        // === KONDISI DEFAULT (BARU) ===
        private void SetDefaultField()
        {
            cmbType.SelectedIndex = 0;
            btnShowKTP.Visible = false;
            btnShowKK.Visible = false;
            btnShowGaji.Visible = false;
            btnBrowseKTP.Visible = true;
            btnBrowseKK.Visible = true;
            btnBrowseGaji.Visible = true;
        }

        // === KONDISI SUDAH ADA DATA ===
        private void SetChosenField()
        {
            btnShowKTP.Visible = true;
            btnShowKK.Visible = true;
            btnShowGaji.Visible = true;
            btnBrowseKTP.Visible = false;
            btnBrowseKK.Visible = false;
            btnBrowseGaji.Visible = false;
        }

        // === RESET SEMUA FIELD ===
        private void ResetField()
        {
            txtKTP.Text = "";
            txtKK.Text = "";
            txtGaji.Text = "";
            txtDate.Text = "";
            txtInterest.Text = "";
            txtTenor.Text = "";
            txtFine.Text = "";
            txtMin.Text = "";
            txtMax.Text = "";
            txtLoan.Text = RandomNumberGenerator.GetString("1234567890", 6);
            txtAdmin.Text = "";
        }

        // === LOAD DATA LOAN KE DATAGRID ===
        private async void LoadLoanGrid(AppDbContext db)
        {
            LoanService loanService = new LoanService(db);
            dgvLoan.DataSource = await loanService.LoadLoanGrid(loggedMember.Id);
            dgvLoan.Columns[0].DataPropertyName = "Id";
            dgvLoan.Columns[1].DataPropertyName = "LoanId";
            dgvLoan.Columns[2].DataPropertyName = "Outstanding";
            dgvLoan.Columns[3].DataPropertyName = "TenorLeft";

            dgvLoan.Columns[0].Visible = false;
            dgvLoan.Columns[1].HeaderText = "Loan ID";
            dgvLoan.Columns[2].HeaderText = "Outstanding";
            dgvLoan.Columns[3].HeaderText = "Tenor Left";
        }

        // === KETIKA ROW DIPILIH DI DATAGRID ===
        private async void dgvLoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvLoan.Rows[e.RowIndex];
                int id = Convert.ToInt32(row.Cells[0].Value.ToString());
                AppDbContext db = new AppDbContext();
                LoanService loanService = new LoanService(db);
                var loan = await loanService.FindLoan(id);
                if (loan != null)
                {
                    if (loan.IsApproved)
                    {
                        SetChosenField();
                        txtKTP.Text = loan.KtpPath;
                        txtKK.Text = loan.KkPath;
                        txtGaji.Text = loan.SlipGajiPath;
                        txtDate.Text = loan.DueDate.ToString();
                        txtInterest.Text = loan.InterestRate.ToString();
                        txtTenor.Text = loan.Tenor.ToString();
                        txtFine.Text = loan.Amount.ToString();
                        txtAdmin.Text = loan.AdminFee.ToString();
                        txtAmount.Text = loan.TotalAmount.ToString();
                        txtLoan.Text = loan.Id.ToString();
                        cmbType.SelectedIndex = 0;
                        cmbType.Enabled = false;

                        if (installmentForm == null)
                            installmentForm = new InstallmentForm(loggedMember, 0);
                        installmentForm.SetLoan(loan.Id);
                        installmentForm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Your Loan is not approved yet.", "Approval", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        HideInstallment();
                    }
                    btnApply.Enabled = false;
                }
            }
        }

        // === SAAT TOMBOL APPLY DIKLIK ===
        private async void btnApply_Click(object sender, EventArgs e)
        {
            AppDbContext db = new AppDbContext();
            LoanService loanService = new LoanService(db);
            decimal amount = decimal.Parse(txtMin.Text);
            decimal maxAmount = decimal.Parse(txtMax.Text);

            if (amount > maxAmount || amount < amount)
            {
                MessageBox.Show("Invalid amount.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            await loanService.SaveOrUpdate(loggedMember, txtLoan.Text,
                txtKTP.Text, txtKK.Text, txtGaji.Text, txtDate.Text,
                txtInterest.Text, txtTenor.Text);
        }

        // === SEMBUNYIKAN FORM CICILAN ===
        private void HideInstallment()
        {
            if (installmentForm == null)
                installmentForm = new InstallmentForm(loggedMember, 0);
            installmentForm.Hide();
        }

        // === RESET COMBOBOX DROPDOWN ===
        private void ResetDropdown()
        {
            txtInterest.Text = "";
            txtTenor.Text = "";
            txtFine.Text = "";
            txtMin.Text = "";
            txtMax.Text = "";
        }

        // === SAAT COMBOBOX TYPE DIPILIH ===
        private async void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResetDropdown();

            if (cmbType.SelectedIndex > 0)
            {
                int idLoanMaster = int.Parse(cmbType.SelectedValue.ToString());
                AppDbContext db = new AppDbContext();
                ProductService productService = new ProductService(db);
                LoanMaster? loanMaster = await productService.FindLoanById(idLoanMaster);
                if (loanMaster != null)
                {
                    txtInterest.Text = loanMaster.Interest.ToString();
                    txtFine.Text = loanMaster.Fine.ToString();
                    txtTenor.Text = loanMaster.Tenor.ToString();
                    txtMin.Text = loanMaster.MinAmount.ToString();
                    txtMax.Text = loanMaster.MaxAmount.ToString();
                }
                else
                {
                    ResetDropdown();
                }
            }
        }

        // === TOMBOL RELOAD ===
        private void btnReload_Click(object sender, EventArgs e)
        {
            AppDbContext db = new AppDbContext();
            SetLoanDropdown(db);
            SetDefaultField();
            ResetField();
            LoadLoanGrid(db);
            HideInstallment();
        }
    }
}
