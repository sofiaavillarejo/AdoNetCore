namespace AdoNetCore
{
    partial class Form08CrudDptos
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
            lstDepartamentos = new ListBox();
            label2 = new Label();
            label3 = new Label();
            txtId = new TextBox();
            txtNombre = new TextBox();
            txtLocalidad = new TextBox();
            label4 = new Label();
            btnInsertar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 6);
            label1.Name = "label1";
            label1.Size = new Size(276, 50);
            label1.TabIndex = 0;
            label1.Text = "Departamentos";
            // 
            // lstDepartamentos
            // 
            lstDepartamentos.Font = new Font("Segoe UI", 9.900001F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstDepartamentos.FormattingEnabled = true;
            lstDepartamentos.Location = new Point(12, 71);
            lstDepartamentos.Margin = new Padding(3, 4, 3, 4);
            lstDepartamentos.Name = "lstDepartamentos";
            lstDepartamentos.Size = new Size(586, 679);
            lstDepartamentos.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(661, 6);
            label2.Name = "label2";
            label2.Size = new Size(58, 50);
            label2.TabIndex = 2;
            label2.Text = "ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(661, 158);
            label3.Name = "label3";
            label3.Size = new Size(158, 50);
            label3.TabIndex = 3;
            label3.Text = "Nombre";
            // 
            // txtId
            // 
            txtId.Location = new Point(661, 71);
            txtId.Name = "txtId";
            txtId.Size = new Size(390, 57);
            txtId.TabIndex = 4;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(661, 211);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(390, 57);
            txtNombre.TabIndex = 5;
            // 
            // txtLocalidad
            // 
            txtLocalidad.Location = new Point(661, 362);
            txtLocalidad.Name = "txtLocalidad";
            txtLocalidad.Size = new Size(390, 57);
            txtLocalidad.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(661, 309);
            label4.Name = "label4";
            label4.Size = new Size(178, 50);
            label4.TabIndex = 6;
            label4.Text = "Localidad";
            // 
            // btnInsertar
            // 
            btnInsertar.BackColor = SystemColors.ControlDarkDark;
            btnInsertar.Location = new Point(661, 475);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(390, 78);
            btnInsertar.TabIndex = 8;
            btnInsertar.Text = "insertar";
            btnInsertar.UseVisualStyleBackColor = false;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = SystemColors.ActiveCaption;
            btnModificar.Location = new Point(661, 570);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(390, 78);
            btnModificar.TabIndex = 9;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = SystemColors.Info;
            btnEliminar.Location = new Point(661, 663);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(390, 78);
            btnEliminar.TabIndex = 10;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click_1;
            // 
            // Form08CrudDptos
            // 
            AutoScaleDimensions = new SizeF(20F, 50F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1063, 780);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnInsertar);
            Controls.Add(txtLocalidad);
            Controls.Add(label4);
            Controls.Add(txtNombre);
            Controls.Add(txtId);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lstDepartamentos);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 11.1F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form08CrudDptos";
            Text = "Form08CrudDptos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox lstDepartamentos;
        private Label label2;
        private Label label3;
        private TextBox txtId;
        private TextBox txtNombre;
        private TextBox txtLocalidad;
        private Label label4;
        private Button btnInsertar;
        private Button btnModificar;
        private Button btnEliminar;
    }
}