using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Proyecto_Grupo_2
{
    internal class Tarea
    {

        private string _tarea;

        public Tarea(string tarea) {
        
            _tarea = tarea;
        
        }

        public string Tareaint
        {

            get { return _tarea; }
            set
            {
                if (value != String.Empty)
                {
                    _tarea = value;
                }
            }
        }

        public override string ToString()
        {
            return $"{Tareaint}";
        }



    }
}
