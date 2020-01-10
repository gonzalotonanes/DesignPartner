
using System;
using System.Collections.Generic;
using HeroesDeCiudad.Adicionales;
using HeroesDeCiudad.Builder;
using HeroesDeCiudad.Command;
using HeroesDeCiudad.Composite;
using HeroesDeCiudad.Heroes;
using HeroesDeCiudad.Observer;
using HeroesDeCiudad.Strategy;
using HeroesDeCiudad.Decorator;

namespace HeroesDeCiudad.Lugares
{

	public class Casa : ILugar, IPatrullable
	{
		
		//ATRIBUTOS
		int numeroPuerta;
		double superficieM2;
		int cantHabitantes;
		List<Observador> observadores ;
		Calle calle;
		ConstructorPartesAbstracto constructor;

	
		//CONSTRUCTOR
		public Casa(int numeroPuerta, double superficieM2, int canHabitantes){
			this.numeroPuerta= numeroPuerta;
			this.superficieM2=superficieM2;
			this.cantHabitantes= canHabitantes;
			this.observadores= new List<Observador>();
			//constructor por defecto
			this.constructor= new ConstructorSimple();	
			
		}

		//PATRON COMMAND
		public bool hayAlgoFueraDeLoNormal()
		{
			
			double probabilidad=0.40;
			
			double numero= Aleatorio.generadorNum();
			
			
			return numero<probabilidad;
		}
		
		//PATRON OBSERVER
		
		
		public void chispa()
		{
			//probabilidad de que se incendie la casa
			double probabilidad= 0.7;
			double incendio= Aleatorio.generadorNum();
			
			if (incendio<probabilidad) {
				Console.WriteLine("Haciendo sonar la alarma de incendio de "+this.ToString());
				notificar();
				
			}
			
			
		}

		public void notificar()
		{
			foreach (Observador element in observadores) {
				element.actualizar(this);
			}
			
		}
		public void agregarObserador(Observador b)
		{
			observadores.Add(b);
		}
		public void quitarObservador(Observador b)
		{
			observadores.Remove(b);
		}
		
		
		
		
		//GETTERS Y SETTERS
		
		public Calle Calle {
			get {
				return calle;
			}
			set {
				calle= value;
			}
		}
		
		public int NumeroPuerta {
			get { return numeroPuerta; }
			set { numeroPuerta = value; }
		}

		public double SuperficieM2 {
			get { return superficieM2; }
			set { superficieM2 = value; }
		}

		public int CantHabitantes {
			get { return cantHabitantes; }
			set { cantHabitantes = value; }
		}

		public ConstructorPartesAbstracto Constructor {
			get {
				return constructor;
			}
			set {
				constructor = value;
			}
		}
		
		//METODOS
	
		public ISector [][] getSectores()
		{
			
			double raiz= Math.Sqrt(superficieM2);
			int n= (int)Math.Round(raiz);
			
			return DirectorDeSector.ConstruirSectores(constructor,n);
			
		}

		override public string ToString()
		{
			return "la casa Nº"+this.NumeroPuerta;
		}
		
		
		
	}
}
