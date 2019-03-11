namespace Desktop
{
    partial class FormUnaInstalacion
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
            this.components = new System.ComponentModel.Container();
            this.pictureBoxInstalacion = new System.Windows.Forms.PictureBox();
            this.groupBoxDatosInstalacion = new System.Windows.Forms.GroupBox();
            this.comboBoxTipoGestion = new System.Windows.Forms.ComboBox();
            this.bindingSourceTipoGestion = new System.Windows.Forms.BindingSource(this.components);
            this.textBoxDireccion = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.labelTipoGestion = new System.Windows.Forms.Label();
            this.labelDireccion = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelDatosInstalacion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInstalacion)).BeginInit();
            this.groupBoxDatosInstalacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTipoGestion)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxInstalacion
            // 
            this.pictureBoxInstalacion.Location = new System.Drawing.Point(15, 40);
            this.pictureBoxInstalacion.Name = "pictureBoxInstalacion";
            this.pictureBoxInstalacion.Size = new System.Drawing.Size(161, 75);
            this.pictureBoxInstalacion.TabIndex = 0;
            this.pictureBoxInstalacion.TabStop = false;
            // 
            // groupBoxDatosInstalacion
            // 
            this.groupBoxDatosInstalacion.Controls.Add(this.comboBoxTipoGestion);
            this.groupBoxDatosInstalacion.Controls.Add(this.textBoxDireccion);
            this.groupBoxDatosInstalacion.Controls.Add(this.textBoxNombre);
            this.groupBoxDatosInstalacion.Controls.Add(this.labelTipoGestion);
            this.groupBoxDatosInstalacion.Controls.Add(this.labelDireccion);
            this.groupBoxDatosInstalacion.Controls.Add(this.labelNombre);
            this.groupBoxDatosInstalacion.Location = new System.Drawing.Point(182, 29);
            this.groupBoxDatosInstalacion.Name = "groupBoxDatosInstalacion";
            this.groupBoxDatosInstalacion.Size = new System.Drawing.Size(354, 100);
            this.groupBoxDatosInstalacion.TabIndex = 1;
            this.groupBoxDatosInstalacion.TabStop = false;
            // 
            // comboBoxTipoGestion
            // 
            this.comboBoxTipoGestion.DataSource = this.bindingSourceTipoGestion;
            this.comboBoxTipoGestion.DisplayMember = "nombre";
            this.comboBoxTipoGestion.FormattingEnabled = true;
            this.comboBoxTipoGestion.Location = new System.Drawing.Point(85, 70);
            this.comboBoxTipoGestion.Name = "comboBoxTipoGestion";
            this.comboBoxTipoGestion.Size = new System.Drawing.Size(263, 21);
            this.comboBoxTipoGestion.TabIndex = 5;
            this.comboBoxTipoGestion.ValueMember = "id";
            // 
            // bindingSourceTipoGestion
            // 
            this.bindingSourceTipoGestion.DataSource = typeof(Desktop.Tipo_gestion);
            // 
            // textBoxDireccion
            // 
            this.textBoxDireccion.Location = new System.Drawing.Point(60, 38);
            this.textBoxDireccion.Name = "textBoxDireccion";
            this.textBoxDireccion.Size = new System.Drawing.Size(288, 20);
            this.textBoxDireccion.TabIndex = 4;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(60, 8);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(288, 20);
            this.textBoxNombre.TabIndex = 3;
            // 
            // labelTipoGestion
            // 
            this.labelTipoGestion.AutoSize = true;
            this.labelTipoGestion.Location = new System.Drawing.Point(6, 73);
            this.labelTipoGestion.Name = "labelTipoGestion";
            this.labelTipoGestion.Size = new System.Drawing.Size(73, 13);
            this.labelTipoGestion.TabIndex = 2;
            this.labelTipoGestion.Text = "Tipo Gestión: ";
            // 
            // labelDireccion
            // 
            this.labelDireccion.AutoSize = true;
            this.labelDireccion.Location = new System.Drawing.Point(6, 41);
            this.labelDireccion.Name = "labelDireccion";
            this.labelDireccion.Size = new System.Drawing.Size(55, 13);
            this.labelDireccion.TabIndex = 1;
            this.labelDireccion.Text = "Dirección:";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(7, 11);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(47, 13);
            this.labelNombre.TabIndex = 0;
            this.labelNombre.Text = "Nombre:";
            // 
            // labelDatosInstalacion
            // 
            this.labelDatosInstalacion.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.labelDatosInstalacion.AutoSize = true;
            this.labelDatosInstalacion.Location = new System.Drawing.Point(12, 13);
            this.labelDatosInstalacion.Name = "labelDatosInstalacion";
            this.labelDatosInstalacion.Size = new System.Drawing.Size(89, 13);
            this.labelDatosInstalacion.TabIndex = 2;
            this.labelDatosInstalacion.Text = "Datos Instalacion";
            // 
            // FormUnaInstalacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(548, 393);
            this.Controls.Add(this.pictureBoxInstalacion);
            this.Controls.Add(this.labelDatosInstalacion);
            this.Controls.Add(this.groupBoxDatosInstalacion);
            this.Name = "FormUnaInstalacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Instalacion";
            this.Load += new System.EventHandler(this.FormUnaInstalacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInstalacion)).EndInit();
            this.groupBoxDatosInstalacion.ResumeLayout(false);
            this.groupBoxDatosInstalacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTipoGestion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxInstalacion;
        private System.Windows.Forms.GroupBox groupBoxDatosInstalacion;
        private System.Windows.Forms.Label labelDatosInstalacion;
        private System.Windows.Forms.Label labelTipoGestion;
        private System.Windows.Forms.Label labelDireccion;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.ComboBox comboBoxTipoGestion;
        private System.Windows.Forms.TextBox textBoxDireccion;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.BindingSource bindingSourceTipoGestion;
    }
}