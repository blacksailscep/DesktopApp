namespace Desktop
{
    partial class FormActividades
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
            this.tabControlActividades = new System.Windows.Forms.TabControl();
            this.tabPageActividades = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.buttonGenerarInforme = new System.Windows.Forms.Button();
            this.buttonGestionar = new System.Windows.Forms.Button();
            this.tabControlActividades.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlActividades
            // 
            this.tabControlActividades.Controls.Add(this.tabPageActividades);
            this.tabControlActividades.Controls.Add(this.tabPage2);
            this.tabControlActividades.Controls.Add(this.tabPage3);
            this.tabControlActividades.Location = new System.Drawing.Point(73, 110);
            this.tabControlActividades.Name = "tabControlActividades";
            this.tabControlActividades.SelectedIndex = 0;
            this.tabControlActividades.Size = new System.Drawing.Size(374, 260);
            this.tabControlActividades.TabIndex = 0;
            this.tabControlActividades.TabIndexChanged += new System.EventHandler(this.tabControlActividades_TabIndexChanged);
            // 
            // tabPageActividades
            // 
            this.tabPageActividades.Location = new System.Drawing.Point(4, 22);
            this.tabPageActividades.Name = "tabPageActividades";
            this.tabPageActividades.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageActividades.Size = new System.Drawing.Size(366, 234);
            this.tabPageActividades.TabIndex = 0;
            this.tabPageActividades.Text = "Aceptadas";
            this.tabPageActividades.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(366, 234);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Pendientes";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(366, 234);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Denegadas";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // buttonGenerarInforme
            // 
            this.buttonGenerarInforme.Location = new System.Drawing.Point(436, 81);
            this.buttonGenerarInforme.Name = "buttonGenerarInforme";
            this.buttonGenerarInforme.Size = new System.Drawing.Size(178, 23);
            this.buttonGenerarInforme.TabIndex = 1;
            this.buttonGenerarInforme.Text = "Generar Informe";
            this.buttonGenerarInforme.UseVisualStyleBackColor = true;
            // 
            // buttonGestionar
            // 
            this.buttonGestionar.Location = new System.Drawing.Point(123, 396);
            this.buttonGestionar.Name = "buttonGestionar";
            this.buttonGestionar.Size = new System.Drawing.Size(182, 23);
            this.buttonGestionar.TabIndex = 2;
            this.buttonGestionar.Text = "Gestionar / Ver";
            this.buttonGestionar.UseVisualStyleBackColor = true;
            // 
            // FormActividades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 479);
            this.Controls.Add(this.buttonGestionar);
            this.Controls.Add(this.buttonGenerarInforme);
            this.Controls.Add(this.tabControlActividades);
            this.Name = "FormActividades";
            this.Text = "Actividades";
            this.tabControlActividades.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlActividades;
        private System.Windows.Forms.TabPage tabPageActividades;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button buttonGenerarInforme;
        private System.Windows.Forms.Button buttonGestionar;
    }
}

