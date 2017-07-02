using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioDoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            double c1 = 0; //Variable para cada una de las calificaciones
            double sc = 0; //Suma de calificaciones
            int alumnos =0;
            int a =1; 
           
            int x = 1;
            double p = 0;
            double pg; //Promedio general
            double sp = 0; // suma de todos los promedios
            
            int aa = 0, ar = 0; //

            int calif = 3;
            Console.WriteLine("Ingresa los numeros de alumnos a calificar ");
            alumnos = Int32.Parse(Console.ReadLine());
            do
            {
                sc = 0;

                for (int i = 1; i <= calif; i++)

                {
                    Console.Write("Ingresa la " + i + " calificacion del alumno " + a + "  " );
                    c1 = Double.Parse(Console.ReadLine());
                    sc += c1;
                }

                p = (double) sc / calif;
                Console.WriteLine("El promedio del alumno " + a + " es " + p);
                sp += p;
                a++;
            } while (a <= alumnos);

            pg = sp / alumnos;

            Console.WriteLine("El promedio general " + pg);
            Console.ReadLine();
        }
        
    }
}
