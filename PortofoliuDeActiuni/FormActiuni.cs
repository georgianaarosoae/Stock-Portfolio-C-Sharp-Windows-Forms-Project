using Microsoft.VisualBasic;
using Proiect;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
//using Oracle.ManagedDataAccess.Client;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
//using System.Data.OracleClient;
using Oracle.ManagedDataAccess.Client;

namespace PortofoliuDeActiuni
{
    public partial class FormActiuni : Form
    {
        
        private PrintDocument printDocument;
        private int currentPage;

        List<Actiuni> listaActiuni=new List<Proiect.Actiuni>();
        List<Portofoliu> listaPortofolii=new List<Portofoliu>();
        string connectionString = "Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=193.226.34.57)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=oradb)));User Id=;Password=;";
    
        public FormActiuni()
        {
            
            InitializeComponent();
            listaActiuni = new List<Actiuni>();
            
         
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                if (cbTipActiune.Text == "")
                    errorProvider1.SetError(cbTipActiune, "Introduceti tipul actiunii!");
                else
                if (tbPret.Text == "")
                    errorProvider1.SetError(tbPret, "Introduceti pret actiunii!");
                else
                if (tbNumeCompanie.Text == "")
                    errorProvider1.SetError(tbNumeCompanie, "Introduceti detinatorul!");
                else
                     if (cbFirme.Text == "")
                     errorProvider1.SetError(cbFirme, "Introduceti firma!");
            else
                {
                    errorProvider1.Clear();
                    try
                    {
                        string tipActiune = cbTipActiune.Text;
                        int pret = Convert.ToInt32(tbPret.Text);
                        string numeCompanie = tbNumeCompanie.Text;
                        Firme firma = (Firme)Enum.Parse(typeof (Firme),cbFirme.Text);
                        Actiuni a = new Actiuni(tipActiune, pret, numeCompanie,firma);
                        listaActiuni.Add(a);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        cbTipActiune.Text = "";
                        tbPret.Clear();
                        tbNumeCompanie.Clear();
                        cbFirme.Text = "";
                    }
               
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
                FormVizualizare frm = new FormVizualizare(listaActiuni);
                frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "(*.txt)|*.txt";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
                sw.WriteLine(tbPret.Text);
                sw.WriteLine(tbNumeCompanie.Text);
                sw.WriteLine(cbTipActiune.Text);
                sw.WriteLine(cbFirme.Text);
                sw.Close();
            }
        }

