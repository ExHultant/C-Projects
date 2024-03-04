using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excersices_2_C
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name, ci, student;
            int  admin, admin2, age, te, ts = 0, tns = 0, resp = 1;
            Console.WriteLine("Cuantas personas para entrevistar en turno de mañana");
            admin = int.Parse(Console.ReadLine());
            Console.WriteLine("Cuantas personas para entrevistar en turno de la tarde");
            admin2 = int.Parse(Console.ReadLine());
            while (resp == 1);
            {
                Console.WriteLine("Buenos dias Bienvenido a nuestro sistema de Seleccion");
                Console.WriteLine("Por favor ingrese su Nombre y apellido");
                name = Console.ReadLine();
                Console.WriteLine("Por favor ingrese su C.I");
                ci = Console.ReadLine();
                Console.WriteLine(name + "Usted es Estudiante de: 1.Informatica 2.Computacion 3.Ninguna");
                student = Console.ReadLine();
                Console.WriteLine(name + "Usted dispone de turnos como : 1.Mañana 2.Tarde 3.Noche");
                student = Console.ReadLine();
                Console.WriteLine(name + "¿Que edad tiene?");
                age = int.Parse(Console.ReadLine());
                if (student == "1" || student == "2" && age >= 18 && age <= 30)
                {
                    ts = ts++;
                    Console.WriteLine("Usted ha sido Seleccionado");
                }
                else
                {
                    Console.WriteLine("Lo sentimos pero usted no puede ser seleccionado");
                    tns++;
                }
                te=ts+tns;
            }
            Console.WriteLine("Total de Seleccionados: " + ts);
            Console.WriteLine("Total de no Seleccionados " + tns);
            Console.WriteLine("Total de entrevistados " + te);
            Console.ReadKey();
        }
    }
}
