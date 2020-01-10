
using System;

namespace HeroesDeCiudad.Iterator 
{
	
	public class IteradorPorMostrador : IteradorDeDenuncias
	{
		IDenuncia denuncia;
		int act;
		
		public IteradorPorMostrador(IDenuncia denuncia)
		{
			this.denuncia= denuncia;
			this.act=0;
		}

		public IDenuncia actual()
		{
			return this.denuncia;
		}

		public void siguiente()
		{
			this.act++;
		}

		public bool fin()
		{
			return act>0;
		}

	}
}
