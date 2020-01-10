
using System;
using HeroesDeCiudad.AbstractFactory.Cuarteles;
using HeroesDeCiudad.Heroes;
using HeroesDeCiudad.Iterator;

namespace HeroesDeCiudad.AbstractFactory
{
	
	public class FabricaDeMedico : IFabricaDeHeroes
	{
		public FabricaDeMedico()
		{
		}

		

		public IResponsable crearHeroe()
		{
			return new Medico(null);
		}

		public IVehiculo crearVehiculo()
		{
			return new Ambulancia();
		}

		public IHerramienta crearHerramienta()
		{
			return new Desfibrilador();
		}

		public ICuartel crearCuartel()
		{
			return Hospital.getInstance();
		}

	
	}
}
