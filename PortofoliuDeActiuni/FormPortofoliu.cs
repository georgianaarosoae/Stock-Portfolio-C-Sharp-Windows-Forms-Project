using PortofoliuDeActiuni;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Proiect
{
    public partial class FormPortofoliu : Form
    {
        List<Actiuni> listaActiuni = new List<Actiuni>();
        List<Portofoliu> listaPortofolii = new List<Portofoliu>();
       
        private PrintDocument printDocument;
        private int currentPage;
        public FormPortofoliu(List<Actiuni> listaux)
        {
            InitializeComponent();
            listaActiuni = listaux;
            ControlExtension.Draggable(button1, true);
        }
        public FormPortofoliu()
        {
            InitializeComponent();
            ControlExtension.Draggable(button1, true);
        }

        private void schimbaCuloareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
                contextMenuStrip1.SourceControl.BackColor = dlg.Color;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void incarcaDate()
        {
            StreamReader sr = new StreamReader("fisier.txt");
            string linie = null;
            while ((linie = sr.ReadLine()) != null)
            {
                int id = Convert.ToInt32(linie.Split(',')[0]);
                int numar = Convert.ToInt32(linie.Split(',')[1]);
                string tip = linie.Split(',')[2];
                Portofoliu p = new Portofoliu(id, numar, tip);
                listaPortofolii.Add(p);
            }
            sr.Close();
            MessageBox.Show("Date incarcate!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            foreach (Portofoliu p in listaPortofolii)
            {
                ListViewItem itm = new ListViewItem(p.Id.ToString());
                itm.SubItems.Add(p.NrActiuni.ToString());
                itm.SubItems.Add(p.Tip);
                listView1.Items.Add(itm);
                if (p.NrActiuni > 20)
                    itm.SubItems.Add("dosar ignorat");
                else
                    itm.SubItems.Add("dosar luat in calcul");
                listView1.Items.Add(itm);
            }
        }
        private void listView1_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (e.Item.Checked)
            {
                e.Item.BackColor = Color.Red;
                tbId.Text = e.Item.SubItems[0].Text;
                tbNumar.Text = e.Item.SubItems[1].Text;
                cbTipPortofoliu.Text = e.Item.SubItems[2].Text;
                
            }
            if (e.Item.Checked == false)
            {
                tbId.Clear();
                tbNumar.Clear();
                cbTipPortofoliu.Text = " ";
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem itm in listView1.Items)
            {
                if (itm.Checked)
                {
                    int id = Convert.ToInt32(itm.SubItems[0].Text);
                    for (int i = 0; i < listaPortofolii.Count; i++)
                    {
                        if (listaPortofolii[i].Id == id)
                            listaPortofolii.RemoveAt(i);
                    }
                    itm.Remove();

                }
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("fisier.txt");
            foreach (Portofoliu p in listaPortofolii)
            {
                sw.Write(p.Id);
                sw.Write(",");
                sw.Write(p.NrActiuni);
                sw.Write(",");
                sw.Write(p.Tip);
                sw.WriteLine();
            }
            sw.Close();
            MessageBox.Show("Date salvate!");
        }

        private void stergeDataSelectataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem itm in listView1.Items)
                if (itm.Selected)
                {
                    int id = Convert.ToInt32(itm.SubItems[0].Text);
                    for (int i = 0; i < listaPortofolii.Count; i++)
                        if (listaPortofolii[i].Id == id)
                            listaPortofolii.RemoveAt(i);
                    itm.Remove();
                }
        }

        private void id_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (tbId.Text == "")
                errorProvider1.SetError(tbId, "Introduceti id-ul actiunii!");
            else
                if (tbNumar.Text == "")
                errorProvider1.SetError(tbNumar, "Introduceti numarul de actiuni!");
            else
                if (cbTipPortofoliu.Text == "")
                errorProvider1.SetError(cbTipPortofoliu, "Introduceti tipul actiunii!");
            else
            {
                errorProvider1.Clear();
                try
                {
                    int idPortofoliu = int.Parse(tbId.Text);
                    int nrActiuni = int.Parse(tbNumar.Text);
                    string tipPortofoliu = (string)cbTipPortofoliu.SelectedItem;
                    Portofoliu p = new Portofoliu(idPortofoliu, nrActiuni, tipPortofoliu);
                    listaPortofolii.Add(p);
                    FormActiuni formularActiuni = new FormActiuni();
                    
                    formularActiuni.ShowDialog();
                   

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    tbId.Clear();
                    tbNumar.Clear();
                   
                    cbTipPortofoliu.Text = "";
                    
                }
            }


        }

        private void updateViewList()
        {
            //if (showPortofoliuActiuni == true)
            //{
                listView1.Items.Clear();
                listView1.Columns.Clear();
                listView1.Columns.Add("Id Portofoliu");
                listView1.Columns.Add("Numar actiuni");
                listView1.Columns.Add("Tip");
            
                foreach (Portofoliu p in listaPortofolii)
                {
                    ListViewItem item = new ListViewItem(p.Id.ToString());
                    item.SubItems.Add(p.NrActiuni.ToString());
                    item.SubItems.Add(p.Tip);
                    listView1.Items.Add(item);
                }
            //}
         
        }
        private void button5_Click_1(object sender, EventArgs e)
        {
           
            if (tbId.Text == "")
                errorProvider1.SetError(tbId, "Introduceti id-ul actiunii!");
            else
              if (tbNumar.Text == "")
                errorProvider1.SetError(tbNumar, "Introduceti numarul de actiuni!");
            else
              if (cbTipPortofoliu.Text == "")
                errorProvider1.SetError(cbTipPortofoliu, "Introduceti tipul actiunii!");
            else
            {
                errorProvider1.Clear();
                try
                {
                    int idPortofoliu = int.Parse(tbId.Text);
                    int nrActiuni = int.Parse(tbNumar.Text);
                    string tipPortofoliu = (string)cbTipPortofoliu.SelectedItem;
                    Portofoliu p = new Portofoliu(idPortofoliu, nrActiuni, tipPortofoliu);
                    listaPortofolii.Add(p);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    tbId.Clear();
                    tbNumar.Clear();
                    cbTipPortofoliu.Text = "";
                }
            }
            listView1.Items.Clear();
            foreach (Portofoliu p in listaPortofolii)
            {
                ListViewItem itm = new ListViewItem(p.Id.ToString());
                itm.SubItems.Add(p.NrActiuni.ToString());
                itm.SubItems.Add(p.Tip.ToString());
                listView1.Items.Add(itm);
            }

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            foreach (ListViewItem itm in listView1.Items)
                if (itm.Checked)
                {
                    int id = Convert.ToInt32(itm.SubItems[0].Text);
                    for (int i = 0; i < listaPortofolii.Count; i++)
                        if (listaPortofolii[i].Id == id)
                            listaPortofolii.RemoveAt(i);
                    itm.Remove();
                }
        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FontDialog dlg = new FontDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
                this.Font = dlg.Font;
        }

        private void schimbaCuloareToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
                contextMenuStrip1.SourceControl.BackColor = dlg.Color;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("listview.txt");
            foreach (Portofoliu p in listaPortofolii)
            {
                sw.Write(p.Id);
                sw.Write(",");
                sw.Write(p.NrActiuni);
                sw.Write(",");
                sw.Write(p.Tip);
                sw.WriteLine();
            }
            sw.Close();
            MessageBox.Show("Date salvate!");
        }

        private void listView1_ItemCheck(object sender, ItemCheckEventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            foreach(Portofoliu p in listaPortofolii)
            {
                ListViewItem item = new ListViewItem(p.Id.ToString());
                item.SubItems.Add(p.NrActiuni.ToString());
                item.SubItems.Add(p.Tip);
                listView1.Items.Add(item);
            }
        }

        private void serializareXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter("PortofoliuXML.xml"))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Portofoliu>));
                xmlSerializer.Serialize(sw, listaPortofolii);
            }
        }

        private void deserializareXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (StreamReader sr = new StreamReader("PortofoliuXML.xml"))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Portofoliu>));
                listaPortofolii = (List<Portofoliu>)xmlSerializer.Deserialize(sr);
                

            }
        }



        private void printPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
