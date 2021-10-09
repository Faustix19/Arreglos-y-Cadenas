using System;
using System.Collections.Generic;
using System.Text;

namespace Cadenas
{
    class Program
    {
        static void Main(string[] args)
        {
			string cadena;

            Console.WriteLine("Ingrese una frase cualquiera ");
            cadena = Console.ReadLine();

            char[] partes = { ' ' };
            string[] frase = cadena.Split(partes);
            int i;
            for (i = 0; i < frase.Length; i++) 
            {

                Console.WriteLine("palabra {0}={1}  ",(i+0), frase[i]);
            }
            Console.ReadKey();
        }
		
    }
}
