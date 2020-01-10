
using System;
using System.Collections.Generic;
using HeroesDeCiudad.Heroes;
using HeroesDeCiudad.Iterator;

namespace HeroesDeCiudad.AbstractFactory
{

	public class CuartelDeBomberos : ICuartel
	{
		//ATRIBUTOS
		private static CuartelDeBomberos unica= null;
		
		List<IHerramienta> herramientas;
		List<IVehiculo> vehiculos;
		List<IResponsable> personal;
		
		//CONSTRUCTOR
		private CuartelDeBomberos()
		{
			this.vehiculos= new List<IVehiculo>();
			this.herramientas= new List<IHerramienta>();
			this.personal= new List<IResponsable>();
		}
		
		//SINGLETON
		public static CuartelDeBomberos getInstance()
		{
			if (unica==null) {
				unica= new CuartelDeBomberos();
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
			
			((Bombero)r).Herramienta=h;
			((Bombero)r).Vehiculo=v;
			
			return r;
			
			
		}
	}
}
