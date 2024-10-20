namespace _1_Proyecto_Grupo_1
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
            botton1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textDueño = new TextBox();
            textAño = new TextBox();
            textMarca = new TextBox();
            label6 = new Label();
            lstVehiculos = new ListBox();
            textPrecio = new TextBox();
            SuspendLayout();
            // 
            // botton1
            // 
            botton1.Location = new Point(111, 244);
            botton1.Name = "botton1";
            botton1.Size = new Size(75, 23);
            botton1.TabIndex = 0;
            botton1.Text = "Agregar";
            botton1.UseVisualStyleBackColor = true;
            botton1.Click += botton1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(136, 39);
            label1.Name = "label1";
            label1.Size = new Size(110, 15);
            label1.TabIndex = 1;
            label1.Text = "Gestionar Vehiculos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(111, 88);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 2;
            label2.Text = "Dueño";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(111, 120);
            label3.Name = "label3";
            label3.Size = new Size(29, 15);
            label3.TabIndex = 3;
            label3.Text = "Año";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(111, 153);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 4;
            label4.Text = "Marca";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(111, 184);
            label5.Name = "label5";
            label5.Size = new Size(40, 15);
            label5.TabIndex = 5;
            label5.Text = "Precio";
            // 
            // textDueño
            // 
            textDueño.Location = new Point(180, 80);
            textDueño.Name = "textDueño";
            textDueño.Size = new Size(100, 23);
            textDueño.TabIndex = 6;
            // 
            // textAño
            // 
            textAño.Location = new Point(180, 112);
            textAño.Name = "textAño";
            textAño.Size = new Size(100, 23);
            textAño.TabIndex = 7;
            // 
            // textMarca
            // 
            textMarca.Location = new Point(180, 145);
            textMarca.Name = "textMarca";
            textMarca.Size = new Size(100, 23);
            textMarca.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(475, 39);
            label6.Name = "label6";
            label6.Size = new Size(100, 15);
            label6.TabIndex = 10;
            label6.Text = "Lista de Vehiculos";
            // 
            // lstVehiculos
            // 
            lstVehiculos.FormattingEnabled = true;
            lstVehiculos.ItemHeight = 15;
            lstVehiculos.Location = new Point(378, 80);
            lstVehiculos.Name = "lstVehiculos";
            lstVehiculos.Size = new Size(284, 124);
            lstVehiculos.TabIndex = 11;
            // 
            // textPrecio
            // 
            textPrecio.Location = new Point(180, 181);
            textPrecio.Name = "textPrecio";
            textPrecio.Size = new Size(100, 23);
            textPrecio.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textPrecio);
            Controls.Add(lstVehiculos);
            Controls.Add(label6);
            Controls.Add(textMarca);
            Controls.Add(textAño);
            Controls.Add(textDueño);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(botton1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button botton1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textDueño;
        private TextBox textAño;
        private TextBox textMarca;
        private Label label6;
        private ListBox lstVehiculos;
        private TextBox textPrecio;
    }
}
