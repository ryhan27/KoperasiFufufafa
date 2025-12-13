using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KoperasiFufufafa.Forms.Public_Menu
{
    public partial class SavingPage : UserControl
    {
        
        public SavingPage(Member member)
        {
            LoggedMember = member;
            InitializeComponent();
        }

   
        public SavingPage()
        {
            InitializeComponent();
        }

        private void ResetField()
        {
            textDocKK.Text = "";
            textDocKtp.Text = "";
            textDocSlip.Text = "";
            textDueDate.Text = "";
            textAmount.Text = "";

            ResetDropDown();

            textLoanId.Text = RandomNumberGenerator.GetString("1234567890", 6);
            Id.Text = "";
        }

        private void ResetDropDown()
        {
            txtInterestFine.Text = "";
            txtInterestFine.Text = "";
            txtTenor.Text = "";
            txtAdminFee.Text = "";
            txtMinAmount.Text = "";
            txtMaxAmount.Text = "";
        }

        private void SetDefaultField()
        {
            cbxSavingType.SelectedIndex = 0;
            btnBrowseKtp.Visible = false;
            btnBrowsekk.Visible = false;
            btnBrowsegaji.Visible = false;
            btnShowKtp.Visible = true;
            btnShowkk.Visible = true;
            btnShowgaji.Visible = true;
        }

        private void SetChosenField()
        {
            btnShowKtp.Visible = true;
            btnShowkk.Visible = true;
            btnShowgaji.Visible = true;
            btnShowKtp.Visible = false;
            btnShowkk.Visible = false;
            btnShowgaji.Visible = false;
        }

        private async Task LoadSavingGrid(AppDbContext db)
        {
            SavingService savingService = new SavingService(db);
            loanBindingSource.DataSource = await savingService.LoadSavingGrid(LoggedMember.Id);

            dataGridVeiwSaving.Columns[0].DataPropertyName = "Id";
            dataGridVeiwSaving.Columns[1].DataPropertyName = "SavingId";
            dataGridVeiwSaving.Columns[2].DataPropertyName = "Amount";
            dataGridVeiwSaving.Columns[3].DataPropertyName = "Tenor";

            dataGridVeiwSaving.Columns[0].Visible = false;
            dataGridVeiwSaving.Columns[1].HeaderText = "Saving ID";
            dataGridVeiwSaving.Columns[2].HeaderText = "Amount";
            dataGridVeiwSaving.Columns[3].HeaderText = "Tenor";
        }

        private void SetSavingDropDown(AppDbContext db)
        {

        }

        private void buttonNewSaving_Click(object sender, EventArgs e)
        {
            SetDefaultField();
            ResetField();
            btnApply.Enabled = true;
            cbxSavingType.SelectedIndex = 0;
            cbxSavingType.Enabled = true;
        }

        private void buttonReload_Click_1(object sender, EventArgs e)
        {
            AppDbContext db = new AppDbContext();

            SetSavingDropDown(db);
            SetDefaultField();
            ResetField();

            LoadSavingGrid(db);
        }

       
        private async void comboLoanMaster_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResetDropDown();

            if (cbxSavingType.SelectedIndex > 0)
            {
            
                int idLoanMaster = int.Parse(cbxSavingType.SelectedValue.ToString());
                AppDbContext db = new AppDbContext();

                ProductService productService = new ProductService(db);
                LoanMaster loanMaster = await productService.FindLoanById(idLoanMaster);
                if (loanMaster != null)
                {
                    txtInterestFine.Text = loanMaster.Interest.ToString();
                    txtInterestFine.Text = loanMaster.Interest.ToString();
                    txtTenor.Text = loanMaster.Tenor.ToString();
                    txtAdminFee.Text = loanMaster.AdminFee.ToString();
                    txtMinAmount.Text = loanMaster.MinAmount.ToString();
                    txtMaxAmount.Text = loanMaster.MaxAmount.ToString();
                }
            }
            else
            {
                ResetDropDown();
            }
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {

        }


        private void buttonFileKK_Click(object sender, EventArgs e)
        {
            textDocKK.Text = FileHelper.UploadDocument("KK");
        }

        private void SavingPage_Load(object sender, EventArgs e)
        {
            
        }


        

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void label7_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        

    }
}