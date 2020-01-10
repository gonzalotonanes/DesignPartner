
using System;
using HeroesDeCiudad.Heroes;

namespace HeroesDeCiudad.Command
{
	
	public class Avisar : ICommand
	{
		
		
		
		public Avisar()
		{
			
		}


		public void ejecutar()
		{
			Console.WriteLine("Avisar a la comisaría y pedir refuerzos");
			
			
		}

	}
}
