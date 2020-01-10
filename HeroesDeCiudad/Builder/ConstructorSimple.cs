
using System;
using HeroesDeCiudad.Decorator;
using HeroesDeCiudad.FactoryMethod;
using HeroesDeCiudad.Adicionales;

namespace HeroesDeCiudad.Builder
{
	
	public class ConstructorSimple : ConstructorPartesAbstracto
	{
		

		public override ISector[][] construirSectores()
		{
			for(int i = 0; i < matriz.Length; i++)
			{
				for(int j = 0; j < matriz.Length; j++)
				{
					
					matriz[i][j]= decorador();
				}
			}
			return matriz;
		}
		
		private ISector decorador()
		{
			
			ISector sector= null;
			sector= FabricaDeSectores.crearSector("sectorBase",sector,0);
			return sector;
		}

	}
}
