
using System;
using HeroesDeCiudad.Iterator;

namespace HeroesDeCiudad.ChainOfResponsability
{
	
	public class Operador911 
	{
		
		IResponsable responsable;
		IteradorDeDenuncias iterador;
		
		public Operador911(IResponsable responsable)
		{
			this.responsable=responsable;
		}
		
		
		public void atenderDenuncias(IDenuncias denuncias)
		{
			iterador= denuncias.Iterador;
			while(!iterador.fin())
			{
				iterador.actual().atender(this.responsable);
				iterador.siguiente();
			}
		}
	}
}
