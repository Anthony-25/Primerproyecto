namespace ejercicio_13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            timer1.Start();

        }

        private void btnDetener_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < progressBar1.Maximum)
            {
                progressBar1.Value += 10;

            }
            else
            {
                timer1.Stop();
                MessageBox.Show("Proceso completado");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
