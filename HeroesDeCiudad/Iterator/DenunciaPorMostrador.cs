
using System;
using HeroesDeCiudad.Strategy;

namespace HeroesDeCiudad.Iterator
{
	
	public class DenunciaPorMostrador : IDenuncias
	{
		
		IDenuncia denuncia;
		
		public DenunciaPorMostrador(IDenuncia denuncia)
		{
			this.denuncia=denuncia;
		}


		public IteradorDeDenuncias Iterador {
			get {
				return new IteradorPorMostrador(denuncia);
			}
			set {
				throw new NotImplementedException();
			}
		}

	}
}
