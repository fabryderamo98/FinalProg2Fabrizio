using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    public class Carrera:IABM
    {
        public string nomCarrera { get; set; }

        public string Alta()
        {
            return "Dando de alta carrera";
        }

        public string Baja()
        {
            return "Dando de baja carrera";
        }

        public string Modificar()
        {
            return "Modificando carrera";
        }
    }
}
