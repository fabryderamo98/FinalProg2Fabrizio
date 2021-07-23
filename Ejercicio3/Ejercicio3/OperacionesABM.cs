using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    public class OperacionesABM:IABM
    {
        private readonly IABM _operacionesABM;

        public OperacionesABM(IABM operacionesABM)
        {
            _operacionesABM = operacionesABM;
        }

        public string Alta()
        {
            return _operacionesABM.Alta();
        }

        public string Baja()
        {
            return _operacionesABM.Baja();
        }

        public string Modificar()
        {
            return _operacionesABM.Modificar();
        }
    }
}
