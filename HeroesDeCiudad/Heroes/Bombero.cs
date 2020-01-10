
using System;
using HeroesDeCiudad.ChainOfResponsability;
using HeroesDeCiudad.Iterator;
using HeroesDeCiudad.State;
using HeroesDeCiudad.Strategy;
using HeroesDeCiudad.Lugares;
using HeroesDeCiudad.Observer;
using HeroesDeCiudad.AbstractFactory;

namespace HeroesDeCiudad.Heroes
{

	public class Bombero : Manejador, Observador, IResponsable
	{
		//ATRIBUTOS
		IHerramienta herramienta;
		IVehiculo vehiculo;
		IEstrategia estrategia;
		
		
		//CONSTRUCTOR
		public Bombero(Manejador sucesor): base(sucesor)
		{
			this.estrategia= new EstrategiaSecuencial();
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

		public IEstrategia Estrategia {
			get {
				return estrategia;
			}
			set {
				estrategia = value;
			}
		}
		
		//METODOS
		
		public void actualizar(Observado o)
		{
			
			ILugar lugar= (ILugar)o;
			
			if (lugar is Casa) {
				estrategia= new EstrategiaEscalera();
			}
			if (lugar is Plaza) {
				estrategia= new EstrategiaEspiral();
			}
			this.apagarIncendio(lugar,lugar.Calle);
			
		}


		public override void apagarIncendio(ILugar lugar, Calle calle)
		{
			if (vehiculo==null && herramienta==null) {
				herramienta= new Manguera();
				vehiculo= new Autobomba();
			}
			
			vehiculo.encenderSirena();
			vehiculo.conducir();
			
			
			if (this.vehiculo.getEstado() is Roto) {
				Console.WriteLine("autobomba se rompio, el policia no pudo completar su tarea");
			}else
			{
				
				this.apagarVehiculo();
				herramienta.usar();
				estrategia.apagarIncendio(lugar,calle.Caudal);
				herramienta.guardar();
				
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
		
		public void cambiarEstrategia(IEstrategia estrategia){
			this.estrategia= estrategia;
		}
		
		public void bajarGatitoDeArbol(){
			
			Console.WriteLine("Bajando gatito del arbol");
		}
	}
}
