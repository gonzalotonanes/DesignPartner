
using System;
using HeroesDeCiudad.Decorator;

namespace HeroesDeCiudad.FactoryMethod
{

	public class FabricaDeMuchoViento : FabricaDeSectores
	{
		
		int viento;
		
		public override ISector crearSector(ISector sector)
		{
			return new MuchoViento(sector, this.viento);
		}
		
		public FabricaDeMuchoViento(int viento)
		{
			this.viento= viento;
		}
		
		
	}
}
