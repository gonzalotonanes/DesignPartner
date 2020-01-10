
using System;
using HeroesDeCiudad.AbstractFactory;

namespace HeroesDeCiudad.State
{
	
	public abstract class EstadoDelMotor
	{
		protected IVehiculo vehiculo;
		
		public EstadoDelMotor(IVehiculo vehiculo)
		{
			this.vehiculo= vehiculo;
		}
		
		
		public virtual void encender()
		{
			Console.WriteLine("Sin efecto!");
		}
		public virtual void apagar()
		{
			Console.WriteLine("Sin efecto!");
		}
		public virtual void acelerar()
		{
			Console.WriteLine("Sin efecto!");
		}
		
		public virtual void desacelerar()
		{
			Console.WriteLine("Sin efecto!");
		}
		public virtual void frenar()
		{
			Console.WriteLine("Sin efecto!");
		}
		public virtual void arreglar()
		{
			Console.WriteLine("Sin efecto!");
		}
		
		public IVehiculo Vehiculo {
			get {
				return vehiculo;
			}
			set {
				vehiculo = value;
			}
		}
		
		
		
		
	}
}
