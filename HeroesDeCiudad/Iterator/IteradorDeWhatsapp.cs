
using System;

namespace HeroesDeCiudad.Iterator
{

	public class IteradorDeWhatsapp : IteradorDeDenuncias
	{
		private MensajeWhatsapp denuncia;
		
		public IteradorDeWhatsapp(MensajeWhatsapp denuncia)
		{
			this.denuncia= denuncia;
		}

	

		public IDenuncia actual()
		{
			return this.denuncia;
			
		}

		public void siguiente()
		{
			denuncia= this.denuncia.Siguiente;
		}

		public bool fin()
		{
			return denuncia==null;
		}
		
	}
}
