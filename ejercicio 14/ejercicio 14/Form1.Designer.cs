namespace ejercicio_14
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
            tabPestaña1 = new TabControl();
            tabPage1 = new TabPage();
            lblInicio = new Label();
            tabPage2 = new TabPage();
            lblInfo = new Label();
            tabPage3 = new TabPage();
            lblcerrar = new Label();
            tabPestaña1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // tabPestaña1
            // 
            tabPestaña1.Controls.Add(tabPage1);
            tabPestaña1.Controls.Add(tabPage2);
            tabPestaña1.Controls.Add(tabPage3);
            tabPestaña1.Location = new Point(242, 96);
            tabPestaña1.Name = "tabPestaña1";
            tabPestaña1.SelectedIndex = 0;
            tabPestaña1.Size = new Size(301, 149);
            tabPestaña1.TabIndex = 0;
            tabPestaña1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(lblInicio);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(293, 121);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblInicio
            // 
            lblInicio.AutoSize = true;
            lblInicio.Location = new Point(52, 53);
            lblInicio.Name = "lblInicio";
            lblInicio.Size = new Size(179, 15);
            lblInicio.TabIndex = 1;
            lblInicio.Text = "Bienvenido a la pestaña de Inicio";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(lblInfo);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(293, 121);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.Location = new Point(48, 50);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(185, 15);
            lblInfo.TabIndex = 0;
            lblInfo.Text = "Esta es la pestaña de Informacion ";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(lblcerrar);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(293, 121);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "tabPage3";
            tabPage3.UseVisualStyleBackColor = true;
            tabPage3.Click += tabPage3_Click;
            // 
            // lblcerrar
            // 
            lblcerrar.AutoSize = true;
            lblcerrar.Location = new Point(28, 48);
            lblcerrar.Name = "lblcerrar";
            lblcerrar.Size = new Size(242, 15);
            lblcerrar.TabIndex = 0;
            lblcerrar.Text = "Esta es la pestaña de cerrar todo el programa";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(763, 323);
            Controls.Add(tabPestaña1);
            Name = "Form1";
            Text = "Form1";
            tabPestaña1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabPestaña1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Label lblInicio;
        private Label lblInfo;
        private Label lblcerrar;
    }
}
