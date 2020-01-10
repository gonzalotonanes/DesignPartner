
using System;
using HeroesDeCiudad.AbstractFactory;

namespace HeroesDeCiudad.State
{
	public class MarchaLenta : EstadoDelMotor
	{
		public MarchaLenta(IVehiculo vehiculo) : base(vehiculo)
		{
		}
		
		
		public override void acelerar()
		{
			Console.WriteLine("Pasando a marcha media");
			this.vehiculo.cambiarEstado(new MarchaMedia(this.vehiculo));
		}
		
		public override void desacelerar()
		{
			Console.WriteLine("desacelerando  a punto muerto");
			this.vehiculo.cambiarEstado(new PuntoMuerto(this.vehiculo));
		}
		
		public override void frenar()
		{
			Console.WriteLine("frenando");
			this.vehiculo.cambiarEstado(new PuntoMuerto(this.vehiculo));
		}
		
		public override void apagar()
		{
			Console.WriteLine("Motor roto");
			this.vehiculo.cambiarEstado(new Roto(this.vehiculo));
		}
		
		
	}
}
