﻿namespace AdoNetCore
{
    partial class Form07DepartamentosEmpleados
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
            label1 = new Label();
            label2 = new Label();
            lstDepartamentos = new ListBox();
            lstEmpleados = new ListBox();
            btnEliminar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(70, 68);
            label1.Name = "label1";
            label1.Size = new Size(223, 41);
            label1.TabIndex = 0;
            label1.Text = "Departamentos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(603, 68);
            label2.Name = "label2";
            label2.Size = new Size(164, 41);
            label2.TabIndex = 1;
            label2.Text = "Empleados";
            // 
            // lstDepartamentos
            // 
            lstDepartamentos.FormattingEnabled = true;
            lstDepartamentos.Location = new Point(70, 128);
            lstDepartamentos.Name = "lstDepartamentos";
            lstDepartamentos.Size = new Size(471, 414);
            lstDepartamentos.TabIndex = 2;
            lstDepartamentos.SelectedIndexChanged += lstDepartamentos_SelectedIndexChanged;
            // 
            // lstEmpleados
            // 
            lstEmpleados.FormattingEnabled = true;
            lstEmpleados.Location = new Point(603, 128);
            lstEmpleados.Name = "lstEmpleados";
            lstEmpleados.Size = new Size(434, 414);
            lstEmpleados.TabIndex = 3;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(1075, 296);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(188, 58);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // Form07DepartamentosEmpleados
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1297, 800);
            Controls.Add(btnEliminar);
            Controls.Add(lstEmpleados);
            Controls.Add(lstDepartamentos);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form07DepartamentosEmpleados";
            Text = "Form07DepartamentosEmpleados";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ListBox lstDepartamentos;
        private ListBox lstEmpleados;
        private Button btnEliminar;
    }
}