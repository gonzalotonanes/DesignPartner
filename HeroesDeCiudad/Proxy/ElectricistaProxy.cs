
using System;
using HeroesDeCiudad.AbstractFactory;
using HeroesDeCiudad.ChainOfResponsability;
using HeroesDeCiudad.Composite;
using HeroesDeCiudad.Heroes;
using HeroesDeCiudad.Iterator;

namespace HeroesDeCiudad.Proxy
{
	
	public class ElectricistaProxy : Electricista, IResponsable
	{
		IFabricaDeHeroes fabrica = null;
		
		public ElectricistaProxy(Manejador sucesor) : base(sucesor)
		{
			
		}
		
		public override void revisar(ILuminable l){
			
			if (fabrica==null) {
				fabrica= new FabricaDeElectricista();
			}
			
			Electricista electricista= (Electricista)fabrica.crearHeroe();
			electricista.Herramienta= fabrica.crearHerramienta();
			electricista.Vehiculo= fabrica.crearVehiculo();
			
			
			electricista.revisar(l);
		
		}
	}
}
