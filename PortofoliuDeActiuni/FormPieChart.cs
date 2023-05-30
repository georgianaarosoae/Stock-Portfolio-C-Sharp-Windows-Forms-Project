using LiveCharts;
using LiveCharts.Wpf;
using Proiect;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PortofoliuDeActiuni
{


    public partial class FormPieChart : Form
    {
        List<Actiuni> lista = new List<Actiuni>();
        int AAPL;
        int AMZN;
        int GOOGL;
        int MSFT;
        int TSLA;
        int AlteOptiuni;

        public FormPieChart()
        {
            InitializeComponent();
            incarcaDate();

        }
        private void incarcaDate()
        {
            Firme firma;
            StreamReader sr = new StreamReader("Actiuni.csv");
            string linie = null;
            while ((linie = sr.ReadLine()) != null)
            {

                string tip = linie.Split(',')[0];
                double pret = Convert.ToDouble(linie.Split(',')[1]);
                string detinator = linie.Split(',')[2];
                string fir = linie.Split(',')[3];
                firma = (Firme)Enum.Parse(typeof(Firme), fir);

                if (fir == "AAPL")
                    AAPL++;
                if (fir == "AMZN")
                    AMZN++;
                if (fir== "GOOGL")
                    GOOGL++;
                if (fir== "MSFT")
                    MSFT++;
                if (fir== "TSLA")
                   TSLA++;
                if (fir == "AlteOptiuni")
                    AlteOptiuni++;
                Actiuni ts = new Actiuni(tip, pret,detinator,firma);
                lista.Add(ts);

            }
        }

        private void Grafic_Load(object sender, EventArgs e)
        {
            Func<ChartPoint, string> labelPoint = chartPoint => string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);
            pieChart2.Series = new SeriesCollection {
            new PieSeries
            {
                Title = "AAPL",
                Values = new ChartValues<double> { AAPL },
                DataLabels = true,
                LabelPoint = labelPoint,

            },
            new PieSeries
            {
                Title = "AMZN",
                Values = new ChartValues<double> { AMZN},
                DataLabels = true,
                LabelPoint = labelPoint,
            },

            new PieSeries
            {
                Title = "GOOGL",
                Values = new ChartValues<double> { GOOGL },
                DataLabels = true,
                LabelPoint = labelPoint,
            },
             new PieSeries
            {
                Title = "MSFT",
                Values = new ChartValues<double> { MSFT },
                DataLabels = true,
                LabelPoint = labelPoint,
            },
              new PieSeries
            {
                Title = "TSLA",
                Values = new ChartValues<double> { TSLA },
                DataLabels = true,
                LabelPoint = labelPoint,
            },

              new PieSeries
            {
                Title = "AlteOptiuni",
                Values = new ChartValues<double> { AlteOptiuni },
                DataLabels = true,
                LabelPoint = labelPoint,
            },
            };
            pieChart2.LegendLocation = LegendLocation.Bottom;
            
        }

        private void pieChart2_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }
    }
}
