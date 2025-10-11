namespace KoperasiFufufafa.Forms
{
    partial class MemberPage
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
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            comboBox1 = new ComboBox();
            MemberId = new Label();
            lblCardId = new Label();
            lblFullName = new Label();
            lblJoinDate = new Label();
            lblEmail = new Label();
            lblPhone = new Label();
            lblPhoneAlt = new Label();
            lblAddres = new Label();
            dgvMember = new DataGridView();
            button1 = new Button();
            lblUpdate = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvMember).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 32);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 0;
            label1.Text = "Member Id";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 58);
            label2.Name = "label2";
            label2.Size = new Size(76, 15);
            label2.TabIndex = 1;
            label2.Text = "Card Id (KTP)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 89);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 2;
            label3.Text = "Full Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 115);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 3;
            label4.Text = "Join Date";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(32, 142);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 4;
            label5.Text = "Email";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(32, 169);
            label6.Name = "label6";
            label6.Size = new Size(41, 15);
            label6.TabIndex = 5;
            label6.Text = "Phone";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(32, 193);
            label7.Name = "label7";
            label7.Size = new Size(59, 15);
            label7.TabIndex = 6;
            label7.Text = "Phone Alt";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(32, 220);
            label8.Name = "label8";
            label8.Size = new Size(44, 15);
            label8.TabIndex = 7;
            label8.Text = "Addres";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(32, 248);
            label9.Name = "label9";
            label9.Size = new Size(39, 15);
            label9.TabIndex = 8;
            label9.Text = "Status";
            label9.Click += label9_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(32, 278);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(228, 23);
            comboBox1.TabIndex = 9;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // MemberId
            // 
            MemberId.AutoSize = true;
            MemberId.Location = new Point(135, 32);
            MemberId.Name = "MemberId";
            MemberId.Size = new Size(16, 15);
            MemberId.TabIndex = 10;
            MemberId.Text = "...";
            MemberId.Click += MemberId_Click;
            // 
            // lblCardId
            // 
            lblCardId.AutoSize = true;
            lblCardId.Location = new Point(135, 58);
            lblCardId.Name = "lblCardId";
            lblCardId.Size = new Size(16, 15);
            lblCardId.TabIndex = 11;
            lblCardId.Text = "...";
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Location = new Point(135, 89);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(16, 15);
            lblFullName.TabIndex = 12;
            lblFullName.Text = "...";
            lblFullName.Click += label12_Click;
            // 
            // lblJoinDate
            // 
            lblJoinDate.AutoSize = true;
            lblJoinDate.Location = new Point(135, 115);
            lblJoinDate.Name = "lblJoinDate";
            lblJoinDate.Size = new Size(16, 15);
            lblJoinDate.TabIndex = 13;
            lblJoinDate.Text = "...";
            lblJoinDate.Click += label13_Click;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(135, 142);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(16, 15);
            lblEmail.TabIndex = 14;
            lblEmail.Text = "...";
            lblEmail.Click += label14_Click;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(135, 169);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(16, 15);
            lblPhone.TabIndex = 15;
            lblPhone.Text = "...";
            lblPhone.Click += Phone_Click;
            // 
            // lblPhoneAlt
            // 
            lblPhoneAlt.AutoSize = true;
            lblPhoneAlt.Location = new Point(135, 193);
            lblPhoneAlt.Name = "lblPhoneAlt";
            lblPhoneAlt.Size = new Size(16, 15);
            lblPhoneAlt.TabIndex = 16;
            lblPhoneAlt.Text = "...";
            lblPhoneAlt.Click += label16_Click;
            // 
            // lblAddres
            // 
            lblAddres.AutoSize = true;
            lblAddres.Location = new Point(135, 220);
            lblAddres.Name = "lblAddres";
            lblAddres.Size = new Size(16, 15);
            lblAddres.TabIndex = 17;
            lblAddres.Text = "...";
            lblAddres.Click += label17_Click;
            // 
            // dgvMember
            // 
            dgvMember.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMember.Location = new Point(346, 20);
            dgvMember.Name = "dgvMember";
            dgvMember.Size = new Size(443, 335);
            dgvMember.TabIndex = 18;
            // 
            // button1
            // 
            button1.Location = new Point(32, 318);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 19;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblUpdate
            // 
            lblUpdate.AutoSize = true;
            lblUpdate.Location = new Point(135, 322);
            lblUpdate.Name = "lblUpdate";
            lblUpdate.Size = new Size(16, 15);
            lblUpdate.TabIndex = 20;
            lblUpdate.Text = "...";
            lblUpdate.Click += label18_Click_1;
            // 
            // MemberPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblUpdate);
            Controls.Add(button1);
            Controls.Add(dgvMember);
            Controls.Add(lblAddres);
            Controls.Add(lblPhoneAlt);
            Controls.Add(lblPhone);
            Controls.Add(lblEmail);
            Controls.Add(lblJoinDate);
            Controls.Add(lblFullName);
            Controls.Add(lblCardId);
            Controls.Add(MemberId);
            Controls.Add(comboBox1);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "MemberPage";
            Size = new Size(882, 445);
            Load += MemberPage_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMember).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private ComboBox comboBox1;
        private Label MemberId;
        private Label lblCardId;
        private Label lblFullName;
        private Label lblJoinDate;
        private Label lblEmail;
        private Label lblPhone;
        private Label lblPhoneAlt;
        private Label lblAddres;
        private DataGridView dgvMember;
        private Button button1;
        private Label lblUpdate;
    }
}
