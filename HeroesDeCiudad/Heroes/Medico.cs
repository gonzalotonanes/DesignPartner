
using System;
using HeroesDeCiudad.ChainOfResponsability;
using HeroesDeCiudad.Iterator;
using HeroesDeCiudad.State;
using HeroesDeCiudad.TemplatheMethod;
using HeroesDeCiudad.AbstractFactory;

namespace HeroesDeCiudad.Heroes
{

	public class Medico : Manejador, IResponsable
	{
		//ATRIBUTOS
		IHerramienta herramienta;
		IVehiculo vehiculo;
		ProtocoloRCP rcp;
		
		
		
		//CONSTRUCTOR
		
		public Medico(Manejador sucesor) : base(sucesor)
		{
			rcp= new RCP_A();
		}
		
		
		
		//GETTER Y SETTER
		public ProtocoloRCP Rcp {
			get {
				return rcp;
			}
			set {
				rcp = value;
			}
		}
		
		public IHerramienta Herramienta {
			get {
				return herramienta;
			}
			set {
				herramienta = value;
			}
		}

		public IVehiculo Vehiculo {
			get {
				return vehiculo;
			}
			set {
				vehiculo = value;
			}
		}
		
		
		//METODOS
		public override void atenderInfarto(IInfartable t){
			
			if (  rcp is RCP_A) {
				((RCP_A)rcp).Contador=1;
			}
			
			if (vehiculo==null && herramienta==null) {
				this.vehiculo= new Ambulancia();
				this.herramienta= new Desfibrilador();
			}
			
			vehiculo.encenderSirena();
			vehiculo.conducir();
			
			
			if (this.vehiculo.getEstado() is Roto) {
				Console.WriteLine("La ambulancia se rompio, el medico no pudo completar su tarea");
			}else
			{
				this.apagarVehiculo();
				herramienta.usar();
				Console.WriteLine("Atendiendo infarto");
				rcp.realizarRCP(t);
				
				herramienta.guardar();
			}
			
			
			
			
		}
		
		public void atenderDesmayo(){
			Console.WriteLine("Atendiendo desmayo");
		}
		
			private void apagarVehiculo()
		{
			if (this.vehiculo.getEstado() is PuntoMuerto) {
				this.vehiculo.getEstado().apagar();
			}else{
			if ( (this.vehiculo.getEstado() is MarchaLenta) || this.vehiculo.getEstado() is TodaVelocidad || this.vehiculo.getEstado() is MarchaMedia) {
				this.vehiculo.getEstado().frenar();
				this.vehiculo.getEstado().apagar();
				}
			}
		}
		
	}
}
