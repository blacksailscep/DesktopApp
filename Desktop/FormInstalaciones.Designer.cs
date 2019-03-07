namespace Desktop
{
    partial class FormInstalaciones
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxBuscaInsta = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBoxBusca = new System.Windows.Forms.PictureBox();
            this.buttonGenerarInforme = new System.Windows.Forms.Button();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.groupBoxBuscaInsta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBusca)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxBuscaInsta
            // 
            this.groupBoxBuscaInsta.Controls.Add(this.buttonBuscar);
            this.groupBoxBuscaInsta.Controls.Add(this.buttonGenerarInforme);
            this.groupBoxBuscaInsta.Controls.Add(this.pictureBoxBusca);
            this.groupBoxBuscaInsta.Controls.Add(this.textBox1);
            this.groupBoxBuscaInsta.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxBuscaInsta.Location = new System.Drawing.Point(0, 44);
            this.groupBoxBuscaInsta.Name = "groupBoxBuscaInsta";
            this.groupBoxBuscaInsta.Size = new System.Drawing.Size(1250, 49);
            this.groupBoxBuscaInsta.TabIndex = 1;
            this.groupBoxBuscaInsta.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(34, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(322, 20);
            this.textBox1.TabIndex = 0;
            // 
            // pictureBoxBusca
            // 
            this.pictureBoxBusca.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBoxBusca.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxBusca.ErrorImage = global::Desktop.Properties.Resources.lupa;
            this.pictureBoxBusca.Image = global::Desktop.Properties.Resources.lupa;
            this.pictureBoxBusca.Location = new System.Drawing.Point(3, 16);
            this.pictureBoxBusca.Name = "pictureBoxBusca";
            this.pictureBoxBusca.Size = new System.Drawing.Size(25, 30);
            this.pictureBoxBusca.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBusca.TabIndex = 1;
            this.pictureBoxBusca.TabStop = false;
            // 
            // buttonGenerarInforme
            // 
            this.buttonGenerarInforme.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonGenerarInforme.Location = new System.Drawing.Point(1033, 16);
            this.buttonGenerarInforme.Name = "buttonGenerarInforme";
            this.buttonGenerarInforme.Size = new System.Drawing.Size(214, 30);
            this.buttonGenerarInforme.TabIndex = 2;
            this.buttonGenerarInforme.Text = "Generar Informe";
            this.buttonGenerarInforme.UseVisualStyleBackColor = true;
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(363, 17);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(69, 23);
            this.buttonBuscar.TabIndex = 3;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            // 
            // FormInstalaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1250, 659);
            this.Controls.Add(this.groupBoxBuscaInsta);
            this.Name = "FormInstalaciones";
            this.Controls.SetChildIndex(this.groupBoxBuscaInsta, 0);
            this.groupBoxBuscaInsta.ResumeLayout(false);
            this.groupBoxBuscaInsta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBusca)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxBuscaInsta;
        private System.Windows.Forms.PictureBox pictureBoxBusca;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonGenerarInforme;
        private System.Windows.Forms.Button buttonBuscar;
    }
}
