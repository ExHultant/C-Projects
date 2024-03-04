using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_Class
{
    internal class Program
    {

        static void suma(int n1, int n2) {
            //Datos que se almacenan para uno 
            int res = 0;
            Console.WriteLine("Ingrese un numero");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro Numero");
            n2 = int.Parse(Console.ReadLine());
            res = n1 + n2;
            Console.WriteLine("El resultado dio " + res);
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            /*Para la evaluacion nro 3 los metodos 
             desarrolle una app que permita mediante el uso de metodos desarrollar la sumatoria
            de dos numeros*/
            //Datos que se muestran para el usuario
            int n1 = 0, n2 = 0;
            suma(n1,n2);
            
        }
    }
}
