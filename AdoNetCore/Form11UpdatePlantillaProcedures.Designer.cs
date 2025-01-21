namespace AdoNetCore
{
    partial class Form11UpdatePlantillaProcedures
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
            txtIncremento = new TextBox();
            btnIncrementar = new Button();
            label3 = new Label();
            lstPlantilla = new ListBox();
            cmbHospitales = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(100, 55);
            label1.Name = "label1";
            label1.Size = new Size(156, 41);
            label1.TabIndex = 0;
            label1.Text = "Hospitales";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(584, 55);
            label2.Name = "label2";
            label2.Size = new Size(170, 41);
            label2.TabIndex = 1;
            label2.Text = "Incremento";
            // 
            // txtIncremento
            // 
            txtIncremento.Location = new Point(584, 101);
            txtIncremento.Name = "txtIncremento";
            txtIncremento.Size = new Size(310, 47);
            txtIncremento.TabIndex = 2;
            // 
            // btnIncrementar
            // 
            btnIncrementar.Location = new Point(369, 188);
            btnIncrementar.Name = "btnIncrementar";
            btnIncrementar.Size = new Size(279, 77);
            btnIncrementar.TabIndex = 3;
            btnIncrementar.Text = "Modificar salarios";
            btnIncrementar.UseVisualStyleBackColor = true;
            btnIncrementar.Click += btnIncrementar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(100, 271);
            label3.Name = "label3";
            label3.Size = new Size(120, 41);
            label3.TabIndex = 4;
            label3.Text = "Plantilla";
            // 
            // lstPlantilla
            // 
            lstPlantilla.FormattingEnabled = true;
            lstPlantilla.Location = new Point(100, 344);
            lstPlantilla.Name = "lstPlantilla";
            lstPlantilla.Size = new Size(817, 332);
            lstPlantilla.TabIndex = 5;
            // 
            // cmbHospitales
            // 
            cmbHospitales.FormattingEnabled = true;
            cmbHospitales.Location = new Point(100, 99);
            cmbHospitales.Name = "cmbHospitales";
            cmbHospitales.Size = new Size(302, 49);
            cmbHospitales.TabIndex = 6;
            cmbHospitales.SelectedIndexChanged += cmbHospitales_SelectedIndexChanged;
            // 
            // Form11UpdatePlantillaProcedures
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1023, 705);
            Controls.Add(cmbHospitales);
            Controls.Add(lstPlantilla);
            Controls.Add(label3);
            Controls.Add(btnIncrementar);
            Controls.Add(txtIncremento);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form11UpdatePlantillaProcedures";
            Text = "Form11UpdatePlantillaProcedures";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtIncremento;
        private Button btnIncrementar;
        private Label label3;
        private ListBox lstPlantilla;
        private ComboBox cmbHospitales;
    }
}