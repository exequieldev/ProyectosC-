namespace _3_Proyecto_Grupo_13
{
    public partial class Form1 : Form
    {
        Stack<int> pila = new Stack<int>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                if (pila.Count >= 5)
                {
                    MessageBox.Show("La pila ya est� llena. No se pueden a�adir m�s de 5 n�meros.");
                    return;
                }
                int numero = int.Parse(textBox1.Text);
                pila.Push(numero);
                MessageBox.Show("N�mero a�adido a la pila: " + numero);
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingresa un n�mero v�lido.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (pila.Count > 0)
            {

                int numeroRemovido = pila.Pop();
                MessageBox.Show("N�mero removido de la pila: " + numeroRemovido);
            }
            else
            {
                MessageBox.Show("La pila est� vac�a. No hay n�meros para quitar.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int numeroSuperio = pila.Peek();
            MessageBox.Show("El numero en la parte superior es:" + numeroSuperio);
        }
    }
}
