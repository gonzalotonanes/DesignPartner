
using System;
using HeroesDeCiudad.AbstractFactory.Cuarteles;
using HeroesDeCiudad.Heroes;
using HeroesDeCiudad.Iterator;

namespace HeroesDeCiudad.AbstractFactory
{
	/// <summary>
	/// Description of FabricaDePolicia.
	/// </summary>
	public class FabricaDePolicia : IFabricaDeHeroes
	{
		public FabricaDePolicia()
		{
		}


		public IResponsable crearHeroe()
		{
			return new Policia(null);
		}

		public IVehiculo crearVehiculo()
		{
			return new Patrullero();
		}

		public IHerramienta crearHerramienta()
		{
			return new Pistola();
		}

		public ICuartel crearCuartel()
		{
			return Comisaria.getInstance();
		}

	}
}
