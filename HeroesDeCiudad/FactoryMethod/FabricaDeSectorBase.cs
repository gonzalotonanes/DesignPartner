
using System;
using HeroesDeCiudad.Decorator;
using HeroesDeCiudad.Adicionales;

namespace HeroesDeCiudad.FactoryMethod
{
	
	public class FabricaDeSectorBase : FabricaDeSectores
	{
	

		public override ISector crearSector(ISector sector)
		{
			return new Sector(Aleatorio.Next(101));
		}

		
		
	}
}
