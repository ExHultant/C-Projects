using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercises_1_C
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ci, name, infor, semest, turn;
            int resp = 1, prom, ts = 0, tns = 0;
            while (resp == 1)
            {
                Console.WriteLine("Buenos dias Bienvenido a nuestro sistema de Seleccion");
                Console.WriteLine("Ingrese su C.I");
                ci = Console.ReadLine();
                Console.WriteLine("Ingrese su Nombre y Apellido");
                name = Console.ReadLine();
                Console.WriteLine("¿Es Estudiante de Informatica? 1.Si 2.No");
                infor = Console.ReadLine();
                if (infor == "1")
                {
                    Console.WriteLine("¿Eres Cursante del 2do y 4to Semestre? 1.Si 2.No");
                    semest = Console.ReadLine();
                    if(semest == "1")
                    {
                        Console.WriteLine("¿Dispones de los turnos? 1.Mañana 2.Tarde");
                        turn = Console.ReadLine();
                        Console.WriteLine("Ingrese su promedio de notas Cursando como programador");
                        prom = int.Parse(Console.ReadLine());
                        if (prom >= 15)
                        {
                            Console.WriteLine(name + " Usted ha sido seleccionado");
                            ts++;
                        }
                        else
                        {
                            Console.WriteLine("Disculpe pero no esta apto, le recomendamos subir su nota");
                            tns++;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Disculpe pero usted no es puede seguir en la seleccion");
                        tns++;
                    }
                }
                    else
                    {
                        Console.WriteLine("Lo sentimos pero no puede seguir con la prueba");
                    }
                    
                Console.WriteLine("¿Otro estudiante? 1.Si 2.No");
                resp = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("El total de seleccionados es:" + ts);
            Console.WriteLine("El total de no seleccionados es:" + tns);
            
            Console.ReadKey();

        }
    }
}
