
using System;
using HeroesDeCiudad.Command;
using HeroesDeCiudad.Heroes;
using HeroesDeCiudad.Iterator;

namespace HeroesDeCiudad.ChainOfResponsability
{
	public class DenunciaDeRobo : IDenuncia
	{
		IPatrullable patrullable;
		
		public DenunciaDeRobo(IPatrullable patrullable)
		{
			this.patrullable= patrullable;
		}

	

		public void atender(IResponsable responsable)
		{
			Manejador policia= ((Manejador)responsable);
			policia.patrullarCalles(patrullable);
		}

	
	}
}
