namespace KoperasiFufufafa.Forms
{
    partial class ForgotPasswordForm
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
            textUsername = new TextBox();
            textQuest1 = new TextBox();
            textQuest2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            buttonSubmit = new Button();
            buttonBack = new Button();
            label4 = new Label();
            textPassword = new TextBox();
            SuspendLayout();
            // 
            // textUsername
            // 
            textUsername.Location = new Point(42, 64);
            textUsername.Margin = new Padding(3, 4, 3, 4);
            textUsername.Name = "textUsername";
            textUsername.Size = new Size(262, 27);
            textUsername.TabIndex = 0;
            // 
            // textQuest1
            // 
            textQuest1.Location = new Point(42, 133);
            textQuest1.Margin = new Padding(3, 4, 3, 4);
            textQuest1.Name = "textQuest1";
            textQuest1.Size = new Size(262, 27);
            textQuest1.TabIndex = 1;
            // 
            // textQuest2
            // 
            textQuest2.Location = new Point(326, 133);
            textQuest2.Margin = new Padding(3, 4, 3, 4);
            textQuest2.Name = "textQuest2";
            textQuest2.Size = new Size(262, 27);
            textQuest2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 40);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 3;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 109);
            label2.Name = "label2";
            label2.Size = new Size(163, 20);
            label2.TabIndex = 4;
            label2.Text = "What is Your Fav Color?";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(329, 109);
            label3.Name = "label3";
            label3.Size = new Size(206, 20);
            label3.TabIndex = 5;
            label3.Text = "Who is Your Fav Artist/Singer?";
            // 
            // buttonSubmit
            // 
            buttonSubmit.BackColor = Color.Lime;
            buttonSubmit.Location = new Point(42, 175);
            buttonSubmit.Margin = new Padding(3, 4, 3, 4);
            buttonSubmit.Name = "buttonSubmit";
            buttonSubmit.Size = new Size(86, 31);
            buttonSubmit.TabIndex = 6;
            buttonSubmit.Text = "Submit";
            buttonSubmit.UseVisualStyleBackColor = false;
            buttonSubmit.Click += buttonSubmit_Click;
            // 
            // buttonBack
            // 
            buttonBack.BackColor = Color.Red;
            buttonBack.Location = new Point(135, 175);
            buttonBack.Margin = new Padding(3, 4, 3, 4);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(86, 31);
            buttonBack.TabIndex = 7;
            buttonBack.Text = "Back";
            buttonBack.UseVisualStyleBackColor = false;
            buttonBack.Click += buttonBack_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(46, 231);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 9;
            label4.Text = "Password";
            // 
            // textPassword
            // 
            textPassword.Location = new Point(42, 255);
            textPassword.Margin = new Padding(3, 4, 3, 4);
            textPassword.Name = "textPassword";
            textPassword.ReadOnly = true;
            textPassword.Size = new Size(380, 27);
            textPassword.TabIndex = 8;
            // 
            // ForgotPasswordForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(625, 332);
            Controls.Add(label4);
            Controls.Add(textPassword);
            Controls.Add(buttonBack);
            Controls.Add(buttonSubmit);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textQuest2);
            Controls.Add(textQuest1);
            Controls.Add(textUsername);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ForgotPasswordForm";
            Text = "Forgot Password";
            Load += ForgotPasswordForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textUsername;
        private TextBox textQuest1;
        private TextBox textQuest2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button buttonSubmit;
        private Button buttonBack;
        private Label label4;
        private TextBox textPassword;
    }
}