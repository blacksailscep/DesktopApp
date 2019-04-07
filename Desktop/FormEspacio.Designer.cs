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
            this.labelPrecio = new System.Windows.Forms.Label();
            this.textBoxPrecio = new System.Windows.Forms.TextBox();
            this.labelInstalación = new System.Windows.Forms.Label();
            this.textBoxInstalacion = new System.Windows.Forms.TextBox();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.radioButtonExterior = new System.Windows.Forms.RadioButton();
            this.groupBoxDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxDatos
            // 
            this.groupBoxDatos.Controls.Add(this.radioButtonExterior);
            this.groupBoxDatos.Controls.Add(this.labelNombre);
            this.groupBoxDatos.Controls.Add(this.textBoxNombre);
            this.groupBoxDatos.Controls.Add(this.labelTipo);
            this.groupBoxDatos.Controls.Add(this.labelPrecio);
            this.groupBoxDatos.Controls.Add(this.textBoxPrecio);
            this.groupBoxDatos.Controls.Add(this.labelInstalación);
            this.groupBoxDatos.Controls.Add(this.textBoxInstalacion);
            this.groupBoxDatos.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxDatos.Location = new System.Drawing.Point(0, 0);
            this.groupBoxDatos.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxDatos.Name = "groupBoxDatos";
            this.groupBoxDatos.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxDatos.Size = new System.Drawing.Size(379, 159);
            this.groupBoxDatos.TabIndex = 0;
            this.groupBoxDatos.TabStop = false;
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(16, 55);
            this.labelNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(58, 17);
            this.labelNombre.TabIndex = 8;
            this.labelNombre.Text = "Nombre";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(101, 52);
            this.textBoxNombre.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(272, 22);
            this.textBoxNombre.TabIndex = 7;
            // 
            // labelTipo
            // 
            this.labelTipo.AutoSize = true;
            this.labelTipo.Location = new System.Drawing.Point(16, 127);
            this.labelTipo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTipo.Name = "labelTipo";
            this.labelTipo.Size = new System.Drawing.Size(36, 17);
            this.labelTipo.TabIndex = 6;
            this.labelTipo.Text = "Tipo";
            // 
            // labelPrecio
            // 
            this.labelPrecio.AutoSize = true;
            this.labelPrecio.Location = new System.Drawing.Point(16, 87);
            this.labelPrecio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPrecio.Name = "labelPrecio";
            this.labelPrecio.Size = new System.Drawing.Size(48, 17);
            this.labelPrecio.TabIndex = 3;
            this.labelPrecio.Text = "Precio";
            // 
            // textBoxPrecio
            // 
            this.textBoxPrecio.Location = new System.Drawing.Point(101, 84);
            this.textBoxPrecio.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPrecio.Name = "textBoxPrecio";
            this.textBoxPrecio.Size = new System.Drawing.Size(272, 22);
            this.textBoxPrecio.TabIndex = 2;
            this.textBoxPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPrecio_KeyPress);
            // 
            // labelInstalación
            // 
            this.labelInstalación.AutoSize = true;
            this.labelInstalación.Location = new System.Drawing.Point(16, 23);
            this.labelInstalación.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelInstalación.Name = "labelInstalación";
            this.labelInstalación.Size = new System.Drawing.Size(75, 17);
            this.labelInstalación.TabIndex = 1;
            this.labelInstalación.Text = "Instalación";
            // 
            // textBoxInstalacion
            // 
            this.textBoxInstalacion.Dock = System.Windows.Forms.DockStyle.Right;
            this.textBoxInstalacion.Enabled = false;
            this.textBoxInstalacion.Location = new System.Drawing.Point(103, 19);
            this.textBoxInstalacion.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxInstalacion.Name = "textBoxInstalacion";
            this.textBoxInstalacion.Size = new System.Drawing.Size(272, 22);
            this.textBoxInstalacion.TabIndex = 0;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(187, 176);
            this.buttonCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(100, 43);
            this.buttonCancelar.TabIndex = 1;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(79, 176);
            this.buttonAceptar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(100, 43);
            this.buttonAceptar.TabIndex = 2;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // radioButtonExterior
            // 
            this.radioButtonExterior.AutoSize = true;
            this.radioButtonExterior.Location = new System.Drawing.Point(101, 127);
            this.radioButtonExterior.Name = "radioButtonExterior";
            this.radioButtonExterior.Size = new System.Drawing.Size(77, 21);
            this.radioButtonExterior.TabIndex = 9;
            this.radioButtonExterior.TabStop = true;
            this.radioButtonExterior.Text = "Exterior";
            this.radioButtonExterior.UseVisualStyleBackColor = true;
            // 
            // FormEspacio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(379, 234);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.groupBoxDatos);
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.Label labelTipo;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.RadioButton radioButtonExterior;
    }
}