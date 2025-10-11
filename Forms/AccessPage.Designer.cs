namespace KoperasiFufufafa.Forms
{
    partial class AccessPage
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
            label1 = new Label();
            btnSubmit = new Button();
            cbMember = new ComboBox();
            groupBox1 = new GroupBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            listBox1 = new ListBox();
            cbGrandAll = new CheckBox();
            cbSaving = new CheckBox();
            cbTransferInhouse = new CheckBox();
            cbTransferAccross = new CheckBox();
            cbExchange = new CheckBox();
            cbLoan = new CheckBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            dgvAccess = new DataGridView();
            label14 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAccess).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 35);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 0;
            label1.Text = "Member";
            label1.Click += label1_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(202, 61);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(75, 23);
            btnSubmit.TabIndex = 1;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            // 
            // cbMember
            // 
            cbMember.FormattingEnabled = true;
            cbMember.Location = new Point(38, 62);
            cbMember.Name = "cbMember";
            cbMember.Size = new Size(121, 23);
            cbMember.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(38, 297);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 198);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Details";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 36);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 0;
            label2.Text = "Full Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 63);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 1;
            label3.Text = "Join Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 91);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 2;
            label4.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 124);
            label5.Name = "label5";
            label5.Size = new Size(41, 15);
            label5.TabIndex = 3;
            label5.Text = "Phone";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(14, 149);
            label6.Name = "label6";
            label6.Size = new Size(59, 15);
            label6.TabIndex = 6;
            label6.Text = "Phone Alt";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(17, 175);
            label7.Name = "label7";
            label7.Size = new Size(49, 15);
            label7.TabIndex = 7;
            label7.Text = "Address";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(38, 108);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(201, 169);
            listBox1.TabIndex = 6;
            // 
            // cbGrandAll
            // 
            cbGrandAll.AutoSize = true;
            cbGrandAll.BackColor = SystemColors.ButtonHighlight;
            cbGrandAll.Location = new Point(50, 121);
            cbGrandAll.Name = "cbGrandAll";
            cbGrandAll.Size = new Size(72, 19);
            cbGrandAll.TabIndex = 7;
            cbGrandAll.Text = "Grant All";
            cbGrandAll.UseVisualStyleBackColor = false;
            // 
            // cbSaving
            // 
            cbSaving.AutoSize = true;
            cbSaving.BackColor = SystemColors.ButtonHighlight;
            cbSaving.Location = new Point(50, 171);
            cbSaving.Name = "cbSaving";
            cbSaving.Size = new Size(61, 19);
            cbSaving.TabIndex = 8;
            cbSaving.Text = "Saving";
            cbSaving.UseVisualStyleBackColor = false;
            // 
            // cbTransferInhouse
            // 
            cbTransferInhouse.AutoSize = true;
            cbTransferInhouse.BackColor = SystemColors.ButtonHighlight;
            cbTransferInhouse.Location = new Point(50, 200);
            cbTransferInhouse.Name = "cbTransferInhouse";
            cbTransferInhouse.Size = new Size(120, 19);
            cbTransferInhouse.TabIndex = 9;
            cbTransferInhouse.Text = "Transfer - Inhouse";
            cbTransferInhouse.UseVisualStyleBackColor = false;
            // 
            // cbTransferAccross
            // 
            cbTransferAccross.AutoSize = true;
            cbTransferAccross.BackColor = SystemColors.ButtonHighlight;
            cbTransferAccross.Location = new Point(50, 225);
            cbTransferAccross.Name = "cbTransferAccross";
            cbTransferAccross.Size = new Size(119, 19);
            cbTransferAccross.TabIndex = 10;
            cbTransferAccross.Text = "Transfer - Accross";
            cbTransferAccross.UseVisualStyleBackColor = false;
            cbTransferAccross.CheckedChanged += checkBox5_CheckedChanged;
            // 
            // cbExchange
            // 
            cbExchange.AutoSize = true;
            cbExchange.BackColor = SystemColors.ButtonHighlight;
            cbExchange.Location = new Point(50, 250);
            cbExchange.Name = "cbExchange";
            cbExchange.Size = new Size(77, 19);
            cbExchange.TabIndex = 11;
            cbExchange.Text = "Exchange";
            cbExchange.UseVisualStyleBackColor = false;
            // 
            // cbLoan
            // 
            cbLoan.AutoSize = true;
            cbLoan.BackColor = SystemColors.ButtonHighlight;
            cbLoan.Location = new Point(50, 146);
            cbLoan.Name = "cbLoan";
            cbLoan.Size = new Size(52, 19);
            cbLoan.TabIndex = 12;
            cbLoan.Text = "Loan";
            cbLoan.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(115, 36);
            label8.Name = "label8";
            label8.Size = new Size(17, 15);
            label8.TabIndex = 13;
            label8.Text = "--";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(115, 63);
            label9.Name = "label9";
            label9.Size = new Size(17, 15);
            label9.TabIndex = 14;
            label9.Text = "--";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(115, 91);
            label10.Name = "label10";
            label10.Size = new Size(17, 15);
            label10.TabIndex = 15;
            label10.Text = "--";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(115, 124);
            label11.Name = "label11";
            label11.Size = new Size(17, 15);
            label11.TabIndex = 16;
            label11.Text = "--";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(115, 149);
            label12.Name = "label12";
            label12.Size = new Size(17, 15);
            label12.TabIndex = 17;
            label12.Text = "--";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(114, 175);
            label13.Name = "label13";
            label13.Size = new Size(17, 15);
            label13.TabIndex = 18;
            label13.Text = "--";
            // 
            // dgvAccess
            // 
            dgvAccess.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAccess.Location = new Point(319, 62);
            dgvAccess.Name = "dgvAccess";
            dgvAccess.Size = new Size(401, 433);
            dgvAccess.TabIndex = 13;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(319, 35);
            label14.Name = "label14";
            label14.Size = new Size(43, 15);
            label14.TabIndex = 14;
            label14.Text = "Access";
            // 
            // AccessPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label14);
            Controls.Add(dgvAccess);
            Controls.Add(cbLoan);
            Controls.Add(cbExchange);
            Controls.Add(cbTransferAccross);
            Controls.Add(cbTransferInhouse);
            Controls.Add(cbSaving);
            Controls.Add(cbGrandAll);
            Controls.Add(listBox1);
            Controls.Add(groupBox1);
            Controls.Add(cbMember);
            Controls.Add(btnSubmit);
            Controls.Add(label1);
            Name = "AccessPage";
            Size = new Size(757, 532);
            Load += AccessPage_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAccess).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnSubmit;
        private ComboBox cbMember;
        private GroupBox groupBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label7;
        private Label label6;
        private ListBox listBox1;
        private CheckBox cbGrandAll;
        private CheckBox cbSaving;
        private CheckBox cbTransferInhouse;
        private CheckBox cbTransferAccross;
        private CheckBox cbExchange;
        private CheckBox cbLoan;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private DataGridView dgvAccess;
        private Label label14;
    }
}
