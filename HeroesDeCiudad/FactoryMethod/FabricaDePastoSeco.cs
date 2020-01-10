
using System;
using HeroesDeCiudad.Decorator;
using HeroesDeCiudad.Adicionales;

namespace HeroesDeCiudad.FactoryMethod
{

	public class FabricaDePastoSeco : FabricaDeSectores
	{
		public override ISector crearSector(ISector sector)
		{
			return new PastoSeco(sector);
		}
		
		
	}
}
