using System.Xml.Serialization;

namespace _6_Proyecto_Grupo5
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
            Persona persona = new Persona
            {
                Nombre = txtNombre.Text,
                Edad = int.Parse(txtEdad.Text),
                Correo = txtCorreo.Text
            };

            // Llamar al método para guardar en XML
            GuardarEnXML(persona);
            sincronizarListado();
        }

        private void GuardarEnXML(Persona persona)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Persona));
            using (FileStream fs = new FileStream("persona.xml", FileMode.Create))
            {
                serializer.Serialize(fs, persona);
            }
            MessageBox.Show("El archivo persona.xml ha sido guardado con éxito.", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private Persona CargarDesdeXML()
        {
            if (File.Exists("persona.xml"))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Persona));
                using (FileStream fs = new FileStream("persona.xml", FileMode.Open))
                {
                    return (Persona)serializer.Deserialize(fs);
                }
            }
            else
            {
                MessageBox.Show("El archivo persona.xml no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private void sincronizarListado()
        {
            // Llamar al método para cargar desde XML
            Persona persona = CargarDesdeXML();

            // Si la persona es null (por ejemplo, si no existe el archivo), no hacer nada más
            if (persona == null) return;

            // Limpiar el ListBox antes de agregar nuevos datos
            listBoxPersonas.Items.Clear();

            // Mostrar los datos en el ListBox
            listBoxPersonas.Items.Add("Nombre: " + persona.Nombre);
            listBoxPersonas.Items.Add("Edad: " + persona.Edad);
            listBoxPersonas.Items.Add("Correo: " + persona.Correo);
        }


    }
}
