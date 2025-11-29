namespace KoperasiFufufafa.Forms
{
    partial class ForgotPasword
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
            btnSubmit = new Button();
            btnBack = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            txtFavArtist = new TextBox();
            txtFavColor = new TextBox();
            txtPassword = new TextBox();
            SuspendLayout();
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(140, 204);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(75, 23);
            btnSubmit.TabIndex = 0;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;            
            // 
            // btnBack
            // 
            btnBack.Location = new Point(349, 204);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 23);
            btnBack.TabIndex = 1;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(140, 34);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 2;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(140, 124);
            label2.Name = "label2";
            label2.Size = new Size(134, 15);
            label2.TabIndex = 3;
            label2.Text = "What is Your Fav Color ?";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(427, 124);
            label3.Name = "label3";
            label3.Size = new Size(168, 15);
            label3.TabIndex = 4;
            label3.Text = "What is Your Fav Artist/Singer?";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(140, 269);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 5;
            label4.Text = "Password";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(146, 61);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(217, 23);
            textBox1.TabIndex = 6;
            // 
            // txtFavArtist
            // 
            txtFavArtist.Location = new Point(427, 155);
            txtFavArtist.Name = "txtFavArtist";
            txtFavArtist.Size = new Size(217, 23);
            txtFavArtist.TabIndex = 7;
            // 
            // txtFavColor
            // 
            txtFavColor.Location = new Point(140, 155);
            txtFavColor.Name = "txtFavColor";
            txtFavColor.Size = new Size(217, 23);
            txtFavColor.TabIndex = 8;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(140, 287);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(217, 23);
            txtPassword.TabIndex = 9;
            // 
            // ForgotPasword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtPassword);
            Controls.Add(txtFavColor);
            Controls.Add(txtFavArtist);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnBack);
            Controls.Add(btnSubmit);
            Name = "ForgotPasword";
            Text = "ForgotPasword";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSubmit;
        private Button btnBack;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox txtFavArtist;
        private TextBox txtFavColor;
        private TextBox txtPassword;
    }
}