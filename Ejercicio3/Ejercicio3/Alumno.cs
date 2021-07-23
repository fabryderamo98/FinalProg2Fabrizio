using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    public class Alumno:IABM,IBusqueda
    {
        private readonly Materia materia;
        public string nombre { get; set; }

        public string apellido { get; set; }

        public string dni { get; set; }

        public Alumno()
        {
            Carrera carrera = new Carrera();
        }

        public Alumno(Materia mat)
        {
            materia = mat;
        }

        public string Alta()
        {
            return "Dando de alta alumno";
        }

        public string Baja()
        {
            return "Dando de baja alumno";
        }

        public string BuscarXdni()
        {
            return "Buscando alumno x dni";
        }

        public string Modificar()
        {
            return "Modificando alumno";
        }
        

    }
}
