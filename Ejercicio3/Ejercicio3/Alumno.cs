using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    public class Alumno:IABM,IBusqueda
    {
        public string nombre { get; set; }

        public string apellido { get; set; }

        public string dni { get; set; }

        public string Alta()
        {
            throw new NotImplementedException();
        }

        public string Baja()
        {
            throw new NotImplementedException();
        }

        public string BuscarXdni()
        {
            throw new NotImplementedException();
        }

        public string Modificar()
        {
            throw new NotImplementedException();
        }
    }
}
