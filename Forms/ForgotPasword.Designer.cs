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
            btnSubmit.Location = new Point(160, 272);
            btnSubmit.Margin = new Padding(3, 4, 3, 4);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(86, 31);
            btnSubmit.TabIndex = 0;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(399, 272);
            btnBack.Margin = new Padding(3, 4, 3, 4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(86, 31);
            btnBack.TabIndex = 1;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(160, 45);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 2;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(160, 165);
            label2.Name = "label2";
            label2.Size = new Size(167, 20);
            label2.TabIndex = 3;
            label2.Text = "What is Your Fav Color ?";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(488, 165);
            label3.Name = "label3";
            label3.Size = new Size(210, 20);
            label3.TabIndex = 4;
            label3.Text = "What is Your Fav Artist/Singer?";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(160, 359);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 5;
            label4.Text = "Password";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(167, 81);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(247, 27);
            textBox1.TabIndex = 6;
            // 
            // txtFavArtist
            // 
            txtFavArtist.Location = new Point(488, 207);
            txtFavArtist.Margin = new Padding(3, 4, 3, 4);
            txtFavArtist.Name = "txtFavArtist";
            txtFavArtist.Size = new Size(247, 27);
            txtFavArtist.TabIndex = 7;
            // 
            // txtFavColor
            // 
            txtFavColor.Location = new Point(160, 207);
            txtFavColor.Margin = new Padding(3, 4, 3, 4);
            txtFavColor.Name = "txtFavColor";
            txtFavColor.Size = new Size(247, 27);
            txtFavColor.TabIndex = 8;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(160, 383);
            txtPassword.Margin = new Padding(3, 4, 3, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(247, 27);
            txtPassword.TabIndex = 9;
            // 
            // ForgotPasword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
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
            Margin = new Padding(3, 4, 3, 4);
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