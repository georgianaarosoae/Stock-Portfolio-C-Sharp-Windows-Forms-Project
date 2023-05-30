using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect
{
	public class Portofoliu: ICloneable
	{
		public int idPortofoliu;
		public int nrActiuni;
		public string tipPortofoliu; //conservator,moderat, echilibrat, de crestere, agresiv
		List<Actiuni> listaActiuni=new List<Actiuni>();
		

		public Portofoliu()
		{
			idPortofoliu = 0;
			nrActiuni = 0;
			tipPortofoliu = "Necunoscut";
			
		}

		public Portofoliu(int idPortofoliu, int nrActiuni, string tipPortofoliu)
		{
			this.idPortofoliu= idPortofoliu;
			this.nrActiuni= nrActiuni;
			this.tipPortofoliu = tipPortofoliu;
			
		}

		public int Id { get => idPortofoliu; set=> idPortofoliu = value; }
		public int NrActiuni { get => nrActiuni; set=> nrActiuni = value; }
		public string Tip { get => tipPortofoliu; set=> tipPortofoliu = value; }
		public List<Actiuni> Actiuni { get => listaActiuni; set=> listaActiuni = value; }
		
		public override string ToString()
		{
			return "Portofoliul cu id-ul " + idPortofoliu + " are un numar de " + nrActiuni+ "actiuni";
		}

		public object Clone()
		{
			Portofoliu clona = (Portofoliu)this.MemberwiseClone();
			return clona;
		}
		
    }
 
}
