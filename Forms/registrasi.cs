using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace KoperasiBadBoy.Forms
{
    public partial class RegistrasiFrom : Form
    {
        public RegistrasiFrom()
        {
            InitializeComponent();
        }

        private void RegistrasiFrom_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            using var db = new AppDbContext();
            var auth = new AuthService(db);
            var member = auth.RegisterAsync(txtAddress.Text, txtCardId.Text,
                txtEmail.Text, txtName.Text, txtPassword.Text,
                txtPhone.Text, txtPhoneAlt.Text, txtReferenceId.Text,
                txtUsername.Text, txtQuest1.Text, txtQuest2.Text);

            if (member != null)
            {
                this.Hide();
                LoginForm loginForm = new LoginForm();
                loginForm.setSuccessAlert("Registration Success! Please Login...");
                loginForm.ShowDialog();
            }
            else
            {
                labelError.Text = "Registration Failed!";
                labelError.Visible = true;
            }
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void txtArtis_TextChanged(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            textBox9 = new TextBox();
            textBox10 = new TextBox();
            textBox11 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 296);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(132, 296);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 1;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 2;
            label1.Text = "Full Name";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 32);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(214, 27);
            textBox1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(319, 9);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 4;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(607, 9);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 5;
            label3.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 75);
            label4.Name = "label4";
            label4.Size = new Size(59, 20);
            label4.TabIndex = 6;
            label4.Text = "Card ID";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(319, 75);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 7;
            label5.Text = "Phone";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(607, 75);
            label6.Name = "label6";
            label6.Size = new Size(73, 20);
            label6.TabIndex = 8;
            label6.Text = "Phone Alt";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 144);
            label7.Name = "label7";
            label7.Size = new Size(46, 20);
            label7.TabIndex = 9;
            label7.Text = "Email";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(319, 144);
            label8.Name = "label8";
            label8.Size = new Size(94, 20);
            label8.TabIndex = 10;
            label8.Text = "Reference ID";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(607, 144);
            label9.Name = "label9";
            label9.Size = new Size(62, 20);
            label9.TabIndex = 11;
            label9.Text = "Address";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(12, 209);
            label10.Name = "label10";
            label10.Size = new Size(163, 20);
            label10.TabIndex = 12;
            label10.Text = "What is Your Fav Color?";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(319, 209);
            label11.Name = "label11";
            label11.Size = new Size(206, 20);
            label11.TabIndex = 13;
            label11.Text = "Who is Your Fav Artist/Singer?";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(319, 32);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(214, 27);
            textBox2.TabIndex = 14;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(319, 98);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(214, 27);
            textBox3.TabIndex = 15;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(12, 167);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(214, 27);
            textBox4.TabIndex = 16;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(12, 98);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(214, 27);
            textBox5.TabIndex = 17;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(608, 98);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(214, 27);
            textBox6.TabIndex = 18;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(608, 167);
            textBox7.Multiline = true;
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(214, 92);
            textBox7.TabIndex = 19;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(608, 32);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(214, 27);
            textBox8.TabIndex = 20;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(319, 167);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(214, 27);
            textBox9.TabIndex = 21;
            // 
            // textBox10
            // 
            textBox10.Location = new Point(12, 232);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(214, 27);
            textBox10.TabIndex = 22;
            // 
            // textBox11
            // 
            textBox11.Location = new Point(319, 232);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(214, 27);
            textBox11.TabIndex = 23;
            // 
            // RegistrasiFrom
            // 
            ClientSize = new Size(834, 360);
            Controls.Add(textBox11);
            Controls.Add(textBox10);
            Controls.Add(textBox9);
            Controls.Add(textBox8);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "RegistrasiFrom";
            Load += RegistrasiFrom_Load_1;
            ResumeLayout(false);
            PerformLayout();

        }
        private Button button1;
        private Button button2;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private TextBox textBox9;
        private TextBox textBox10;

        private void RegistrasiFrom_Load_1(object sender, EventArgs e)
        {

        }
        private TextBox textBox11;
    }
}