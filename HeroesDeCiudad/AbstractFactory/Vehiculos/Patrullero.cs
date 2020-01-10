
using System;
using HeroesDeCiudad.Adicionales;
using HeroesDeCiudad.State;

namespace HeroesDeCiudad.AbstractFactory
{
	
	public class Patrullero :IVehiculo
	{
		
		//ATRIBUTOS
		EstadoDelMotor estado;
		
		
		//CONSTRUCTOR
		public Patrullero()
		{
			this.estado= new Apagado(this);
		}

		//METODOS
		public void encenderSirena()
		{
			Console.WriteLine("Encendiendo sirena de patrullero");
		}

		public void conducir()
		{
			
			Console.WriteLine("Conduciendo patrullero");
			int cont = 0;
			int random;
		
			while (cont != 6) {
						
				if (this.estado is Apagado) {
					this.estado.encender();
				}
				
				if (this.estado is Roto) {
					this.estado.arreglar();
				}
				
				random= Aleatorio.Next(0,4);
				
				
				//CAMBIA DE ESTADOS ALEATORIAMENTE
				switch (random) {
					case 0:
						if ( !(this.estado is Apagado) && !(this.estado is Roto)  ) {
							this.estado.apagar();
						}
						break;
					case 1:
						if(!(this.estado is Apagado) && !(this.estado is Roto) ) {
							this.estado.acelerar();
						}
						break;
					case 2:
						if ( !(this.estado is PuntoMuerto) && !(this.estado is Apagado) && !(this.estado is Roto) ) {
							this.estado.desacelerar();
						}
						break;
					case 3:
						if ( !(this.estado is Roto) && !(this.estado is Apagado) && !(this.estado is PuntoMuerto) ) {
							this.estado.frenar();
						}
						
						break;
				}
			
				cont++;
				
			}
			
			
		}
		
		//METODOS

		public void cambiarEstado(EstadoDelMotor estado)
		{
			this.estado=estado;
		}
		public EstadoDelMotor getEstado()
		{
			return this.estado;;
		}
		
		public override string ToString()
		{
			return "patrullero";
		}
	}
}
