namespace KoperasiFufufafa.Forms.AdminMenu
{
    partial class AccrossPage
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
            label2 = new Label();
            dgvCoop = new DataGridView();
            dgvMember = new DataGridView();
            dgvTransfer = new DataGridView();
            label3 = new Label();
            btnRefresh = new Button();
            CoopCode = new DataGridViewButtonColumn();
            CoopName = new DataGridViewButtonColumn();
            CoopAddress = new DataGridViewButtonColumn();
            MemberCode = new DataGridViewTextBoxColumn();
            MemberName = new DataGridViewTextBoxColumn();
            MemberBalance = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvCoop).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvMember).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvTransfer).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 37);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 0;
            label1.Text = "Coop";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(360, 37);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 1;
            label2.Text = "Member";
            // 
            // dgvCoop
            // 
            dgvCoop.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCoop.Columns.AddRange(new DataGridViewColumn[] { CoopCode, CoopName, CoopAddress });
            dgvCoop.Location = new Point(25, 73);
            dgvCoop.Name = "dgvCoop";
            dgvCoop.Size = new Size(262, 150);
            dgvCoop.TabIndex = 2;
            // 
            // dgvMember
            // 
            dgvMember.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMember.Columns.AddRange(new DataGridViewColumn[] { MemberCode, MemberName, MemberBalance });
            dgvMember.Location = new Point(316, 73);
            dgvMember.Name = "dgvMember";
            dgvMember.Size = new Size(240, 150);
            dgvMember.TabIndex = 3;
            // 
            // dgvTransfer
            // 
            dgvTransfer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTransfer.Location = new Point(25, 272);
            dgvTransfer.Name = "dgvTransfer";
            dgvTransfer.Size = new Size(531, 150);
            dgvTransfer.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 241);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 5;
            label3.Text = "Transfer";
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(264, 442);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(75, 23);
            btnRefresh.TabIndex = 6;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            // 
            // CoopCode
            // 
            CoopCode.HeaderText = "Code";
            CoopCode.Name = "CoopCode";
            // 
            // CoopName
            // 
            CoopName.HeaderText = "Name";
            CoopName.Name = "CoopName";
            // 
            // CoopAddress
            // 
            CoopAddress.HeaderText = "Address";
            CoopAddress.Name = "CoopAddress";
            // 
            // MemberCode
            // 
            MemberCode.HeaderText = "Code";
            MemberCode.Name = "MemberCode";
            // 
            // MemberName
            // 
            MemberName.HeaderText = "Name";
            MemberName.Name = "MemberName";
            // 
            // MemberBalance
            // 
            MemberBalance.HeaderText = "Balance";
            MemberBalance.Name = "MemberBalance";
            // 
            // AccrossPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnRefresh);
            Controls.Add(label3);
            Controls.Add(dgvTransfer);
            Controls.Add(dgvMember);
            Controls.Add(dgvCoop);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AccrossPage";
            Size = new Size(606, 504);
            Load += AccrossPage_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCoop).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvMember).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvTransfer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private DataGridView dgvCoop;
        private DataGridView dgvMember;
        private DataGridView dgvTransfer;
        private Label label3;
        private Button btnRefresh;
        private DataGridViewButtonColumn CoopCode;
        private DataGridViewButtonColumn CoopName;
        private DataGridViewButtonColumn CoopAddress;
        private DataGridViewTextBoxColumn MemberCode;
        private DataGridViewTextBoxColumn MemberName;
        private DataGridViewTextBoxColumn MemberBalance;
    }
}
