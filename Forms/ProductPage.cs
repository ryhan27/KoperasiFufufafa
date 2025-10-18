using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection.Emit;

namespace KoperasiFufufafa.Forms
{
    public partial class ProductPage : UserControl
    {
        public ProductPage()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ProductPage_Load(object sender, EventArgs e)
        {
            AppDbContext db = new AppDbContext();
            LoadGrids(db);
        }

        private void LoadGrids(AppDbContext db)
        {
            ProductService service = new ProductService(db);
            loanMasterBindingSource.DataSource = service.LoadLoanGrid();
            savingMasterBindingSource.DataSource = service.LoadSavingGrid();

            dataGridViewLoan.Columns[0].Visible = false;
            dataGridViewSaving.Columns[0].Visible = false;

            dataGridViewLoan.Columns[0].DataPropertyName = "Id";
            dataGridViewLoan.Columns[1].DataPropertyName = "Name";
            dataGridViewLoan.Columns[2].DataPropertyName = "Interest";
            dataGridViewLoan.Columns[3].DataPropertyName = "Tenor";

            dataGridViewSaving.Columns[0].DataPropertyName = "Id";
            dataGridViewSaving.Columns[1].DataPropertyName = "Name";
            dataGridViewSaving.Columns[2].DataPropertyName = "Interest";
            dataGridViewSaving.Columns[3].DataPropertyName = "Tenor";
        }

        private async void buttonSubmit_Click(object sender, EventArgs e)
        {
            AppDbContext db = new AppDbContext();
            ProductService service = new ProductService(db);

            if (comboMode.SelectedIndex == 0) // loan
            {
                await service.SaveOrUpdateLoan(labelId.Text, textAdminFee.Text, textBoxName.Text,
                    textFine.Text, textInterest.Text, textMaxAmount.Text,
                    textMinAmount.Text, textTenor.Text);
            }
            else
            {
                await service.SaveOrUpdateSaving(labelId.Text, textAdminFee.Text, textBoxName.Text,
                    textFine.Text, textInterest.Text, textMaxAmount.Text,
                    textMinAmount.Text, textTenor.Text);
            }

            ClearField();
            LoadGrids(db);
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            ClearField();
        }

        private void ClearField()
        {
            labelId.Text = "";
            textAdminFee.Text = "";
            textBoxName.Text = "";
            textFine.Text = "";
            textInterest.Text = "";
            textMaxAmount.Text = "";
            textMinAmount.Text = "";
            textTenor.Text = "";
            comboMode.SelectedIndex = 0;
            buttonSubmit.Enabled = true;
        }

        private async void dataGridViewLoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int id = int.Parse(dataGridViewLoan.Rows[e.RowIndex].Cells[0].Value.ToString());
                AppDbContext db = new AppDbContext();
                ProductService service = new ProductService(db);
                var loanMaster = await service.FindLoanById(id);
                if (loanMaster != null)
                {
                    labelId.Text = loanMaster.Id.ToString();
                    textAdminFee.Text = loanMaster.AdminFee.ToString();
                    textBoxName.Text = loanMaster.Name.ToString();
                    textFine.Text = loanMaster.Fine.ToString();
                    textInterest.Text = loanMaster.Interest.ToString();
                    textMinAmount.Text = loanMaster.MinAmount.ToString();
                    textMaxAmount.Text = loanMaster.MaxAmount.ToString();
                    textTenor.Text = loanMaster.Tenor.ToString();
                    buttonSubmit.Enabled = false;
                }
            }
        }

        private async void dataGridViewSaving_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int id = int.Parse(dataGridViewSaving.Rows[e.RowIndex].Cells[0].Value.ToString());
                AppDbContext db = new AppDbContext();
                ProductService service = new ProductService(db);
                var savingMaster = await service.FindSavingById(id);
                if (savingMaster != null)
                {
                    labelId.Text = savingMaster.Id.ToString();
                    textAdminFee.Text = savingMaster.AdminFee.ToString();
                    textBoxName.Text = savingMaster.Name.ToString();
                    textFine.Text = savingMaster.Fine.ToString();
                    textInterest.Text = savingMaster.Interest.ToString();
                    textMinAmount.Text = savingMaster.MinAmount.ToString();
                    textMaxAmount.Text = savingMaster.MaxAmount.ToString();
                    textTenor.Text = savingMaster.Tenor.ToString();
                    buttonSubmit.Enabled = false;
                }
            }
        }
     }
}
