namespace AdoNetCore
{
    partial class Form12MensajesServidor
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
            txtNumero = new TextBox();
            txtNombre = new TextBox();
            txtLocalidad = new TextBox();
            label3 = new Label();
            label4 = new Label();
            btnInsertar = new Button();
            lstDepartamentos = new ListBox();
            lblMensaje = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(67, 38);
            label1.Name = "label1";
            label1.Size = new Size(127, 41);
            label1.TabIndex = 0;
            label1.Text = "Número";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(67, 154);
            label2.Name = "label2";
            label2.Size = new Size(128, 41);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(67, 82);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(292, 47);
            txtNumero.TabIndex = 2;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(67, 198);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(292, 47);
            txtNombre.TabIndex = 3;
            // 
            // txtLocalidad
            // 
            txtLocalidad.Location = new Point(67, 308);
            txtLocalidad.Name = "txtLocalidad";
            txtLocalidad.Size = new Size(292, 47);
            txtLocalidad.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(67, 264);
            label3.Name = "label3";
            label3.Size = new Size(144, 41);
            label3.TabIndex = 4;
            label3.Text = "Localidad";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(437, 38);
            label4.Name = "label4";
            label4.Size = new Size(223, 41);
            label4.TabIndex = 6;
            label4.Text = "Departamentos";
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(67, 404);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(250, 73);
            btnInsertar.TabIndex = 8;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // lstDepartamentos
            // 
            lstDepartamentos.FormattingEnabled = true;
            lstDepartamentos.Location = new Point(437, 96);
            lstDepartamentos.Name = "lstDepartamentos";
            lstDepartamentos.Size = new Size(556, 373);
            lstDepartamentos.TabIndex = 9;
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.Location = new Point(67, 588);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(0, 41);
            lblMensaje.TabIndex = 10;
            // 
            // Form12MensajesServidor
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1063, 704);
            Controls.Add(lblMensaje);
            Controls.Add(lstDepartamentos);
            Controls.Add(btnInsertar);
            Controls.Add(label4);
            Controls.Add(txtLocalidad);
            Controls.Add(label3);
            Controls.Add(txtNombre);
            Controls.Add(txtNumero);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form12MensajesServidor";
            Text = "Form12MensajesServidor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtNumero;
        private TextBox txtNombre;
        private TextBox txtLocalidad;
        private Label label3;
        private Label label4;
        private Button btnInsertar;
        private ListBox lstDepartamentos;
        private Label lblMensaje;
    }
}