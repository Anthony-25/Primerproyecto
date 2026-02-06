namespace ejercicio_11
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
            lblFecha = new Label();
            btnMostrarFecha = new Button();
            dateTimerPicker1 = new DateTimePicker();
            SuspendLayout();
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(67, 74);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(0, 15);
            lblFecha.TabIndex = 0;
            // 
            // btnMostrarFecha
            // 
            btnMostrarFecha.Location = new Point(315, 189);
            btnMostrarFecha.Name = "btnMostrarFecha";
            btnMostrarFecha.Size = new Size(75, 23);
            btnMostrarFecha.TabIndex = 1;
            btnMostrarFecha.Text = "Mostrar Fecha ";
            btnMostrarFecha.UseVisualStyleBackColor = true;
            btnMostrarFecha.Click += BtnMostrarFecha_Click;
            // 
            // dateTimerPicker1
            // 
            dateTimerPicker1.Location = new Point(315, 74);
            dateTimerPicker1.Name = "dateTimerPicker1";
            dateTimerPicker1.Size = new Size(248, 23);
            dateTimerPicker1.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dateTimerPicker1);
            Controls.Add(btnMostrarFecha);
            Controls.Add(lblFecha);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFecha;
        private Button btnMostrarFecha;
        private DateTimePicker dateTimerPicker1;
    }
}
