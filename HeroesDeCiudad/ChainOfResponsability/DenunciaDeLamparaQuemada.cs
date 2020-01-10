
using System;
using HeroesDeCiudad.Composite;
using HeroesDeCiudad.Heroes;
using HeroesDeCiudad.Iterator;

namespace HeroesDeCiudad.ChainOfResponsability
{
	public class DenunciaDeLamparaQuemada : IDenuncia
	{
		
		ILuminable iluminable;
		public DenunciaDeLamparaQuemada(ILuminable iluminable)
		{
			this.iluminable=iluminable;
		}

	

		public void atender(IResponsable responsable)
		{
			Manejador electricista= ((Manejador)responsable);
			electricista.revisar(this.iluminable);
			
		}

		
	}
}
