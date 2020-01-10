
using System;
using System.Collections;
using System.Collections.Generic;

namespace HeroesDeCiudad.Iterator
{
	public interface IteradorDeDenuncias
	{
		
		IDenuncia actual();
		void siguiente();
		bool fin();
	}
}
