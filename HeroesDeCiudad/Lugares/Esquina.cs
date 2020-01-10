
using System;
using HeroesDeCiudad.Adicionales;
using HeroesDeCiudad.Command;
using HeroesDeCiudad.Composite;

namespace HeroesDeCiudad.Lugares
{
	
	public class Esquina : ILuminable, IPatrullable
	{
		int cantSemaforos;
		
		public int CantSemaforos {
			get { return cantSemaforos; }
			set { cantSemaforos = value; }
		}
		
		public Esquina(int cantSemaforos)
		{
			this.cantSemaforos= cantSemaforos;
		}

		//PATRON COMMAND
		public bool hayAlgoFueraDeLoNormal()
		{
		
			double probabilidad=0.99;
			double numero=Aleatorio.generadorNum();
			return numero<probabilidad;
		}
		
	
		
		//PATRON COMPOSITE
		public void revisarYCambiarLamparasQuemadas()
		{
			Console.WriteLine("Cambiando lamparas en esquina");
		}
	
		
		override public  string ToString(){
		
			return "Esquina";
		}

		
	}
}
