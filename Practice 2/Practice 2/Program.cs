using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* la coordinacion busca preparadores: requisitos:
             * 1.estudiante de informatica 
             * 2.cursante entre segundo y cuarto semestre 
             * 3.disponibilidad de mañana o tarde 
             * 4. Promedio no menor a 15 puntos
             * indique si fue o no seleccionado 
             */
            string resp = "1";
            while (resp == "1")
            {
                Console.WriteLine("Buenos dias Introduzca su nombre por favor");
                string nom = null, ci = null, student = null, cursant = null, turn = null;
                int prom = 0;
                nom = Console.ReadLine();
                Console.WriteLine(nom + " introduzca su C.I");
                ci = Console.ReadLine();
                Console.WriteLine(nom + " ¿Usted es estudiante de informatica? 1.Si 2.No");
                student = Console.ReadLine();
                Console.WriteLine(nom + " ¿Cursa entre 2do y 4to Semestre? 1.Si 2.No");
                cursant = Console.ReadLine();
                Console.WriteLine(nom + " Tiene disponibilidad para: 1.Mañana 2.Tarde");
                turn = Console.ReadLine();
                Console.WriteLine("Indique por favor su promedio");
                prom = int.Parse(Console.ReadLine());
                if ((student == "1") && (cursant == "1") && (prom >= 15))
                {
                    Console.WriteLine("Usted ha sido seleccionado");
                }
                else
                {

                    Console.WriteLine("Lo sentimos pero usted no esta capacitado");

                }
                Console.WriteLine("¿Alguien mas? 1.Si 2.No");
                resp = Console.ReadLine();
                Console.Clear();
                Console.ReadKey();
            }
            Console.Clear();
            Console.WriteLine("Hasta Luego");
            Console.ReadKey();
            //Metodo PARA se escribe de la siguiente manera //
            /* b=1
             * while (b <= 5)   {
             * 
             * 
             * 
             * 
             * b=b+1
             * }
        }
    }
}
