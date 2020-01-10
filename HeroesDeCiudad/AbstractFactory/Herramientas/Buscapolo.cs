
using System;
using HeroesDeCiudad.AbstractFactory.Cuarteles;

namespace HeroesDeCiudad.AbstractFactory
{
	
	public class Buscapolo : IHerramienta
	{
		public Buscapolo()
		{
		}
		
		public void usar()
		{
			Console.WriteLine("Usando buscapolo");
		}

		public void guardar()
		{
			Console.WriteLine("guardando buscapolo");
			
		}
	}
}
