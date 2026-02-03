namespace ejercicio_4
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
            button1 = new Button();
            ingrese = new Label();
            txtNum1 = new TextBox();
            txtNum2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtRes = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(126, 190);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "=";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ingrese
            // 
            ingrese.AutoSize = true;
            ingrese.Location = new Point(77, 65);
            ingrese.Name = "ingrese";
            ingrese.Size = new Size(93, 15);
            ingrese.TabIndex = 1;
            ingrese.Text = "Ingrese  numero";
            ingrese.Click += ingrese_Click;
            // 
            // txtNum1
            // 
            txtNum1.Location = new Point(185, 57);
            txtNum1.Name = "txtNum1";
            txtNum1.Size = new Size(100, 23);
            txtNum1.TabIndex = 2;
            // 
            // txtNum2
            // 
            txtNum2.Location = new Point(185, 102);
            txtNum2.Name = "txtNum2";
            txtNum2.Size = new Size(100, 23);
            txtNum2.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(77, 110);
            label1.Name = "label1";
            label1.Size = new Size(93, 15);
            label1.TabIndex = 3;
            label1.Text = "Ingrese  numero";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(91, 150);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 5;
            label2.Text = "Resultado:";
            // 
            // txtRes
            // 
            txtRes.Location = new Point(185, 147);
            txtRes.Name = "txtRes";
            txtRes.Size = new Size(100, 23);
            txtRes.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(615, 314);
            Controls.Add(txtRes);
            Controls.Add(label2);
            Controls.Add(txtNum2);
            Controls.Add(label1);
            Controls.Add(txtNum1);
            Controls.Add(ingrese);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label ingrese;
        private TextBox txtNum1;
        private TextBox txtNum2;
        private Label label1;
        private Label label2;
        private TextBox txtRes;
    }
}
