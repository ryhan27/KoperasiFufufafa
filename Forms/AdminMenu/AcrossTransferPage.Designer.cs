namespace KoperasiFufufafa.Forms.AdminMenu
{
    partial class AcrossTransferPage
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
            txtBalance = new TextBox();
            txtAmount = new TextBox();
            txtBenficiary = new TextBox();
            txtRemarks = new TextBox();
            txtTransferRef = new TextBox();
            dataGridIncoming = new DataGridView();
            dataGridView2 = new DataGridView();
            btnSubmit = new Button();
            btnClear = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridIncoming).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(75, 67);
            label1.Name = "label1";
            label1.Size = new Size(71, 25);
            label1.TabIndex = 0;
            label1.Text = "Balance";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(75, 141);
            label2.Name = "label2";
            label2.Size = new Size(96, 25);
            label2.TabIndex = 1;
            label2.Text = "Beneficiary";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(75, 224);
            label3.Name = "label3";
            label3.Size = new Size(77, 25);
            label3.TabIndex = 2;
            label3.Text = "Amount";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(75, 310);
            label4.Name = "label4";
            label4.Size = new Size(103, 25);
            label4.TabIndex = 3;
            label4.Text = "Transfer Ref";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(75, 401);
            label5.Name = "label5";
            label5.Size = new Size(79, 25);
            label5.TabIndex = 4;
            label5.Text = "Remarks";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(463, 18);
            label6.Name = "label6";
            label6.Size = new Size(87, 25);
            label6.TabIndex = 5;
            label6.Text = "Incoming";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(463, 310);
            label7.Name = "label7";
            label7.Size = new Size(89, 25);
            label7.TabIndex = 6;
            label7.Text = "Outgoing";
            // 
            // txtBalance
            // 
            txtBalance.Location = new Point(75, 95);
            txtBalance.Name = "txtBalance";
            txtBalance.Size = new Size(150, 31);
            txtBalance.TabIndex = 7;
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(75, 252);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(150, 31);
            txtAmount.TabIndex = 8;
            // 
            // txtBenficiary
            // 
            txtBenficiary.Location = new Point(75, 169);
            txtBenficiary.Name = "txtBenficiary";
            txtBenficiary.Size = new Size(150, 31);
            txtBenficiary.TabIndex = 10;
            // 
            // txtRemarks
            // 
            txtRemarks.Location = new Point(75, 429);
            txtRemarks.Name = "txtRemarks";
            txtRemarks.Size = new Size(150, 31);
            txtRemarks.TabIndex = 11;
            // 
            // txtTransferRef
            // 
            txtTransferRef.Location = new Point(75, 354);
            txtTransferRef.Name = "txtTransferRef";
            txtTransferRef.Size = new Size(150, 31);
            txtTransferRef.TabIndex = 12;
            // 
            // dataGridIncoming
            // 
            dataGridIncoming.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridIncoming.Location = new Point(463, 58);
            dataGridIncoming.Name = "dataGridIncoming";
            dataGridIncoming.RowHeadersWidth = 62;
            dataGridIncoming.Size = new Size(360, 225);
            dataGridIncoming.TabIndex = 13;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(463, 338);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.Size = new Size(360, 225);
            dataGridView2.TabIndex = 14;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(77, 477);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(112, 34);
            btnSubmit.TabIndex = 15;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(260, 480);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(112, 34);
            btnClear.TabIndex = 16;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // AcrossTransferPage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnClear);
            Controls.Add(btnSubmit);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridIncoming);
            Controls.Add(txtTransferRef);
            Controls.Add(txtRemarks);
            Controls.Add(txtBenficiary);
            Controls.Add(txtAmount);
            Controls.Add(txtBalance);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AcrossTransferPage";
            Size = new Size(944, 581);
            ((System.ComponentModel.ISupportInitialize)dataGridIncoming).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
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
        private TextBox txtBalance;
        private TextBox txtAmount;
        private TextBox txtBenficiary;
        private TextBox txtRemarks;
        private TextBox txtTransferRef;
        private DataGridView dataGridIncoming;
        private DataGridView dataGridView2;
        private Button btnSubmit;
        private Button btnClear;
    }
}
