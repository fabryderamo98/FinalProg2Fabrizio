using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    public class Materia:IABM
    {
        public string nomMateria { get; set; }

        public string Alta()
        {
            return "Dando de alta materia";
        }

        public string Baja()
        {
            return "Dando de baja materia";
        }

        public string Modificar()
        {
            return "Modificando Materia";
        }
    }
}
