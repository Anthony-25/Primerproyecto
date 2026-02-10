namespace ejercicio_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtElemento.Text))
            {
                lstElementos.Items.Add(txtElemento.Text);
                txtElemento.Clear();
                txtElemento.Focus();


            }
            else
            {
                MessageBox.Show("Ingrese un texto antes de agregar");

            }


        }
    }
}
