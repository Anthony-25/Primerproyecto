namespace ejercicio_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numero;

            if (int.TryParse(textBox1.Text, out numero))
            {
                MessageBox.Show("El valor ingresado es un numero valido:" + numero,
                                 "Correcto",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error: Debe ingresar un numero valido.",
                                 "Error",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Error);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
