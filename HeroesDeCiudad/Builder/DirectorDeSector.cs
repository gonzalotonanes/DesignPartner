
using System;
using HeroesDeCiudad.Decorator;
using HeroesDeCiudad.Adicionales;
using HeroesDeCiudad.Strategy;

namespace HeroesDeCiudad.Builder
{
	
	public class DirectorDeSector
	{
		
		public  static ISector[][] ConstruirSectores(ConstructorPartesAbstracto constructor, int m2)
		{
			constructor.construirMatriz(m2);
			constructor.construirSectores();
			
			return constructor.obtenerSector();
		}
		
		

	}
}
