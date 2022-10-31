using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Entrevistar 3 personas indique:
             * 1.Total de mujeres
             * 2.Total de hombres
             * 3. total de entrevistados
             * */
            int x = 1;
            string ci = null, name = null, age = null;
            int sex = 0, th = 0, tm = 0;
            while (x <= 3)
            {
                
                Console.WriteLine("Buenos dias indique su numero de C.I");
                ci = Console.ReadLine();
                Console.WriteLine("Ingrese su nombre");
                name = Console.ReadLine(); 
                Console.WriteLine(name + " ¿Que edad tiene?");
                age = Console.ReadLine();
                Console.WriteLine("Indique su Sexo: 1.Masculino 2.Femenino");
                sex = int.Parse(Console.ReadLine());
                if (sex == 1)
                {
                    th++;
                }
                else {  tm++; 
                } 
                x = x + 1;
                Console.ReadKey();
                Console.Clear();
            }
            Console.WriteLine("Total de Hombres: " + th);
            Console.WriteLine("Total de Mujeres " + tm);
            Console.ReadKey();
        }
    }
}
