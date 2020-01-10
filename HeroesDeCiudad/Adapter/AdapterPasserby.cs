
using System;
using HeroesDeCiudad.TemplatheMethod;

namespace HeroesDeCiudad.Adapter
{

	public class AdapterPasserby : IInfartable
	{
		Passerby transeunte;
		
		public AdapterPasserby(Passerby transeunte )
		{
			this.transeunte=transeunte;
		}

	

		public bool estasConciente()
		{
			return this.transeunte.isConscious();
		}

		public bool estasRespirando()
		{
			return this.transeunte.isBreathing();
		}

		public bool tenesRitmoCardiaco()
		{
			return this.transeunte.haveHeartRate();
		}

	}
}
