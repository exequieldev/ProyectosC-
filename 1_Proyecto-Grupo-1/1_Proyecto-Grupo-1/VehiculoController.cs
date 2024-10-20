using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Proyecto_Grupo_1
{
    internal static class VehiculoController
    {
        public static void GuardarVehiculo(Vehiculo unVehiculo)
        {
            //Aca deberia haber algun tipo logica implementada

            //Mandamos los datos al almacenamiento
            VehiculoService.GuardarVehiculo(unVehiculo);

        }

        public static List<Vehiculo> LeerVehiculos()
        {
            List<Vehiculo> vehiculos = new List<Vehiculo>();
            vehiculos = VehiculoService.LeerProducto();
            if (vehiculos != null)
            {


                return vehiculos;
            }
            else
            {

                throw new Exception("No hay productos para mostrar");
            }
        }

    }
}
