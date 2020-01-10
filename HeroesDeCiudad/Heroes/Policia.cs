
using System;
using System.Collections.Generic;
using HeroesDeCiudad.Adicionales;
using HeroesDeCiudad.ChainOfResponsability;
using HeroesDeCiudad.Command;
using HeroesDeCiudad.Iterator;
using HeroesDeCiudad.State;
using HeroesDeCiudad.Strategy;
using HeroesDeCiudad.AbstractFactory;

namespace HeroesDeCiudad.Heroes
{
	
	public class Policia : Manejador, IResponsable
	{
		//ATRIBUTOS
		IHerramienta herramienta;
		IVehiculo vehiculo;
		private ICommand orden;
		private ICommand[] ordenes;
		int numeroOrden;
		List<ILugar> lugares;
		
		
		//CONSTRUCTOR
		public Policia(Manejador sucesor) : base(sucesor)
		{
			lugares= new List<ILugar>();
			ordenes= generarOrdenes();
			numeroOrden= Aleatorio.Next(0,2);
			
			
		}
		
		//GETTERS Y SETTER

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
		

		public ICommand Orden {
			get {
				return orden;
			}
			set {
				orden = value;
			}
		}

		public int NumeroOrden {
			get {
				return numeroOrden;
			}
			set {
				numeroOrden = value;
			}
		}
		
		//METODOS
		
		public override void patrullarCalles(IPatrullable patrullable){
			
			if (vehiculo==null && herramienta==null) {
				herramienta= new Pistola();
				vehiculo= new Patrullero();
			}
			
			if (patrullable.hayAlgoFueraDeLoNormal()) {
				
				vehiculo.getEstado().encender();
				vehiculo.encenderSirena();
				vehiculo.conducir();
				
				
				if (vehiculo.getEstado() is Roto) {
					Console.WriteLine("la patrulla se rompio, el policia no pudo completar su tarea");
				}else{
					
					this.apagarVehiculo();
					this.ordenes[this.numeroOrden].ejecutar();
					herramienta.usar();
					herramienta.guardar();
					
				}
				
			}
			
		}
		
		public void detenerDelincuentes(){}
		
		
		private static ICommand[] generarOrdenes()
		{
			ICommand[] acciones= new  ICommand[3];
			acciones[0]= new Avisar();
			acciones[1]= new DarLaVoz();
			acciones[2]= new Perseguir();
			
			return acciones;
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
