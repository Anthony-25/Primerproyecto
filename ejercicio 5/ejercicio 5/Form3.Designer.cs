namespace ejercicio_5
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            rdbOpcion1 = new RadioButton();
            rdbOpcion2 = new RadioButton();
            rdbOpcion3 = new RadioButton();
            btnAceptar = new Button();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // rdbOpcion1
            // 
            rdbOpcion1.AutoSize = true;
            rdbOpcion1.Location = new Point(146, 89);
            rdbOpcion1.Name = "rdbOpcion1";
            rdbOpcion1.Size = new Size(73, 19);
            rdbOpcion1.TabIndex = 0;
            rdbOpcion1.TabStop = true;
            rdbOpcion1.Text = "Opcion 1";
            rdbOpcion1.UseVisualStyleBackColor = true;
            // 
            // rdbOpcion2
            // 
            rdbOpcion2.AutoSize = true;
            rdbOpcion2.Location = new Point(224, 128);
            rdbOpcion2.Name = "rdbOpcion2";
            rdbOpcion2.Size = new Size(73, 19);
            rdbOpcion2.TabIndex = 1;
            rdbOpcion2.TabStop = true;
            rdbOpcion2.Text = "Opcion 2";
            rdbOpcion2.UseVisualStyleBackColor = true;
            // 
            // rdbOpcion3
            // 
            rdbOpcion3.AutoSize = true;
            rdbOpcion3.Location = new Point(338, 159);
            rdbOpcion3.Name = "rdbOpcion3";
            rdbOpcion3.Size = new Size(73, 19);
            rdbOpcion3.TabIndex = 2;
            rdbOpcion3.TabStop = true;
            rdbOpcion3.Text = "Opcion 3";
            rdbOpcion3.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(382, 95);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 3;
            btnAceptar.Text = "Agregar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += BtnAceptar_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(266, 46);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(0, 15);
            lblResultado.TabIndex = 4;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(681, 305);
            Controls.Add(lblResultado);
            Controls.Add(btnAceptar);
            Controls.Add(rdbOpcion3);
            Controls.Add(rdbOpcion2);
            Controls.Add(rdbOpcion1);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton rdbOpcion1;
        private RadioButton rdbOpcion2;
        private RadioButton rdbOpcion3;
        private Button btnAceptar;
        private Label lblResultado;
    }
}