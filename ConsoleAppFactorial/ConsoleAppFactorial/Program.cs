using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppFactorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, x, f = 1, resp = 0;
                Console.Write("Ingrese un numero");
                n = int.Parse(Console.ReadLine());
                if (n < 0)
                {
                    Console.WriteLine("El numero " + n + " es negativo");
                }
                for (x = 1; x < n; x++)
                {
                    f = f * x;
                }
                Console.WriteLine("El factorial del numero " + n + " es: " + f);
                Console.WriteLine("¿Otro Numero? \n 1.Si \n 2.No");
                resp = int.Parse(Console.ReadLine());
            
        }
    }
}
