
using System;
using System.Collections.Generic;

namespace HeroesDeCiudad.Iterator
{
	
	public class IteradorDeTablero : IteradorDeDenuncias
	{
		
		List<IDenuncia> lista;
		int posicion;
		
		public IteradorDeTablero(List<IDenuncia> lista)
		{
			this.lista= lista;
			this.posicion=0;
		}

	

		public IDenuncia actual()
		{
			return lista[posicion];
		}

		public void siguiente()
		{
			posicion++;
		}

		public bool fin()
		{
			return posicion>=lista.Count;
		}

	
	}
}
