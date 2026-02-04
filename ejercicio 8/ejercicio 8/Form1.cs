namespace ejercicio_8
{
    public partial class Form1 : Form
    {
        int counter = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            counter++;
            label1.Text = counter.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            counter++;
            label1.Text = counter.ToString();   
        }
    }
}
