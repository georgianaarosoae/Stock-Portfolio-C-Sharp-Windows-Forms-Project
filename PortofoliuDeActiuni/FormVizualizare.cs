using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proiect
{
    public partial class FormVizualizare : Form
    {
        List<Actiuni> list2;
        public FormVizualizare(List<Actiuni>list)
        {
            InitializeComponent();
            list2 = list;
            foreach (Actiuni p in list2)
                textBox1.Text += p.ToString() + Environment.NewLine;
        }
     

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void salvareFisierTextToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "(*.txt)|*.txt";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
                sw.WriteLine(textBox1.Text);
                sw.Close();
                textBox1.Clear();
            }
        }

        private void citireFisierTextToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "(*.txt)|*.txt";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(openFileDialog1.FileName);
                textBox1.Text = sr.ReadToEnd();
                sr.Close();
            }
        }

        private void serializareToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = new FileStream("fisier.dat",
                FileMode.Create, FileAccess.Write);
            bf.Serialize(fs, list2);
            fs.Close();
            textBox1.Clear();
        }

        private void deserializareToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = new FileStream("fisier.dat",
                FileMode.Open, FileAccess.Read);
            List<Actiuni> list3 = (List<Actiuni>)bf.Deserialize(fs);
            foreach (Actiuni a in list3)
                textBox1.Text += a.ToString() + Environment.NewLine;
            fs.Close();
        }

        private void salvareInFisierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "(*.txt)|*.txt";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
                sw.WriteLine(textBox1.Text);
                sw.Close();
                textBox1.Clear();
            }
        }

        private void citireDinFisierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "(*.txt)|*.txt";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(openFileDialog1.FileName);
                textBox1.Text = sr.ReadToEnd();
                sr.Close();
            }
        }

        private void serializareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = new FileStream("fisier.dat",
                FileMode.Create, FileAccess.Write);
            bf.Serialize(fs, list2);
            fs.Close();
            textBox1.Clear();
        }

        private void deserializareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = new FileStream("fisier.dat",
                FileMode.Open, FileAccess.Read);
            List<Actiuni> list3 = (List<Actiuni>)bf.Deserialize(fs);
            foreach (Actiuni a in list3)
                textBox1.Text += a.ToString() + Environment.NewLine;
            fs.Close();
        }
    }
}
