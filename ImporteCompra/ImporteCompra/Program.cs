using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImporteCompra
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int coca, gansito, sabrita;
            int producto,cantidad,pago;
            float subtotal, importe;
            float iva;

            Console.WriteLine("P R O D U C T O S");
            Console.WriteLine("1.- Coca-Cola $15");
            Console.WriteLine("2.- Gansito $10");
            Console.WriteLine("3.- Sabrita $20");
            Console.WriteLine("Selecciona tu producto");
            producto = Int32.Parse(Console.ReadLine());

           
            if (producto  == 0 || producto >= 4)
            {
                Console.WriteLine("INGRESA UN NUMERO ELEGIBLE ");
            }
            
            
            else if (producto == 1)
            {
                    Console.WriteLine("Cuantos productos quieres");
                    cantidad = Int32.Parse(Console.ReadLine());
                    coca = 15;
                    pago = coca * cantidad;
                    iva = 16;
                    subtotal = (iva / 100) * pago;
                    importe = pago - subtotal;
                    Console.WriteLine("EL Subtotal es " + importe);
                    Console.WriteLine("EL iva es " + subtotal);
                    Console.WriteLine("EL total de tus Coca-Cola es " + pago);
                   
            }

            else if (producto == 2)
            {
                Console.WriteLine("Cuantos productos quieres");
                cantidad = Int32.Parse(Console.ReadLine());
                gansito = 10;
                pago = gansito * cantidad;
                iva = 16;
                subtotal = (iva / 100) * pago;
                importe = pago - subtotal;
                Console.WriteLine("EL Subtotal es " + importe);
                Console.WriteLine("EL iva es " + subtotal);
                Console.WriteLine("EL total de tus Gansitos es " + pago);
                   
            }

            else if(producto == 3)
              {
                Console.WriteLine("Cuantos productos quieres");
                cantidad = Int32.Parse(Console.ReadLine());
                sabrita = 20;
                pago = sabrita * cantidad;
                iva = 16;
                subtotal = (iva / 100) * pago;
                importe = pago - subtotal;
                Console.WriteLine("EL Subtotal es " + importe);
                Console.WriteLine("EL iva es " + subtotal);
                Console.WriteLine("EL total de tus Sabritas es " + pago);
                   
               }
            
            Console.ReadKey();
          
        }
    }
}
