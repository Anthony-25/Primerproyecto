namespace ejercicio_15
{
    public partial class Form1 : Form
    {
        string rutaArchivo = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Abrir archivo de texto (* .txt) | *.txt";
            openFile.Title = "Abrir archivo de texto";

            if (openFile.ShowDialog() == DialogResult.OK)

            {
                rutaArchivo = openFile.FileName;
                txtContenido.Text = File.ReadAllText(rutaArchivo);

            }


        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (rutaArchivo == "")
            {
                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.Filter = "Archivos de texto (*.txt)|*.txt";
                saveFile.Title = "Guardar archivo de texto";

                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    rutaArchivo = saveFile.FileName;

                }
            }

            if (rutaArchivo != "")
            {
                File.WriteAllText(rutaArchivo, txtContenido.Text);
                MessageBox.Show("Archivo guardado Correctamente", "Exito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
