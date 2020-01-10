
using System;
using HeroesDeCiudad.Decorator;
using HeroesDeCiudad.FactoryMethod;
using HeroesDeCiudad.Adicionales;

namespace HeroesDeCiudad.Builder
{
	
	public class ConstructorDesfavorable : ConstructorPartesAbstracto
	{
		public ConstructorDesfavorable()
		{
		}

	
		
		public override ISector[][] construirSectores()
		{
			double temperatura = Aleatorio.Next(0,45);
			double viento = Aleatorio.Next(1,251);
			double lluvia= Aleatorio.Next(1,501);
			
			
			for(int i = 0; i < matriz.Length; i++)
			{
				for(int j = 0; j < matriz.Length; j++)
				{
					
					matriz[i][j]= decorador();
				}
			}
			
			return matriz;
		}
		
		private ISector decorador(){
			
			ISector sector=null;
			
			int temp= Aleatorio.Next(30,46);
			int viento= Aleatorio.Next(80,251);
			
			sector= FabricaDeSectores.crearSector("sectorBase",sector,0);
			sector= FabricaDeSectores.crearSector("arbolesGrandes",sector,0);
			sector=FabricaDeSectores.crearSector("genteAsustada",sector,0);
			sector=FabricaDeSectores.crearSector("pastoSeco",sector,0);
			sector=FabricaDeSectores.crearSector("muchoCalor",sector,temp);
			sector=FabricaDeSectores.crearSector("muchoViento",sector,viento);
			
			
			
			return sector;
		}

		
	}
}
