
using System;
using System.Collections.Generic;
using HeroesDeCiudad.Heroes;
using HeroesDeCiudad.Iterator;

namespace HeroesDeCiudad.AbstractFactory.Cuarteles
{
	
	public class Comisaria : ICuartel
	{
		//ATRIBUTOS
		private static Comisaria unica=null;
		
		List<IVehiculo> vehiculos;
		List<IHerramienta> herramientas;
		List<IResponsable> personal;
		
		//CONSTRUCTOR
		private Comisaria()
		{
			this.vehiculos= new List<IVehiculo>();
			this.herramientas= new List<IHerramienta>();
			this.personal= new List<IResponsable>();
		}
		
		//SINGLETON
		public static Comisaria getInstance()
		{
			if (unica==null) {
				unica= new Comisaria();
			}
			
			return unica;
		}

	
		//METODOS
		public void agregarVehiculo(IVehiculo vehiculo)
		{
			this.vehiculos.Add(vehiculo);
		}

		public void agregarPersonal (IResponsable responsable)
		{
			this.personal.Add(responsable);
		}

		public void agregarherramienta(IHerramienta herramienta)
		{
			this.herramientas.Add(herramienta);
		}

		public IResponsable getPersonal()
		{
			IHerramienta h= herramientas[0];
			herramientas.RemoveAt(0);
			IVehiculo v= vehiculos[0];
			vehiculos.RemoveAt(0);
			IResponsable r= personal[0];
			personal.RemoveAt(0);
			
			((Policia)r).Herramienta=h;
			((Policia)r).Vehiculo=v;
			
			return r;
		}

	}
}
