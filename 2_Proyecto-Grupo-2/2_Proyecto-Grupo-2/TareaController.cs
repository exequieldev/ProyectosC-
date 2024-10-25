using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.MonthCalendar;

namespace _2_Proyecto_Grupo_2
{
    internal class TareaController
    {

        // Este es nuestro controlador del negocio
        public static void GuardarTarea(Tarea unTarea)
        {
            
            TareaService.GuardarTarea(unTarea);

        }

        public static List<Tarea> LeerTarea()
        {
            List<Tarea> tarea = new List<Tarea>();

            tarea = TareaService.LeerTarea();

            if (tarea != null)
            {
                return tarea;
            }
            else
            {
                throw new Exception("No hay productos para mostrar");
            }
        }

        public static void eliminarTarea(string nombreTarea)
        {
            List<Tarea> tareas = new List<Tarea>();
            //List<Tarea> tareaEliminar = new List<Tarea>();

            tareas = TareaService.LeerTarea();

            var unaTarea = tareas.FirstOrDefault(t => t.Tareaint == nombreTarea);
            

            if (unaTarea != null)
            {
                
                tareas.Remove(unaTarea);

                TareaService.eliminarTarea(tareas);
            }
            
        }

    }
}
