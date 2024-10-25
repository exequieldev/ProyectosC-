using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Proyecto_Grupo_2
{
    internal class TareaService
    {
        static string GetAppPath()
        {
            return AppContext.BaseDirectory;
        }

        public static void GuardarTarea(Tarea unaTarea)
        {
            // Se establece el nombre del archivo a escribir
            string fileName = Path.Combine(GetAppPath(),"tarea.txt");

            if (!File.Exists(fileName))
            {
                // Se crea y escribe el archivo ya que no existe
                // Se genera un StreamWriter para controlar la escritura de datos
                using (StreamWriter archivoSalida = new StreamWriter(fileName))
                {
                    // Se recorre la colección de cadenas de caracteres y se escribe al archivo
                    string data = $"{unaTarea.Tareaint}";
                    archivoSalida.WriteLine(data);


                }
            }
            else
            {
                // Se añaden datos al archivo ya que existe, para eso se establece el segundo parámetro
                using (StreamWriter archivoSalida = new StreamWriter(fileName,true))
                {
                    string data = $"{unaTarea.Tareaint}";

                    archivoSalida.WriteLine(data);
                }
            }
        }

        public static List<Tarea> LeerTarea()
        {
            // Se establece el nombre del archivo a escribir
            string fileName = Path.Combine(GetAppPath(), "tarea.txt");

            if (File.Exists(fileName))
            {
                // Se crea y escribe el archivo ya que no existe
                // Se genera un StreamWriter para controlar la escritura de datos
                //using (StreamWriter archivoEntrada = new StreamWriter(fileName))

                {
                    // Se recorre la colección de cadenas de caracteres y se escribe al archivo
                    List<Tarea> listaTarea = new List<Tarea>();
                    string[] lineas = File.ReadAllLines(fileName);


                    foreach (var productoComoTexto in lineas)
                    {
                        var datos = productoComoTexto.Split(";");

                        Tarea unaTarea = new Tarea(datos[0]);

                        listaTarea.Add(unaTarea);
                    }

                    return listaTarea;
                }


            }
            else
            {
                // Se añaden datos al archivo ya que existe, para eso se establece el segundo parámetro
                return null;

            }
        }

        public static void eliminarTarea(List <Tarea> tareas)
        {
            string fileName = Path.Combine(GetAppPath(), "tarea.txt");

            using (StreamWriter sw = new StreamWriter(fileName))
            {
                foreach (var tarea in tareas)
                {
                    sw.WriteLine(tarea.ToString());
                }
            }
        }

    }
}
