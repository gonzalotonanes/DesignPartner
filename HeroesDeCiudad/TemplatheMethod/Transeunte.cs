
using System;
using HeroesDeCiudad.Adicionales;

namespace HeroesDeCiudad.TemplatheMethod
{
	
	public class Transeunte : IInfartable 
	{
		public Transeunte()
		{
		}

		public bool estasConciente()
		{
			
			return Aleatorio.generadorNum()<0.2;
		}

		public bool estasRespirando()
		{
			return Aleatorio.generadorNum()<0.1;
		}

		public bool tenesRitmoCardiaco()
		{
			return Aleatorio.generadorNum()<0.2;
		}

	}
}
