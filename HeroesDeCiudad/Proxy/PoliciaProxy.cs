
using System;
using HeroesDeCiudad.AbstractFactory;
using HeroesDeCiudad.ChainOfResponsability;
using HeroesDeCiudad.Command;
using HeroesDeCiudad.Heroes;
using HeroesDeCiudad.Iterator;

namespace HeroesDeCiudad.Proxy
{
	
	public class PoliciaProxy : Policia, IResponsable
	{
		
		IFabricaDeHeroes fabrica= null;
		
		public PoliciaProxy(Manejador sucesor): base(sucesor)
		{
		}
		
		public override void patrullarCalles(IPatrullable patrullable){
			
			
			if (fabrica==null) {
				
				fabrica= new FabricaDePolicia();
			}
			
			Policia policia= (Policia)fabrica.crearHeroe();
			policia.Herramienta= fabrica.crearHerramienta();
			policia.Vehiculo= fabrica.crearVehiculo();
			
			
			policia.patrullarCalles(patrullable);
			
			
			
		}
	}
}
