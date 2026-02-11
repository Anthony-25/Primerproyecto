namespace ejercicio_15
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtContenido = new TextBox();
            btnAbrir = new Button();
            btnGuardar = new Button();
            SuspendLayout();
            // 
            // txtContenido
            // 
            txtContenido.Location = new Point(229, 99);
            txtContenido.Multiline = true;
            txtContenido.Name = "txtContenido";
            txtContenido.ScrollBars = ScrollBars.Vertical;
            txtContenido.Size = new Size(206, 40);
            txtContenido.TabIndex = 0;
            // 
            // btnAbrir
            // 
            btnAbrir.Location = new Point(229, 218);
            btnAbrir.Name = "btnAbrir";
            btnAbrir.Size = new Size(75, 23);
            btnAbrir.TabIndex = 1;
            btnAbrir.Text = "Abrir";
            btnAbrir.UseVisualStyleBackColor = true;
            btnAbrir.Click += btnAbrir_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(371, 218);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(64, 23);
            btnGuardar.TabIndex = 2;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(706, 402);
            Controls.Add(btnGuardar);
            Controls.Add(btnAbrir);
            Controls.Add(txtContenido);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtContenido;
        private Button btnAbrir;
        private Button btnGuardar;
    }
}
