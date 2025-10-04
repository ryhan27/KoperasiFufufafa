namespace KoperasiFufufafa.Forms
{
    partial class AdminForm
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
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            memberToolStripMenuItem = new ToolStripMenuItem();
            accesToolStripMenuItem = new ToolStripMenuItem();
            productToolStripMenuItem = new ToolStripMenuItem();
            approvalToolStripMenuItem = new ToolStripMenuItem();
            accesCooperationToolStripMenuItem = new ToolStripMenuItem();
            panelDisplay = new Panel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, memberToolStripMenuItem, accesToolStripMenuItem, productToolStripMenuItem, approvalToolStripMenuItem, accesCooperationToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            fileToolStripMenuItem.Click += fileToolStripMenuItem_Click;
            // 
            // memberToolStripMenuItem
            // 
            memberToolStripMenuItem.Name = "memberToolStripMenuItem";
            memberToolStripMenuItem.Size = new Size(64, 20);
            memberToolStripMenuItem.Text = "Member";
            memberToolStripMenuItem.Click += memberToolStripMenuItem_Click_1;
            // 
            // accesToolStripMenuItem
            // 
            accesToolStripMenuItem.Name = "accesToolStripMenuItem";
            accesToolStripMenuItem.Size = new Size(55, 20);
            accesToolStripMenuItem.Text = "Access";
            accesToolStripMenuItem.Click += accesToolStripMenuItem_Click;
            // 
            // productToolStripMenuItem
            // 
            productToolStripMenuItem.Name = "productToolStripMenuItem";
            productToolStripMenuItem.Size = new Size(61, 20);
            productToolStripMenuItem.Text = "Product";
            // 
            // approvalToolStripMenuItem
            // 
            approvalToolStripMenuItem.Name = "approvalToolStripMenuItem";
            approvalToolStripMenuItem.Size = new Size(67, 20);
            approvalToolStripMenuItem.Text = "Approval";
            approvalToolStripMenuItem.Click += approvalToolStripMenuItem_Click_1;
            // 
            // accesCooperationToolStripMenuItem
            // 
            accesCooperationToolStripMenuItem.Name = "accesCooperationToolStripMenuItem";
            accesCooperationToolStripMenuItem.Size = new Size(123, 20);
            accesCooperationToolStripMenuItem.Text = "Across Cooperation";
            accesCooperationToolStripMenuItem.Click += accesCooperationToolStripMenuItem_Click;
            // 
            // panelDisplay
            // 
            panelDisplay.Location = new Point(12, 27);
            panelDisplay.Name = "panelDisplay";
            panelDisplay.Size = new Size(776, 411);
            panelDisplay.TabIndex = 1;
            panelDisplay.Paint += panelDisplay_Paint;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelDisplay);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "AdminForm";
            Text = "AdminForm";
            Load += AdminForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem memberToolStripMenuItem;
        private ToolStripMenuItem accesToolStripMenuItem;
        private ToolStripMenuItem productToolStripMenuItem;
        private ToolStripMenuItem approvalToolStripMenuItem;
        private ToolStripMenuItem accesCooperationToolStripMenuItem;
        private Panel panelDisplay;
    }
}