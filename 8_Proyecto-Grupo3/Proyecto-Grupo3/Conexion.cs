using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Collections.Specialized;
using System.Windows.Forms;

namespace Proyecto_Grupo3
{
    internal class Conexion
    {
        private SqlConnection conec = new SqlConnection();

        private const string puerto = "1234";

        private readonly string servidor = "servidorpeliculas.database.windows";

        private readonly string bd = "Peliculas";

        private readonly string usuario = "adminsql";

        private readonly string clave = "Seminario2";

        
        //Define la coenxion asincrona con las credenciales, para conextar a la base de datos
        public async Task<SqlConnection> establecerConexionAsyn()
        {

            try
            {
                string cadenaConexion = $"Data Source={servidor};" +
                                        $"User ID={usuario}" +
                                        $"Password={clave}" +
                                        $"initial Catalogo={bd}" +
                                        "Persist Security info =true;" +
                                        "Pooling=false";

                conec.ConnectionString = cadenaConexion;
                await conec.OpenAsync();
                MessageBox.Show("Se establecio la conexion con la base de datos");

            }
            catch (SqlConnection e) {
                MessageBox.Show("No establecio la conexion con la base de datos");
            }
        }
    }
}
