
using System;
using HeroesDeCiudad.AbstractFactory;
using HeroesDeCiudad.ChainOfResponsability;
using HeroesDeCiudad.Heroes;
using HeroesDeCiudad.Iterator;
using HeroesDeCiudad.Lugares;
using HeroesDeCiudad.Strategy;

namespace HeroesDeCiudad.Proxy
{
	
	public class BomberoProxy : Bombero, IResponsable
	{
		
		IFabricaDeHeroes fabrica = null;
		
		public BomberoProxy(Manejador sucesor) : base(sucesor)
		{
				
		}
			
		public override void apagarIncendio(ILugar lugar, Calle calle)
		{
			
			
			if (fabrica== null) {
				fabrica= new  FabricaDeBombero();
			}
			
			Bombero bombero= (Bombero)fabrica.crearHeroe();
			bombero.Herramienta= fabrica.crearHerramienta();
			bombero.Vehiculo= fabrica.crearVehiculo();
			
			bombero.apagarIncendio(lugar,calle);
			
			
		}
		
		
		
	}
}
