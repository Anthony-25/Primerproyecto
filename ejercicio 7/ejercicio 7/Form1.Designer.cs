namespace ejercicio_7
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
            txtElemento = new TextBox();
            lstElementos = new ListBox();
            btnAgregar = new Button();
            SuspendLayout();
            // 
            // txtElemento
            // 
            txtElemento.Location = new Point(266, 136);
            txtElemento.Name = "txtElemento";
            txtElemento.Size = new Size(100, 23);
            txtElemento.TabIndex = 0;
            // 
            // lstElementos
            // 
            lstElementos.FormattingEnabled = true;
            lstElementos.Location = new Point(266, 165);
            lstElementos.Name = "lstElementos";
            lstElementos.Size = new Size(120, 94);
            lstElementos.TabIndex = 1;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(392, 200);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAgregar);
            Controls.Add(lstElementos);
            Controls.Add(txtElemento);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtElemento;
        private ListBox lstElementos;
        private Button btnAgregar;
    }
}
