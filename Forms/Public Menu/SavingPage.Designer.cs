namespace KoperasiFufufafa.Forms.Public_Menu
{
    partial class SavingPage
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
            lblSavingID = new Label();
            lblSavingType = new Label();
            lblAdminFee = new Label();
            lblMinAmount = new Label();
            lblInterestFine = new Label();
            lblDueDate = new Label();
            lblDocumentKK = new Label();
            txtSavingID = new TextBox();
            txtAdminFee = new TextBox();
            txtMinAmount = new TextBox();
            txtInterestFine = new TextBox();
            txtDocument = new TextBox();
            txtDueDate = new TextBox();
            btnBrowse = new Button();
            btnShow = new Button();
            cbxSavingType = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            txtSlipGaji = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            txtTenor = new TextBox();
            txtAmount = new TextBox();
            lblDocumentSlipGaji = new Label();
            lblDocumentKTP = new Label();
            lblMaxAmount = new Label();
            lblTenor = new Label();
            lblInterest = new Label();
            lblAmount = new Label();
            button3 = new Button();
            button4 = new Button();
            bnApplySaving = new Button();
            btnNewSaving = new Button();
            fine = new DataGridViewTextBoxColumn();
            tenorleft = new DataGridViewTextBoxColumn();
            outstanding = new DataGridViewTextBoxColumn();
            LoanId = new DataGridViewTextBoxColumn();
            Id = new DataGridViewTextBoxColumn();
            dgvSavingPage = new DataGridView();
            txtInterest = new TextBox();
            btnReload = new Button();
            lblSaving = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvSavingPage).BeginInit();
            SuspendLayout();
            // 
            // lblSavingID
            // 
            lblSavingID.AutoSize = true;
            lblSavingID.Location = new Point(63, 40);
            lblSavingID.Name = "lblSavingID";
            lblSavingID.Size = new Size(56, 15);
            lblSavingID.TabIndex = 0;
            lblSavingID.Text = "Saving ID";
            // 
            // lblSavingType
            // 
            lblSavingType.AutoSize = true;
            lblSavingType.Location = new Point(63, 84);
            lblSavingType.Name = "lblSavingType";
            lblSavingType.Size = new Size(70, 15);
            lblSavingType.TabIndex = 1;
            lblSavingType.Text = "Saving Type";
            // 
            // lblAdminFee
            // 
            lblAdminFee.AutoSize = true;
            lblAdminFee.Location = new Point(63, 137);
            lblAdminFee.Name = "lblAdminFee";
            lblAdminFee.Size = new Size(64, 15);
            lblAdminFee.TabIndex = 2;
            lblAdminFee.Text = "Admin Fee";
            // 
            // lblMinAmount
            // 
            lblMinAmount.AutoSize = true;
            lblMinAmount.Location = new Point(63, 190);
            lblMinAmount.Name = "lblMinAmount";
            lblMinAmount.Size = new Size(75, 15);
            lblMinAmount.TabIndex = 3;
            lblMinAmount.Text = "Min Amount";
            // 
            // lblInterestFine
            // 
            lblInterestFine.AutoSize = true;
            lblInterestFine.Location = new Point(63, 234);
            lblInterestFine.Name = "lblInterestFine";
            lblInterestFine.Size = new Size(71, 15);
            lblInterestFine.TabIndex = 4;
            lblInterestFine.Text = "Interest Fine";
            // 
            // lblDueDate
            // 
            lblDueDate.AutoSize = true;
            lblDueDate.Location = new Point(63, 288);
            lblDueDate.Name = "lblDueDate";
            lblDueDate.Size = new Size(55, 15);
            lblDueDate.TabIndex = 5;
            lblDueDate.Text = "Due Date";
            // 
            // lblDocumentKK
            // 
            lblDocumentKK.AutoSize = true;
            lblDocumentKK.Location = new Point(63, 342);
            lblDocumentKK.Name = "lblDocumentKK";
            lblDocumentKK.Size = new Size(80, 15);
            lblDocumentKK.TabIndex = 6;
            lblDocumentKK.Text = "Document KK";
            // 
            // txtSavingID
            // 
            txtSavingID.Location = new Point(63, 58);
            txtSavingID.Name = "txtSavingID";
            txtSavingID.Size = new Size(211, 23);
            txtSavingID.TabIndex = 13;
            xtSavingID.TextChanged += this.textBox1_TextChanged_1;
            // 
            // txtAdminFee
            // 
            txtAdminFee.Location = new Point(63, 155);
            txtAdminFee.Name = "txtAdminFee";
            txtAdminFee.Size = new Size(211, 23);
            txtAdminFee.TabIndex = 14;
            // 
            // txtMinAmount
            // 
            txtMinAmount.Location = new Point(63, 208);
            txtMinAmount.Name = "txtMinAmount";
            txtMinAmount.Size = new Size(211, 23);
            txtMinAmount.TabIndex = 17;
            txtMinAmount.TextChanged += this.textBox5_TextChanged;
            // 
            // txtInterestFine
            // 
            txtInterestFine.Location = new Point(63, 252);
            txtInterestFine.Name = "txtInterestFine";
            txtInterestFine.Size = new Size(211, 23);
            txtInterestFine.TabIndex = 19;
            // 
            // txtDocument
            // 
            txtDocument.Location = new Point(63, 360);
            txtDocument.Name = "txtDocument";
            txtDocument.Size = new Size(211, 23);
            txtDocument.TabIndex = 22;
            // 
            // txtDueDate
            // 
            txtDueDate.Location = new Point(63, 306);
            txtDueDate.Name = "txtDueDate";
            txtDueDate.Size = new Size(211, 23);
            txtDueDate.TabIndex = 23;
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new Point(63, 395);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(75, 23);
            btnBrowse.TabIndex = 25;
            btnBrowse.Text = "Browse";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += button1_Click;
            // 
            // btnShow
            // 
            btnShow.Location = new Point(199, 395);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(75, 23);
            btnShow.TabIndex = 26;
            btnShow.Text = "Show";
            btnShow.UseVisualStyleBackColor = true;
            // 
            // cbxSavingType
            // 
            cbxSavingType.FormattingEnabled = true;
            cbxSavingType.Location = new Point(63, 111);
            cbxSavingType.Name = "cbxSavingType";
            cbxSavingType.Size = new Size(211, 23);
            cbxSavingType.TabIndex = 27;
            // 
            // button1
            // 
            button1.Location = new Point(443, 284);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 42;
            button1.Text = "Show";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(308, 284);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 41;
            button2.Text = "Browse";
            button2.UseVisualStyleBackColor = true;
            // 
            // txtSlipGaji
            // 
            txtSlipGaji.Location = new Point(311, 360);
            txtSlipGaji.Name = "txtSlipGaji";
            txtSlipGaji.Size = new Size(211, 23);
            txtSlipGaji.TabIndex = 39;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(307, 252);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(211, 23);
            textBox3.TabIndex = 38;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(307, 208);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(211, 23);
            textBox4.TabIndex = 37;
            // 
            // txtTenor
            // 
            txtTenor.Location = new Point(307, 155);
            txtTenor.Name = "txtTenor";
            txtTenor.Size = new Size(211, 23);
            txtTenor.TabIndex = 36;
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(307, 58);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(211, 23);
            txtAmount.TabIndex = 35;
            // 
            // lblDocumentSlipGaji
            // 
            lblDocumentSlipGaji.AutoSize = true;
            lblDocumentSlipGaji.Location = new Point(311, 342);
            lblDocumentSlipGaji.Name = "lblDocumentSlipGaji";
            lblDocumentSlipGaji.Size = new Size(108, 15);
            lblDocumentSlipGaji.TabIndex = 34;
            lblDocumentSlipGaji.Text = "Document Slip Gaji";
            // 
            // lblDocumentKTP
            // 
            lblDocumentKTP.AutoSize = true;
            lblDocumentKTP.Location = new Point(307, 234);
            lblDocumentKTP.Name = "lblDocumentKTP";
            lblDocumentKTP.Size = new Size(84, 15);
            lblDocumentKTP.TabIndex = 32;
            lblDocumentKTP.Text = "Document Ktp";
            // 
            // lblMaxAmount
            // 
            lblMaxAmount.AutoSize = true;
            lblMaxAmount.Location = new Point(307, 190);
            lblMaxAmount.Name = "lblMaxAmount";
            lblMaxAmount.Size = new Size(76, 15);
            lblMaxAmount.TabIndex = 31;
            lblMaxAmount.Text = "Max Amount";
            // 
            // lblTenor
            // 
            lblTenor.AutoSize = true;
            lblTenor.Location = new Point(307, 137);
            lblTenor.Name = "lblTenor";
            lblTenor.Size = new Size(37, 15);
            lblTenor.TabIndex = 30;
            lblTenor.Text = "Tenor";
            // 
            // lblInterest
            // 
            lblInterest.AutoSize = true;
            lblInterest.Location = new Point(307, 84);
            lblInterest.Name = "lblInterest";
            lblInterest.Size = new Size(46, 15);
            lblInterest.TabIndex = 29;
            lblInterest.Text = "Interest";
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Location = new Point(307, 40);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(51, 15);
            lblAmount.TabIndex = 28;
            lblAmount.Text = "Amount";
            lblAmount.Click += label7_Click;
            // 
            // button3
            // 
            button3.Location = new Point(311, 395);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 44;
            button3.Text = "Browse";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(447, 395);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 45;
            button4.Text = "Show";
            button4.UseVisualStyleBackColor = true;
            // 
            // bnApplySaving
            // 
            bnApplySaving.Location = new Point(316, 469);
            bnApplySaving.Name = "bnApplySaving";
            bnApplySaving.Size = new Size(103, 23);
            bnApplySaving.TabIndex = 46;
            bnApplySaving.Text = "Aply Saving";
            bnApplySaving.UseVisualStyleBackColor = true;
            // 
            // btnNewSaving
            // 
            btnNewSaving.Location = new Point(447, 469);
            btnNewSaving.Name = "btnNewSaving";
            btnNewSaving.Size = new Size(94, 23);
            btnNewSaving.TabIndex = 47;
            btnNewSaving.Text = "New Saving";
            btnNewSaving.UseVisualStyleBackColor = true;
            // 
            // fine
            // 
            fine.HeaderText = "fine";
            fine.Name = "fine";
            // 
            // tenorleft
            // 
            tenorleft.HeaderText = "tenorleft";
            tenorleft.Name = "tenorleft";
            // 
            // outstanding
            // 
            outstanding.HeaderText = "outstanding";
            outstanding.Name = "outstanding";
            // 
            // LoanId
            // 
            LoanId.HeaderText = "LoanId";
            LoanId.Name = "LoanId";
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.Name = "Id";
            // 
            // dgvSavingPage
            // 
            dgvSavingPage.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSavingPage.Columns.AddRange(new DataGridViewColumn[] { Id, LoanId, outstanding, tenorleft, fine });
            dgvSavingPage.Location = new Point(551, 58);
            dgvSavingPage.Name = "dgvSavingPage";
            dgvSavingPage.Size = new Size(410, 355);
            dgvSavingPage.TabIndex = 48;
            dgvSavingPage.CellContentClick += dataGridView1_CellContentClick;
            // 
            // txtInterest
            // 
            txtInterest.Location = new Point(307, 102);
            txtInterest.Name = "txtInterest";
            txtInterest.Size = new Size(211, 23);
            txtInterest.TabIndex = 49;
            // 
            // btnReload
            // 
            btnReload.Location = new Point(641, 465);
            btnReload.Name = "btnReload";
            btnReload.Size = new Size(89, 27);
            btnReload.TabIndex = 50;
            btnReload.Text = "Reload";
            btnReload.UseVisualStyleBackColor = true;
            // 
            // lblSaving
            // 
            lblSaving.AutoSize = true;
            lblSaving.Location = new Point(552, 33);
            lblSaving.Name = "lblSaving";
            lblSaving.Size = new Size(42, 15);
            lblSaving.TabIndex = 51;
            lblSaving.Text = "Saving";
            // 
            // SavingPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblSaving);
            Controls.Add(btnReload);
            Controls.Add(txtInterest);
            Controls.Add(dgvSavingPage);
            Controls.Add(btnNewSaving);
            Controls.Add(bnApplySaving);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(txtSlipGaji);
            Controls.Add(textBox3);
            Controls.Add(textBox4);
            Controls.Add(txtTenor);
            Controls.Add(txtAmount);
            Controls.Add(lblDocumentSlipGaji);
            Controls.Add(lblDocumentKTP);
            Controls.Add(lblMaxAmount);
            Controls.Add(lblTenor);
            Controls.Add(lblInterest);
            Controls.Add(lblAmount);
            Controls.Add(cbxSavingType);
            Controls.Add(btnShow);
            Controls.Add(btnBrowse);
            Controls.Add(txtDueDate);
            Controls.Add(txtDocument);
            Controls.Add(txtInterestFine);
            Controls.Add(txtMinAmount);
            Controls.Add(txtAdminFee);
            Controls.Add(txtSavingID);
            Controls.Add(lblDocumentKK);
            Controls.Add(lblDueDate);
            Controls.Add(lblInterestFine);
            Controls.Add(lblMinAmount);
            Controls.Add(lblAdminFee);
            Controls.Add(lblSavingType);
            Controls.Add(lblSavingID);
            Name = "SavingPage";
            Size = new Size(988, 495);
            Load += this.SavingPage_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSavingPage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSavingID;
        private Label lblSavingType;
        private Label lblAdminFee;
        private Label lblMinAmount;
        private Label lblInterestFine;
        private Label lblDueDate;
        private Label lblDocumentKK;
        private TextBox txtSavingID;
        private TextBox txtAdminFee;
        private TextBox txtMinAmount;
        private TextBox txtInterestFine;
        private TextBox txtDocument;
        private TextBox txtDueDate;
        private Button btnBrowse;
        private Button buttonShow;
        private ComboBox cbxSavingType;
        private Button button1;
        private Button button2;
        private TextBox txtSlipGaji;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox txtTenor;
        private TextBox txtAmount;
        private Label lblDocumentSlipGaji;
        private Label lblDocumentKTP;
        private Label lblMaxAmount;
        private Label lblTenor;
        private Label lblInterest;
        private Label lblAmount;
        private Button button3;
        private Button button4;
        private Button bnApplySaving;
        private Button btnNewSaving;
        private DataGridViewTextBoxColumn fine;
        private DataGridViewTextBoxColumn tenorleft;
        private DataGridViewTextBoxColumn outstanding;
        private DataGridViewTextBoxColumn LoanId;
        private DataGridViewTextBoxColumn Id;
        private DataGridView dgvSavingPage;
        private TextBox txtInterest;
        private Button btnReload;
        private Label lblSaving;
    }
}
