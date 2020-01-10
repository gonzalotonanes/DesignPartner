
using System;
using HeroesDeCiudad.Adicionales;
using HeroesDeCiudad.Decorator;

namespace HeroesDeCiudad.Builder
{
	
	public class ConstructorMixto : ConstructorPartesAbstracto
	{
		public ConstructorMixto()
		{
		}


		public override ISector[][] construirSectores()
		{
			
			int temp= Aleatorio.Next(30,46);
			int viento= Aleatorio.Next(80,251);
			int lluvia= Aleatorio.Next(0,501);
			
			for(int i = 0; i < matriz.Length; i++)
			{
				for(int j = 0; j < matriz.Length; j++)
				{
					
					matriz[i][j]= DecoradorSectores.CrearDecorador(lluvia,temp,viento);
				}
			}
			
			return matriz;
		}
		
		
		

	}
}
