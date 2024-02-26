using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
class Biblioteca
{
    static void Main(string[] args)
    {
        
        string tipoLibro;
        bool disponible;

        int edadUsuario;
        bool miembroPremium;
        int librosPrestados;

    
        Console.WriteLine("Ingrese el tipo de libro (ficción, no ficcion, referencia): ");
        tipoLibro = Console.ReadLine().ToLower();

        Console.WriteLine("¿El libro está disponible? (si/no): ");
        disponible = Console.ReadLine().ToLower() == "si";

        Console.WriteLine("Ingrese la edad del usuario: ");
        edadUsuario = int.Parse(Console.ReadLine());

        Console.WriteLine("¿El usuario es miembro premium? (si/no): ");
        miembroPremium = Console.ReadLine().ToLower() == "si";

        Console.WriteLine("Ingrese la cantidad de libros que el usuario tiene prestados: ");
        librosPrestados = int.Parse(Console.ReadLine());

       
        bool prestamoPermitido = false;

        if (tipoLibro == "ficcion" && disponible)
        {
            prestamoPermitido = true;
        }
        else if (tipoLibro == "no ficcion" && edadUsuario >= 18)
        {
            prestamoPermitido = true;
        }
        else if (tipoLibro == "referencia" && miembroPremium)
        {
            prestamoPermitido = true;
        }

        if (prestamoPermitido && librosPrestados < 3)
        {
            Console.WriteLine("¡El préstamo del libro está permitido!");
        }
        else
        {
            Console.WriteLine("Lo sentimos, el préstamo del libro no está permitido.");
        }
        Console.ReadKey();
    }
}
