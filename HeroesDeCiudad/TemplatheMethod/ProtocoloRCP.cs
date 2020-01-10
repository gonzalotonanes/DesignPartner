
using System;

namespace HeroesDeCiudad.TemplatheMethod
{
	
	public abstract class ProtocoloRCP
	{
		
		public  void realizarRCP(IInfartable paciente){
			
			
			this.eliminarElementoBoca();
			this.comprobarEstadoVictima();
			if (!paciente.estasConciente()) {
				this.llamarAmbulancia();
				this.descrubrirTorax();
				this.acomodarCabeza();
				do{
					this.hacerCompresionesToraxicas();
					this.hacerInsuflaciones();
					
					if (paciente.tenesRitmoCardiaco()) {
						this.usarDesfibrilador();
						return;
					}
					
				}while(!paciente.estasRespirando() && intentoReanimacion());
			}
			
			
		}
			
		protected abstract   void eliminarElementoBoca();
		protected abstract   void comprobarEstadoVictima();
		protected abstract   void llamarAmbulancia();
		protected abstract   void descrubrirTorax();
		protected abstract   void acomodarCabeza();
		protected abstract   void hacerCompresionesToraxicas();
		protected abstract   void hacerInsuflaciones();
		protected abstract   void usarDesfibrilador();
		protected abstract   bool intentoReanimacion();
		
		
		
		
	}
}
