namespace ejercicio_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void button6_MouseClick(object sender, MouseEventArgs e)
        {
            this.BackColor = Color.CadetBlue;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.Yellow;
        }

        private void button5_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;   
        }
    }
}
