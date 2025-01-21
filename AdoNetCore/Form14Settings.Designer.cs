namespace AdoNetCore
{
    partial class Form14Settings
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
            lblCadenaConexion = new Label();
            btnLeer = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // lblCadenaConexion
            // 
            lblCadenaConexion.AutoSize = true;
            lblCadenaConexion.Location = new Point(71, 187);
            lblCadenaConexion.Name = "lblCadenaConexion";
            lblCadenaConexion.Size = new Size(276, 41);
            lblCadenaConexion.TabIndex = 0;
            lblCadenaConexion.Text = "lblCadenaConexion";
            // 
            // btnLeer
            // 
            btnLeer.Location = new Point(71, 52);
            btnLeer.Name = "btnLeer";
            btnLeer.Size = new Size(245, 65);
            btnLeer.TabIndex = 1;
            btnLeer.Text = "Leer settings";
            btnLeer.UseVisualStyleBackColor = true;
            btnLeer.Click += btnLeer_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(71, 249);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(599, 656);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(756, 249);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(704, 656);
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // Form14Settings
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1606, 1158);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btnLeer);
            Controls.Add(lblCadenaConexion);
            Name = "Form14Settings";
            Text = "Form14Settings";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCadenaConexion;
        private Button btnLeer;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}