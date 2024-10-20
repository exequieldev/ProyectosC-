using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Proyecto_Grupo_1
{
    internal static class VehiculoService
    {
        static string GetAppPath()
        {
            return AppContext.BaseDirectory;
        }

        public static void GuardarVehiculo(Vehiculo unVehiculo)
        {
            // Se establece el nombre del archivo a escribir
            string fileName = Path.Combine(GetAppPath(), "datos.txt");

            if (!File.Exists(fileName))
            {
                // Se crea y escribe el archivo ya que no existe
                // Se genera un StreamWriter para controlar la escritura de datos
                using (StreamWriter archivoSalida = new StreamWriter(fileName))
                {
                    // Se recorre la colección de cadenas de caracteres y se escribe al archivo
                    string data = $"{unVehiculo.Dueño};{unVehiculo.Año}, {unVehiculo.Marca}, {unVehiculo.Precio}";
                    archivoSalida.WriteLine(data);


                }
            }
            else
            {
                // Se añaden datos al archivo ya que existe, para eso se establece el segundo parámetro
                using (StreamWriter archivoSalida = new StreamWriter(fileName, true))
                {
                    string datos = $"{unVehiculo.Dueño};{unVehiculo.Año};{unVehiculo.Marca};{unVehiculo.Precio}";
                    archivoSalida.WriteLine(datos);
                }
            }
        }

        public static List<Vehiculo> LeerProducto()
        {
            // Se establece el nombre del archivo a escribir
            string fileName = Path.Combine(GetAppPath(), "datos.txt");

            if (File.Exists(fileName))
            {
                // Se crea y escribe el archivo ya que no existe
                // Se genera un StreamWriter para controlar la escritura de datos
                //using (StreamWriter archivoEntrada = new StreamWriter(fileName))

                {
                    // Se recorre la colección de cadenas de caracteres y se escribe al archivo
                    List<Vehiculo> listaVehiculos = new List<Vehiculo>();
                    string[] lineas = File.ReadAllLines(fileName);


                    foreach (var productoComoTexto in lineas)
                    {
                        var datos = productoComoTexto.Split(";");
                        Vehiculo unVehiculo = new Vehiculo(datos[0],datos[1],datos[2],int.Parse(datos[3]));
                        listaVehiculos.Add(unVehiculo);
                    }

                    return listaVehiculos;
                }


            }
            else
            {
                // Se añaden datos al archivo ya que existe, para eso se establece el segundo parámetro
                return null;

            }
        }
    }
}
