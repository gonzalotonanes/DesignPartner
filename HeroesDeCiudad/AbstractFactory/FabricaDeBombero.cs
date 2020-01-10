
using System;
using HeroesDeCiudad.Heroes;
using HeroesDeCiudad.Iterator;

namespace HeroesDeCiudad.AbstractFactory
{
	
	public class FabricaDeBombero : IFabricaDeHeroes
	{
		public FabricaDeBombero()
		{
		}

	

		public IResponsable crearHeroe()
		{
			return new Bombero(null);
		}

		public IVehiculo crearVehiculo()
		{
			return new Autobomba();
		}

		public IHerramienta crearHerramienta()
		{
			return new Manguera() ;
		}
		
		public ICuartel crearCuartel()
		{
			return CuartelDeBomberos.getInstance() ;
		}

	}
}
