using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperficieCuadrado
{
    class Program
    {
        static void Main(string[] args)
        {
            int superficie, perimetro, bas;
            Console.WriteLine("Ingresa la base del Cuadrado mayor de cero y positivo");
            bas = Int32.Parse(Console.ReadLine());

            if ( bas <= 0 )
            {
                Console.WriteLine("Ingresa un numero adecuado");
            }
            else
            {
                superficie = bas * bas;
                perimetro = bas + bas + bas + bas;
                Console.WriteLine("La superficie del cuadrado de base " + bas + " es " + superficie  );
                Console.WriteLine("El Perimetro del cuadrado de base " + bas + " es " + perimetro);
            }
          
            
            Console.ReadKey();




        }
    }
}
