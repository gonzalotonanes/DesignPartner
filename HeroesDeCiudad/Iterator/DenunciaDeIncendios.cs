
using System;
using HeroesDeCiudad.ChainOfResponsability;
using HeroesDeCiudad.Lugares;
using HeroesDeCiudad.Strategy;
using HeroesDeCiudad.Heroes;

namespace HeroesDeCiudad.Iterator
{
	public class DenunciaDeIncendios : IDenuncia
	{
		ILugar lugar;

		public ILugar Lugar {
			get {
				return lugar;
			}
			set {
				lugar = value;
			}
		}
		public DenunciaDeIncendios(ILugar lugar)
		{
			
			this.lugar=lugar;
			this.lugar.Calle = new Calle(100,4,100);
			
		}


		public void atender(IResponsable responsable)
		{
			Manejador bombero= ((Manejador)responsable);
			bombero.apagarIncendio(this.lugar,this.lugar.Calle);
		}
		

	}
}
