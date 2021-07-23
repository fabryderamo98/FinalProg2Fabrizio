using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    public class OperacionesBusqueda : IBusqueda
    {
        private readonly IBusqueda _operacionesbusqueda;

        public OperacionesBusqueda(IBusqueda operacionesbusqueda)
        {
            _operacionesbusqueda = operacionesbusqueda;
        }
        public string BuscarXdni()
        {
            return _operacionesbusqueda.BuscarXdni();
        }
    }
}
