
using System;
using HeroesDeCiudad.State;

namespace HeroesDeCiudad.AbstractFactory
{
	
	public interface IVehiculo
	{
		void encenderSirena();
		void conducir();
		
		void cambiarEstado(EstadoDelMotor estado);
		
		EstadoDelMotor getEstado();
		
	}
}
