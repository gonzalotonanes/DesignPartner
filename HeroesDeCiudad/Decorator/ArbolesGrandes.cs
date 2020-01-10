
using System;

namespace HeroesDeCiudad.Decorator
{
	
	public class ArbolesGrandes : AdicionalDecorador
	{
		
		
		public ArbolesGrandes(ISector sector) : base(sector)
		{
			
		}
		 public override void mojar(double agua)
		{
		 	double resultado= agua*0.75;
		 	base.mojar(resultado);
		}
		
			
		public override string ToString(){
			return sector.ToString()+", arboles grandes";
		}
	}
}
