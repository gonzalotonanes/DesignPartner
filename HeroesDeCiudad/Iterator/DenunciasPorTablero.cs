
using System;
using System.Collections.Generic;
using HeroesDeCiudad.Observer;
using HeroesDeCiudad.Strategy;
using HeroesDeCiudad.Lugares;

namespace HeroesDeCiudad.Iterator
{
	
	public class DenunciasPorTablero : Observador, IDenuncias
	{
		List<IDenuncia> denuncias;

		public List<IDenuncia> Denuncias {
			get {
				return denuncias;
			}
		}
		
		public DenunciasPorTablero()
		{
			denuncias= new List<IDenuncia>();
		}
		
		
		public void actualizar(Observado o)
		{
			
			denuncias.Add( new DenunciaDeIncendios(  (ILugar)o) );
		}
		
		public IteradorDeTablero iterador()
		{
			return new IteradorDeTablero(denuncias);
		}
		
		
		public IteradorDeDenuncias Iterador {
			get {
				return new IteradorDeTablero(denuncias);
			}
			set {
				throw new NotImplementedException();
			}
		}
	}
}
