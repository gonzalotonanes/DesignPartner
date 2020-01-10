
using System;
using System.Collections.Generic;
using System.Linq;
using HeroesDeCiudad.Iterator;
using HeroesDeCiudad.Heroes;

namespace HeroesDeCiudad.AbstractFactory.Cuarteles
{
	public class CentralElectrica : ICuartel
	{
		
		//ATRIBUTOS
		private static CentralElectrica unica=null;
		
		List<IVehiculo> vehiculos;
		List<IHerramienta> herramientas;
		List<IResponsable> personal;
		
		//CONSTRUCTOR
		private CentralElectrica()
		{
			this.vehiculos= new List<IVehiculo>();
			this.herramientas= new List<IHerramienta>();
			this.personal= new List<IResponsable>();
		}
		
		
		//SINGLETON
		public static CentralElectrica getInstance()
		{
			if (unica==null) {
				
				unica= new CentralElectrica();
			}
			
			return unica;
		}

	
		//METODOS
		public void agregarVehiculo(IVehiculo vehiculo)
		{
			this.vehiculos.Add(vehiculo);
		}

		public void agregarPersonal(IResponsable responsable)
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
			
			((Electricista)r).Herramienta=h;
			((Electricista)r).Vehiculo=v;
			

			return r;
		}

		
	}
}