        private void salvareInFisierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "(*.txt)|*.txt";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
                sw.WriteLine(tbPret.Text);
                sw.WriteLine(tbNumeCompanie.Text);
                sw.WriteLine(cbTipActiune.Text);
                sw.WriteLine(cbFirme.Text);
                sw.Close();
            }
        }

        

       

        private void exportToTXTALTVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            
            foreach (var actiune in listaActiuni)
            {
                sb.Append(actiune.Tip);
                sb.Append(",");
                sb.Append(actiune.Pret);
                sb.Append(",");
                sb.Append(actiune.Detinator);
                sb.Append(",");
                sb.Append(actiune.Firma);
                sb.Append(Environment.NewLine);
            }
            string csv = sb.ToString();
            using (StreamWriter sw = new StreamWriter("exportTXTactiuni.txt"))
            {
                sw.Write(csv);
            }
            MessageBox.Show("Exportul în format TXT a fost finalizat cu succes!");
        }
        

      
        /////////////////////////print
        
        List<Actiuni> lista = new List<Actiuni>();
        private List<Actiuni> GetLista()
        { 
            foreach (ListViewItem item in listView1.Items)
            {
               
                string tip = item.SubItems[1].Text;
                double pret = Convert.ToDouble(item.SubItems[2].Text);
                string detinator = item.SubItems[3].Text;
                Firme firma = (Firme)Enum.Parse(typeof(Firme), item.SubItems[4].Text);

                Actiuni a = new Actiuni(tip, pret, detinator,firma);
                lista.Add(a);
            }
            return lista;
        }

        private void printDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            int itemsPerPage = 10;
            int startX = 50;
            int startY = 100;
            int offsetY = 20;

            for (int i = currentPage * itemsPerPage; i < lista.Count; i++)
            {
                if (i < (currentPage + 1) * itemsPerPage)
                {
                    Actiuni actiune = lista[i];
                    string ActiuneInfo = $"Tip: {actiune.Tip}, Pret: {actiune.Pret}, Detinator: {actiune.Detinator}, Firma: {actiune.Firma}";
                    e.Graphics.DrawString(ActiuneInfo, Font, Brushes.Black, startX, startY + offsetY);
                    offsetY += 20;
                }
            }

            currentPage++;

            e.HasMorePages = (currentPage * itemsPerPage < lista.Count);
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printDocument = new PrintDocument();
            printDocument.PrintPage += new PrintPageEventHandler(printDocument_PrintPage);

            PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
            printPreviewDialog.Document = printDocument;

            currentPage = 0;
            lista = GetLista();

            printPreviewDialog.ShowDialog();
        }

        private void printToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            printDocument = new PrintDocument();
            printDocument.PrintPage += new PrintPageEventHandler(printDocument_PrintPage);

            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                currentPage = 0;
                lista = GetLista();

                printDocument.Print();
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            OracleConnection connection = new OracleConnection(connectionString);
            connection.Open();
            string sql = "select * from actiuni";
            OracleCommand cmd = new OracleCommand(sql, connection);
            OracleDataReader reader = cmd.ExecuteReader();
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            for (int i = 0; i < reader.FieldCount; i++)
                listView1.Columns.Add(reader.GetName(i));
            while (reader.Read())
            {
                ListViewItem item = new ListViewItem(reader.GetValue(0).ToString());
                for (int i = 1; i < reader.FieldCount; i++)
                    item.SubItems.Add(reader.GetValue(i).ToString());
                listView1.Items.Add(item);
            }
            reader.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OracleConnection conexiune = new OracleConnection(connectionString);
            OracleCommand comanda = new OracleCommand();

            try
            {
                conexiune.Open();

                foreach (ListViewItem itm in listView1.Items)
                {
                    if (itm.Checked)
                    {
                        int id= Convert.ToInt32(itm.SubItems[0].Text);
                        comanda.CommandText = "UPDATE actiuni SET tip = 'alta optiune' WHERE id = :id";
                        comanda.Parameters.Add(":id", OracleDbType.Double).Value = id;
                        comanda.Connection = conexiune;
                        comanda.ExecuteNonQuery();
                        comanda.Parameters.Clear();

                        itm.SubItems[1].Text = "alta optiune";

                    }
                }
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexiune.Close();

            }
        }
        private void listView1_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (e.Item.Checked)
            {
                e.Item.BackColor = Color.Red;

            }

        }

        private void listView1_ItemCheck(object sender, ItemCheckEventArgs e)
        {

        }
        private void button5_Click(object sender, EventArgs e)
        {
            OracleConnection conexiune = new OracleConnection(connectionString);
            OracleCommand comanda = new OracleCommand();
            try
            {
                int id = Convert.ToInt32(tbPret.Text) + 1;
                conexiune.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conexiune;
                cmd.CommandText = "INSERT INTO actiuni (id,tip, pret, detinator,firma) " +
                                  "VALUES (:id, :tip, :pret,:detinator,:firma)";
                cmd.Parameters.Add("id", OracleDbType.Int32).Value = id;
                cmd.Parameters.Add("tip", OracleDbType.NVarchar2).Value = cbTipActiune.Text;
                cmd.Parameters.Add("pret", OracleDbType.Int32).Value = tbPret.Text;
                cmd.Parameters.Add("detinator", OracleDbType.NVarchar2).Value = tbNumeCompanie.Text;
                cmd.Parameters.Add("firma", OracleDbType.NVarchar2).Value = cbFirme.Text;

                cmd.ExecuteNonQuery();
                ListViewItem newItem = new ListViewItem(id.ToString());
                newItem.SubItems.Add(cbTipActiune.Text);
                newItem.SubItems.Add(tbPret.Text);
                newItem.SubItems.Add(tbNumeCompanie.Text);
                newItem.SubItems.Add(cbFirme.Text);
                listView1.Items.Add(newItem);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexiune.Close();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OracleConnection conexiune = new OracleConnection(connectionString);
            OracleCommand comanda = new OracleCommand();
            try
            {
                conexiune.Open();
                foreach (ListViewItem itm in listView1.Items)
                {
                    if (itm.Checked)
                    {
                        int id = Convert.ToInt32(itm.SubItems[0].Text);
                        comanda.CommandText = "DELETE FROM actiuni WHERE id= :id";
                        comanda.Parameters.Add(":id", OracleDbType.Int32).Value = id;
                        comanda.Connection = conexiune;
                        comanda.ExecuteNonQuery();
                        itm.Remove();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("A intervenit o eroare la ștergere: " + ex.Message, "Eroare ștergere", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexiune.Close();
            }
        }

        private void FormActiuni_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Alt && e.KeyCode == Keys.V)
              {
                  exportToTXTALTVToolStripMenuItem_Click(sender, e);
              }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}
