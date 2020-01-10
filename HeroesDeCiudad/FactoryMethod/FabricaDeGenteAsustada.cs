
using System;
using HeroesDeCiudad.Decorator;

namespace HeroesDeCiudad.FactoryMethod
{
	
	public class FabricaDeGenteAsustada : FabricaDeSectores
	{
		public override ISector crearSector(ISector sector)
		{
			return new GenteAsustada(sector);
		}
		
		
	}
}
