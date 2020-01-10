
using System;
using System.Collections.Generic;

namespace HeroesDeCiudad.Composite
{
	
	public class Ciudad : Zona, ILuminable
	{
	
		List<ILuminable> hijos= new List<ILuminable>();
	

		override public void agregar(ILuminable l)
		{
			hijos.Add(l);
		}

		override public void quitar(ILuminable l)
		{
			hijos.Remove(l);
		}

		


		public void revisarYCambiarLamparasQuemadas()
		{
			foreach (ILuminable element in hijos) {
				element.revisarYCambiarLamparasQuemadas();
			}
		}

	

		public Ciudad()
		{
			this.hijos= new List<ILuminable>();
		}
	}
}
