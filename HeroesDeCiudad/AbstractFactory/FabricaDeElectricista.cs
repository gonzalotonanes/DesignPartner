
using System;
using HeroesDeCiudad.AbstractFactory.Cuarteles;
using HeroesDeCiudad.Heroes;
using HeroesDeCiudad.Iterator;

namespace HeroesDeCiudad.AbstractFactory
{
	
	public class FabricaDeElectricista : IFabricaDeHeroes
	{
		public FabricaDeElectricista()
		{
		}


		public IResponsable crearHeroe()
		{
			return new Electricista(null);
		}

		public IVehiculo crearVehiculo()
		{
			return new Camioneta();
		}

		public IHerramienta crearHerramienta()
		{
			return new Buscapolo();
		}

		public ICuartel crearCuartel()
		{
			return CentralElectrica.getInstance();
		}

	}
}
