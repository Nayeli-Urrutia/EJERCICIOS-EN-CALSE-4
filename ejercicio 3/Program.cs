using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //EJERCICIO 3.1
      
            string contraseña;
            string contraseñacorrecta = "jutiapa";
            
                         

            do
            {
                Console.WriteLine(" Ingresar Contraseña: ");
                contraseña = Console.ReadLine();
              
            } while (contraseña !=contraseñacorrecta);
            

                Console.WriteLine("¡CONTRASEÑA CORRECTA!");
          

            Console.ReadKey();

            //EJERCICIO 3.2
           
            Random random = new Random();
            int numeroAleatorio = random.Next(1, 101);

            
            int adivinanza;
            bool adivinado = false;
            while (!adivinado)
            {
                
                Console.WriteLine("Introduce un número entre 1 y 100: ");
                adivinanza = int.Parse(Console.ReadLine());

               
                if (adivinanza < numeroAleatorio)
                {
                    Console.WriteLine("El número es más grande.");
                }
                else if (adivinanza > numeroAleatorio)
                {
                    Console.WriteLine("El número es más pequeño.");
                }
                else
                {
                    adivinado = true;
                }
            }

         
            Console.WriteLine("¡Felicidades! Has adivinado el número correctamente.");
            Console.ReadKey();
        }
    }

}
    

