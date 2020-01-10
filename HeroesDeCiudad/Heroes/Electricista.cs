
using System;
using HeroesDeCiudad.ChainOfResponsability;
using HeroesDeCiudad.Composite;
using HeroesDeCiudad.AbstractFactory;
using HeroesDeCiudad.Iterator;
using HeroesDeCiudad.State;

namespace HeroesDeCiudad.Heroes
{
	
	public class Electricista : Manejador, IResponsable
	{
		//ATRIBUTOS
		IHerramienta herramienta;
		IVehiculo vehiculo;
		
		//CONSTRUCTOR
		public Electricista(Manejador sucesor) : base(sucesor)
		{
			
		}

		
		//GETTERS Y SETTERS
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
		
		public override void revisar(ILuminable lugar){
			if (vehiculo==null && herramienta==null) {
				this.herramienta= new Buscapolo();
				this.vehiculo= new Camioneta();
			}
			this.vehiculo.getEstado().encender();
			this.vehiculo.encenderSirena();
			this.vehiculo.conducir();
			
			
			if (this.vehiculo.getEstado() is Roto) {
				Console.WriteLine("La camioneta se rompio, electricista no pudo completar su tarea");
			}else{
				Console.WriteLine("Revisando electricidad");
				this.apagarVehiculo();
				this.herramienta.usar();
				lugar.revisarYCambiarLamparasQuemadas();
				this.herramienta.guardar();

				
			}
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
