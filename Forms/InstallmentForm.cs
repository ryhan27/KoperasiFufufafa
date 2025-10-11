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
    public partial class InstallmentForm : Form
    {
        public InstallmentForm()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void InitializeComponent()
        {
            dataGridViewInstallment = new DataGridView();
            textLoanId = new TextBox();
            label1 = new Label();
            btnBrowse = new Button();
            label2 = new Label();
            textAmount = new TextBox();
            label3 = new Label();
            textRecipt = new TextBox();
            btnSubmit = new Button();
            btnNewInstallment = new Button();
            ((ISupportInitialize)dataGridViewInstallment).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewInstallment
            // 
            dataGridViewInstallment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInstallment.Location = new Point(12, 12);
            dataGridViewInstallment.Name = "dataGridViewInstallment";
            dataGridViewInstallment.RowHeadersWidth = 62;
            dataGridViewInstallment.Size = new Size(409, 504);
            dataGridViewInstallment.TabIndex = 0;
            // 
            // textLoanId
            // 
            textLoanId.BackColor = Color.Silver;
            textLoanId.Location = new Point(495, 47);
            textLoanId.Name = "textLoanId";
            textLoanId.Size = new Size(309, 31);
            textLoanId.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(495, 12);
            label1.Name = "label1";
            label1.Size = new Size(73, 25);
            label1.TabIndex = 2;
            label1.Text = "Loan ID";
            // 
            // btnBrowse
            // 
            btnBrowse.BackColor = Color.Silver;
            btnBrowse.Location = new Point(657, 276);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(147, 34);
            btnBrowse.TabIndex = 3;
            btnBrowse.Text = "Browse";
            btnBrowse.UseVisualStyleBackColor = false;
            btnBrowse.Click += button1_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(495, 97);
            label2.Name = "label2";
            label2.Size = new Size(77, 25);
            label2.TabIndex = 5;
            label2.Text = "Amount";
            // 
            // textAmount
            // 
            textAmount.BackColor = Color.Silver;
            textAmount.Location = new Point(495, 132);
            textAmount.Name = "textAmount";
            textAmount.Size = new Size(309, 31);
            textAmount.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(495, 186);
            label3.Name = "label3";
            label3.Size = new Size(60, 25);
            label3.TabIndex = 7;
            label3.Text = "Recipt";
            // 
            // textRecipt
            // 
            textRecipt.BackColor = Color.Silver;
            textRecipt.Location = new Point(495, 221);
            textRecipt.Name = "textRecipt";
            textRecipt.Size = new Size(309, 31);
            textRecipt.TabIndex = 6;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.Silver;
            btnSubmit.Location = new Point(495, 360);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(112, 34);
            btnSubmit.TabIndex = 8;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            // 
            // btnNewInstallment
            // 
            btnNewInstallment.BackColor = Color.Silver;
            btnNewInstallment.Location = new Point(657, 360);
            btnNewInstallment.Name = "btnNewInstallment";
            btnNewInstallment.Size = new Size(147, 34);
            btnNewInstallment.TabIndex = 9;
            btnNewInstallment.Text = "New Installment";
            btnNewInstallment.UseVisualStyleBackColor = false;
            // 
            // InstallmentForm
            // 
            ClientSize = new Size(981, 596);
            Controls.Add(btnNewInstallment);
            Controls.Add(btnSubmit);
            Controls.Add(label3);
            Controls.Add(textRecipt);
            Controls.Add(label2);
            Controls.Add(textAmount);
            Controls.Add(btnBrowse);
            Controls.Add(label1);
            Controls.Add(textLoanId);
            Controls.Add(dataGridViewInstallment);
            Name = "InstallmentForm";
            ((ISupportInitialize)dataGridViewInstallment).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
