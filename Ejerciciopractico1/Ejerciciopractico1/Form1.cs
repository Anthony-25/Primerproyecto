namespace Ejerciciopractico1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre_matricula = textBox1.Text;
            string mensaje = ("Hola " + nombre_matricula + ". Bienvenid@ a la Clase de Lenguaje de Programacion.!!");
            MessageBox.Show(mensaje, "Informacion", MessageBoxButtons.OK);
        }
    }
}
