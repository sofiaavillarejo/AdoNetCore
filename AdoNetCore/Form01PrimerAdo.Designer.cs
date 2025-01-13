namespace AdoNetCore
{
    partial class Form01PrimerAdo
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
            btnConectar = new Button();
            btnDesconectar = new Button();
            btnLeer = new Button();
            Apellidos = new Label();
            lstApellidos = new ListBox();
            lstColumnas = new ListBox();
            Columnas = new Label();
            lstTiposDato = new ListBox();
            label3 = new Label();
            lblMensaje = new Label();
            SuspendLayout();
            // 
            // btnConectar
            // 
            btnConectar.Location = new Point(42, 150);
            btnConectar.Name = "btnConectar";
            btnConectar.Size = new Size(192, 58);
            btnConectar.TabIndex = 0;
            btnConectar.Text = "Conectar";
            btnConectar.UseVisualStyleBackColor = true;
            btnConectar.Click += btnConectar_Click;
            // 
            // btnDesconectar
            // 
            btnDesconectar.Location = new Point(42, 232);
            btnDesconectar.Name = "btnDesconectar";
            btnDesconectar.Size = new Size(216, 58);
            btnDesconectar.TabIndex = 1;
            btnDesconectar.Text = "Desconectar";
            btnDesconectar.UseVisualStyleBackColor = true;
            btnDesconectar.Click += btnDesconectar_Click;
            // 
            // btnLeer
            // 
            btnLeer.Location = new Point(42, 322);
            btnLeer.Name = "btnLeer";
            btnLeer.Size = new Size(230, 58);
            btnLeer.TabIndex = 2;
            btnLeer.Text = "Leer datos";
            btnLeer.UseVisualStyleBackColor = true;
            btnLeer.Click += btnLeer_Click;
            // 
            // Apellidos
            // 
            Apellidos.AutoSize = true;
            Apellidos.Location = new Point(294, 58);
            Apellidos.Name = "Apellidos";
            Apellidos.Size = new Size(97, 41);
            Apellidos.TabIndex = 3;
            Apellidos.Text = "label1";
            // 
            // lstApellidos
            // 
            lstApellidos.FormattingEnabled = true;
            lstApellidos.Location = new Point(294, 102);
            lstApellidos.Name = "lstApellidos";
            lstApellidos.Size = new Size(300, 373);
            lstApellidos.TabIndex = 4;
            // 
            // lstColumnas
            // 
            lstColumnas.FormattingEnabled = true;
            lstColumnas.Location = new Point(703, 102);
            lstColumnas.Name = "lstColumnas";
            lstColumnas.Size = new Size(300, 373);
            lstColumnas.TabIndex = 6;
            // 
            // Columnas
            // 
            Columnas.AutoSize = true;
            Columnas.Location = new Point(703, 58);
            Columnas.Name = "Columnas";
            Columnas.Size = new Size(97, 41);
            Columnas.TabIndex = 5;
            Columnas.Text = "label2";
            // 
            // lstTiposDato
            // 
            lstTiposDato.FormattingEnabled = true;
            lstTiposDato.Location = new Point(1053, 102);
            lstTiposDato.Name = "lstTiposDato";
            lstTiposDato.Size = new Size(300, 373);
            lstTiposDato.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1053, 58);
            label3.Name = "label3";
            label3.Size = new Size(162, 41);
            label3.TabIndex = 7;
            label3.Text = "Tipos Dato";
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.Location = new Point(42, 563);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(0, 41);
            lblMensaje.TabIndex = 9;
            // 
            // Form01PrimerAdo
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1439, 653);
            Controls.Add(lblMensaje);
            Controls.Add(lstTiposDato);
            Controls.Add(label3);
            Controls.Add(lstColumnas);
            Controls.Add(Columnas);
            Controls.Add(lstApellidos);
            Controls.Add(Apellidos);
            Controls.Add(btnLeer);
            Controls.Add(btnDesconectar);
            Controls.Add(btnConectar);
            Name = "Form01PrimerAdo";
            Text = "Form01PrimerAdo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConectar;
        private Button btnDesconectar;
        private Button btnLeer;
        private Label Apellidos;
        private ListBox lstApellidos;
        private ListBox lstColumnas;
        private Label Columnas;
        private ListBox lstTiposDato;
        private Label label3;
        private Label lblMensaje;
    }
}