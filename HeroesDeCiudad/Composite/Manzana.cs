
using System;
using System.Collections.Generic;

namespace HeroesDeCiudad.Composite
{

	public class Manzana :  Zona, ILuminable
	{
		
		List<ILuminable> hijos;
	

		public void revisarYCambiarLamparasQuemadas()
		{
			foreach (ILuminable element in hijos) {
				element.revisarYCambiarLamparasQuemadas();
			}
		}

	

		override public void agregar(ILuminable l)
		{
			hijos.Add(l);
		}

		override public void quitar(ILuminable l)
		{
			hijos.Add(l);
		}

	

		public Manzana()
		{
			this.hijos= new List<ILuminable>();
		}
	}
}
