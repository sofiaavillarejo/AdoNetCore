namespace AdoNetCore
{
    partial class Form13ParametrosSalida
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
            cmbDepartamentos = new ComboBox();
            btnMostrar = new Button();
            label2 = new Label();
            txtSuma = new TextBox();
            txtMedia = new TextBox();
            label3 = new Label();
            txtPersonas = new TextBox();
            label4 = new Label();
            label5 = new Label();
            lstEmpleados = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 41);
            label1.Name = "label1";
            label1.Size = new Size(98, 41);
            label1.TabIndex = 0;
            label1.Text = "Dptos";
            // 
            // cmbDepartamentos
            // 
            cmbDepartamentos.FormattingEnabled = true;
            cmbDepartamentos.Location = new Point(36, 85);
            cmbDepartamentos.Name = "cmbDepartamentos";
            cmbDepartamentos.Size = new Size(302, 49);
            cmbDepartamentos.TabIndex = 1;
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(36, 170);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(302, 58);
            btnMostrar.TabIndex = 2;
            btnMostrar.Text = "Mostrar datos";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 261);
            label2.Name = "label2";
            label2.Size = new Size(189, 41);
            label2.TabIndex = 3;
            label2.Text = "Suma salarial";
            // 
            // txtSuma
            // 
            txtSuma.Location = new Point(36, 314);
            txtSuma.Name = "txtSuma";
            txtSuma.Size = new Size(250, 47);
            txtSuma.TabIndex = 4;
            // 
            // txtMedia
            // 
            txtMedia.Location = new Point(36, 449);
            txtMedia.Name = "txtMedia";
            txtMedia.Size = new Size(250, 47);
            txtMedia.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 396);
            label3.Name = "label3";
            label3.Size = new Size(198, 41);
            label3.TabIndex = 5;
            label3.Text = "Media salarial";
            // 
            // txtPersonas
            // 
            txtPersonas.Location = new Point(36, 577);
            txtPersonas.Name = "txtPersonas";
            txtPersonas.Size = new Size(250, 47);
            txtPersonas.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 524);
            label4.Name = "label4";
            label4.Size = new Size(136, 41);
            label4.TabIndex = 7;
            label4.Text = "Personas";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(513, 53);
            label5.Name = "label5";
            label5.Size = new Size(164, 41);
            label5.TabIndex = 9;
            label5.Text = "Empleados";
            // 
            // lstEmpleados
            // 
            lstEmpleados.FormattingEnabled = true;
            lstEmpleados.Location = new Point(513, 110);
            lstEmpleados.Name = "lstEmpleados";
            lstEmpleados.Size = new Size(477, 496);
            lstEmpleados.TabIndex = 10;
            // 
            // Form13ParametrosSalida
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1017, 650);
            Controls.Add(lstEmpleados);
            Controls.Add(label5);
            Controls.Add(txtPersonas);
            Controls.Add(label4);
            Controls.Add(txtMedia);
            Controls.Add(label3);
            Controls.Add(txtSuma);
            Controls.Add(label2);
            Controls.Add(btnMostrar);
            Controls.Add(cmbDepartamentos);
            Controls.Add(label1);
            Name = "Form13ParametrosSalida";
            Text = "Form13ParametrosSalida";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbDepartamentos;
        private Button btnMostrar;
        private Label label2;
        private TextBox txtSuma;
        private TextBox txtMedia;
        private Label label3;
        private TextBox txtPersonas;
        private Label label4;
        private Label label5;
        private ListBox lstEmpleados;
    }
}