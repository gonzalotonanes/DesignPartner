
using System;
using HeroesDeCiudad.AbstractFactory;

namespace HeroesDeCiudad.State
{

	public class Apagado : EstadoDelMotor
	{
	
		public Apagado(IVehiculo vehiculo) :base(vehiculo)
		{
		}
		
		public override void encender()
		{
			Console.WriteLine("Encendiendo "+vehiculo.ToString());
			this.vehiculo.cambiarEstado(new PuntoMuerto(this.vehiculo));
		}
		
	}
}
