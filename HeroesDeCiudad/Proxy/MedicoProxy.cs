
using System;
using HeroesDeCiudad.AbstractFactory;
using HeroesDeCiudad.ChainOfResponsability;
using HeroesDeCiudad.Heroes;
using HeroesDeCiudad.Iterator;
using HeroesDeCiudad.TemplatheMethod;

namespace HeroesDeCiudad.Proxy
{
	
	public class MedicoProxy  : Medico, IResponsable
	{
		IFabricaDeHeroes fabrica= null;
		
		public MedicoProxy(Manejador sucesor) : base(sucesor)
		{
		}
		
		public override void atenderInfarto(IInfartable transeunte){
			
			
			if (fabrica==null) {
				
				fabrica= new FabricaDeMedico();
			}
			
			Medico medico= (Medico)fabrica.crearHeroe();
			medico.Herramienta= fabrica.crearHerramienta();
			medico.Vehiculo= fabrica.crearVehiculo();
			
			
			medico.atenderInfarto(transeunte);
			
			
		
		
			
			
		}
	}
}
