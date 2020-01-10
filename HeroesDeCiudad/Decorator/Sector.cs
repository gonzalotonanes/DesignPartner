
using System;

namespace HeroesDeCiudad.Decorator
{
	
	public class Sector : ISector
	{
		private double afectacioFuego ;
		//PRUEBAS PARA EL DECORATOR
		

		//public Sector(){}
		
		public Sector(int afectacioFuego)
		{
			this.afectacioFuego=afectacioFuego;
			
		}
		
		
		

		public double AfectacioFuego {
			get {
				return afectacioFuego;
			}
			set {
				afectacioFuego = value;
			}
		}
		
		public void mojar(double agua)
		{
		
			
			Console.Write(" -> {0}",AfectacioFuego);
			double aguaR= Math.Round(agua,2);
			while (!estaApagado()) {
				AfectacioFuego=Math.Round(AfectacioFuego-aguaR);
				if (estaApagado()) {
					AfectacioFuego=0;
				}
				Console.Write(" -> " +AfectacioFuego);
			}
			Console.WriteLine();
			
			
			
		}
		
		public bool estaApagado()
		{
			
			return afectacioFuego <=0;
		}
		
		
		public override string ToString()
		{
			return "Sector base";
		}
		
		
	}
}
