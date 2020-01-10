
using System;
using HeroesDeCiudad.Heroes;
using HeroesDeCiudad.Iterator;
using HeroesDeCiudad.TemplatheMethod;

namespace HeroesDeCiudad.ChainOfResponsability
{
 
	public class DenunciaDeInfarto : IDenuncia
	{
		IInfartable infartable;
		
		public DenunciaDeInfarto(IInfartable infartable)
		{
			this.infartable=infartable;
		}

	

		public void atender(IResponsable responsable)
		{
			
			Manejador medico= ((Manejador)responsable);
			medico.atenderInfarto(this.infartable);
			
		}

	
	}
}
