
using System;
using HeroesDeCiudad.Iterator;

namespace HeroesDeCiudad.AbstractFactory
{
	
	public interface IFabricaDeHeroes
	{
		IResponsable crearHeroe();
		IVehiculo crearVehiculo();
		IHerramienta crearHerramienta();
		ICuartel crearCuartel();
	}
}
