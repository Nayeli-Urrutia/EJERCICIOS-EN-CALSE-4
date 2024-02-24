using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace TEJERCICIOS_EN_CALSE_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //PROGRAMA 1


            Console.WriteLine(" Los primeros 5 numeros pares son:");

            for (int i = 2; i <= 10; i +=2)
            {
                Console.WriteLine(i);

            }
            Console.ReadKey();

            //PROGRAMA 1.2

          

            int resultado = 0;
            for(int x = 1; x<=10; x++) 
            {
                resultado = resultado + x;
              
            }
            Console.WriteLine(" La suma de los primeros 10 Número es:  " + resultado);
            Console.ReadKey();
        }
    }
}
