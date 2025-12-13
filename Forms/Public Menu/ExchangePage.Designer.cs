namespace KoperasiFufufafa.Forms.Public_Menu
{
    partial class ExchangePage
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
            llAmount = new Label();
            lblRate = new Label();
            lblSubtotal = new Label();
            textBox1 = new TextBox();
            lblFee = new Label();
            lblTotal = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            btnSubmit = new Button();
            btnClear = new Button();
            lblExchange = new Label();
            SuspendLayout();
            // 
            // llAmount
            // 
            llAmount.AutoSize = true;
            llAmount.Location = new Point(64, 67);
            llAmount.Name = "llAmount";
            llAmount.Size = new Size(44, 15);
            llAmount.TabIndex = 0;
            llAmount.Text = "Amout";
            // 
            // lblRate
            // 
            lblRate.AutoSize = true;
            lblRate.Location = new Point(64, 101);
            lblRate.Name = "lblRate";
            lblRate.Size = new Size(30, 15);
            lblRate.TabIndex = 1;
            lblRate.Text = "Rate";
            // 
            // lblSubtotal
            // 
            lblSubtotal.AutoSize = true;
            lblSubtotal.Location = new Point(64, 131);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(51, 15);
            lblSubtotal.TabIndex = 2;
            lblSubtotal.Text = "Subtotal";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(138, 59);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(149, 23);
            textBox1.TabIndex = 3;
            // 
            // lblFee
            // 
            lblFee.AutoSize = true;
            lblFee.Location = new Point(64, 160);
            lblFee.Name = "lblFee";
            lblFee.Size = new Size(25, 15);
            lblFee.TabIndex = 4;
            lblFee.Text = "Fee";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(64, 193);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(33, 15);
            lblTotal.TabIndex = 5;
            lblTotal.Text = "Total";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(138, 93);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(149, 23);
            textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(138, 152);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(149, 23);
            textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(138, 123);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(149, 23);
            textBox4.TabIndex = 8;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(138, 185);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(149, 23);
            textBox5.TabIndex = 9;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(138, 240);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(64, 25);
            btnSubmit.TabIndex = 10;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(223, 240);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(64, 25);
            btnClear.TabIndex = 11;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // lblExchange
            // 
            lblExchange.AutoSize = true;
            lblExchange.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblExchange.Location = new Point(138, 0);
            lblExchange.Name = "lblExchange";
            lblExchange.Size = new Size(132, 21);
            lblExchange.TabIndex = 12;
            lblExchange.Text = "EXCHANGE USD";
            // 
            // ExchangePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblExchange);
            Controls.Add(btnClear);
            Controls.Add(btnSubmit);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(lblTotal);
            Controls.Add(lblFee);
            Controls.Add(textBox1);
            Controls.Add(lblSubtotal);
            Controls.Add(lblRate);
            Controls.Add(llAmount);
            Name = "ExchangePage";
            Size = new Size(663, 560);
            Load += ExchangePage_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label llAmount;
        private Label lblRate;
        private Label lblSubtotal;
        private TextBox textBox1;
        private Label lblFee;
        private Label lblTotal;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Button btnSubmit;
        private Button btnClear;
        private Label lblExchange;
    }
}
