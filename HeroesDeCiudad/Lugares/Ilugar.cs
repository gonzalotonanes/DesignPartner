
using System;
using HeroesDeCiudad.Decorator;
using HeroesDeCiudad.Lugares;
using HeroesDeCiudad.Observer;
using HeroesDeCiudad.Heroes;

namespace HeroesDeCiudad.Strategy
{
	
	public interface ILugar : Observado
	{
		ISector [][] getSectores();
		
		Calle Calle{
			get;
			set;
		}
		
		void chispa();
		
		 string ToString();
	}
}
