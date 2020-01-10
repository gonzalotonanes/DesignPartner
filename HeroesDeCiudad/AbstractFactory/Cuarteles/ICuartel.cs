
using System;
using HeroesDeCiudad.Iterator;

namespace HeroesDeCiudad.AbstractFactory
{
	
	public interface ICuartel
	{
		void agregarVehiculo(IVehiculo vehiculo);
		void agregarPersonal(IResponsable responsable);
		void agregarherramienta(IHerramienta herramienta);
		IResponsable getPersonal();
	}
}
