using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ciclos
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, i, c;
            int N = 5;
            // Ciclo for
            for(i=0; i>N;i++)
            {
                Console.WriteLine("Ingresa el valos");
                x = Int32.Parse(Console.ReadLine());
            }

            // Ciclo do while
            c = 0;
            do
            {
                Console.WriteLine("Ingresa el valos");
                x = Int32.Parse(Console.ReadLine());

                c++;
            } while (c<N);

            // Ciclo while
            int d = 0;
            while (c < N) ;
            {
                Console.WriteLine("Ingresa el valos");
                x = Int32.Parse(Console.ReadLine());

                d++;
            }
        }


    }
}
