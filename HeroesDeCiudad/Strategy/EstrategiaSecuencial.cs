
using System;
using HeroesDeCiudad.Decorator;

namespace HeroesDeCiudad.Strategy
{
	
	public class EstrategiaSecuencial : IEstrategia
	{

		public void apagarIncendio(ILugar lugar, int caudal)
		{
			
			Console.WriteLine("Apagando el incendio con la estrategia secuencial en "+lugar.ToString());

			ISector [][] sectores= lugar.getSectores();
	
			int tamaño=sectores.GetLength(0);
		
			
			for(int i = 0; i < tamaño; i++){
				
				for(int j = 0; j < tamaño; j++){
					
					Console.Write("({0},{1})",i,j);
					Console.Write(" -- ({0})",sectores[i][j].ToString());
					sectores[i][j].mojar(caudal);
				}

			}
			Console.WriteLine("!!!!!El fuego de "+lugar.ToString()+" fue extinguido en su totalidad¡¡¡¡¡¡");
			

		}

	}
}
