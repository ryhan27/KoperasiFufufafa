using KoperasiFufufafa.Models;
using System.Windows.Forms;
using System.Xml.Linq;

namespace KoperasiFufufafa.Forms
{
    partial class DashboardPage
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            label1 = new Label();
            lblBalance = new Label();
            label3 = new Label();
            lblLoan = new Label();
            pictureBox2 = new PictureBox();
            panelTitle = new Panel();
            pictureBox3 = new PictureBox();
            label7 = new Label();
            lblInhouse = new Label();
            pictureBox4 = new PictureBox();
            label9 = new Label();
            lblAcross = new Label();
            pictureBox5 = new PictureBox();
            lblExchange = new Label();
            label12 = new Label();
            pictureBox6 = new PictureBox();
            label5 = new Label();
            lblSaving = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveCaption;
            pictureBox1.Location = new Point(72, 121);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(183, 110);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Location = new Point(87, 131);
            label1.Name = "label1";
            label1.Size = new Size(61, 20);
            label1.TabIndex = 1;
            label1.Text = "Balance";
            // 
            // lblBalance
            // 
            lblBalance.AutoSize = true;
            lblBalance.BackColor = SystemColors.ActiveCaption;
            lblBalance.Location = new Point(206, 196);
            lblBalance.Name = "lblBalance";
            lblBalance.Size = new Size(17, 20);
            lblBalance.TabIndex = 2;
            lblBalance.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.MenuHighlight;
            label3.Location = new Point(351, 131);
            label3.Name = "label3";
            label3.Size = new Size(41, 20);
            label3.TabIndex = 5;
            label3.Text = "Loan";
            // 
            // lblLoan
            // 
            lblLoan.AutoSize = true;
            lblLoan.BackColor = SystemColors.MenuHighlight;
            lblLoan.Location = new Point(478, 196);
            lblLoan.Name = "lblLoan";
            lblLoan.Size = new Size(17, 20);
            lblLoan.TabIndex = 4;
            lblLoan.Text = "0";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.MenuHighlight;
            pictureBox2.Location = new Point(336, 121);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(183, 110);
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // panelTitle
            // 
            panelTitle.Location = new Point(70, 34);
            panelTitle.Name = "panelTitle";
            panelTitle.Size = new Size(734, 72);
            panelTitle.TabIndex = 6;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Yellow;
            pictureBox3.Location = new Point(336, 282);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(183, 110);
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            //pictureBox3.Click += pictureBox3_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Red;
            label7.Location = new Point(87, 294);
            label7.Name = "label7";
            label7.Size = new Size(145, 20);
            label7.TabIndex = 12;
            label7.Text = "Inhouse Transactions";
            // 
            // lblInhouse
            // 
            lblInhouse.AutoSize = true;
            lblInhouse.BackColor = Color.Red;
            lblInhouse.Location = new Point(206, 357);
            lblInhouse.Name = "lblInhouse";
            lblInhouse.Size = new Size(17, 20);
            lblInhouse.TabIndex = 11;
            lblInhouse.Text = "0";
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Red;
            pictureBox4.Location = new Point(72, 282);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(183, 110);
            pictureBox4.TabIndex = 10;
            pictureBox4.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Yellow;
            label9.Location = new Point(351, 294);
            label9.Name = "label9";
            label9.Size = new Size(137, 20);
            label9.TabIndex = 15;
            label9.Text = "Across Transactions";
            // 
            // lblAcross
            // 
            lblAcross.AutoSize = true;
            lblAcross.BackColor = Color.Yellow;
            lblAcross.Location = new Point(478, 357);
            lblAcross.Name = "lblAcross";
            lblAcross.Size = new Size(17, 20);
            lblAcross.TabIndex = 14;
            lblAcross.Text = "0";
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.DarkGoldenrod;
            pictureBox5.Location = new Point(621, 121);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(183, 110);
            pictureBox5.TabIndex = 13;
            pictureBox5.TabStop = false;
            // 
            // lblExchange
            // 
            lblExchange.AutoSize = true;
            lblExchange.BackColor = Color.Green;
            lblExchange.Location = new Point(769, 357);
            lblExchange.Name = "lblExchange";
            lblExchange.Size = new Size(17, 20);
            lblExchange.TabIndex = 18;
            lblExchange.Text = "0";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Green;
            label12.Location = new Point(644, 294);
            label12.Name = "label12";
            label12.Size = new Size(72, 20);
            label12.TabIndex = 17;
            label12.Text = "Exchange";
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.Green;
            pictureBox6.Location = new Point(621, 282);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(183, 110);
            pictureBox6.TabIndex = 16;
            pictureBox6.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.DarkGoldenrod;
            label5.Location = new Point(644, 131);
            label5.Name = "label5";
            label5.Size = new Size(53, 20);
            label5.TabIndex = 19;
            label5.Text = "Saving";
            // 
            // lblSaving
            // 
            lblSaving.AutoSize = true;
            lblSaving.BackColor = Color.DarkGoldenrod;
            lblSaving.Location = new Point(769, 196);
            lblSaving.Name = "lblSaving";
            lblSaving.Size = new Size(17, 20);
            lblSaving.TabIndex = 20;
            lblSaving.Text = "0";
            // 
            // DashboardPage
            // 
            //AutoScaleDimensions = new SizeF(8F, 20F);
            //AutoScaleMode = AutoScaleMode.Font;
            //            Controls.Add(lblSaving);
            //          Controls.Add(label5);
            //        Controls.Add(lblExchange);
            //      Controls.Add(label12);
            //    Controls.Add(pictureBox6);
            //  Controls.Add(label9);
            //Controls.Add(lblAcross);
            //Controls.Add(pictureBox5);
            //Controls.Add(label7);
            //Controls.Add(lblInhouse);
            //Controls.Add(pictureBox4);
            //Controls.Add(pictureBox3);
            //Controls.Add(panelTitle);
            //Controls.Add(label3);
            //Controls.Add(lblLoan);
            //Controls.Add(pictureBox2);
            //Controls.Add(lblBalance);
            //Controls.Add(label1);
            //Controls.Add(pictureBox1);
            //Name = "DashboardPage";
            //Size = new Size(867, 575);
            //Load += DashboardPage_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label lblBalance;
        private Label label3;
        private Label lblLoan;
        private PictureBox pictureBox2;
        private Panel panelTitle;
        private PictureBox pictureBox3;
        private Label label7;
        private Label lblInhouse;
        private PictureBox pictureBox4;
        private Label label9;
        private Label lblAcross;
        private PictureBox pictureBox5;
        private Label lblExchange;
        private Label label12;
        private PictureBox pictureBox6;
        private Label label5;
        private Label lblSaving;
    }
}