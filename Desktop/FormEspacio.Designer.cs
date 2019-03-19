namespace Desktop
{
    partial class FormEspacio
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
            this.groupBoxDatos = new System.Windows.Forms.GroupBox();
            this.labelNombre = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.labelTipo = new System.Windows.Forms.Label();
            this.radioButtonExterior = new System.Windows.Forms.RadioButton();
            this.labelPrecio = new System.Windows.Forms.Label();
            this.textBoxPrecio = new System.Windows.Forms.TextBox();
            this.labelInstalación = new System.Windows.Forms.Label();
            this.textBoxInstalacion = new System.Windows.Forms.TextBox();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.groupBoxDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxDatos
            // 
            this.groupBoxDatos.Controls.Add(this.labelNombre);
            this.groupBoxDatos.Controls.Add(this.textBoxNombre);
            this.groupBoxDatos.Controls.Add(this.labelTipo);
            this.groupBoxDatos.Controls.Add(this.radioButtonExterior);
            this.groupBoxDatos.Controls.Add(this.labelPrecio);
            this.groupBoxDatos.Controls.Add(this.textBoxPrecio);
            this.groupBoxDatos.Controls.Add(this.labelInstalación);
            this.groupBoxDatos.Controls.Add(this.textBoxInstalacion);
            this.groupBoxDatos.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxDatos.Location = new System.Drawing.Point(0, 0);
            this.groupBoxDatos.Name = "groupBoxDatos";
            this.groupBoxDatos.Size = new System.Drawing.Size(284, 129);
            this.groupBoxDatos.TabIndex = 0;
            this.groupBoxDatos.TabStop = false;
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(12, 45);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(44, 13);
            this.labelNombre.TabIndex = 8;
            this.labelNombre.Text = "Nombre";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(76, 42);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(205, 20);
            this.textBoxNombre.TabIndex = 7;
            // 
            // labelTipo
            // 
            this.labelTipo.AutoSize = true;
            this.labelTipo.Location = new System.Drawing.Point(12, 103);
            this.labelTipo.Name = "labelTipo";
            this.labelTipo.Size = new System.Drawing.Size(28, 13);
            this.labelTipo.TabIndex = 6;
            this.labelTipo.Text = "Tipo";
            // 
            // radioButtonExterior
            // 
            this.radioButtonExterior.AutoSize = true;
            this.radioButtonExterior.Location = new System.Drawing.Point(76, 101);
            this.radioButtonExterior.Name = "radioButtonExterior";
            this.radioButtonExterior.Size = new System.Drawing.Size(60, 17);
            this.radioButtonExterior.TabIndex = 5;
            this.radioButtonExterior.TabStop = true;
            this.radioButtonExterior.Text = "Exterior";
            this.radioButtonExterior.UseVisualStyleBackColor = true;
            // 
            // labelPrecio
            // 
            this.labelPrecio.AutoSize = true;
            this.labelPrecio.Location = new System.Drawing.Point(12, 71);
            this.labelPrecio.Name = "labelPrecio";
            this.labelPrecio.Size = new System.Drawing.Size(37, 13);
            this.labelPrecio.TabIndex = 3;
            this.labelPrecio.Text = "Precio";
            // 
            // textBoxPrecio
            // 
            this.textBoxPrecio.Location = new System.Drawing.Point(76, 68);
            this.textBoxPrecio.Name = "textBoxPrecio";
            this.textBoxPrecio.Size = new System.Drawing.Size(205, 20);
            this.textBoxPrecio.TabIndex = 2;
            // 
            // labelInstalación
            // 
            this.labelInstalación.AutoSize = true;
            this.labelInstalación.Location = new System.Drawing.Point(12, 19);
            this.labelInstalación.Name = "labelInstalación";
            this.labelInstalación.Size = new System.Drawing.Size(58, 13);
            this.labelInstalación.TabIndex = 1;
            this.labelInstalación.Text = "Instalación";
            // 
            // textBoxInstalacion
            // 
            this.textBoxInstalacion.Dock = System.Windows.Forms.DockStyle.Right;
            this.textBoxInstalacion.Enabled = false;
            this.textBoxInstalacion.Location = new System.Drawing.Point(76, 16);
            this.textBoxInstalacion.Name = "textBoxInstalacion";
            this.textBoxInstalacion.Size = new System.Drawing.Size(205, 20);
            this.textBoxInstalacion.TabIndex = 0;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(140, 143);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 35);
            this.buttonCancelar.TabIndex = 1;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(59, 143);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(75, 35);
            this.buttonAceptar.TabIndex = 2;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // FormEspacio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(284, 190);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.groupBoxDatos);
            this.Name = "FormEspacio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormEspacio_Load);
            this.groupBoxDatos.ResumeLayout(false);
            this.groupBoxDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxDatos;
        private System.Windows.Forms.TextBox textBoxInstalacion;
        private System.Windows.Forms.Label labelInstalación;
        private System.Windows.Forms.TextBox textBoxPrecio;
        private System.Windows.Forms.Label labelPrecio;
        private System.Windows.Forms.RadioButton radioButtonExterior;
        private System.Windows.Forms.Label labelTipo;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.TextBox textBoxNombre;
    }
}