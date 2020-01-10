
using System;
using HeroesDeCiudad.Adicionales;

namespace HeroesDeCiudad.Decorator
{
	
	public class DiaLluvioso : AdicionalDecorador
	{
		
		int caudalLluvia;
		
		public DiaLluvioso(ISector sector) : base(sector)
		{
			
		}
		public DiaLluvioso(ISector sector, int lluvia) : base(sector)
		{
			this.caudalLluvia=lluvia;
		}
		
		
		public override void mojar(double agua){
		
		
			double resultadoCaudal= agua+caudalLluvia;
			base.mojar(resultadoCaudal);
			
		}
		
		public override string ToString(){
			return sector.ToString() + ", dia lluvioso";
		}
	}
}
