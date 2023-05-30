using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect
{
    internal class Actiuni
    {
        private string tip; //comune sau preferentiale
        private int cota;
        private string numeCompanie;
        
        public Actiuni() {
            tip = "Necunoscut";
            cota = 0;
            numeCompanie = "Necunoscuta" ;

        }
        public Actiuni(string tip, int cota, string numeCompanie) {
            this.tip = tip;
            this.cota = cota;
            this.numeCompanie= numeCompanie;
        }
        public string Tip { get => tip; set => tip = value; }
        public int Cota { get=>cota; set=> cota=value; }
        public string NumeCompanie { get => numeCompanie; set => numeCompanie = value; }

        public override string ToString()
        {
            return "Actiunea de tipul " + tip +" intr-un cota de "+cota+ " este din firma " + numeCompanie;
        }

        
    }
}
