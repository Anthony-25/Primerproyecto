namespace ejercicio_12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            double celsius;
            if (double.TryParse(txtCelsius.Text, out celsius))
            {
                double fahreint = (celsius * 9 / 5) + 32;
                lblResultado.Text = $"{celsius} °C son {fahreint} °F";

            }
            else
            {
                MessageBox.Show("por favor, ingrese un número válido para los grados Celsius." +
                    "", "Entrada no válida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
