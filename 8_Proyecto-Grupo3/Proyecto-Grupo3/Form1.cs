using System.Data;

namespace Proyecto_Grupo3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Realiza una conexion asincrona, utilizado la clase Conexion.
        private async void button1_Click(object sender, EventArgs e)
        {
            Conexion miConexion = new Conexion();

            conn = await miConexion.establecerConexionAsyn();

            if (conn?.State == ConnectionState.Open) {

                MessageBox.Show("Conexion establecida");

            }
        }
    }
}
