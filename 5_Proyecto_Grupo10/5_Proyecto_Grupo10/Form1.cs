using Newtonsoft.Json;
using System.IO;


namespace _5_Proyecto_Grupo10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            sincronizarListado();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Crear una instancia de Persona y asignar valores desde los TextBox
            Persona persona = new Persona
            {
                Nombre = txtNombre.Text,
                Edad = int.Parse(txtEdad.Text),
                Correo = txtCorreo.Text
            };

            // Serializar el objeto Persona a JSON
            string json = JsonConvert.SerializeObject(persona, Newtonsoft.Json.Formatting.Indented);

            // Guardar el JSON en un archivo
            File.WriteAllText("persona.json", json);

            // Notificar al usuario que se guardó el archivo
            MessageBox.Show("El archivo persona.json ha sido guardado con éxito.", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            sincronizarListado();
        }

        private void sincronizarListado()
        {
            if (File.Exists("persona.json"))
            {
                // Leer el contenido del archivo JSON
                string json = File.ReadAllText("persona.json");

                // Deserializar el JSON a un objeto Persona
                Persona persona = JsonConvert.DeserializeObject<Persona>(json);

                // Limpiar el ListBox antes de agregar nuevos datos
                listBoxPersonas.Items.Clear();

                // Mostrar los datos en el ListBox
                listBoxPersonas.Items.Add("Nombre: " + persona.Nombre);
                listBoxPersonas.Items.Add("Edad: " + persona.Edad);
                listBoxPersonas.Items.Add("Correo: " + persona.Correo);
            }
            else
            {
                MessageBox.Show("El archivo persona.json no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
