
using System;
using HeroesDeCiudad.Decorator;

namespace HeroesDeCiudad.FactoryMethod
{
	public class FabricaDeDiaLluvioso : FabricaDeSectores
	{
		
		int lluvia;
		
		public override ISector crearSector(ISector sector)
		{
			return new DiaLluvioso(sector,this.lluvia);
		}
		
		public FabricaDeDiaLluvioso(int lluvia)
		{
			this.lluvia= lluvia;
		}
		
		
	}
}
