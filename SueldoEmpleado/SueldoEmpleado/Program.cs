using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SueldoEmpleado
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaracio de variables
            int horas;
            double sxh, s;
            //Solicitar datos
            Console.WriteLine("Ingresa las horas trabajadas");
            horas = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el sueldo por hora");
            sxh  = Double.Parse(Console.ReadLine());
            //determinar si los valores ingresados son validos
           
            if ((horas >=0 ) && (sxh >= 0))
            {
               
                // Son validos
                s = sxh * horas;
                Console.WriteLine("EL sueldo total de las  " + horas + " horas " + " por " + " el sueldo por hora " + sxh + " es " + s + " pesos");

            }
      
            else
            {
                //No son validos
                if (horas < 0) 
                {
                    Console.WriteLine("Las horas son incorrectas");
                }
                if(sxh <= 0)
                {
                    Console.WriteLine("Error en el sueldo por hora");                }
                
            }
            Console.ReadKey();
        }
    }
}
