using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_C_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Condicionales 
             Desarrolle un app que permita que se inicie un numero y que indique si es positivo
            negativo
             */
         
            int n = 0;
            Console.WriteLine("Ingrese un Numero");
            n = Int32.Parse(Console.ReadLine());
            if (n >= 0)
            {
                Console.WriteLine("Es Positivo");
            }
            else
            {
                {
                    Console.WriteLine("Es Negativo");
                }
            }


            Console.ReadKey ();
        }
    }
}
