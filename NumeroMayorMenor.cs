using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;

            Console.WriteLine("Numero mayor y numero menor");

            Console.WriteLine("Ingresa el 1er. Numero ");
            a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa el 2do. Numero");
            b = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa el 3er. Numero");
            c = Int32.Parse(Console.ReadLine());

            if ((a > b) && (a > c)) 

            {
                Console.WriteLine("El mayor es el numero " + a);
            }
            else  if((b > c) && (b > a))

            {
                Console.WriteLine("El mayor es el numero " + b);
            }
             else 

            {
                Console.WriteLine("El mayor es el numero " + c);
            }
             if ((a < b) && (a < c))

            {
                Console.WriteLine("El menor es el numero " + a);
            }
            else if ((b < c) && (b < a))

            {
                Console.WriteLine("El menor es el numero " + b);
            }
            else 

            {
                Console.WriteLine("El menor es el numero " + c);
            }
            Console.ReadKey();
        }
    }
}