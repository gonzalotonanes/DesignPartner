
using System;
using HeroesDeCiudad.Decorator;

namespace HeroesDeCiudad.Strategy
{
	
	public class EstrategiaEspiral : IEstrategia
	{
		
		public void apagarIncendio(ILugar lugar, int caudal)
		{
			Console.WriteLine("Apagando el incendio con la estrategia espiral");
			ISector [][] sectores= lugar.getSectores();
			
			int fin= sectores.GetLength(0)-1;
			int iteraciones= sectores.GetLength(0)*4;
			int inicio=0;
			
			for (int j = 0; j < sectores.Length; j++) {
				for (int i = inicio; i <= fin; i++) {
					
					Console.Write("({0},{1})",inicio,i);
					Console.Write(sectores[inicio][i]);
					
					sectores[inicio][i].mojar(caudal);
				}
				for (int i = inicio+1; i <= fin; i++) {
					
					Console.Write("({0},{1})",i,fin);
					Console.Write(sectores[i][fin]);
					sectores[i][fin].mojar(caudal);
					
				}
				for (int i = fin-1; i >= inicio; i--) {
					
					Console.Write("({0},{1})",fin,i);
					Console.Write(sectores[fin][i]);
					sectores[fin][i].mojar(caudal);
				}
				
				for (int i = fin-1; i > inicio; i--) {
					Console.Write("({0},{1})",i,inicio);
					Console.Write(sectores[i][inicio]);
					sectores[i][inicio].mojar(caudal);
				}
				
				inicio++;
				fin--;
				
			}

			Console.WriteLine("El fuego de"+lugar.ToString()+" fue extinguido en su totalidad");		}
	}
	
	
}




