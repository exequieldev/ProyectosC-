namespace _1_Proyecto_Grupo_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            sincronizarListado();
        }

        private void botton1_Click(object sender, EventArgs e)
        {
            string due�o = textDue�o.Text;
            string a�o = textA�o.Text;
            string marca = textMarca.Text;
            int precio = int.Parse(textPrecio.Text);

            //Cremos un objeto de tipo vehiculo

            Vehiculo unVehiculo = new Vehiculo(due�o,a�o,marca,precio);

            //Lllamamamos a la funcion para agregar el vehiculo
            VehiculoController.GuardarVehiculo(unVehiculo);
        }

        private void sincronizarListado()
        {
            this.lstVehiculos.Items.Clear();
            List<Vehiculo>ListaVehiculos = new List<Vehiculo>();
           //ist<Producto> ListaProductos = new List<Producto>();

            try
            {
                ListaVehiculos = VehiculoController.LeerVehiculos();
                foreach (var producto in ListaVehiculos)
                {
                    this.lstVehiculos.Items.Add(producto);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Hubo un error en la lectura de productos");
            }
        }
    }
}
