namespace AdoNetCore
{
    partial class Form10UpdateEmpleados
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
            txtIncremento = new TextBox();
            lstOficios = new ListBox();
            lstEmpleados = new ListBox();
            label2 = new Label();
            label3 = new Label();
            Incrementar = new Button();
            lblSumaSalario = new Label();
            lblMedia = new Label();
            lblMaximoSalario = new Label();
            label4 = new Label();
            txtOficio = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 60);
            label1.Name = "label1";
            label1.Size = new Size(109, 41);
            label1.TabIndex = 0;
            label1.Text = "Oficios";
            // 
            // txtIncremento
            // 
            txtIncremento.Location = new Point(915, 216);
            txtIncremento.Name = "txtIncremento";
            txtIncremento.Size = new Size(250, 47);
            txtIncremento.TabIndex = 1;
            // 
            // lstOficios
            // 
            lstOficios.FormattingEnabled = true;
            lstOficios.Location = new Point(56, 104);
            lstOficios.Name = "lstOficios";
            lstOficios.Size = new Size(384, 496);
            lstOficios.TabIndex = 2;
            lstOficios.SelectedIndexChanged += lstOficios_SelectedIndexChanged;
            // 
            // lstEmpleados
            // 
            lstEmpleados.FormattingEnabled = true;
            lstEmpleados.Location = new Point(491, 104);
            lstEmpleados.Name = "lstEmpleados";
            lstEmpleados.Size = new Size(384, 496);
            lstEmpleados.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(491, 60);
            label2.Name = "label2";
            label2.Size = new Size(164, 41);
            label2.TabIndex = 3;
            label2.Text = "Empleados";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(915, 161);
            label3.Name = "label3";
            label3.Size = new Size(170, 41);
            label3.TabIndex = 5;
            label3.Text = "Incremento";
            // 
            // Incrementar
            // 
            Incrementar.Location = new Point(915, 313);
            Incrementar.Name = "Incrementar";
            Incrementar.Size = new Size(250, 62);
            Incrementar.TabIndex = 6;
            Incrementar.Text = "Incrementar";
            Incrementar.UseVisualStyleBackColor = true;
            Incrementar.Click += Incrementar_Click;
            // 
            // lblSumaSalario
            // 
            lblSumaSalario.AutoSize = true;
            lblSumaSalario.Location = new Point(934, 417);
            lblSumaSalario.Name = "lblSumaSalario";
            lblSumaSalario.Size = new Size(204, 41);
            lblSumaSalario.TabIndex = 7;
            lblSumaSalario.Text = "Suma salarial: ";
            // 
            // lblMedia
            // 
            lblMedia.AutoSize = true;
            lblMedia.Location = new Point(933, 473);
            lblMedia.Name = "lblMedia";
            lblMedia.Size = new Size(205, 41);
            lblMedia.TabIndex = 8;
            lblMedia.Text = "Media salarial:";
            // 
            // lblMaximoSalario
            // 
            lblMaximoSalario.AutoSize = true;
            lblMaximoSalario.Location = new Point(933, 528);
            lblMaximoSalario.Name = "lblMaximoSalario";
            lblMaximoSalario.Size = new Size(225, 41);
            lblMaximoSalario.TabIndex = 9;
            lblMaximoSalario.Text = "Máximo salario:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(915, 28);
            label4.Name = "label4";
            label4.Size = new Size(96, 41);
            label4.TabIndex = 10;
            label4.Text = "Oficio";
            // 
            // txtOficio
            // 
            txtOficio.Location = new Point(915, 84);
            txtOficio.Name = "txtOficio";
            txtOficio.Size = new Size(250, 47);
            txtOficio.TabIndex = 11;
            // 
            // Form10UpdateEmpleados
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1192, 632);
            Controls.Add(txtOficio);
            Controls.Add(label4);
            Controls.Add(lblMaximoSalario);
            Controls.Add(lblMedia);
            Controls.Add(lblSumaSalario);
            Controls.Add(Incrementar);
            Controls.Add(label3);
            Controls.Add(lstEmpleados);
            Controls.Add(label2);
            Controls.Add(lstOficios);
            Controls.Add(txtIncremento);
            Controls.Add(label1);
            Name = "Form10UpdateEmpleados";
            Text = "Form10UpdateEmpleados";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtIncremento;
        private ListBox lstOficios;
        private ListBox lstEmpleados;
        private Label label2;
        private Label label3;
        private Button Incrementar;
        private Label lblSumaSalario;
        private Label lblMedia;
        private Label lblMaximoSalario;
        private Label label4;
        private TextBox txtOficio;
    }
}