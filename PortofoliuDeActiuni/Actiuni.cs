using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect
{
    public enum Firme
    {
     
        AAPL, // Apple Inc.
        AMZN, // Amazon.com Inc.
        GOOGL, // Alphabet Inc. (Clasa A)
        MSFT, // Microsoft Corporation
        TSLA, // Tesla Inc.
        AlteOptiuni

    }

    [Serializable]
    public class Actiuni: ICloneable, IComparable
    {
        private string tip; //comune sau preferentiale
        private double pret;
        private string detinator;
        Firme firma;
        public Actiuni() {
            tip = "Necunoscut";
            pret = 0;
            detinator ="Necunoscut";
            
        }
        public Actiuni(string tip,double pret, string numeCompanie, Firme firma ) {
            this.pret = pret;
            this.detinator= numeCompanie;
            this.tip = tip;
            this.firma = firma;
        }
        public string Tip { get => tip; set => tip = value; }
        public double Pret { get=>pret; set=> pret=value; }
        public string Detinator { get => detinator; set => detinator = value; }
        
        public Firme Firma { get=> firma; set => firma = value; }


        public object Clone()
        {
            throw new NotImplementedException();
        }

        public int CompareTo(object obj)
        {
            Actiuni a=(Actiuni)obj;
            if ((int) this < (int)a)
                return 1;
            else 
                if((int)this> (int)a) return -1;
            else return string.Compare(this.Tip, a.Tip);

        }

        public override string ToString()
        {
            return "Actiunea de tipul " + tip +" intr-un pret de "+pret+ " este din firma " + detinator;
        }

        public static explicit operator int(Actiuni obj)
        {
            return (int)obj.pret;
        }
        

    }
}
