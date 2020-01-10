/*
 * Created by SharpDevelop.
 * User: gonza
 * Date: 26/11/2019
 * Time: 18:38
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using HeroesDeCiudad.Command;
using HeroesDeCiudad.Composite;
using HeroesDeCiudad.Iterator;
using HeroesDeCiudad.Lugares;
using HeroesDeCiudad.Strategy;
using HeroesDeCiudad.TemplatheMethod;

namespace HeroesDeCiudad.ChainOfResponsability
{
	/// <summary>
	/// Description of Manejador.
	/// </summary>
	public abstract class Manejador : IResponsable
	{
		Manejador sucesor;
		
		public Manejador(Manejador sucesor)
		{
			this.sucesor= sucesor;
		}
		
		//METODO DEL MEDICO
		public virtual void atenderInfarto(IInfartable infartable){
			if (this.sucesor!=null) {
				sucesor.atenderInfarto(infartable);
			}
			
		}
		//METODO DEL ELECTRICISTA
		public virtual void revisar(ILuminable luminable)
		{
			if (this.sucesor!=null) {
				
				sucesor.revisar(luminable);
			}
		}
		//METODO DEL POLICIA
		public virtual void patrullarCalles(IPatrullable patrullable){
			if (this.sucesor!=null) {
				this.sucesor.patrullarCalles(patrullable);
			}
		}
		
		
		//METODO DEL BOMBERO
		public  virtual void apagarIncendio(ILugar lugar, Calle calle)
		{
			if (this.sucesor!=null) {
				this.sucesor.apagarIncendio(lugar,calle);
			}
		}
		
	}
}
