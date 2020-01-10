
using System;

namespace HeroesDeCiudad.AbstractFactory
{

	public class Pistola : IHerramienta
	{
		public Pistola()
		{
		}
		
		
		
		public void usar()
		{
			Console.WriteLine("Usando pistola");
		}

		public void guardar()
		{
			Console.WriteLine("guardando pistola");
		}
	}
}
