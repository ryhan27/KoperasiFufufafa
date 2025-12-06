using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KoperasiFufufafa.Data;
using KoperasiFufufafa.Forms;
using KoperasiFufufafa.Models;

namespace KoperasiFufufafa
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registrations form = new Registrations();
            form.ShowDialog();
        }

        private void label4_Click(String message)
        {
            labelSuccess.Text = message;
            labelSuccess.Visible = true;
        }

        private async void buttonSubmit_Click(object sender, EventArgs e)
        {
            labelSuccess.Visible = false;
            using var db = new AppDbContext();
            var auth = new AuthService(db);
            var user = await auth.LoginAsync(textUsername.Text, textPassword.Text);
            if (user != null)
            {
                LoggedInUser = user;
                if (LoggedInUser.level == "admin")
                {
                    this.Hide();
                    AdminForm form = new AdminForm(LoggedInUser);
                    form.ShowDialog();
                }
                else
                {
                    AccessService accessService = new AccessService(db);
                    Access access = await accessService.GetAccess(user.Id);
                    if (access == null)
                    {
                        labelSuccess.Text = "Access Is Not Granted By Admin!";
                        labelSuccess.ForeColor = Color.Red;
                        labelSuccess.Visible = true;
                    }
                    else
                    {
                        this.Hide();
                        HomeForm form = new HomeForm(LoggedInUser);
                        form.ShowDialog();
                    }
                }
            }
            else
            {
                labelSuccess.Text = "Invalid Credentials";
                labelSuccess.ForeColor = Color.Red;
                labelSuccess.Visible = true;
            }
        }

        private void linkForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            ForgotPasswordForm form = new ForgotPasswordForm();
            form.ShowDialog();
        }
    }
}
