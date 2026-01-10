namespace KoperasiFufufafa.Forms
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            pictureBox1 = new PictureBox();
            buttonRegistration = new Button();
            linkForgotPassword = new LinkLabel();
            buttonSubmit = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textPassword = new TextBox();
            textUsername = new TextBox();
            labelSuccess = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1, 1);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(370, 479);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // buttonRegistration
            // 
            buttonRegistration.BackColor = Color.Cyan;
            buttonRegistration.Location = new Point(377, 419);
            buttonRegistration.Margin = new Padding(3, 4, 3, 4);
            buttonRegistration.Name = "buttonRegistration";
            buttonRegistration.Size = new Size(103, 31);
            buttonRegistration.TabIndex = 16;
            buttonRegistration.Text = "Registration";
            buttonRegistration.UseVisualStyleBackColor = false;
            buttonRegistration.Click += buttonRegistration_Click;
            // 
            // linkForgotPassword
            // 
            linkForgotPassword.AutoSize = true;
            linkForgotPassword.Location = new Point(569, 309);
            linkForgotPassword.Name = "linkForgotPassword";
            linkForgotPassword.Size = new Size(118, 20);
            linkForgotPassword.TabIndex = 15;
            linkForgotPassword.TabStop = true;
            linkForgotPassword.Text = "Forgot Password";
            linkForgotPassword.VisitedLinkColor = Color.Blue;
            linkForgotPassword.LinkClicked += linkForgotPassword_LinkClicked;
            // 
            // buttonSubmit
            // 
            buttonSubmit.BackColor = Color.Lime;
            buttonSubmit.Location = new Point(377, 304);
            buttonSubmit.Margin = new Padding(3, 4, 3, 4);
            buttonSubmit.Name = "buttonSubmit";
            buttonSubmit.Size = new Size(86, 31);
            buttonSubmit.TabIndex = 14;
            buttonSubmit.Text = "Submit";
            buttonSubmit.UseVisualStyleBackColor = false;
            buttonSubmit.Click += buttonSubmit_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label3.Location = new Point(420, 95);
            label3.Name = "label3";
            label3.Size = new Size(238, 37);
            label3.TabIndex = 13;
            label3.Text = "LOGIN FUFUFAFA";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(381, 227);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 12;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(381, 153);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 11;
            label1.Text = "Username";
            // 
            // textPassword
            // 
            textPassword.Location = new Point(377, 251);
            textPassword.Margin = new Padding(3, 4, 3, 4);
            textPassword.Name = "textPassword";
            textPassword.Size = new Size(302, 27);
            textPassword.TabIndex = 10;
            // 
            // textUsername
            // 
            textUsername.Location = new Point(377, 177);
            textUsername.Margin = new Padding(3, 4, 3, 4);
            textUsername.Name = "textUsername";
            textUsername.Size = new Size(302, 27);
            textUsername.TabIndex = 9;
            // 
            // labelSuccess
            // 
            labelSuccess.AutoSize = true;
            labelSuccess.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelSuccess.ForeColor = Color.Green;
            labelSuccess.Location = new Point(377, 29);
            labelSuccess.Name = "labelSuccess";
            labelSuccess.Size = new Size(27, 28);
            labelSuccess.TabIndex = 18;
            labelSuccess.Text = "...";
            labelSuccess.Visible = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(722, 481);
            Controls.Add(labelSuccess);
            Controls.Add(pictureBox1);
            Controls.Add(buttonRegistration);
            Controls.Add(linkForgotPassword);
            Controls.Add(buttonSubmit);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textPassword);
            Controls.Add(textUsername);
            Margin = new Padding(3, 4, 3, 4);
            Name = "LoginForm";
            Text = "LoginForm";
            Load += LoginForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button buttonRegistration;
        private LinkLabel linkForgotPassword;
        private Button buttonSubmit;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textPassword;
        private TextBox textUsername;
        private Label labelSuccess;
    }
}