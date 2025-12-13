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
            txtAmount = new TextBox();
            lblFee = new Label();
            lblTotal = new Label();
            txtRate = new TextBox();
            txtFee = new TextBox();
            txtSubtotal = new TextBox();
            txtTotal = new TextBox();
            btnSubmit = new Button();
            btnClear = new Button();
            lblExchange = new Label();
            SuspendLayout();
            // 
            // llAmount
            // 
            llAmount.AutoSize = true;
            llAmount.Location = new Point(91, 112);
            llAmount.Margin = new Padding(4, 0, 4, 0);
            llAmount.Name = "llAmount";
            llAmount.Size = new Size(67, 25);
            llAmount.TabIndex = 0;
            llAmount.Text = "Amout";
            // 
            // lblRate
            // 
            lblRate.AutoSize = true;
            lblRate.Location = new Point(91, 168);
            lblRate.Margin = new Padding(4, 0, 4, 0);
            lblRate.Name = "lblRate";
            lblRate.Size = new Size(47, 25);
            lblRate.TabIndex = 1;
            lblRate.Text = "Rate";
            // 
            // lblSubtotal
            // 
            lblSubtotal.AutoSize = true;
            lblSubtotal.Location = new Point(91, 218);
            lblSubtotal.Margin = new Padding(4, 0, 4, 0);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(79, 25);
            lblSubtotal.TabIndex = 2;
            lblSubtotal.Text = "Subtotal";
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(197, 98);
            txtAmount.Margin = new Padding(4, 5, 4, 5);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(211, 31);
            txtAmount.TabIndex = 3;
            txtAmount.TextChanged += txtAmount_TextChanged;
            // 
            // lblFee
            // 
            lblFee.AutoSize = true;
            lblFee.Location = new Point(91, 267);
            lblFee.Margin = new Padding(4, 0, 4, 0);
            lblFee.Name = "lblFee";
            lblFee.Size = new Size(39, 25);
            lblFee.TabIndex = 4;
            lblFee.Text = "Fee";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(91, 322);
            lblTotal.Margin = new Padding(4, 0, 4, 0);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(49, 25);
            lblTotal.TabIndex = 5;
            lblTotal.Text = "Total";
            // 
            // txtRate
            // 
            txtRate.Location = new Point(197, 155);
            txtRate.Margin = new Padding(4, 5, 4, 5);
            txtRate.Name = "txtRate";
            txtRate.ReadOnly = true;
            txtRate.Size = new Size(211, 31);
            txtRate.TabIndex = 6;
            // 
            // txtFee
            // 
            txtFee.Location = new Point(197, 253);
            txtFee.Margin = new Padding(4, 5, 4, 5);
            txtFee.Name = "txtFee";
            txtFee.ReadOnly = true;
            txtFee.Size = new Size(211, 31);
            txtFee.TabIndex = 7;
            // 
            // txtSubtotal
            // 
            txtSubtotal.Location = new Point(197, 205);
            txtSubtotal.Margin = new Padding(4, 5, 4, 5);
            txtSubtotal.Name = "txtSubtotal";
            txtSubtotal.ReadOnly = true;
            txtSubtotal.Size = new Size(211, 31);
            txtSubtotal.TabIndex = 8;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(197, 308);
            txtTotal.Margin = new Padding(4, 5, 4, 5);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(211, 31);
            txtTotal.TabIndex = 9;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(197, 400);
            btnSubmit.Margin = new Padding(4, 5, 4, 5);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(91, 42);
            btnSubmit.TabIndex = 10;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(319, 400);
            btnClear.Margin = new Padding(4, 5, 4, 5);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(91, 42);
            btnClear.TabIndex = 11;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // lblExchange
            // 
            lblExchange.AutoSize = true;
            lblExchange.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblExchange.Location = new Point(197, 0);
            lblExchange.Margin = new Padding(4, 0, 4, 0);
            lblExchange.Name = "lblExchange";
            lblExchange.Size = new Size(197, 32);
            lblExchange.TabIndex = 12;
            lblExchange.Text = "EXCHANGE USD";
            // 
            // ExchangePage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblExchange);
            Controls.Add(btnClear);
            Controls.Add(btnSubmit);
            Controls.Add(txtTotal);
            Controls.Add(txtSubtotal);
            Controls.Add(txtFee);
            Controls.Add(txtRate);
            Controls.Add(lblTotal);
            Controls.Add(lblFee);
            Controls.Add(txtAmount);
            Controls.Add(lblSubtotal);
            Controls.Add(lblRate);
            Controls.Add(llAmount);
            Margin = new Padding(4, 5, 4, 5);
            Name = "ExchangePage";
            Size = new Size(947, 933);
            Load += ExchangePage_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label llAmount;
        private Label lblRate;
        private Label lblSubtotal;
        private TextBox txtAmount;
        private Label lblFee;
        private Label lblTotal;
        private TextBox txtRate;
        private TextBox txtFee;
        private TextBox txtSubtotal;
        private TextBox txtTotal;
        private Button btnSubmit;
        private Button btnClear;
        private Label lblExchange;
    }
}
