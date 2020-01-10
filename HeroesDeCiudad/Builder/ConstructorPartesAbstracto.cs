
using System;
using HeroesDeCiudad.Adicionales;
using HeroesDeCiudad.Decorator;
using HeroesDeCiudad.FactoryMethod;

namespace HeroesDeCiudad.Builder
{
	public abstract class ConstructorPartesAbstracto
	{
		
		protected ISector[][] matriz;

		public ISector[][] Matriz {
			get {
				return matriz;
			}
		}
		public void construirMatriz(int tam){
			matriz= new ISector[tam][];
			
			for (int i = 0; i < tam; i++) {
				matriz[i]= new ISector [tam];
			}
			
			
		}
		
		public ISector[][] obtenerSector(){
			return matriz;
		}
		
		
		public abstract ISector[][] construirSectores();
		
		
	}
}
