using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciclofor
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, i, y;
            int acumulador = 0 ;
            Double promedio;
            int cp=0;
            int cn=0;
            Console.Write("Cuantos numeros quieres ingresar ");
            x = Int32.Parse(Console.ReadLine());

            if(x>0)
            {
                for (i = 1; i <= x; i++)
                {
                    Console.Write("Ingresa el " + i + " numero ");
                    y = Int32.Parse(Console.ReadLine());
                    acumulador += y;
                    // Cuantos son positivos
                    if (y > 0)
                    {
                        cp++;
                    }
                    else
                    {
                        cn++;
                    }
                }
                promedio = (double)acumulador / x;


                Console.WriteLine("Los numeros ingresados suman " + acumulador);
                Console.WriteLine("El promedio de los numeros es " + promedio);
                Console.WriteLine("Valores positivos " + cp);
                Console.WriteLine("Valores negativos " + cn);

               
                
            }
            else
            {
                Console.WriteLine("Ingresa un numero positivo");
            }
            Console.Write("Presiona una tecla para terminar");
            Console.ReadKey();

        }
    }
}
