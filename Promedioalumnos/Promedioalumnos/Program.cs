using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promedioalumnos
{
    class Program
    {
        static void Main(string[] args)
        {
            double c1 = 0; //Variable para cada una de las calificaciones
            double sc = 0; //Suma de calificaciones
            double p =0; //Promedio individual
            double sp = 0; // suma de todos los promedios
            double pg; //Promedio general
            int aa = 0, ar = 0; //
            int alumnos;
            int calif = 3;
            int x;

            Console.WriteLine("Ingresa los numeros de alumnos a calificar ");
            alumnos = Int32.Parse(Console.ReadLine());

            if (alumnos > 0)
            {
                for ( x = 1; x <= alumnos; x++)
                {
                    sc = 0;
                    for (int i = 1; i <= calif; i++)
                    {
                       
                        Console.Write("Ingresa la " + i + " calificacion del alumno " + x + "  " );
                        c1 = Double.Parse(Console.ReadLine());
                        sc += c1;
                    }
                    
                    p = (double)sc / calif;
                    Console.WriteLine("El promedio del alumno " + x + " es " + p);
                    sp += p;
                }
               
                pg = sp / alumnos;
                Console.WriteLine("El promedio general " + pg);
            
            }
            else
            {
                Console.WriteLine("Ingresa un numero positivo");
            }
            Console.ReadLine();
        }
    }
}

 