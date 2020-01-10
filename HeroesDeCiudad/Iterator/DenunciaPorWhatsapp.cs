
using System;

namespace HeroesDeCiudad.Iterator
{
	
	public class DenunciaPorWhatsapp  : IDenuncias
	{
		
		MensajeWhatsapp denuncia;
		
		public DenunciaPorWhatsapp(MensajeWhatsapp denuncia)
		{
			this.denuncia= denuncia;
		}

		
		
		public IteradorDeDenuncias Iterador {
			get {
				return new IteradorDeWhatsapp(denuncia);
			}
			set {
				throw new NotImplementedException();
			}
		}
	}
}
