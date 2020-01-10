
using System;

namespace HeroesDeCiudad.AbstractFactory
{
	
	public class Desfibrilador :IHerramienta
	{
		public Desfibrilador()
		{
		}

		

		
		public void usar()
		{
			Console.WriteLine("Usando desfibrilador");
		}

		public void guardar()
		{
			Console.WriteLine("guardando desfibrilador");
		
		}

	
	}
}
