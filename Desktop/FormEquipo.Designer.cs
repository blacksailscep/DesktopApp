namespace Desktop
{
    partial class FormEquipo
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
            this.components = new System.ComponentModel.Container();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxDeporte = new System.Windows.Forms.TextBox();
            this.textBoxCategoria = new System.Windows.Forms.TextBox();
            this.textBoxCompeticion = new System.Windows.Forms.TextBox();
            this.textBoxSexo = new System.Windows.Forms.TextBox();
            this.textBoxNivel = new System.Windows.Forms.TextBox();
            this.listBoxActividades = new System.Windows.Forms.ListBox();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.actconcedidaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.actconcedidaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(367, 92);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(810, 20);
            this.textBoxNombre.TabIndex = 1;
            // 
            // textBoxDeporte
            // 
            this.textBoxDeporte.Location = new System.Drawing.Point(367, 130);
            this.textBoxDeporte.Name = "textBoxDeporte";
            this.textBoxDeporte.Size = new System.Drawing.Size(810, 20);
            this.textBoxDeporte.TabIndex = 2;
            // 
            // textBoxCategoria
            // 
            this.textBoxCategoria.Location = new System.Drawing.Point(367, 169);
            this.textBoxCategoria.Name = "textBoxCategoria";
            this.textBoxCategoria.Size = new System.Drawing.Size(810, 20);
            this.textBoxCategoria.TabIndex = 3;
            // 
            // textBoxCompeticion
            // 
            this.textBoxCompeticion.Location = new System.Drawing.Point(367, 206);
            this.textBoxCompeticion.Name = "textBoxCompeticion";
            this.textBoxCompeticion.Size = new System.Drawing.Size(810, 20);
            this.textBoxCompeticion.TabIndex = 4;
            // 
            // textBoxSexo
            // 
            this.textBoxSexo.Location = new System.Drawing.Point(367, 242);
            this.textBoxSexo.Name = "textBoxSexo";
            this.textBoxSexo.Size = new System.Drawing.Size(810, 20);
            this.textBoxSexo.TabIndex = 5;
            // 
            // textBoxNivel
            // 
            this.textBoxNivel.Location = new System.Drawing.Point(367, 282);
            this.textBoxNivel.Name = "textBoxNivel";
            this.textBoxNivel.Size = new System.Drawing.Size(810, 20);
            this.textBoxNivel.TabIndex = 6;
            // 
            // listBoxActividades
            // 
            this.listBoxActividades.DataSource = this.actconcedidaBindingSource;
            this.listBoxActividades.DisplayMember = "nombre";
            this.listBoxActividades.FormattingEnabled = true;
            this.listBoxActividades.Location = new System.Drawing.Point(13, 337);
            this.listBoxActividades.Name = "listBoxActividades";
            this.listBoxActividades.Size = new System.Drawing.Size(1164, 238);
            this.listBoxActividades.TabIndex = 7;
            this.listBoxActividades.ValueMember = "nombre";
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(518, 607);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(173, 23);
            this.buttonAceptar.TabIndex = 8;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // actconcedidaBindingSource
            // 
            this.actconcedidaBindingSource.DataSource = typeof(Desktop.Act_concedida);
            // 
            // FormEquipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1250, 659);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.listBoxActividades);
            this.Controls.Add(this.textBoxNivel);
            this.Controls.Add(this.textBoxSexo);
            this.Controls.Add(this.textBoxCompeticion);
            this.Controls.Add(this.textBoxCategoria);
            this.Controls.Add(this.textBoxDeporte);
            this.Controls.Add(this.textBoxNombre);
            this.Name = "FormEquipo";
            this.Load += new System.EventHandler(this.FormEquipo_Load);
            this.Controls.SetChildIndex(this.textBoxNombre, 0);
            this.Controls.SetChildIndex(this.textBoxDeporte, 0);
            this.Controls.SetChildIndex(this.textBoxCategoria, 0);
            this.Controls.SetChildIndex(this.textBoxCompeticion, 0);
            this.Controls.SetChildIndex(this.textBoxSexo, 0);
            this.Controls.SetChildIndex(this.textBoxNivel, 0);
            this.Controls.SetChildIndex(this.listBoxActividades, 0);
            this.Controls.SetChildIndex(this.buttonAceptar, 0);
            ((System.ComponentModel.ISupportInitialize)(this.actconcedidaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxDeporte;
        private System.Windows.Forms.TextBox textBoxCategoria;
        private System.Windows.Forms.TextBox textBoxCompeticion;
        private System.Windows.Forms.TextBox textBoxSexo;
        private System.Windows.Forms.TextBox textBoxNivel;
        private System.Windows.Forms.ListBox listBoxActividades;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.BindingSource actconcedidaBindingSource;
    }
}
