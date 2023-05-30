using Proiect;
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
    public partial class FormMeniu : Form
    {
        public FormMeniu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormPieChart chart = new FormPieChart();
            chart.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormGrafic formGrafic = new FormGrafic();
            formGrafic.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormPortofoliu formPortofoliu = new FormPortofoliu();
            formPortofoliu.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void FormMeniu_Load(object sender, EventArgs e)
        {
            FormUser frm=new FormUser();
            frm.ShowDialog();
        }
    }
}
