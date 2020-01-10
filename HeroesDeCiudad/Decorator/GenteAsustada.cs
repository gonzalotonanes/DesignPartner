
using System;
using HeroesDeCiudad.Adicionales;
namespace HeroesDeCiudad.Decorator
{

	public class GenteAsustada : AdicionalDecorador
	{
		
		int cantidadGente;
			
			public GenteAsustada(ISector sector) : base(sector)
		{
		}
		
		
		
		public int CantidadGente {
			get {
				return cantidadGente;
			}
			set {
				cantidadGente = value;
			}
		}
		
		public override void mojar(double agua)
		{
			//genera randoms para la cantidad de personas asustadas
			int cantidadGente = Aleatorio.Next(1,6);
			cantidadGente=1;
			int cont=0;
			double resultado=agua;
			while (cont<cantidadGente) {
				resultado= resultado*0.25;
				cont++;
			}
			
			
			base.mojar(resultado);
		}
		
		
		public override string ToString(){
			return sector.ToString()+", gente asustada";
		}
		
	}
}
