
using System;
using System.Collections.Generic;

namespace HeroesDeCiudad.Composite
{
	
	public class Barrio :Zona, ILuminable
	{
		string nombre;
		List<ILuminable> hijos;
	

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

	

		public Barrio(string nombre)
		{
			this.nombre=nombre;
			
			this.hijos= new List<ILuminable>();
		}
	}
}
