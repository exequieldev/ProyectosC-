using System.Windows.Forms;

namespace _2_Proyecto_Grupo_2
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
            string textTarea = txtTarea.Text;


            Tarea unaTarea = new Tarea(textTarea);


            TareaController.GuardarTarea(unaTarea);
            sincronizarListado();
        }

        private void sincronizarListado()
        {
            this.lstTarea.Items.Clear();
            List<Tarea> ListaTareas = new List<Tarea>();

            try
            {
                ListaTareas = TareaController.LeerTarea();

                foreach (var tarea in ListaTareas)
                {
                    this.lstTarea.Items.Add(tarea);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Hubo un error en la lectura de productos");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (lstTarea.SelectedIndex != -1)  // Verificar si hay un elemento seleccionado
            {
                string tareaSel = lstTarea.SelectedItem.ToString();
                
                
                // Eliminar el elemento del ListBox
                lstTarea.Items.RemoveAt(lstTarea.SelectedIndex);

                // Eliminar del archivo usando el gestor
                TareaController.eliminarTarea(tareaSel);
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un elemento para eliminar.");
            }
            sincronizarListado();
        }
    }
}
