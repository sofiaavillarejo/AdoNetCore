namespace AdoNetCore
{
    partial class Form02BuscadorEmpleados
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
            txtSalario = new TextBox();
            btnBuscar = new Button();
            label2 = new Label();
            lstEmpleados = new ListBox();
            btnOficios = new Button();
            txtOficio = new TextBox();
            lblOficio = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 40);
            label1.Name = "label1";
            label1.Size = new Size(252, 41);
            label1.TabIndex = 0;
            label1.Text = "Introduzca salario";
            // 
            // txtSalario
            // 
            txtSalario.Location = new Point(50, 96);
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new Size(312, 47);
            txtSalario.TabIndex = 1;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(50, 170);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(312, 58);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar empleados";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 280);
            label2.Name = "label2";
            label2.Size = new Size(164, 41);
            label2.TabIndex = 3;
            label2.Text = "Empleados";
            // 
            // lstEmpleados
            // 
            lstEmpleados.FormattingEnabled = true;
            lstEmpleados.Location = new Point(50, 337);
            lstEmpleados.Name = "lstEmpleados";
            lstEmpleados.Size = new Size(701, 250);
            lstEmpleados.TabIndex = 4;
            // 
            // btnOficios
            // 
            btnOficios.Location = new Point(439, 170);
            btnOficios.Name = "btnOficios";
            btnOficios.Size = new Size(312, 58);
            btnOficios.TabIndex = 7;
            btnOficios.Text = "Buscar oficio";
            btnOficios.UseVisualStyleBackColor = true;
            btnOficios.Click += btnOficios_Click;
            // 
            // txtOficio
            // 
            txtOficio.Location = new Point(439, 96);
            txtOficio.Name = "txtOficio";
            txtOficio.Size = new Size(312, 47);
            txtOficio.TabIndex = 6;
            // 
            // lblOficio
            // 
            lblOficio.AutoSize = true;
            lblOficio.Location = new Point(439, 40);
            lblOficio.Name = "lblOficio";
            lblOficio.Size = new Size(240, 41);
            lblOficio.TabIndex = 5;
            lblOficio.Text = "Introduzca oficio";
            // 
            // Form02BuscadorEmpleados
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(830, 633);
            Controls.Add(btnOficios);
            Controls.Add(txtOficio);
            Controls.Add(lblOficio);
            Controls.Add(lstEmpleados);
            Controls.Add(label2);
            Controls.Add(btnBuscar);
            Controls.Add(txtSalario);
            Controls.Add(label1);
            Name = "Form02BuscadorEmpleados";
            Text = "Form02BuscadorEmpleados";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtSalario;
        private Button btnBuscar;
        private Label label2;
        private ListBox lstEmpleados;
        private Button btnOficios;
        private TextBox txtOficio;
        private Label lblOficio;
    }
}