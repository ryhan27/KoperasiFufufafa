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
            lblmember = new Label();
            lblCardId = new Label();
            lblFullName = new Label();
            lblJoinDate = new Label();
            lblEmail = new Label();
            lblPhone = new Label();
            lblPhoneAlt = new Label();
            lbladdress = new Label();
            lblStatus = new Label();
            comboBox1 = new ComboBox();
            btnUpdate = new Button();
            SuspendLayout();
            // 
            // lblmember
            // 
            lblmember.AutoSize = true;
            lblmember.Location = new Point(36, 51);
            lblmember.Name = "lblmember";
            lblmember.Size = new Size(65, 15);
            lblmember.TabIndex = 0;
            lblmember.Text = "Member Id";
            lblmember.Click += label1_Click;
            // 
            // lblCardId
            // 
            lblCardId.AutoSize = true;
            lblCardId.Location = new Point(36, 73);
            lblCardId.Name = "lblCardId";
            lblCardId.Size = new Size(42, 15);
            lblCardId.TabIndex = 1;
            lblCardId.Text = "CardId";
            lblCardId.Click += label2_Click;
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Location = new Point(36, 96);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(61, 15);
            lblFullName.TabIndex = 2;
            lblFullName.Text = "Full Name";
            lblFullName.Click += label3_Click;
            // 
            // lblJoinDate
            // 
            lblJoinDate.AutoSize = true;
            lblJoinDate.Location = new Point(36, 124);
            lblJoinDate.Name = "lblJoinDate";
            lblJoinDate.Size = new Size(55, 15);
            lblJoinDate.TabIndex = 3;
            lblJoinDate.Text = "Join Date";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(36, 149);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "Email";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(36, 173);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(41, 15);
            lblPhone.TabIndex = 5;
            lblPhone.Text = "Phone";
            // 
            // lblPhoneAlt
            // 
            lblPhoneAlt.AutoSize = true;
            lblPhoneAlt.Location = new Point(36, 197);
            lblPhoneAlt.Name = "lblPhoneAlt";
            lblPhoneAlt.Size = new Size(59, 15);
            lblPhoneAlt.TabIndex = 6;
            lblPhoneAlt.Text = "Phone Alt";
            // 
            // lbladdress
            // 
            lbladdress.AutoSize = true;
            lbladdress.Location = new Point(36, 221);
            lbladdress.Name = "lbladdress";
            lbladdress.Size = new Size(49, 15);
            lbladdress.TabIndex = 7;
            lbladdress.Text = "Address";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(38, 263);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(39, 15);
            lblStatus.TabIndex = 8;
            lblStatus.Text = "Status";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(38, 281);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(271, 23);
            comboBox1.TabIndex = 9;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(36, 319);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 10;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // MemberPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnUpdate);
            Controls.Add(comboBox1);
            Controls.Add(lblStatus);
            Controls.Add(lbladdress);
            Controls.Add(lblPhoneAlt);
            Controls.Add(lblPhone);
            Controls.Add(lblEmail);
            Controls.Add(lblJoinDate);
            Controls.Add(lblFullName);
            Controls.Add(lblCardId);
            Controls.Add(lblmember);
            Name = "MemberPage";
            Size = new Size(991, 640);
            Load += MemberPage_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblmember;
        private Label lblCardId;
        private Label lblFullName;
        private Label lblJoinDate;
        private Label lblEmail;
        private Label lblPhone;
        private Label lblPhoneAlt;
        private Label lbladdress;
        private Label lblStatus;
        private ComboBox comboBox1;
        private Button btnUpdate;
    }
}
