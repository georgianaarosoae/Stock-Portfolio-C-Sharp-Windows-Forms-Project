using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect
{
	internal class Portofoliu: ICloneable, IComparable
	{
		private int idPortofoliu;
		private int riscAsumat;
		Actiuni actiuni;

		public Portofoliu()
		{
			idPortofoliu = 0;
			riscAsumat = 0;
			actiuni = Actiuni();
		}

		public Portofoliu(int idPortofoliu, int riscAsumat, Actiune actiuni)
		{
			this.idPortofoliu= idPortofoliu;
			this.riscAsumat= riscAsumat;	
			this.actiuni= actiuni;	
		}

		public int Id { get => idPortofoliu; set=> idPortofoliu = value; }
		public int Risc { get => riscAsumat; set=> riscAsumat = value; }
		
		public override string ToString()
		{
			return "Portofoliul cu id-ul " + idPortofoliu + " are riscul de " + riscAsumat + " si contine actiunile " + actiuni;
		}

		public object Clone()
		{
			Portofoliu clona = (Portofoliu)this.MemberwiseClone();
			return clona;
		}
		public int CompareTo(object obj)
		{
			Portofoliu p=(Portofoliu)obj;
			if ((float)this < (float)p) return 1;
			else if ((float)this < (float)p) return -1;
			else return string.Compare(this.idPortofoliu, p.idPortofoliu);
		}

		public override string ToString()
		{
			string rezultat= "Portofoliul cu id-ul " + idPortofoliu + " are riscul de " + riscAsumat + " si contine actiunile " + actiuni;
        }
    
	}
}
