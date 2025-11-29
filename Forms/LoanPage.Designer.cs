namespace KoperasiFufufafa.Forms
{
    partial class LoanPage
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
            components = new System.ComponentModel.Container();
            lblLoan = new Label();
            lblType = new Label();
            lblAdmin = new Label();
            lblMin = new Label();
            lblInterest = new Label();
            lblDue = new Label();
            lblDocument = new Label();
            lblAmount = new Label();
            lblInterest2 = new Label();
            lblTenor = new Label();
            label11 = new Label();
            label12 = new Label();
            txtLoan = new TextBox();
            txtAdmin = new TextBox();
            txtMin = new TextBox();
            txtFine = new TextBox();
            txtDate = new TextBox();
            txtAmount = new TextBox();
            txtInterest = new TextBox();
            txtTenor = new TextBox();
            txtMax = new TextBox();
            txtKTP = new TextBox();
            txtKK = new TextBox();
            cmbType = new ComboBox();
            btnBrowseKK = new Button();
            btnShowKK = new Button();
            btnNew = new Button();
            btnApply = new Button();
            btnShowGaji = new Button();
            btnBrowseGaji = new Button();
            btnShowKTP = new Button();
            btnBrowseKTP = new Button();
            label1 = new Label();
            txtGaji = new TextBox();
            btnReload = new Button();
            dgvLoan = new DataGridView();
            label2 = new Label();
            openFileDialog1 = new OpenFileDialog();
            bindingSource1 = new BindingSource(components);
            labelID = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvLoan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // lblLoan
            // 
            lblLoan.AutoSize = true;
            lblLoan.Location = new Point(16, 24);
            lblLoan.Name = "lblLoan";
            lblLoan.Size = new Size(47, 15);
            lblLoan.TabIndex = 0;
            lblLoan.Text = "Loan ID";
            //lblLoan.Click += label1_Click;
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Location = new Point(16, 96);
            lblType.Name = "lblType";
            lblType.Size = new Size(61, 15);
            lblType.TabIndex = 1;
            lblType.Text = "Loan Type";
            // 
            // lblAdmin
            // 
            lblAdmin.AutoSize = true;
            lblAdmin.Location = new Point(16, 175);
            lblAdmin.Name = "lblAdmin";
            lblAdmin.Size = new Size(64, 15);
            lblAdmin.TabIndex = 2;
            lblAdmin.Text = "Admin Fee";
            // 
            // lblMin
            // 
            lblMin.AutoSize = true;
            lblMin.Location = new Point(16, 248);
            lblMin.Name = "lblMin";
            lblMin.Size = new Size(75, 15);
            lblMin.TabIndex = 3;
            lblMin.Text = "Min Amount";
            // 
            // lblInterest
            // 
            lblInterest.AutoSize = true;
            lblInterest.Location = new Point(16, 334);
            lblInterest.Name = "lblInterest";
            lblInterest.Size = new Size(71, 15);
            lblInterest.TabIndex = 4;
            lblInterest.Text = "Interest Fine";
            // 
            // lblDue
            // 
            lblDue.AutoSize = true;
            lblDue.Location = new Point(16, 403);
            lblDue.Name = "lblDue";
            lblDue.Size = new Size(55, 15);
            lblDue.TabIndex = 5;
            lblDue.Text = "Due Date";
            // 
            // lblDocument
            // 
            lblDocument.AutoSize = true;
            lblDocument.Location = new Point(16, 486);
            lblDocument.Name = "lblDocument";
            lblDocument.Size = new Size(80, 15);
            lblDocument.TabIndex = 6;
            lblDocument.Text = "Document KK";
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Location = new Point(441, 24);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(51, 15);
            lblAmount.TabIndex = 7;
            lblAmount.Text = "Amount";
            // 
            // lblInterest2
            // 
            lblInterest2.AutoSize = true;
            lblInterest2.Location = new Point(441, 96);
            lblInterest2.Name = "lblInterest2";
            lblInterest2.Size = new Size(46, 15);
            lblInterest2.TabIndex = 8;
            lblInterest2.Text = "Interest";
            // 
            // lblTenor
            // 
            lblTenor.AutoSize = true;
            lblTenor.Location = new Point(441, 175);
            lblTenor.Name = "lblTenor";
            lblTenor.Size = new Size(37, 15);
            lblTenor.TabIndex = 9;
            lblTenor.Text = "Tenor";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(441, 248);
            label11.Name = "label11";
            label11.Size = new Size(76, 15);
            label11.TabIndex = 10;
            label11.Text = "Max Amount";
            //label11.Click += label11_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(435, 334);
            label12.Name = "label12";
            label12.Size = new Size(87, 15);
            label12.TabIndex = 11;
            label12.Text = "Document KTP";
            // 
            // txtLoan
            // 
            txtLoan.Location = new Point(16, 53);
            txtLoan.Name = "txtLoan";
            txtLoan.Size = new Size(273, 23);
            txtLoan.TabIndex = 12;
            // 
            // txtAdmin
            // 
            txtAdmin.Location = new Point(16, 204);
            txtAdmin.Name = "txtAdmin";
            txtAdmin.Size = new Size(273, 23);
            txtAdmin.TabIndex = 14;
            // 
            // txtMin
            // 
            txtMin.Location = new Point(16, 286);
            txtMin.Name = "txtMin";
            txtMin.Size = new Size(273, 23);
            txtMin.TabIndex = 15;
            // 
            // txtFine
            // 
            txtFine.Location = new Point(16, 363);
            txtFine.Name = "txtFine";
            txtFine.Size = new Size(273, 23);
            txtFine.TabIndex = 16;
            // 
            // txtDate
            // 
            txtDate.Location = new Point(16, 445);
            txtDate.Name = "txtDate";
            txtDate.Size = new Size(273, 23);
            txtDate.TabIndex = 17;
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(441, 53);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(273, 23);
            txtAmount.TabIndex = 18;
            // 
            // txtInterest
            // 
            txtInterest.Location = new Point(441, 134);
            txtInterest.Name = "txtInterest";
            txtInterest.Size = new Size(273, 23);
            txtInterest.TabIndex = 19;
            // 
            // txtTenor
            // 
            txtTenor.Location = new Point(441, 204);
            txtTenor.Name = "txtTenor";
            txtTenor.Size = new Size(273, 23);
            txtTenor.TabIndex = 20;
            // 
            // txtMax
            // 
            txtMax.Location = new Point(441, 286);
            txtMax.Name = "txtMax";
            txtMax.Size = new Size(273, 23);
            txtMax.TabIndex = 21;
            // 
            // txtKTP
            // 
            txtKTP.Location = new Point(441, 363);
            txtKTP.Name = "txtKTP";
            txtKTP.Size = new Size(273, 23);
            txtKTP.TabIndex = 22;
            // 
            // txtKK
            // 
            txtKK.Location = new Point(16, 520);
            txtKK.Name = "txtKK";
            txtKK.Size = new Size(273, 23);
            txtKK.TabIndex = 23;
            // 
            // cmbType
            // 
            cmbType.FormattingEnabled = true;
            cmbType.Location = new Point(16, 134);
            cmbType.Name = "cmbType";
            cmbType.Size = new Size(273, 23);
            cmbType.TabIndex = 24;
            // 
            // btnBrowseKK
            // 
            btnBrowseKK.Location = new Point(16, 567);
            btnBrowseKK.Name = "btnBrowseKK";
            btnBrowseKK.Size = new Size(108, 23);
            btnBrowseKK.TabIndex = 25;
            btnBrowseKK.Text = "Browse";
            btnBrowseKK.UseVisualStyleBackColor = true;
            //btnBrowseKK.Click += button1_Click;
            // 
            // btnShowKK
            // 
            btnShowKK.Location = new Point(171, 567);
            btnShowKK.Name = "btnShowKK";
            btnShowKK.Size = new Size(118, 23);
            btnShowKK.TabIndex = 26;
            btnShowKK.Text = "Show";
            btnShowKK.UseVisualStyleBackColor = true;
            // 
            // btnNew
            // 
            btnNew.Location = new Point(379, 621);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(170, 23);
            btnNew.TabIndex = 27;
            btnNew.Text = "New Loan";
            btnNew.UseVisualStyleBackColor = true;
            //btnNew.Click += button3_Click;
            // 
            // btnApply
            // 
            btnApply.Location = new Point(171, 621);
            btnApply.Name = "btnApply";
            btnApply.Size = new Size(175, 23);
            btnApply.TabIndex = 28;
            btnApply.Text = "Apply Loan";
            btnApply.UseVisualStyleBackColor = true;
            // 
            // btnShowGaji
            // 
            btnShowGaji.Location = new Point(606, 567);
            btnShowGaji.Name = "btnShowGaji";
            btnShowGaji.Size = new Size(108, 23);
            btnShowGaji.TabIndex = 29;
            btnShowGaji.Text = "Show";
            btnShowGaji.UseVisualStyleBackColor = true;
            //btnShowGaji.Click += button5_Click;
            // 
            // btnBrowseGaji
            // 
            btnBrowseGaji.Location = new Point(435, 567);
            btnBrowseGaji.Name = "btnBrowseGaji";
            btnBrowseGaji.Size = new Size(110, 23);
            btnBrowseGaji.TabIndex = 30;
            btnBrowseGaji.Text = "Browse";
            btnBrowseGaji.UseVisualStyleBackColor = true;
            // 
            // btnShowKTP
            // 
            btnShowKTP.Location = new Point(606, 403);
            btnShowKTP.Name = "btnShowKTP";
            btnShowKTP.Size = new Size(108, 23);
            btnShowKTP.TabIndex = 31;
            btnShowKTP.Text = "Show";
            btnShowKTP.UseVisualStyleBackColor = true;
            // 
            // btnBrowseKTP
            // 
            btnBrowseKTP.Location = new Point(441, 403);
            btnBrowseKTP.Name = "btnBrowseKTP";
            btnBrowseKTP.Size = new Size(104, 23);
            btnBrowseKTP.TabIndex = 32;
            btnBrowseKTP.Text = "Browse";
            btnBrowseKTP.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(441, 486);
            label1.Name = "label1";
            label1.Size = new Size(108, 15);
            label1.TabIndex = 33;
            label1.Text = "Document Slip Gaji";
            // 
            // txtGaji
            // 
            txtGaji.Location = new Point(435, 520);
            txtGaji.Name = "txtGaji";
            txtGaji.Size = new Size(273, 23);
            txtGaji.TabIndex = 34;
            // 
            // btnReload
            // 
            btnReload.Location = new Point(1017, 567);
            btnReload.Name = "btnReload";
            btnReload.Size = new Size(178, 23);
            btnReload.TabIndex = 35;
            btnReload.Text = "Reload";
            btnReload.UseVisualStyleBackColor = true;
            // 
            // dgvLoan
            // 
            dgvLoan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLoan.Location = new Point(739, 24);
            dgvLoan.Name = "dgvLoan";
            dgvLoan.Size = new Size(686, 536);
            dgvLoan.TabIndex = 36;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(739, 6);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 37;
            label2.Text = "Loan";
            // 
            // labelID
            // 
            labelID.AutoSize = true;
            labelID.Location = new Point(242, 24);
            labelID.Name = "labelID";
            labelID.Size = new Size(19, 15);
            labelID.TabIndex = 38;
            labelID.Text = " ...";
            // 
            // LoanPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(labelID);
            Controls.Add(label2);
            Controls.Add(dgvLoan);
            Controls.Add(btnReload);
            Controls.Add(txtGaji);
            Controls.Add(label1);
            Controls.Add(btnBrowseKTP);
            Controls.Add(btnShowKTP);
            Controls.Add(btnBrowseGaji);
            Controls.Add(btnShowGaji);
            Controls.Add(btnApply);
            Controls.Add(btnNew);
            Controls.Add(btnShowKK);
            Controls.Add(btnBrowseKK);
            Controls.Add(cmbType);
            Controls.Add(txtKK);
            Controls.Add(txtKTP);
            Controls.Add(txtMax);
            Controls.Add(txtTenor);
            Controls.Add(txtInterest);
            Controls.Add(txtAmount);
            Controls.Add(txtDate);
            Controls.Add(txtFine);
            Controls.Add(txtMin);
            Controls.Add(txtAdmin);
            Controls.Add(txtLoan);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(lblTenor);
            Controls.Add(lblInterest2);
            Controls.Add(lblAmount);
            Controls.Add(lblDocument);
            Controls.Add(lblDue);
            Controls.Add(lblInterest);
            Controls.Add(lblMin);
            Controls.Add(lblAdmin);
            Controls.Add(lblType);
            Controls.Add(lblLoan);
            Name = "LoanPage";
            Size = new Size(1444, 671);
            Load += LoanPage_Load;
            ((System.ComponentModel.ISupportInitialize)dgvLoan).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLoan;
        private Label lblType;
        private Label lblAdmin;
        private Label lblMin;
        private Label lblInterest;
        private Label lblDue;
        private Label lblDocument;
        private Label lblAmount;
        private Label lblInterest2;
        private Label lblTenor;
        private Label label11;
        private Label label12;
        private TextBox txtLoan;
        private TextBox txtAdmin;
        private TextBox txtMin;
        private TextBox txtFine;
        private TextBox txtDate;
        private TextBox txtAmount;
        private TextBox txtInterest;
        private TextBox txtTenor;
        private TextBox txtMax;
        private TextBox txtKTP;
        private TextBox txtKK;
        private ComboBox cmbType;
        private Button btnBrowseKK;
        private Button btnShowKK;
        private Button btnNew;
        private Button btnApply;
        private Button btnShowGaji;
        private Button btnBrowseGaji;
        private Button btnShowKTP;
        private Button btnBrowseKTP;
        private Label label1;
        private TextBox txtGaji;
        private Button btnReload;
        private DataGridView dgvLoan;
        private Label label2;
        private OpenFileDialog openFileDialog1;
        private BindingSource bindingSource1;
        private Label labelID;
    }
}
