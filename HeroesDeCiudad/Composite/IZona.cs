
using System;
using System.Collections.Generic;

namespace HeroesDeCiudad.Composite
{
	
	
	
	
	public abstract class Zona : ILuminable
	{
		
		private List<ILuminable> hijos;
		
		#region ILuminable implementation

		public void revisarYCambiarLamparasQuemadas()
		{
			throw new NotImplementedException();
		}

		#endregion

		
		
		public abstract void agregar(ILuminable l);
		public abstract void quitar(ILuminable l);
	}
}
