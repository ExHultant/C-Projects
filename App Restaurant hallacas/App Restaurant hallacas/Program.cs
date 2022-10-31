using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Restaurant_hallacas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int resp=1, pg_hc, pg_bb, opc, opc1, opc2, pthc=0, ptbb=0, mt=0, hc, bb, incre, desc, ta=0, mtincre = 0;
            Console.WriteLine("Bienvenido al Sistema de Hallacas Ramon");
            Console.WriteLine("Ingrese el precio de las hallacas");
            hc = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el precio de las bebidas");
            bb = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el porcentaje de incremento");
            incre = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el porcentaje de descuento");
            desc = int.Parse(Console.ReadLine());
            Console.Clear();
            while (resp==1) {
                Console.WriteLine("Bienvenido a Hallacas Ramon");
                Console.WriteLine("¿Cuantas Hallacas desea? El precio de las hallacas: " + hc + " Bs.S");
                pg_hc = int.Parse(Console.ReadLine());
                Console.WriteLine("Usted pedio " + pg_hc + " Hallacas");
                Console.WriteLine("¿Esta seguro de su pedido? 1.Si 2.No");
                opc = int.Parse(Console.ReadLine());
                switch (opc)
                {
                    case 2:
                        Console.WriteLine("¿Cuantas Hallacas desea? El precio de las hallacas: " + hc + " Bs.S");
                        pg_hc = int.Parse(Console.ReadLine());
                        break;
                    default:
                        break;
                }
                Console.WriteLine("¿Cuantas Bebidas desea? El precio de las bebidas: " + bb + " Bs.S");
                pg_bb = int.Parse(Console.ReadLine());
                Console.WriteLine("Usted pedio " + pg_bb + " Bebidas");
                Console.WriteLine("¿Esta seguro de su pedido?  1.Si  2.No");
                opc1 = int.Parse(Console.ReadLine());
                switch (opc1)
                {
                    case 2:
                        Console.WriteLine("¿Cuantas Bebidas desea, El precio de las bebidas: " + bb + " Bs.S");
                        pg_hc = int.Parse(Console.ReadLine());
                        break;
                    default:
                        break;
                }
                if (pg_hc > 4)
                {
                    pthc = hc * pg_hc - desc / 100; 
                    Console.WriteLine("Por usted hacer una compra mayor a 4 Hallacas se le hara un descuento de:");
                }
                pthc = hc * pg_hc;
                ptbb = bb * pg_bb;
                mt = ptbb + pthc;
                Console.WriteLine("El monto de las Hallacas es: " + pthc + " Bs.S");
                Console.WriteLine("El monto de las Bebidas es: " + ptbb + " Bs.S");
                Console.WriteLine("El monto total a pagar es: " + mt + " Bs.S");
                Console.WriteLine("NOTA: Si usted hizo una compra mayor a 4 hallacas automaticamente nuestro sistema le hace un descuento a su compra");
                Console.WriteLine("¡Muchas gracias por su compra!");
                Console.WriteLine("¿Como deseara pagar? 1.Tarjeta de Credito 2.Tarjeta de Debito 3.Efectivo");
                Console.WriteLine("Al pagar por tarjeta de credito se le incrementara un porcentaje preestablecido");
                opc2 = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (opc2)
                {
                    case 1:
                        mtincre = ptbb + pthc + incre;
                        Console.WriteLine("Al ingresar por tarjeta de credito se le incremetara un " + incre + "%");
                        Console.WriteLine("El monto de las Hallacas es: " + pthc + " Bs.S");
                        Console.WriteLine("El monto de las Bebidas es: " + ptbb + " Bs.S");
                        Console.WriteLine("El monto total a pagar es: " + mtincre + " Bs.S");
                        break;
                    case 2:
                        Console.WriteLine("El monto de las Hallacas es: " + pthc + " Bs.S");
                        Console.WriteLine("El monto de las Bebidas es: " + ptbb + " Bs.S");
                        Console.WriteLine("El monto total a pagar es: " + mt + " Bs.S");
                        break;
                    case 3:
                        Console.WriteLine("El monto de las Hallacas es: " + pthc + " Bs.S");
                        Console.WriteLine("El monto de las Bebidas es: " + ptbb + " Bs.S");
                        Console.WriteLine("El monto total a pagar es: " + mt + " Bs.S");
                        break;
                    default:
                        Console.WriteLine("Seleccione alguna opcion");
                        break;
                }
                Console.WriteLine("¿Alguien mas? 1.Si 2.No");
                resp = int.Parse(Console.ReadLine());
                Console.Clear();
            }
            ta = mt++;
            Console.WriteLine("El total del dia acumulado fue de: "+ ta + " Bs.S");
            Console.WriteLine("Hasta Luego");
            Console.ReadKey();
        }
    }
}
