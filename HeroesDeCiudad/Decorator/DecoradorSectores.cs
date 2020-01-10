
using System;
using HeroesDeCiudad.Adicionales;
using HeroesDeCiudad.FactoryMethod;

namespace HeroesDeCiudad.Decorator
{
	
	public class DecoradorSectores
	{
		
		//CLASE PARA DECORAR SECTORES 
		public DecoradorSectores()
		{
		}
		
		
		private static ISector decorarSector(ISector sector,int caudalLluvia, int temperatura, int velocidadViento)
		{
			double probabilidad= 0.2;
			if (Aleatorio.generadorNum()<probabilidad) {
				sector= FabricaDeSectores.crearSector("pastoSeco",sector,0);
			}
			
			if (Aleatorio.generadorNum()<probabilidad) {
				sector= FabricaDeSectores.crearSector("arbolesGrandes",sector,0);
			}
			
			if (Aleatorio.generadorNum()<probabilidad) {
				sector= FabricaDeSectores.crearSector("genteAsustada",sector,0);
			}
			
			if (temperatura>30) {
				sector= FabricaDeSectores.crearSector("muchoCalor",sector,temperatura);
			}
			
			if (velocidadViento>80) {
				sector= FabricaDeSectores.crearSector("muchoViento",sector,velocidadViento);
			}
			//Probabilidad de dia lluvioso
			bool lluvia=false;
			double pLluvia=0.2;
			if (Aleatorio.generadorNum()<pLluvia) {
				lluvia=true;
			}
						
			if (caudalLluvia>0 && lluvia) {
				sector= FabricaDeSectores.crearSector("diaLluvioso",sector,caudalLluvia);
			}
			
			return sector;
			
		}
		
		
		public static  ISector CrearDecorador(int caudalLluvia,int temperatura,int velocidadViento)
		{
			int caudal= Aleatorio.Next(100);
			ISector sector = new Sector(caudal);
			return decorarSector(sector,caudalLluvia,temperatura,velocidadViento);
		}
	}
}
