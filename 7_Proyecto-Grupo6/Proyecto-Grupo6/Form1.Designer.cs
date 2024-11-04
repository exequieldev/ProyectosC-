namespace Proyecto_Grupo6
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
            label1 = new Label();
            comboBox1 = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            Area = new TextBox();
            button1 = new Button();
            label4 = new Label();
            textBoxBase = new TextBox();
            label5 = new Label();
            textBoxAltura = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(335, 42);
            label1.Name = "label1";
            label1.Size = new Size(118, 15);
            label1.TabIndex = 0;
            label1.Text = "Calculadora de Areas";
            label1.Click += label1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(221, 101);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(109, 104);
            label2.Name = "label2";
            label2.Size = new Size(106, 15);
            label2.TabIndex = 2;
            label2.Text = "Figura geometrica:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(178, 288);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 3;
            label3.Text = "Area: ";
            // 
            // Area
            // 
            Area.Location = new Point(221, 285);
            Area.Name = "Area";
            Area.Size = new Size(63, 23);
            Area.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(335, 185);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(181, 150);
            label4.Name = "label4";
            label4.Size = new Size(34, 15);
            label4.TabIndex = 6;
            label4.Text = "Base:";
            // 
            // textBoxBase
            // 
            textBoxBase.Location = new Point(221, 144);
            textBoxBase.Name = "textBoxBase";
            textBoxBase.Size = new Size(63, 23);
            textBoxBase.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(173, 188);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 8;
            label5.Text = "Altura:";
            // 
            // textBoxAltura
            // 
            textBoxAltura.Location = new Point(221, 186);
            textBoxAltura.Name = "textBoxAltura";
            textBoxAltura.Size = new Size(63, 23);
            textBoxAltura.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxAltura);
            Controls.Add(label5);
            Controls.Add(textBoxBase);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(Area);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboBox1;
        private Label label2;
        private Label label3;
        private TextBox Area;
        private Button button1;
        private Label label4;
        private TextBox textBoxBase;
        private Label label5;
        private TextBox textBoxAltura;
    }
}
