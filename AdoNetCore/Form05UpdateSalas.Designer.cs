namespace AdoNetCore
{
    partial class Form05UpdateSalas
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
            lstSalas = new ListBox();
            label2 = new Label();
            txtNuevaSala = new TextBox();
            btnModificar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 51);
            label1.Name = "label1";
            label1.Size = new Size(84, 41);
            label1.TabIndex = 0;
            label1.Text = "Salas";
            // 
            // lstSalas
            // 
            lstSalas.FormattingEnabled = true;
            lstSalas.Location = new Point(39, 108);
            lstSalas.Name = "lstSalas";
            lstSalas.Size = new Size(740, 455);
            lstSalas.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(856, 185);
            label2.Name = "label2";
            label2.Size = new Size(160, 41);
            label2.TabIndex = 2;
            label2.Text = "Nueva sala";
            // 
            // txtNuevaSala
            // 
            txtNuevaSala.Location = new Point(856, 241);
            txtNuevaSala.Name = "txtNuevaSala";
            txtNuevaSala.Size = new Size(345, 47);
            txtNuevaSala.TabIndex = 3;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(856, 316);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(345, 79);
            btnModificar.TabIndex = 4;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // Form05UpdateSalas
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1313, 620);
            Controls.Add(btnModificar);
            Controls.Add(txtNuevaSala);
            Controls.Add(label2);
            Controls.Add(lstSalas);
            Controls.Add(label1);
            Name = "Form05UpdateSalas";
            Text = "Form05UpdateSalas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox lstSalas;
        private Label label2;
        private TextBox txtNuevaSala;
        private Button btnModificar;
    }
}