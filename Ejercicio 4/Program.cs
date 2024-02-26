using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

//EJERCICIO 4
namespace GraduacionEstudiante
{
    class Estudiante
    {
        private string nombre;
        private List<Asignatura> asignaturas;
        private double promedioGeneral;
        private bool sancionado;

        public Estudiante(string nombre)
        {
            this.nombre = nombre;
            this.asignaturas = new List<Asignatura>();
            this.promedioGeneral = 0.0;
            this.sancionado = false;
        }

        public void AgregarAsignatura(string nombre, double calificacion)
        {
            asignaturas.Add(new Asignatura(nombre, calificacion));
        }

        public void CalcularPromedioGeneral()
        {
            double totalCalificaciones = 0.0;
            foreach (Asignatura asignatura in asignaturas)
            {
                totalCalificaciones += asignatura.Calificacion;
            }
            promedioGeneral = totalCalificaciones / asignaturas.Count;
        }

        public bool PuedeGraduarse()
        {
            return !sancionado && promedioGeneral >= 70.0 && AsignaturasAprobadas() == asignaturas.Count;
        }

        private int AsignaturasAprobadas()
        {
            int count = 0;
            foreach (Asignatura asignatura in asignaturas)
            {
                if (asignatura.Calificacion >= 60.0)
                {
                    count++;
                }
            }
            return count;
        }

        public override string ToString()
        {
            string mensaje = $"Nombre: {nombre}\n";
            mensaje += $"Promedio general: {promedioGeneral:F2}\n";
            mensaje += $"Sancionado: {(sancionado ? "Sí" : "No")}\n";
            mensaje += $"Aprobadas: {AsignaturasAprobadas()} / {asignaturas.Count}\n";
            mensaje += $"Puede graduarse: {(PuedeGraduarse() ? "Sí" : "No")}\n";
            return mensaje;
        }
    }

    class Asignatura
    {
        private string nombre;
        private double calificacion;

        public Asignatura(string nombre, double calificacion)
        {
            this.nombre = nombre;
            this.calificacion = calificacion;
        }

        public string Nombre { get => nombre; }
        public double Calificacion { get => calificacion; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Estudiante estudiante = new Estudiante("Juan Pérez");
            estudiante.AgregarAsignatura("Matemáticas", 85.0);
            estudiante.AgregarAsignatura("Lenguaje", 90.0);
            estudiante.AgregarAsignatura("Ciencia", 75.0);
            estudiante.AgregarAsignatura("Historia", 65.0);

            estudiante.CalcularPromedioGeneral();

            Console.WriteLine(estudiante);
            Console.ReadLine();
        }
    }
}
