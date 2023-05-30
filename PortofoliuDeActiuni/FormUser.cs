using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PortofoliuDeActiuni
{
    public partial class FormUser : Form
    {
        public FormUser()
        {
            InitializeComponent();
        }

        private void FormUser_Load(object sender, EventArgs e)
        {
            ClassLibrary.UserControl1 user=new ClassLibrary.UserControl1();
            Controls.Add(user);
        }
    }
}
