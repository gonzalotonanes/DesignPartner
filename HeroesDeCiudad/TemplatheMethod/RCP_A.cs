
using System;

namespace HeroesDeCiudad.TemplatheMethod
{

	public class RCP_A : ProtocoloRCP
	{
		private int contador=1;

		public int Contador {
			get {
				return contador;
			}
			set {
				contador = value;
			}
		}

		public RCP_A()
		{
			this.contador=1;
		}
		
		//metodo para que haga hasta 5  intento reanimaciones
		protected override bool intentoReanimacion()
		{
			if (contador==5) {
				return false;
			}
			else
				contador++;
				return true;
		}
		
		protected override void eliminarElementoBoca()
		{
			Console.WriteLine("Eliminando objetos de la boca, rcp A");
		}
		protected override void comprobarEstadoVictima()
		{
			Console.WriteLine("Comprobando estado del paciento, rcp A");
		}
		protected override void llamarAmbulancia()
		{
			Console.WriteLine("LLamar ambulancia, rcp A");
		}
		protected override void descrubrirTorax()
		{
			Console.WriteLine("Descrubrir torax, rcp A");
		}
		protected override void acomodarCabeza()
		{
			Console.WriteLine("Acomodar cabeza, rcp A");
		}
		protected override void hacerCompresionesToraxicas()
		{
			Console.WriteLine("Hacer compresiones toraxicas, rcp A");
		}
		protected override void hacerInsuflaciones()
		{
			Console.WriteLine("Hacer insuflaciones, rcp A");
		}
		protected override void usarDesfibrilador()
		{
			Console.WriteLine("Usar desfibrilador, rcp`A");
		}
		
	}
}
