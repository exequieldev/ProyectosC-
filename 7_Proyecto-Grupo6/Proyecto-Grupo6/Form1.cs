namespace Proyecto_Grupo6
{
    public partial class Form1 : Form
    {

        private Geometria calculator = new Geometria();

        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.AddRange(new string[] { "C�rculo", "Cuadrado", "Rect�ngulo", "Tri�ngulo" });
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //Te permite filtrar a traves del nombre de la figura, cual calculo debes utilizar
        private void button1_Click(object sender, EventArgs e)
        {
            string figuraSeleccionada = comboBox1.SelectedItem.ToString();
            double resultado = 0;

            try
            {
                switch (figuraSeleccionada)
                {
                    case "C�rculo":
                        double radio = double.Parse(Area.Text);
                        resultado = calculator.CalcularAreaCirculo(radio);
                        break;

                    case "Cuadrado":
                        double lado = double.Parse(Area.Text);
                        resultado = calculator.CalcularAreaCuadrado(lado);
                        break;

                    case "Rect�ngulo":
                        double baseRect = double.Parse(textBoxBase.Text);
                        double alturaRect = double.Parse(textBoxAltura.Text);
                        resultado = calculator.CalcularAreaRectangulo(baseRect, alturaRect);
                        break;

                    case "Tri�ngulo":
                        double baseTri = double.Parse(textBoxBase.Text);
                        double alturaTri = double.Parse(textBoxAltura.Text);
                        resultado = calculator.CalcularAreaTriangulo(baseTri, alturaTri);
                        break;
                }

                Area.Text = $"�rea: {resultado:F2}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingresa valores num�ricos v�lidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
