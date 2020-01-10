
using System;
using HeroesDeCiudad.Decorator;

namespace HeroesDeCiudad.FactoryMethod
{
	
	public class FabricaDeArbolesGrandes : FabricaDeSectores
	{
		public override ISector crearSector(ISector sector)
		{
			return new ArbolesGrandes(sector);
		}
		
	}
}
