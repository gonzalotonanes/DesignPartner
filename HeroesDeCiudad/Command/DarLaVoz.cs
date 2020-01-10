
using System;

namespace HeroesDeCiudad.Command
{
	
	public class DarLaVoz : ICommand
	{
	
		public DarLaVoz()
		{
			
		}

		public void ejecutar()
		{
			Console.WriteLine("Dar la voz de alto para que el delincuente se vaya");
			
		}

		
	}
}
