namespace ejercicio_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ingrese_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b, res;
            a = int.Parse(txtNum1.Text);
            b = int.Parse(txtNum2.Text);
            res = a + b;
            txtRes.Text = res.ToString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
