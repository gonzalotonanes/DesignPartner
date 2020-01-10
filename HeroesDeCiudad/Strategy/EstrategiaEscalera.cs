
using System;
using HeroesDeCiudad.Lugares;
using HeroesDeCiudad.Decorator;

namespace HeroesDeCiudad.Strategy
{
	
	public class EstrategiaEscalera :IEstrategia
	{
		
		public void apagarIncendio(ILugar lugar, int caudal)
		{
			Console.WriteLine("Apagando el incendio con la estrategia escalera en "+lugar.ToString());
			
			ISector [][] sectores=lugar.getSectores();

			int  fin = sectores.Length-1;
			int cont=0;
			int indicador=0;
			
			while(cont<=fin)
			{
				switch(indicador)
				{
					case 0:
						for (int i = 0; i <= fin; i++) {
							Console.Write("({0},{1})",cont,i);
							Console.Write(sectores[cont][i]);
							
							sectores[cont][i].mojar(caudal);

						}
						
						indicador=1;
						break;
					case 1:
						for (int j = fin; j >= 0; j--) {
							Console.Write("({0},{1})",cont,j);
							Console.Write(sectores[cont][j]);
							
							sectores[cont][j].mojar(caudal);
							
							
						}
						indicador=0;
						break;
				}
				
				Console.WriteLine();
				
				cont++;
				
			}
			
			Console.WriteLine("!!!!!El fuego de "+lugar.ToString()+" fue extinguido en su totalidad¡¡¡¡¡¡");
			
		}
		
		
	}
}
