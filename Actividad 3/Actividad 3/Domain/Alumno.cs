using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_3.Domain
{
    internal class Alumno
    {
        string Nombre { get; set; }
        double Calificacion { get; set; }
        public Alumno(string nombre, double calificacion)
        {
            Nombre = nombre;
            Calificacion = calificacion;
        }
        public override string ToString()
        {
            return $"{Nombre}: {Calificacion}";
        }
    }
}
