using System;
using System.Linq;

namespace Arreglos1
{
	public class Programa
	{
		public static void Main(string[] args)
		{
			float[] valores = { 46,35,20,15,55,77,99 };
			float media = valores.Average();
			Console.WriteLine("La media de los valores es: " + media);
		}
	}
}
