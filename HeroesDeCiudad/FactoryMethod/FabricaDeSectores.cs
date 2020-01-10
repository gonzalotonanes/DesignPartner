
using System;
using HeroesDeCiudad.Decorator;

namespace HeroesDeCiudad.FactoryMethod
{

	public abstract class FabricaDeSectores
	{
		
		public static ISector crearSector(string cual,ISector sector, int variable){
			FabricaDeSectores fabrica = null;
			switch (cual) {
				case "pastoSeco":
					fabrica= new FabricaDePastoSeco();
					break;
				case "arbolesGrandes":
					fabrica= new FabricaDeArbolesGrandes();
					break;
				case "genteAsustada":
					fabrica= new FabricaDeGenteAsustada();
					break;
				case "muchoCalor":
					fabrica= new FabricaDeMuchoCalor(variable);
					break;
				case "muchoViento":
					fabrica= new FabricaDeMuchoViento(variable);
					break;
				case "diaLluvioso":
					fabrica= new FabricaDeDiaLluvioso(variable);
					break;
				case "sectorBase":
					fabrica= new FabricaDeSectorBase();
					break;
			}
			
			return fabrica.crearSector(sector);
		}
		
			
		
		public abstract ISector crearSector(ISector sector);
	
	
		
	}
}
