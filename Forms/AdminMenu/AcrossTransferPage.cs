using KoperasiFufufafa.Api.Connectors;
using KoperasiFufufafa.Api.Models;
using KoperasiFufufafa.Data;
using KoperasiFufufafa.Models;
using KoperasiFufufafa.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KoperasiFufufafa.Forms.MemberMenus
{
    public partial class AcrossTransferPage : UserControl
    {
        Member loggedMember;

        public AcrossTransferPage(Member member)
        {
            loggedMember = member;
            InitializeComponent();
        }

        private async void AcrossTransferPage_Load(object sender, EventArgs e)
        {
            timerInbox.Enabled = false;

            if (loggedMember.ReferenceId == null ||
                loggedMember.ReferenceId == "" ||
                loggedMember.ReferenceId == "--")
            {
                DialogResult result = MessageBox.Show(
                    "You do not have a privilege to Use Across Transfer. Registration Now?",
                    "Invalid",
                    MessageBoxButtons.YesNo
                );

                if (result == DialogResult.Yes)
                {
                    string message;
                    
