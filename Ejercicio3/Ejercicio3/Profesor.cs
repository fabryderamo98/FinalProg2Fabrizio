using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    public class Profesor:IABM,IBusqueda
    {
        public string nombre { get; set; }

        public string apellido { get; set; }

        public string dni { get; set; }

        public string Alta()
        {
            return "Dando de alta profesor";
        }

        public string Baja()
        {
            return "Dando de baja profesor";
        }

        public string BuscarXdni()
        {
            return "Buscando profesor x dni";
        }

        public string Modificar()
        {
            return "Modificando profesor";
        }
    }
}
