
using System;
using HeroesDeCiudad.Composite;

namespace HeroesDeCiudad.Lugares
{
	
	public class Calle: ILuminable
	{
		
		//ATRIBUTOS
		private double lontitudMetros;
		int cantFarolas;
		int caudal;
		
		//CONSTRUCTOR
		public Calle(double lontitudMetros, int cantFarolas, int caudal)
		{
			this.lontitudMetros=lontitudMetros;
			this.cantFarolas= cantFarolas;
			this.caudal= caudal;
		}
		
		//GETTERS Y SETTERS
		public double LontitudMetros {
			get { return lontitudMetros; }
			set { lontitudMetros = value; }
		}

		public int CantFarolas {
			get { return cantFarolas; }
			set { cantFarolas = value; }
		}

		public int Caudal {
			get {
				return caudal;
			}
			set {
				caudal = value;
			}
		}
		

		public void revisarYCambiarLamparasQuemadas()
		{
			Console.WriteLine("Cambiando lamparas en calle");
		}
		
		
	}
}
