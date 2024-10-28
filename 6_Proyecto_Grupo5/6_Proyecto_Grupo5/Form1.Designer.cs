namespace _6_Proyecto_Grupo5
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
            txtNombre = new TextBox();
            txtCorreo = new TextBox();
            txtEdad = new NumericUpDown();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            listBoxPersonas = new ListBox();
            label5 = new Label();
            label6 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)txtEdad).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(157, 68);
            label1.Name = "label1";
            label1.Size = new Size(102, 15);
            label1.TabIndex = 0;
            label1.Text = "Gestionar Persona";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(203, 101);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 1;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(203, 143);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(100, 23);
            txtCorreo.TabIndex = 2;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(203, 186);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(100, 23);
            txtEdad.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(124, 109);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 4;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(124, 151);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 5;
            label3.Text = "Correo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(124, 194);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 6;
            label4.Text = "Edad";
            // 
            // listBoxPersonas
            // 
            listBoxPersonas.FormattingEnabled = true;
            listBoxPersonas.ItemHeight = 15;
            listBoxPersonas.Location = new Point(425, 100);
            listBoxPersonas.Name = "listBoxPersonas";
            listBoxPersonas.Size = new Size(271, 109);
            listBoxPersonas.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(308, 20);
            label5.Name = "label5";
            label5.Size = new Size(151, 15);
            label5.TabIndex = 8;
            label5.Text = "Serializar y Deserializar XML";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(515, 68);
            label6.Name = "label6";
            label6.Size = new Size(97, 15);
            label6.TabIndex = 9;
            label6.Text = "Lista de Personas";
            // 
            // button1
            // 
            button1.Location = new Point(124, 259);
            button1.Name = "button1";
            button1.Size = new Size(71, 25);
            button1.TabIndex = 10;
            button1.Text = "Enviar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(listBoxPersonas);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtEdad);
            Controls.Add(txtCorreo);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)txtEdad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNombre;
        private TextBox txtCorreo;
        private NumericUpDown txtEdad;
        private Label label2;
        private Label label3;
        private Label label4;
        private ListBox listBoxPersonas;
        private Label label5;
        private Label label6;
        private Button button1;
    }
}
