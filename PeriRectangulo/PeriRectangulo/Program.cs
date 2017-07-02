using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriRectangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int lado, resultado;
            int largo, ancho, radio;
            double uno = Math.PI;
            double resul;

            int diametro;
            Console.WriteLine("Ingresa un numero del 1- AL 3");
            numero = Int32.Parse(Console.ReadLine());

            if ((numero <= 0 ) || (numero >= 4))
            {
                Console.WriteLine("Numero Incorrecto");
            }

            else if (numero == 1)
            {
                Console.WriteLine("Perimetro del cuadrado");
                Console.WriteLine("Ingresa un lado del cuadrado");
                lado = Int32.Parse(Console.ReadLine());
                resultado = lado + lado + lado + lado;
                Console.WriteLine("El Perimetro del cuadrado es " + resultado);
            }

            else if (numero == 2)
            {
                Console.WriteLine("Perimetro del rectangulo");
                Console.WriteLine("Ingresa el largo");
                largo = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Ingresa el ancho");
                ancho = Int32.Parse(Console.ReadLine());

                resultado = ((largo * 2) + (ancho * 2));
                Console.WriteLine("El Perimetro del rectangulo es " + resultado);
            }
            else if (numero == 3)
            {
                Console.WriteLine("Perimetro del circulo");
                Console.WriteLine("Ingresa el radio");
                radio = Int32.Parse(Console.ReadLine());
                diametro = radio *2 ;
               
                resul= uno * diametro;
                Console.WriteLine("El perimetro del circulo es " + resul);
            }
            Console.ReadKey();
        }
    }
}
