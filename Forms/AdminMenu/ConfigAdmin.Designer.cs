namespace KoperasiFufufafa.Forms
{
    partial class ConfigPage
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
            textTermin1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textExchangesRate = new TextBox();
            textInhouseFee = new TextBox();
            label3 = new Label();
            label4 = new Label();
            textTermin2 = new TextBox();
            textAccessFee = new TextBox();
            label5 = new Label();
            label6 = new Label();
            textTermin3 = new TextBox();
            buttonUpdate = new Button();
            SuspendLayout();
            // 
            // textTermin1
            // 
            textTermin1.BackColor = Color.Gray;
            textTermin1.Location = new Point(69, 56);
            textTermin1.Multiline = true;
            textTermin1.Name = "textTermin1";
            textTermin1.Size = new Size(266, 293);
            textTermin1.TabIndex = 0;
//            textTermin1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(71, 24);
            label1.Name = "label1";
            label1.Size = new Size(130, 25);
            label1.TabIndex = 1;
            label1.Text = "Terminonlogi 1";
  //          label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(69, 363);
            label2.Name = "label2";
            label2.Size = new Size(134, 25);
            label2.TabIndex = 2;
            label2.Text = "Exchanges Rate";
            // 
            // textExchangesRate
            // 
            textExchangesRate.BackColor = Color.Silver;
            textExchangesRate.Location = new Point(69, 401);
            textExchangesRate.Name = "textExchangesRate";
            textExchangesRate.Size = new Size(266, 31);
            textExchangesRate.TabIndex = 4;
            // 
            // textInhouseFee
            // 
            textInhouseFee.BackColor = Color.Silver;
            textInhouseFee.Location = new Point(393, 401);
            textInhouseFee.Name = "textInhouseFee";
            textInhouseFee.Size = new Size(266, 31);
            textInhouseFee.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(393, 363);
            label3.Name = "label3";
            label3.Size = new Size(107, 25);
            label3.TabIndex = 7;
            label3.Text = "Inhouse Fee";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(395, 24);
            label4.Name = "label4";
            label4.Size = new Size(120, 25);
            label4.TabIndex = 6;
            label4.Text = "Terminologi 2";
            // 
            // textTermin2
            // 
            textTermin2.BackColor = Color.Gray;
            textTermin2.Location = new Point(393, 56);
            textTermin2.Multiline = true;
            textTermin2.Name = "textTermin2";
            textTermin2.Size = new Size(266, 293);
            textTermin2.TabIndex = 5;
            // 
            // textAccessFee
            // 
            textAccessFee.BackColor = Color.Silver;
            textAccessFee.Location = new Point(720, 401);
            textAccessFee.Name = "textAccessFee";
            textAccessFee.Size = new Size(266, 31);
            textAccessFee.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(720, 363);
            label5.Name = "label5";
            label5.Size = new Size(97, 25);
            label5.TabIndex = 11;
            label5.Text = "Access Fee";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(722, 24);
            label6.Name = "label6";
            label6.Size = new Size(120, 25);
            label6.TabIndex = 10;
            label6.Text = "Terminologi 3";
            // 
            // textTermin3
            // 
            textTermin3.BackColor = Color.Gray;
            textTermin3.Location = new Point(720, 56);
            textTermin3.Multiline = true;
            textTermin3.Name = "textTermin3";
            textTermin3.Size = new Size(266, 293);
            textTermin3.TabIndex = 9;
            // 
            // buttonUpdate
            // 
            buttonUpdate.BackColor = Color.Silver;
            buttonUpdate.ForeColor = Color.Black;
            buttonUpdate.Location = new Point(459, 470);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(112, 34);
            buttonUpdate.TabIndex = 13;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = false;
           // buttonUpdate.Click += buttonUpdate_Click;
            // 
            // ConfigPage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(buttonUpdate);
            Controls.Add(textAccessFee);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(textTermin3);
            Controls.Add(textInhouseFee);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(textTermin2);
            Controls.Add(textExchangesRate);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textTermin1);
            Name = "ConfigPage";
            Size = new Size(1078, 535);
            Load += textExchangesRate_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textTermin1;
        private Label label1;
        private Label label2;
        private TextBox textExchangesRate;
        private TextBox textInhouseFee;
        private Label label3;
        private Label label4;
        private TextBox textTermin2;
        private TextBox textAccessFee;
        private Label label5;
        private Label label6;
        private TextBox textTermin3;
        private Button buttonUpdate;
    }
}
