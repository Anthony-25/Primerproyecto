namespace ejercicio_6
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
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(36, 37);
            button1.Name = "button1";
            button1.Size = new Size(185, 123);
            button1.TabIndex = 0;
            button1.Text = "CadetBlue";
            button1.UseVisualStyleBackColor = true;
            button1.MouseClick += button6_MouseClick;
            // 
            // button2
            // 
            button2.Location = new Point(264, 37);
            button2.Name = "button2";
            button2.Size = new Size(185, 123);
            button2.TabIndex = 1;
            button2.Text = "CadetBlue";
            button2.UseVisualStyleBackColor = true;
            button2.MouseClick += button6_MouseClick;
            // 
            // button3
            // 
            button3.Location = new Point(515, 37);
            button3.Name = "button3";
            button3.Size = new Size(185, 123);
            button3.TabIndex = 2;
            button3.Text = "CadetBlue";
            button3.UseVisualStyleBackColor = true;
            button3.MouseClick += button6_MouseClick;
            button3.MouseEnter += button3_MouseEnter;
            // 
            // button4
            // 
            button4.Location = new Point(36, 204);
            button4.Name = "button4";
            button4.Size = new Size(185, 123);
            button4.TabIndex = 3;
            button4.Text = "CadetBlue";
            button4.UseVisualStyleBackColor = true;
            button4.MouseClick += button6_MouseClick;
            // 
            // button5
            // 
            button5.Location = new Point(264, 204);
            button5.Name = "button5";
            button5.Size = new Size(185, 123);
            button5.TabIndex = 4;
            button5.Text = "CadetBlue";
            button5.UseVisualStyleBackColor = true;
            button5.MouseClick += button6_MouseClick;
            button5.MouseEnter += button5_MouseEnter;
            // 
            // button6
            // 
            button6.Location = new Point(515, 204);
            button6.Name = "button6";
            button6.Size = new Size(185, 123);
            button6.TabIndex = 5;
            button6.Text = "CadetBlue";
            button6.UseVisualStyleBackColor = true;
            button6.MouseClick += button6_MouseClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
    }
}
