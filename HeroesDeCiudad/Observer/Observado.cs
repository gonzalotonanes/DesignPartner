
using System;
using HeroesDeCiudad.Heroes;

namespace HeroesDeCiudad.Observer
{
	
	public interface Observado 
	{
		void notificar();
		void agregarObserador(Observador b);
		void quitarObservador(Observador b);
		
		
	}
}
