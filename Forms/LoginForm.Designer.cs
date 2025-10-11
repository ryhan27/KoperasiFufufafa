namespace KoperasiFufufafa
{
    partial class Form2
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            textUsername = new TextBox();
            label3 = new Label();
            textPassword = new TextBox();
            buttonSubmit = new Button();
            buttonRegistration = new Button();
            linkForgotPassword = new LinkLabel();
            labelSuccess = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AccessibleName = "";
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(351, 29);
            label1.Name = "label1";
            label1.Size = new Size(87, 32);
            label1.TabIndex = 0;
            label1.Text = "LOGIN";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(255, 60);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 1;
            label2.Text = "Username";
            label2.Click += label2_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // textUsername
            // 
            textUsername.Location = new Point(255, 78);
            textUsername.Name = "textUsername";
            textUsername.Size = new Size(269, 23);
            textUsername.TabIndex = 3;
            textUsername.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(255, 114);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 4;
            label3.Text = "Password";
            // 
            // textPassword
            // 
            textPassword.Location = new Point(255, 132);
            textPassword.Name = "textPassword";
            textPassword.Size = new Size(269, 23);
            textPassword.TabIndex = 5;
            // 
            // buttonSubmit
            // 
            buttonSubmit.Location = new Point(256, 178);
            buttonSubmit.Name = "buttonSubmit";
            buttonSubmit.Size = new Size(71, 22);
            buttonSubmit.TabIndex = 6;
            buttonSubmit.Text = "Submit";
            buttonSubmit.UseVisualStyleBackColor = true;
            buttonSubmit.Click += buttonSubmit_Click;
            // 
            // buttonRegistration
            // 
            buttonRegistration.Location = new Point(256, 220);
            buttonRegistration.Name = "buttonRegistration";
            buttonRegistration.Size = new Size(96, 24);
            buttonRegistration.TabIndex = 7;
            buttonRegistration.Text = "Regristation";
            buttonRegistration.UseVisualStyleBackColor = true;
            buttonRegistration.Click += button2_Click;
            // 
            // linkForgotPassword
            // 
            linkForgotPassword.AutoSize = true;
            linkForgotPassword.Location = new Point(456, 229);
            linkForgotPassword.Name = "linkForgotPassword";
            linkForgotPassword.Size = new Size(95, 15);
            linkForgotPassword.TabIndex = 8;
            linkForgotPassword.TabStop = true;
            linkForgotPassword.Text = "Forgot Password";
            linkForgotPassword.LinkClicked += linkForgotPassword_LinkClicked;
            // 
            // labelSuccess
            // 
            labelSuccess.AutoSize = true;
            labelSuccess.ForeColor = Color.Red;
            labelSuccess.Location = new Point(256, 9);
            labelSuccess.Name = "labelSuccess";
            labelSuccess.Size = new Size(16, 15);
            labelSuccess.TabIndex = 9;
            labelSuccess.Text = "...";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelSuccess);
            Controls.Add(linkForgotPassword);
            Controls.Add(buttonRegistration);
            Controls.Add(buttonSubmit);
            Controls.Add(textPassword);
            Controls.Add(label3);
            Controls.Add(textUsername);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Login";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox textUsername;
        private Label label3;
        private TextBox textPassword;
        private Button buttonSubmit;
        private Button buttonRegistration;
        private LinkLabel linkForgotPassword;
        private Label labelSuccess;
    }
}