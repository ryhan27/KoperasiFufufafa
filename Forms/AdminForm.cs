﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using KoperasiFufufafa.Forms.AdminMenu;
using KoperasiFufufafa.Models;

namespace KoperasiFufufafa.Forms
{
    public partial class AdminForm : Form
    {
        Member? loggedMember = null;
        public AdminForm(Member member)
        {
            loggedMember = member;
            InitializeComponent();
            this.Text = "Koperasi Fufufafa: " +
                loggedMember.MemberId + " - " + loggedMember.FullName + ")";
        }
        public void route(System.Windows.Forms.Control control)
        {
            this.panelDisplay.Controls.Clear();
            this.panelDisplay.Dock = DockStyle.Fill;
            this.panelDisplay.Controls.Add(control);
        }
        private void AdminForm_Load(object sender, EventArgs e)
        {
            route(new DashboardAdminPage(loggedMember));
        }
        private void accessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            route(new AccessPage(loggedMember));
        }
        private void configurationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            route(new ConfigPage());
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loggedMember = null;
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
        }
        private void memberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            route(new MemberPage());
        }
        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            route(new ProductPage());
        }
        private void acrossCooperationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            route(new AcrossPage());
        }
        private void approvalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            route(new ApprovalPage(loggedMember));
        }

        private void memberToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void accesCooperationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void accesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void approvalToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void panelDisplay_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
