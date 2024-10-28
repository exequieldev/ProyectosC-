using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Proyecto_Grupo15
{
    internal class Alumno
    {
        

        public Alumno(string nombre, string dni, string telefono)
        {
            Nombre = nombre;
            Dni = dni;
            Telefono = telefono;
        }

        public string Nombre { get; set; }
        public string Dni { get; set; }
        public string Telefono { get; set; }

    }
}
