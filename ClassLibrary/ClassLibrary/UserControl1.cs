using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassLibrary
{
    public partial class UserControl1 : UserControl
    {

        User user = new User("arosoaegeorgiana21@gmail.com", "PortofoliuPAW");
        public UserControl1()
        {
            InitializeComponent();

        }
        private bool mailValid(string mail)
        {
            if (mail != user.Mail)
                return false;
            return true;
        }
        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (mailValid(textBox1.Text) == false)
            {
                errorProvider1.SetError(textBox1, "Mail invalid!");
                e.Cancel = true;
            }
        }

        private void textBox1_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBox1, "");
        }
        bool parolaValida(string parola)
        {
            if (user.Parola != parola)
                return false;
            return true;

        }
        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            if (parolaValida(textBox2.Text) == false)
            {
                errorProvider1.SetError(textBox2, "Parola incorecta!");
                e.Cancel = true;
            }
        }

        private void textBox2_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBox2, "");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == user.Mail && textBox2.Text == user.Parola)
            {
                MessageBox.Show("Autentificare reusita");
            }
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void UserControl1_Validating(object sender, CancelEventArgs e)
        {

        }
    }
}
