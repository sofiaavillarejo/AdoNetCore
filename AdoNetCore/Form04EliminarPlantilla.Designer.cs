namespace AdoNetCore
{
    partial class Form04EliminarPlantilla
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
            lstTrabajadores = new ListBox();
            label2 = new Label();
            btnEliminar = new Button();
            txtIdEmpleado = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // lstTrabajadores
            // 
            lstTrabajadores.FormattingEnabled = true;
            lstTrabajadores.Location = new Point(512, 93);
            lstTrabajadores.Name = "lstTrabajadores";
            lstTrabajadores.Size = new Size(355, 332);
            lstTrabajadores.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(512, 35);
            label2.Name = "label2";
            label2.Size = new Size(186, 41);
            label2.TabIndex = 8;
            label2.Text = "Trabajadores";
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(12, 187);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(301, 61);
            btnEliminar.TabIndex = 7;
            btnEliminar.Text = "Eliminar trabajador";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // txtIdEmpleado
            // 
            txtIdEmpleado.Location = new Point(12, 93);
            txtIdEmpleado.Name = "txtIdEmpleado";
            txtIdEmpleado.Size = new Size(250, 47);
            txtIdEmpleado.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 35);
            label1.Name = "label1";
            label1.Size = new Size(189, 41);
            label1.TabIndex = 5;
            label1.Text = "ID empleado";
            // 
            // Form04EliminarPlantilla
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(954, 461);
            Controls.Add(lstTrabajadores);
            Controls.Add(label2);
            Controls.Add(btnEliminar);
            Controls.Add(txtIdEmpleado);
            Controls.Add(label1);
            Name = "Form04EliminarPlantilla";
            Text = "Form04EliminarPlantilla";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstTrabajadores;
        private Label label2;
        private Button btnEliminar;
        private TextBox txtIdEmpleado;
        private Label label1;
    }
}