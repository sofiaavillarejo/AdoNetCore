namespace AdoNetCore
{
    partial class Form06UpdateSalasClases
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
            btnModificar = new Button();
            txtNuevaSala = new TextBox();
            label2 = new Label();
            lstSalas = new ListBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnModificar
            // 
            btnModificar.BackColor = SystemColors.Info;
            btnModificar.Location = new Point(869, 314);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(345, 79);
            btnModificar.TabIndex = 9;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // txtNuevaSala
            // 
            txtNuevaSala.Location = new Point(869, 239);
            txtNuevaSala.Name = "txtNuevaSala";
            txtNuevaSala.Size = new Size(345, 47);
            txtNuevaSala.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(869, 183);
            label2.Name = "label2";
            label2.Size = new Size(160, 41);
            label2.TabIndex = 7;
            label2.Text = "Nueva sala";
            // 
            // lstSalas
            // 
            lstSalas.FormattingEnabled = true;
            lstSalas.Location = new Point(52, 106);
            lstSalas.Name = "lstSalas";
            lstSalas.Size = new Size(740, 455);
            lstSalas.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 49);
            label1.Name = "label1";
            label1.Size = new Size(84, 41);
            label1.TabIndex = 5;
            label1.Text = "Salas";
            // 
            // Form06UpdateSalasClases
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1232, 592);
            Controls.Add(btnModificar);
            Controls.Add(txtNuevaSala);
            Controls.Add(label2);
            Controls.Add(lstSalas);
            Controls.Add(label1);
            Name = "Form06UpdateSalasClases";
            Text = "Form06UpdateSalasClases";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnModificar;
        private TextBox txtNuevaSala;
        private Label label2;
        private ListBox lstSalas;
        private Label label1;
    }
}