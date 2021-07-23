using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    public class Program
    {
        static void Main(string[] args)
        {
            Carrera carrera = new Carrera();
            Materia materia = new Materia();
            Profesor profesor = new Profesor();
            Alumno alumno = new Alumno();

            OperacionesABM operacionesABM = new OperacionesABM(alumno);
            OperacionesABM operacionesABM1 = new OperacionesABM(profesor);
            OperacionesABM operacionesABM2 = new OperacionesABM(carrera);
            OperacionesABM operacionesABM3 = new OperacionesABM(materia);
            OperacionesBusqueda operacionesBusqueda = new OperacionesBusqueda(alumno);
            OperacionesBusqueda operacionesBusqueda1 = new OperacionesBusqueda(profesor);

            Console.WriteLine(operacionesBusqueda.BuscarXdni());
            Console.WriteLine(operacionesBusqueda1.BuscarXdni());
            Console.WriteLine(operacionesABM.Alta());
            Console.WriteLine(operacionesABM1.Baja());
            Console.WriteLine(operacionesABM2.Modificar());
            Console.WriteLine(operacionesABM3.Alta());
            Console.WriteLine(carrera.BuscarAlumno());
            Console.WriteLine(materia.buscarAlumno());
            Console.ReadLine();

        }
    }
}
