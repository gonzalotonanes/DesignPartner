
using System;
using HeroesDeCiudad.AbstractFactory;

namespace HeroesDeCiudad.State
{
	public class Roto : EstadoDelMotor
	{
		public Roto(IVehiculo vehiculo): base(vehiculo)
		{
		}
		
		public override void arreglar()
		{
			Console.WriteLine("Arreglando motor");
			this.vehiculo.cambiarEstado(new Apagado(this.vehiculo));
		}
	}
}
