
using System;
using HeroesDeCiudad.AbstractFactory;

namespace HeroesDeCiudad.State
{
	
	public class PuntoMuerto : EstadoDelMotor
	{
		public PuntoMuerto(IVehiculo vehiculo) :base(vehiculo)
		{
			
		}
		
		
		public override void acelerar()
		{
			Console.WriteLine("Pasando a marcha lenta");
			this.vehiculo.cambiarEstado(new MarchaLenta(this.vehiculo));
		}
		
		
		public override void apagar()
		{
			Console.WriteLine("Apagando motor");
			this.vehiculo.cambiarEstado(new Apagado(this.vehiculo));
		}
		
	}
}
