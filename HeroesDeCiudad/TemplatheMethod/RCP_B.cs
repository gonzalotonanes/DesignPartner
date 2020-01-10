
using System;

namespace HeroesDeCiudad.TemplatheMethod
{
	
	public class RCP_B : ProtocoloRCP
	{
		
		public RCP_B()
		{
		}

	
		protected override bool intentoReanimacion()
		{
			return true;
		}

		
		
		protected override void eliminarElementoBoca()
		{
			Console.WriteLine("Eliminando objetos de la boca, rcp B");
		}
		protected override void comprobarEstadoVictima()
		{
			Console.WriteLine("Comprobando estado del paciento, rcp B");
		}
		protected override void llamarAmbulancia()
		{
			Console.WriteLine("LLamar ambulancia, rcp B");
		}
		protected override void descrubrirTorax()
		{
			Console.WriteLine("Descrubrir torax, rcp B");
		}
		protected override void acomodarCabeza()
		{
			Console.WriteLine("Acomodar cabeza, rcp B");
		}
		protected override void hacerCompresionesToraxicas()
		{
			
			Console.WriteLine("Hacer compresiones toraxicas, rcp B");
		}
		protected override void hacerInsuflaciones()
		{
			Console.WriteLine("Hacer insuflaciones, rcp B");
			
		}
		protected override void usarDesfibrilador()
		{
			Console.WriteLine("Usar desfibrilador, rcp B");
		}
		
		
	}
}
