namespace Desktop
{
    partial class FormHorarioInsta
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
            this.labelHorario = new System.Windows.Forms.Label();
            this.comboBoxTipoGestion = new System.Windows.Forms.ComboBox();
            this.textBoxDireccion = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.labelDiaSemana = new System.Windows.Forms.Label();
            this.labelHFin = new System.Windows.Forms.Label();
            this.labelHInicio = new System.Windows.Forms.Label();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelHorario
            // 
            this.labelHorario.AutoSize = true;
            this.labelHorario.Location = new System.Drawing.Point(12, 19);
            this.labelHorario.Name = "labelHorario";
            this.labelHorario.Size = new System.Drawing.Size(57, 13);
            this.labelHorario.TabIndex = 6;
            this.labelHorario.Text = "HORARIO";
            // 
            // comboBoxTipoGestion
            // 
            this.comboBoxTipoGestion.DisplayMember = "nombre";
            this.comboBoxTipoGestion.FormattingEnabled = true;
            this.comboBoxTipoGestion.Location = new System.Drawing.Point(88, 45);
            this.comboBoxTipoGestion.Name = "comboBoxTipoGestion";
            this.comboBoxTipoGestion.Size = new System.Drawing.Size(184, 21);
            this.comboBoxTipoGestion.TabIndex = 13;
            this.comboBoxTipoGestion.ValueMember = "id";
            // 
            // textBoxDireccion
            // 
            this.textBoxDireccion.Location = new System.Drawing.Point(88, 105);
            this.textBoxDireccion.Name = "textBoxDireccion";
            this.textBoxDireccion.Size = new System.Drawing.Size(184, 20);
            this.textBoxDireccion.TabIndex = 11;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(88, 76);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(184, 20);
            this.textBoxNombre.TabIndex = 10;
            // 
            // labelDiaSemana
            // 
            this.labelDiaSemana.AutoSize = true;
            this.labelDiaSemana.Location = new System.Drawing.Point(9, 48);
            this.labelDiaSemana.Name = "labelDiaSemana";
            this.labelDiaSemana.Size = new System.Drawing.Size(67, 13);
            this.labelDiaSemana.TabIndex = 9;
            this.labelDiaSemana.Text = "Día Semana";
            // 
            // labelHFin
            // 
            this.labelHFin.AutoSize = true;
            this.labelHFin.Location = new System.Drawing.Point(9, 108);
            this.labelHFin.Name = "labelHFin";
            this.labelHFin.Size = new System.Drawing.Size(50, 13);
            this.labelHFin.TabIndex = 8;
            this.labelHFin.Text = "Hora Fin:";
            // 
            // labelHInicio
            // 
            this.labelHInicio.AutoSize = true;
            this.labelHInicio.Location = new System.Drawing.Point(8, 79);
            this.labelHInicio.Name = "labelHInicio";
            this.labelHInicio.Size = new System.Drawing.Size(61, 13);
            this.labelHInicio.TabIndex = 7;
            this.labelHInicio.Text = "Hora Inicio:";
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(88, 152);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(75, 23);
            this.buttonAceptar.TabIndex = 14;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            // 
            // FormHorarioInsta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(284, 223);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.comboBoxTipoGestion);
            this.Controls.Add(this.textBoxDireccion);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.labelDiaSemana);
            this.Controls.Add(this.labelHFin);
            this.Controls.Add(this.labelHInicio);
            this.Controls.Add(this.labelHorario);
            this.Name = "FormHorarioInsta";
            this.Text = "FormHorarioInsta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHorario;
        private System.Windows.Forms.ComboBox comboBoxTipoGestion;
        private System.Windows.Forms.TextBox textBoxDireccion;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label labelDiaSemana;
        private System.Windows.Forms.Label labelHFin;
        private System.Windows.Forms.Label labelHInicio;
        private System.Windows.Forms.Button buttonAceptar;
    }
}