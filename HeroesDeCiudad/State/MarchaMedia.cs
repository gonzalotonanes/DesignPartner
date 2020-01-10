
using System;
using HeroesDeCiudad.AbstractFactory;

namespace HeroesDeCiudad.State
{
	
	public class MarchaMedia : EstadoDelMotor
	{
		public MarchaMedia(IVehiculo vehiculo) : base(vehiculo)
		{
		}
		
		public override void acelerar()
		{
			Console.WriteLine("pasando a toda marcha");
			this.vehiculo.cambiarEstado(new TodaVelocidad(this.vehiculo));
		}
		
		public override void desacelerar()
		{
			Console.WriteLine("pasando a marcha lenta");
			this.vehiculo.cambiarEstado(new MarchaLenta(this.vehiculo));
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
