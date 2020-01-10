
using System;
using HeroesDeCiudad.Decorator;

namespace HeroesDeCiudad.FactoryMethod
{

	public class FabricaDeMuchoCalor : FabricaDeSectores
	{
		private int temp;
	
	
		public FabricaDeMuchoCalor( int temp)
		{
		
			this.temp=temp;
		}
		
		
		
		public override ISector crearSector(ISector sector)
		{
			return new MuchoCalor(sector,this.temp);
		}
	
	}
}
