namespace pryZarateFerro
{
    partial class frmFerro
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
            lblFerro = new Label();
            lblDistancia = new Label();
            btnCalcular = new Button();
            lblDias = new Label();
            numDistancia = new NumericUpDown();
            numDias = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numDistancia).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDias).BeginInit();
            SuspendLayout();
            // 
            // lblFerro
            // 
            lblFerro.AutoSize = true;
            lblFerro.Location = new Point(72, 37);
            lblFerro.Name = "lblFerro";
            lblFerro.Size = new Size(107, 15);
            lblFerro.TabIndex = 0;
            lblFerro.Text = "Organización Ferro";
            // 
            // lblDistancia
            // 
            lblDistancia.AutoSize = true;
            lblDistancia.Location = new Point(72, 107);
            lblDistancia.Name = "lblDistancia";
            lblDistancia.Size = new Size(55, 15);
            lblDistancia.TabIndex = 3;
            lblDistancia.Text = "Distancia";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(75, 257);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 5;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblDias
            // 
            lblDias.AutoSize = true;
            lblDias.Location = new Point(75, 149);
            lblDias.Name = "lblDias";
            lblDias.Size = new Size(29, 15);
            lblDias.TabIndex = 4;
            lblDias.Text = "Días";
            // 
            // numDistancia
            // 
            numDistancia.Location = new Point(156, 99);
            numDistancia.Name = "numDistancia";
            numDistancia.Size = new Size(120, 23);
            numDistancia.TabIndex = 6;
            // 
            // numDias
            // 
            numDias.Location = new Point(156, 147);
            numDias.Maximum = new decimal(new int[] { 30, 0, 0, 0 });
            numDias.Name = "numDias";
            numDias.Size = new Size(120, 23);
            numDias.TabIndex = 7;
            // 
            // frmFerro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(685, 450);
            Controls.Add(numDias);
            Controls.Add(numDistancia);
            Controls.Add(btnCalcular);
            Controls.Add(lblDias);
            Controls.Add(lblDistancia);
            Controls.Add(lblFerro);
            Name = "frmFerro";
            Text = "Ferro";
            ((System.ComponentModel.ISupportInitialize)numDistancia).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDias).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFerro;
        private Label lblDistancia;
        private Button btnCalcular;
        private Label lblDias;
        private NumericUpDown numDistancia;
        private NumericUpDown numDias;
    }
}