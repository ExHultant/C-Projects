using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercises_Methods_1
{
    internal class Program
    {
        static int tpe(int ne)
        {
            int pe = 0;
            Console.WriteLine("¿Cuantas Empanadas desea? Empanadas: 15 Bolos");
            ne=int.Parse(Console.ReadLine());
            pe = ne * 15;

            return pe;
        }
        static int tpb(int nb)
        {
            int pb = 0;
            Console.WriteLine("¿Cuantas Bebidas desea? Bebidas: 9 Bolos");
            nb = int.Parse(Console.ReadLine());
            pb = nb * 9;
            return pb;
        }
        static int tbasico(int pe1,int pb1)
        {
            int mt = 0;
            mt = pe1 + pb1;
            
            
            return mt;
        }
        static int desc(int tb1)
        {
            int tdesc = 0;
            if (tb1 > 50)
            {
                tdesc = tb1 * 25 / 100;
            }
            else
            {
                tdesc = 0;
            }
            
            return tdesc;
        }
        static void Main(string[] args)
        {
            /*Desarrolle una aplicacion empleando metodos que 
            retornen valores que permitan calcular y mostrar lo 
            que pagara un cliente por la posible compra de 
            empanadas y bebidas si el consumo sobrepasa los 50bs
            habra un descuento de 25%.
            Precios: Empanadas 15, bebidas 9 */
            int ne = 0, pe1 = 0, pb1 = 0, nb = 0, tb1 = 0, desc1 = 0, mt = 0;
            pe1 = tpe(ne);
            pb1 = tpb(nb);
            tb1 = tbasico(pe1, pb1);
            desc1 = desc(tb1);
            Console.WriteLine("Total a pagar empanadas " + pe1 +  " Bolos");
            Console.WriteLine("Total a pagar Bebidas " + pb1 + " Bolos");
            Console.WriteLine("Total a pagar " + tb1 + " Bolos");
            Console.WriteLine("Descuento total es de: " + desc1 + " Bolos");
            mt = tb1 - desc1;
            Console.WriteLine("El total a pagar de todo mas el descuento es: " + mt + " Bolos :D");
            Console.ReadKey();
        }
    }
}
