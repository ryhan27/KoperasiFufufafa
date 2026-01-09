namespace KoperasiFufufafa.Forms.AdminMenus
{
    partial class AcrossPage
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
            dgvCoop = new DataGridView();
            CoopCode = new DataGridViewTextBoxColumn();
            CoopName = new DataGridViewTextBoxColumn();
            CoopAddress = new DataGridViewTextBoxColumn();
            IsDelete = new DataGridViewTextBoxColumn();
            dgvBalance = new DataGridView();
            MemberCode = new DataGridViewTextBoxColumn();
            MemberName = new DataGridViewTextBoxColumn();
            Balance = new DataGridViewTextBoxColumn();
            dgvTransfer = new DataGridView();
            TransferCode = new DataGridViewTextBoxColumn();
            Origin = new DataGridViewTextBoxColumn();
            Benef = new DataGridViewTextBoxColumn();
            Amount = new DataGridViewTextBoxColumn();
            TransferOn = new DataGridViewTextBoxColumn();
            Remarks = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            buttonRefresh = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCoop).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvBalance).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvTransfer).BeginInit();
            SuspendLayout();
            // 
            // dgvCoop
            // 
            dgvCoop.AllowUserToAddRows = false;
            dgvCoop.AllowUserToDeleteRows = false;
            dgvCoop.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCoop.Columns.AddRange(new DataGridViewColumn[] { CoopCode, CoopName, CoopAddress, IsDelete });
            dgvCoop.Location = new Point(32, 61);
            dgvCoop.Margin = new Padding(4, 5, 4, 5);
            dgvCoop.Name = "dgvCoop";
            dgvCoop.ReadOnly = true;
            dgvCoop.RowHeadersWidth = 51;
            dgvCoop.Size = new Size(668, 320);
            dgvCoop.TabIndex = 0;
            // 
            // CoopCode
            // 
            CoopCode.HeaderText = "Code";
            CoopCode.MinimumWidth = 6;
            CoopCode.Name = "CoopCode";
            CoopCode.ReadOnly = true;
            CoopCode.Width = 125;
            // 
            // CoopName
            // 
            CoopName.HeaderText = "Name";
            CoopName.MinimumWidth = 6;
            CoopName.Name = "CoopName";
            CoopName.ReadOnly = true;
            CoopName.Width = 125;
            // 
            // CoopAddress
            // 
            CoopAddress.HeaderText = "Address";
            CoopAddress.MinimumWidth = 6;
            CoopAddress.Name = "CoopAddress";
            CoopAddress.ReadOnly = true;
            CoopAddress.Width = 125;
            // 
            // IsDelete
            // 
            IsDelete.HeaderText = "Telah dihapus?";
            IsDelete.MinimumWidth = 6;
            IsDelete.Name = "IsDelete";
            IsDelete.ReadOnly = true;
            IsDelete.Width = 125;
            // 
            // dgvBalance
            // 
            dgvBalance.AllowUserToAddRows = false;
            dgvBalance.AllowUserToDeleteRows = false;
            dgvBalance.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBalance.Columns.AddRange(new DataGridViewColumn[] { MemberCode, MemberName, Balance });
            dgvBalance.Location = new Point(709, 61);
            dgvBalance.Margin = new Padding(4, 5, 4, 5);
            dgvBalance.Name = "dgvBalance";
            dgvBalance.ReadOnly = true;
            dgvBalance.RowHeadersWidth = 51;
            dgvBalance.Size = new Size(538, 320);
            dgvBalance.TabIndex = 1;
            // 
            // MemberCode
            // 
            MemberCode.HeaderText = "Code";
            MemberCode.MinimumWidth = 6;
            MemberCode.Name = "MemberCode";
            MemberCode.ReadOnly = true;
            MemberCode.Width = 125;
            // 
            // MemberName
            // 
            MemberName.HeaderText = "Name";
            MemberName.MinimumWidth = 6;
            MemberName.Name = "MemberName";
            MemberName.ReadOnly = true;
            MemberName.Width = 125;
            // 
            // Balance
            // 
            Balance.HeaderText = "Balance";
            Balance.MinimumWidth = 6;
            Balance.Name = "Balance";
            Balance.ReadOnly = true;
            Balance.Width = 125;
            // 
            // dgvTransfer
            // 
            dgvTransfer.AllowUserToAddRows = false;
            dgvTransfer.AllowUserToDeleteRows = false;
            dgvTransfer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTransfer.Columns.AddRange(new DataGridViewColumn[] { TransferCode, Origin, Benef, Amount, TransferOn, Remarks });
            dgvTransfer.Location = new Point(32, 435);
            dgvTransfer.Margin = new Padding(4, 5, 4, 5);
            dgvTransfer.Name = "dgvTransfer";
            dgvTransfer.ReadOnly = true;
            dgvTransfer.RowHeadersWidth = 51;
            dgvTransfer.Size = new Size(1212, 310);
            dgvTransfer.TabIndex = 2;
            // 
            // TransferCode
            // 
            TransferCode.HeaderText = "Transfer Code";
            TransferCode.MinimumWidth = 6;
            TransferCode.Name = "TransferCode";
            TransferCode.ReadOnly = true;
            TransferCode.Width = 125;
            // 
            // Origin
            // 
            Origin.HeaderText = "Origin";
            Origin.MinimumWidth = 6;
            Origin.Name = "Origin";
            Origin.ReadOnly = true;
            Origin.Width = 125;
            // 
            // Benef
            // 
            Benef.HeaderText = "Benef";
            Benef.MinimumWidth = 6;
            Benef.Name = "Benef";
            Benef.ReadOnly = true;
            Benef.Width = 125;
            // 
            // Amount
            // 
            Amount.HeaderText = "Amount";
            Amount.MinimumWidth = 6;
            Amount.Name = "Amount";
            Amount.ReadOnly = true;
            Amount.Width = 125;
            // 
            // TransferOn
            // 
            TransferOn.HeaderText = "Transfer On";
            TransferOn.MinimumWidth = 6;
            TransferOn.Name = "TransferOn";
            TransferOn.ReadOnly = true;
            TransferOn.Width = 125;
            // 
            // Remarks
            // 
            Remarks.HeaderText = "Remarks";
            Remarks.MinimumWidth = 6;
            Remarks.Name = "Remarks";
            Remarks.ReadOnly = true;
            Remarks.Width = 125;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 31);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(56, 25);
            label1.TabIndex = 3;
            label1.Text = "Coop";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(709, 31);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(79, 25);
            label2.TabIndex = 4;
            label2.Text = "Member";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 405);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(73, 25);
            label3.TabIndex = 5;
            label3.Text = "Transfer";
            // 
            // buttonRefresh
            // 
            buttonRefresh.BackColor = Color.Lime;
            buttonRefresh.Location = new Point(628, 755);
            buttonRefresh.Margin = new Padding(4, 5, 4, 5);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new Size(108, 39);
            buttonRefresh.TabIndex = 6;
            buttonRefresh.Text = "Refresh";
            buttonRefresh.UseVisualStyleBackColor = false;
            buttonRefresh.Click += buttonRefresh_Click;
            // 
            // AcrossPage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            Controls.Add(buttonRefresh);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvTransfer);
            Controls.Add(dgvBalance);
            Controls.Add(dgvCoop);
            Margin = new Padding(4, 5, 4, 5);
            Name = "AcrossPage";
            Size = new Size(1316, 820);
            Load += AcrossPage_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCoop).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvBalance).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvTransfer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvCoop;
        private DataGridView dgvBalance;
        private DataGridView dgvTransfer;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button buttonRefresh;
        private DataGridViewTextBoxColumn MemberCode;
        private DataGridViewTextBoxColumn MemberName;
        private DataGridViewTextBoxColumn Balance;
        private DataGridViewTextBoxColumn TransferCode;
        private DataGridViewTextBoxColumn Origin;
        private DataGridViewTextBoxColumn Benef;
        private DataGridViewTextBoxColumn Amount;
        private DataGridViewTextBoxColumn TransferOn;
        private DataGridViewTextBoxColumn Remarks;
        private DataGridViewTextBoxColumn CoopCode;
        private DataGridViewTextBoxColumn CoopName;
        private DataGridViewTextBoxColumn CoopAddress;
        private DataGridViewTextBoxColumn IsDelete;
    }
}
