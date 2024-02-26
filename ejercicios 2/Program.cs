using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicios_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //PROGRAMA 2
            int numero1;
            int numero2=0;

            Console.WriteLine("2.Ingrese Un Número Negativo si quiere salir del bucle");
            do
            {

                Console.WriteLine(" Un Número Positivo");
                 numero1 = int.Parse(Console.ReadLine());
                if( numero1>=0)
                {
                    numero2 += numero1;
                }

            } while (numero1 >= 0);
            Console.WriteLine(" La suma es " + numero2);

            Console.ReadKey();

            //PROGRAMA 2.1
            int divisor1 = 7;
            int divisor2 = 11;

            int numero=0;

            Console.WriteLine("El numero divisible entre 7 y 11 es:");

            while (true)
            {
                for (numero  = 1; numero <= 100; numero++) 
                {

                    if (numero % divisor1 == 0 && numero % divisor2 == 0)
                    {
                        Console.WriteLine($" {numero}");

                    }
                
                }
                Console.ReadKey();
            }
         
        }

    }
}
