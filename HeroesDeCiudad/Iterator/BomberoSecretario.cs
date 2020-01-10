
using System;
using HeroesDeCiudad.Heroes;
using HeroesDeCiudad.Strategy;

namespace HeroesDeCiudad.Iterator
{
	
	public class BomberoSecretario : IResponsable
	{
		
		Bombero bombero;
		IteradorDeDenuncias iterador;
		
		
		public BomberoSecretario(Bombero bombero)
		{
			this.bombero= bombero;
		}
		
		public void atenderDenuncias(IDenuncias denuncias)
		{
			 iterador= denuncias.Iterador;
			
			while(!iterador.fin())
			{
				iterador.actual().atender(this.bombero);
				iterador.siguiente();
			}
		}
	}
}
