namespace AdoNetCore
{
    partial class Form09CrudHospitales
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
            btnEliminar = new Button();
            btnModificar = new Button();
            btnInsertar = new Button();
            txtDireccion = new TextBox();
            label4 = new Label();
            txtNombre = new TextBox();
            txtId = new TextBox();
            label3 = new Label();
            label2 = new Label();
            lstHospitales = new ListBox();
            label1 = new Label();
            txtCamas = new TextBox();
            label5 = new Label();
            txtTelefono = new TextBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = SystemColors.Info;
            btnEliminar.Location = new Point(816, 640);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(390, 78);
            btnEliminar.TabIndex = 21;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = SystemColors.ActiveCaption;
            btnModificar.Location = new Point(816, 547);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(390, 78);
            btnModificar.TabIndex = 20;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnInsertar
            // 
            btnInsertar.BackColor = SystemColors.ControlDarkDark;
            btnInsertar.Location = new Point(816, 452);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(390, 78);
            btnInsertar.TabIndex = 19;
            btnInsertar.Text = "insertar";
            btnInsertar.UseVisualStyleBackColor = false;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(679, 332);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(207, 47);
            txtDireccion.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(679, 279);
            label4.Name = "label4";
            label4.Size = new Size(142, 41);
            label4.TabIndex = 17;
            label4.Text = "Direccion";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(679, 203);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(207, 47);
            txtNombre.TabIndex = 16;
            // 
            // txtId
            // 
            txtId.Location = new Point(679, 91);
            txtId.Name = "txtId";
            txtId.Size = new Size(207, 47);
            txtId.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(679, 150);
            label3.Name = "label3";
            label3.Size = new Size(128, 41);
            label3.TabIndex = 14;
            label3.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(679, 26);
            label2.Name = "label2";
            label2.Size = new Size(47, 41);
            label2.TabIndex = 13;
            label2.Text = "ID";
            // 
            // lstHospitales
            // 
            lstHospitales.Font = new Font("Segoe UI", 9.900001F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstHospitales.FormattingEnabled = true;
            lstHospitales.Location = new Point(30, 91);
            lstHospitales.Margin = new Padding(3, 4, 3, 4);
            lstHospitales.Name = "lstHospitales";
            lstHospitales.Size = new Size(586, 679);
            lstHospitales.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 26);
            label1.Name = "label1";
            label1.Size = new Size(156, 41);
            label1.TabIndex = 11;
            label1.Text = "Hospitales";
            // 
            // txtCamas
            // 
            txtCamas.Location = new Point(999, 279);
            txtCamas.Name = "txtCamas";
            txtCamas.Size = new Size(207, 47);
            txtCamas.TabIndex = 25;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(999, 226);
            label5.Name = "label5";
            label5.Size = new Size(106, 41);
            label5.TabIndex = 24;
            label5.Text = "Camas";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(999, 150);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(207, 47);
            txtTelefono.TabIndex = 23;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(999, 97);
            label6.Name = "label6";
            label6.Size = new Size(132, 41);
            label6.TabIndex = 22;
            label6.Text = "Telefono";
            // 
            // Form09CrudHospitales
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1254, 786);
            Controls.Add(txtCamas);
            Controls.Add(label5);
            Controls.Add(txtTelefono);
            Controls.Add(label6);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnInsertar);
            Controls.Add(txtDireccion);
            Controls.Add(label4);
            Controls.Add(txtNombre);
            Controls.Add(txtId);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lstHospitales);
            Controls.Add(label1);
            Name = "Form09CrudHospitales";
            Text = "Form09CrudHospitales";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEliminar;
        private Button btnModificar;
        private Button btnInsertar;
        private TextBox txtDireccion;
        private Label label4;
        private TextBox txtNombre;
        private TextBox txtId;
        private Label label3;
        private Label label2;
        private ListBox lstHospitales;
        private Label label1;
        private TextBox txtCamas;
        private Label label5;
        private TextBox txtTelefono;
        private Label label6;
    }
}