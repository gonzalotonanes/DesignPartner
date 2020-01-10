
using System;
using HeroesDeCiudad.Heroes;

namespace HeroesDeCiudad.Command
{
	
	public class Perseguir :ICommand
	{
		public Perseguir()
		{
			
		}
		
		public void ejecutar()
		{
			
			Console.WriteLine("Perseguir hasta arrestar al delincuente");
			
		}
	
	}
}
