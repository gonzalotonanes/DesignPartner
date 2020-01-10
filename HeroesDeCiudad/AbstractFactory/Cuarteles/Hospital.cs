
using System;
using System.Collections.Generic;
using HeroesDeCiudad.Heroes;
using HeroesDeCiudad.Iterator;

namespace HeroesDeCiudad.AbstractFactory.Cuarteles
{
	
	public class Hospital : ICuartel
	{
		
		//ATRIBUTOS
		private static Hospital unica= null;
		List<IHerramienta> herramientas;
		List<IVehiculo> vehiculos;
		List<IResponsable> personal;
		
		
		//CONSTRUCTOR
		private Hospital()
		{
			this.vehiculos= new List<IVehiculo>();
			this.herramientas= new List<IHerramienta>();
			this.personal= new List<IResponsable>();
		}
		
		
		//SINGLETON
		public static Hospital getInstance()
		{
			if (unica==null) {
				
				unica= new Hospital();
			}
			
			return unica;
		}

		
		
		//METODOS

		public void agregarVehiculo(IVehiculo vehiculo)
		{
			this.vehiculos.Add(vehiculo);
		}

		public void agregarPersonal(global::HeroesDeCiudad.Iterator.IResponsable responsable)
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
			
			((Medico)r).Herramienta=h;
			((Medico)r).Vehiculo=v;
			
			return r;
		}

	
	}
}
