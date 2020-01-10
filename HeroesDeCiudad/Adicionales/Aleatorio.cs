
using System;

namespace HeroesDeCiudad.Adicionales
{
	
	public class Aleatorio
	{
		
		static Random random = new Random();
		
		
		
		//CLASE PARA GENERAR NUMEROS RANDOM
		
		public Aleatorio()
		{
		}
		
		
		public static  double generadorNum()
		{
			return random.NextDouble();
		}
		
		
		public static  int Next(int n)
		{
			return random.Next(n);
		}
		
		public static  int Next(int n, int m)
		{
			return random.Next(n,m);
		}
	}
}
