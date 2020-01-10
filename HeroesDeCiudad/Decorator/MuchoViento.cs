
using System;
using HeroesDeCiudad.Adicionales;

namespace HeroesDeCiudad.Decorator
{
	
	public class MuchoViento : AdicionalDecorador
	{
		
		int velocidadViento;
		
		public MuchoViento(ISector sector) : base(sector)
		{
			
		}
		
		
		public MuchoViento(ISector sector, int viento) : base(sector)
		{
			this.velocidadViento=viento;
		
		}
		public override void mojar(double agua){
			
			double resultadoCaudal= agua -Math.Exp(velocidadViento/100);
			
			resultadoCaudal= Math.Round(resultadoCaudal);
			base.mojar(resultadoCaudal);
		}
		
		public override string ToString(){
			return sector.ToString()+", mucho viento";
		}
	}
}
