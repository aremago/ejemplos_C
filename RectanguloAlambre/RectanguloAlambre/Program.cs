using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectanguloAlambre
{
    class Program
    {
        static void Main(string[] args)
        {
            int lado1, lado2,resultado,importe, costo;
            Console.WriteLine("Escribe el lado mas largo del rectangulo");
            lado1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Escribe el lado corto del rectangulo");
            lado2 = Int32.Parse(Console.ReadLine());
            if(lado1 <= lado2 || lado1 < 0 || lado2 < 0 )
            {
                Console.WriteLine("Escribe valores adecuados del rectangulo");
            }
            else
            {
                Console.WriteLine("Ingresa el costo del alambre por metro");
                costo = Int32.Parse(Console.ReadLine());

                resultado = (lado1 * 2 + lado2 * 2) * 3;
                importe = resultado * costo;

                Console.WriteLine("El total de alambre que necesitaras es " + resultado +
                                    " metros" + " Costo total del alambre es " + importe);
            }
           
            Console.ReadKey();
        }
    }
}
