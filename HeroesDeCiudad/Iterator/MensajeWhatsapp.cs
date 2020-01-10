
using System;

namespace HeroesDeCiudad.Iterator
{
	
	public class MensajeWhatsapp : IDenuncia
	{
		
		IDenuncia denuncia;
		MensajeWhatsapp siguiente;

		
		
		//CONSTRUCTOR
		public MensajeWhatsapp(IDenuncia denuncia,MensajeWhatsapp siguiente)
		{
			this.denuncia= denuncia;
			this.siguiente=siguiente;
		}
		
		public void atender(IResponsable responsable)
		{
			
			denuncia.atender(responsable);
			
		}

		
		
		//GETTER Y SETTERS
		
		public IDenuncia Denuncia {
			get {
				return denuncia;
			}
			set {
				denuncia = value;
			}
		}
		public MensajeWhatsapp Siguiente {
			get {
				return siguiente;
			}
			set {
				siguiente = value;
			}
		}
		
		
	}
}
