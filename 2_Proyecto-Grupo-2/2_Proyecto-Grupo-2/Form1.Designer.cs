namespace _2_Proyecto_Grupo_2
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
            label2 = new Label();
            txtTarea = new TextBox();
            button1 = new Button();
            lstTarea = new ListBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(183, 59);
            label1.Name = "label1";
            label1.Size = new Size(87, 15);
            label1.TabIndex = 0;
            label1.Text = "Gestionar Tarea";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(77, 117);
            label2.Name = "label2";
            label2.Size = new Size(78, 15);
            label2.TabIndex = 1;
            label2.Text = "Ingrese Tarea:";
            // 
            // txtTarea
            // 
            txtTarea.Location = new Point(161, 114);
            txtTarea.Name = "txtTarea";
            txtTarea.Size = new Size(237, 23);
            txtTarea.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(77, 172);
            button1.Name = "button1";
            button1.Size = new Size(86, 23);
            button1.TabIndex = 3;
            button1.Text = "AgregarTarea";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lstTarea
            // 
            lstTarea.FormattingEnabled = true;
            lstTarea.ItemHeight = 15;
            lstTarea.Location = new Point(77, 210);
            lstTarea.Name = "lstTarea";
            lstTarea.Size = new Size(321, 94);
            lstTarea.TabIndex = 4;
            // 
            // button2
            // 
            button2.Location = new Point(77, 310);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 5;
            button2.Text = "Eliminar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(lstTarea);
            Controls.Add(button1);
            Controls.Add(txtTarea);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtTarea;
        private Button button1;
        private ListBox lstTarea;
        private Button button2;
    }
}
