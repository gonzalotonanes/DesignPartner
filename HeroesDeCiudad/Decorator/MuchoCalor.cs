
using System;
using HeroesDeCiudad.Adicionales;

namespace HeroesDeCiudad.Decorator
{
	
	public class MuchoCalor : AdicionalDecorador
	{
		
		
		int temperatura ;
		
		public MuchoCalor(ISector sector,int temperatura) : base(sector)
		{
			this.temperatura= temperatura;
		}
		
		
		public override void mojar(double agua)
		{
		
			double resultadoCaudal= agua-(0.1*temperatura);
			
			base.mojar(resultadoCaudal);
			
			
		}
		
		public override string ToString(){
			return sector.ToString()+", mucho calor";
		}
	}
}
