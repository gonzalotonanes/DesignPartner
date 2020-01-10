
using System;
using HeroesDeCiudad.Decorator;

namespace HeroesDeCiudad.Decorator
{
	
	public abstract class AdicionalDecorador  : ISector
	{
		protected ISector sector;
		
		public  AdicionalDecorador(ISector s)
		{
			this.sector=s;
		}

		
		
		
		virtual public void mojar(double agua)
		{
			sector.mojar(agua);
			
		}
		virtual public bool estaApagado()
		{
			return sector.estaApagado();
		}
		
			
		
		
	}
}
