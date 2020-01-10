
using System;

namespace HeroesDeCiudad.AbstractFactory
{
	public class Manguera : IHerramienta
	{
		public Manguera()
		{
		}

		

		public void usar()
		{
			Console.WriteLine("Usando manguera");
		}

		public void guardar()
		{
			Console.WriteLine("guardando manguera");
			
		}

		
	}
}
