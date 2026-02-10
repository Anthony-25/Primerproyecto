using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ejercicio_5
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            if (rdbOpcion1.Checked)
                lblResultado.Text = "Opcion 1 seleccionada";
            else if (rdbOpcion2.Checked)
                lblResultado.Text = "Opcion 2 seleccionada";
            else if (rdbOpcion3.Checked)
                lblResultado.Text = "Opcion 3 seleccionada";
            else
                lblResultado.Text = "No seleccionaste ninguna opcion";

        }
    }
}
