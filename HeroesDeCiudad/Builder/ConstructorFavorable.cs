
using System;
using HeroesDeCiudad.Decorator;
using HeroesDeCiudad.FactoryMethod;
using HeroesDeCiudad.Adicionales;

namespace HeroesDeCiudad.Builder
{
	public class ConstructorFavorable : ConstructorPartesAbstracto
	{
		public ConstructorFavorable()
		{
		}


		public override ISector[][] construirSectores()
		{
			double caudaLluvia= Aleatorio.Next(1,501);
			
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
			int lluvia= Aleatorio.Next(0,501);
			sector= FabricaDeSectores.crearSector("sectorBase",sector,0);
			sector= FabricaDeSectores.crearSector("diaLluvioso",sector,lluvia);
			
			
			
			return sector;
		}

	}
}
