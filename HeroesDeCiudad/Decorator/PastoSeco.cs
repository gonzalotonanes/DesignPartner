
using System;

namespace HeroesDeCiudad.Decorator
{
	
	public class PastoSeco : AdicionalDecorador
	{	
		
	
		
		public PastoSeco(ISector sector) : base(sector)
		{
			
		}

		
		 public override void mojar(double agua)
		{
		 	double resultado= agua/2;
		 	base.mojar(resultado);
		}
		
		
		public override string ToString()
		{
			return sector.ToString() +", pasto seco";
		}
		
		
	}
}
