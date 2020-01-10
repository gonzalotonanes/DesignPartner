
using System;
using HeroesDeCiudad.AbstractFactory;

namespace HeroesDeCiudad.State
{

	public class TodaVelocidad : EstadoDelMotor
	{
		public TodaVelocidad(IVehiculo vehiculo) : base(vehiculo)
		{
		}
		
		public override void acelerar()
		{
			Console.WriteLine("sobrepaso de aceleracion ");
			this.vehiculo.cambiarEstado(new Roto(this.vehiculo));
		}
		
		public override void desacelerar()
		{
			Console.WriteLine("desacelerando a marcha media ");
			this.vehiculo.cambiarEstado(new MarchaMedia(this.vehiculo));
		}
		
		public override void frenar()
		{
			Console.WriteLine("frenando");
			this.vehiculo.cambiarEstado(new PuntoMuerto(this.vehiculo));
		}
		
			public override void apagar()
		{
			Console.WriteLine("motor roto");
			this.vehiculo.cambiarEstado(new Roto(this.vehiculo));
		}
			
	}
}
