
using System;
using HeroesDeCiudad.Adicionales;
using HeroesDeCiudad.Builder;
using HeroesDeCiudad.Command;
using HeroesDeCiudad.Composite;
using HeroesDeCiudad.Decorator;
using HeroesDeCiudad.Strategy;
using System.Collections.Generic;
using HeroesDeCiudad.Heroes;
using HeroesDeCiudad.Observer;
using HeroesDeCiudad.FactoryMethod;


namespace HeroesDeCiudad.Lugares
{
	
	public class Plaza : ILugar, ILuminable, IPatrullable
	{
		
		
		//ATRIBUTOS
		String nombre;
		int superficieM2;
		int cantArboles;
		int cantFarolas;
		List<Observador> observadores;
		Calle calle;
		
		ConstructorPartesAbstracto constructor;
		
		//CONSTRUCTOR
		public Plaza(string nombre, int superficieM2, int cantArboles, int cantFarolas)
		{
			this.nombre= nombre;
			this.superficieM2=superficieM2;
			this.cantArboles= cantArboles;
			this.cantFarolas=cantFarolas;
			this.observadores= new List<Observador>();
			
			//CONSTRUCTOR MIXTO POR DEFECTO
			this.constructor= new ConstructorMixto();
		}

		//PATRON COMPOSITE
		public void revisarYCambiarLamparasQuemadas()
		{
			Console.WriteLine("Cambiando lamparas en la Plaza "+this.nombre);
		}

		//PATRON COMMAND
		public bool hayAlgoFueraDeLoNormal()
		{
			
			double probabilidad=0.40;
			double numero = Aleatorio.generadorNum();

			return numero<probabilidad;
		}	
		
		//PATRON OBSERVER
		
		public void agregarObserador(Observador b)
		{
			observadores.Add(b);
		}

		public void quitarObservador(Observador b)
		{
			observadores.Add(b);
		}
		
		
		public void notificar()
		{
			foreach (Observador element in observadores) {
				element.actualizar(this);
			}
		
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

		public ConstructorPartesAbstracto Constructor {
			get {
				return constructor;
			}
			set {
				constructor = value;
			}
		}
		public string Nombre {
			get { return nombre; }
			set { nombre = value; }
		}

		public int SuperficieM2 {
			get { return superficieM2; }
			set { superficieM2 = value; }
		}

		public int CantArboles {
			get { return cantArboles; }
			set { cantArboles = value; }
		}

		public int CantFarolas {
			get { return cantFarolas; }
			set { cantFarolas = value; }
		}
		
		//METODOS

		public ISector[][] getSectores()
		{
			double raiz= Math.Sqrt(superficieM2);
			int n= (int)Math.Round(raiz);			
			return DirectorDeSector.ConstruirSectores(this.constructor,n);
		}
		
		
		public void chispa()
		{
			double probabilidad= 0.7;
			double incendio= Aleatorio.generadorNum();
			if (incendio<probabilidad) {
				Console.WriteLine("Haciendo sonar la alarma de incendio de "+this.ToString());
				notificar();
			}
		}
		
		override public string ToString()
		{
			return "la plaza";
		}
		

	}
}
