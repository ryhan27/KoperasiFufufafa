using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BankDashboard
{
    public partial class DashboardForm : Form
    {
        // Deklarasi label
        private Label lblBalance;
        private Label lblLoan;
        private Label lblSaving;
        private Label lblInhouseTransactions;
        private Label lblAcrossTransactions;
        private Label lblExchange;

        public DashboardForm()
        {
            InitializeComponent();
            InitializeDashboard();
        }

        private void InitializeDashboard()
        {
            // Set form properties
            this.Text = "Bank Dashboard";
            this.Size = new Size(900, 600);
            this.BackColor = Color.WhiteSmoke;

            int panelWidth = 200, panelHeight = 100, marginX = 80, marginY = 40;
            int baseX = 80, baseY = 120, verticalSpacing = 30;

            // Panel dan Label untuk Balance
            Panel pnlBalance = CreatePanel(baseX, baseY, panelWidth, panelHeight, Color.LightSteelBlue);
            Label lbl1 = CreateTextLabel("Balance", 12, new Point(10, 10));
            lblBalance = CreateValueLabel("lblBalance", new Point(170, 70));

            // Panel dan Label untuk Loan
            Panel pnlLoan = CreatePanel(baseX + panelWidth + marginX, baseY, panelWidth, panelHeight, Color.DodgerBlue);
            Label lbl2 = CreateTextLabel("Loan", 12, new Point(10, 10));
            lblLoan = CreateValueLabel("lblLoan", new Point(170, 70));

            // Panel dan Label untuk Saving
            Panel pnlSaving = CreatePanel(baseX + (panelWidth + marginX) * 2, baseY, panelWidth, panelHeight, Color.DarkGoldenrod);
            Label lbl3 = CreateTextLabel("Saving", 12, new Point(10, 10));
            lblSaving = CreateValueLabel("lblSaving", new Point(170, 70));

            // Panel dan Label untuk Inhouse Transactions
            Panel pnlInhouse = CreatePanel(baseX, baseY + panelHeight + verticalSpacing, panelWidth, panelHeight, Color.Red);
            Label lbl4 = CreateTextLabel("Inhouse Transactions", 12, new Point(10, 10));
            lblInhouseTransactions = CreateValueLabel("lblInhouseTransactions", new Point(170, 70));

            // Panel dan Label untuk Across Transactions
            Panel pnlAcross = CreatePanel(baseX + panelWidth + marginX, baseY + panelHeight + verticalSpacing, panelWidth, panelHeight, Color.Yellow);
            Label lbl5 = CreateTextLabel("Across Transactions", 12, new Point(10, 10));
            lblAcrossTransactions = CreateValueLabel("lblAcrossTransactions", new Point(170, 70));

            // Panel dan Label untuk Exchange
            Panel pnlExchange = CreatePanel(baseX + (panelWidth + marginX) * 2, baseY + panelHeight + verticalSpacing, panelWidth, panelHeight, Color.Green);
            Label lbl6 = CreateTextLabel("Exchange", 12, new Point(10, 10));
            lblExchange = CreateValueLabel("lblExchange", new Point(170, 70));

            // Tambahkan kontrol pada masing-masing panel
            pnlBalance.Controls.Add(lbl1); pnlBalance.Controls.Add(lblBalance);
            pnlLoan.Controls.Add(lbl2); pnlLoan.Controls.Add(lblLoan);
            pnlSaving.Controls.Add(lbl3); pnlSaving.Controls.Add(lblSaving);
            pnlInhouse.Controls.Add(lbl4); pnlInhouse.Controls.Add(lblInhouseTransactions);
            pnlAcross.Controls.Add(lbl5); pnlAcross.Controls.Add(lblAcrossTransactions);
            pnlExchange.Controls.Add(lbl6); pnlExchange.Controls.Add(lblExchange);

            // Tambahkan panel ke form
            this.Controls.Add(pnlBalance);
            this.Controls.Add(pnlLoan);
            this.Controls.Add(pnlSaving);
            this.Controls.Add(pnlInhouse);
            this.Controls.Add(pnlAcross);
            this.Controls.Add(pnlExchange);
        }

        private Panel CreatePanel(int x, int y, int width, int height, Color color)
        {
            Panel panel = new Panel();
            panel.Location = new Point(x, y);
            panel.Size = new Size(width, height);
            panel.BackColor = color;
            panel.BorderStyle = BorderStyle.FixedSingle;
            return panel;
        }

        private Label CreateTextLabel(string text, int fontSize, Point location)
        {
            Label label = new Label();
            label.Text = text;
            label.Font = new Font("Segoe UI", fontSize, FontStyle.Regular);
            label.Location = location;
            label.AutoSize = true;
            label.ForeColor = Color.Black;
            return label;
        }

        private Label CreateValueLabel(string name, Point location)
        {
            Label label = new Label();
            label.Name = name;
            label.Text = "0";
            label.Font = new Font("Segoe UI", 16, FontStyle.Bold);
            label.Location = location;
            label.AutoSize = true;
            label.ForeColor = Color.Black;
            return label;
        }

        private void InitializeComponent()
        {

        }
    }
}
