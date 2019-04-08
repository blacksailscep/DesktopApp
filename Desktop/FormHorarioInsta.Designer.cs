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
            this.components = new System.ComponentModel.Container();
            this.labelHorario = new System.Windows.Forms.Label();
            this.comboBoxDiasSemana = new System.Windows.Forms.ComboBox();
            this.bindingSourceDiesSetmana = new System.Windows.Forms.BindingSource(this.components);
            this.labelDiaSemana = new System.Windows.Forms.Label();
            this.labelHFin = new System.Windows.Forms.Label();
            this.labelHInicio = new System.Windows.Forms.Label();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.dateTimePickerHInicio = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerHFinal = new System.Windows.Forms.DateTimePicker();
            this.buttonCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDiesSetmana)).BeginInit();
            this.SuspendLayout();
            // 
            // labelHorario
            // 
            this.labelHorario.AutoSize = true;
            this.labelHorario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHorario.Location = new System.Drawing.Point(12, 19);
            this.labelHorario.Name = "labelHorario";
            this.labelHorario.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelHorario.Size = new System.Drawing.Size(84, 18);
            this.labelHorario.TabIndex = 6;
            this.labelHorario.Text = "HORARIO";
            this.labelHorario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxDiasSemana
            // 
            this.comboBoxDiasSemana.DataSource = this.bindingSourceDiesSetmana;
            this.comboBoxDiasSemana.DisplayMember = "nombre";
            this.comboBoxDiasSemana.FormattingEnabled = true;
            this.comboBoxDiasSemana.Location = new System.Drawing.Point(88, 45);
            this.comboBoxDiasSemana.Name = "comboBoxDiasSemana";
            this.comboBoxDiasSemana.Size = new System.Drawing.Size(184, 21);
            this.comboBoxDiasSemana.TabIndex = 13;
            this.comboBoxDiasSemana.ValueMember = "id";
            // 
            // bindingSourceDiesSetmana
            // 
            this.bindingSourceDiesSetmana.DataSource = typeof(Desktop.Dias_Semana);
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
            this.buttonAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAceptar.Location = new System.Drawing.Point(43, 174);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(96, 37);
            this.buttonAceptar.TabIndex = 14;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // dateTimePickerHInicio
            // 
            this.dateTimePickerHInicio.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerHInicio.Location = new System.Drawing.Point(88, 73);
            this.dateTimePickerHInicio.Name = "dateTimePickerHInicio";
            this.dateTimePickerHInicio.Size = new System.Drawing.Size(184, 20);
            this.dateTimePickerHInicio.TabIndex = 15;
            this.dateTimePickerHInicio.Value = new System.DateTime(2019, 3, 14, 0, 0, 0, 0);
            // 
            // dateTimePickerHFinal
            // 
            this.dateTimePickerHFinal.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerHFinal.Location = new System.Drawing.Point(88, 102);
            this.dateTimePickerHFinal.Name = "dateTimePickerHFinal";
            this.dateTimePickerHFinal.Size = new System.Drawing.Size(184, 20);
            this.dateTimePickerHFinal.TabIndex = 16;
            this.dateTimePickerHFinal.Value = new System.DateTime(2019, 3, 14, 0, 0, 0, 0);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelar.Location = new System.Drawing.Point(145, 174);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(96, 37);
            this.buttonCancelar.TabIndex = 17;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // FormHorarioInsta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(284, 223);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.dateTimePickerHFinal);
            this.Controls.Add(this.dateTimePickerHInicio);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.comboBoxDiasSemana);
            this.Controls.Add(this.labelDiaSemana);
            this.Controls.Add(this.labelHFin);
            this.Controls.Add(this.labelHInicio);
            this.Controls.Add(this.labelHorario);
            this.Name = "FormHorarioInsta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormHorarioInsta";
            this.Load += new System.EventHandler(this.FormHorarioInsta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDiesSetmana)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHorario;
        private System.Windows.Forms.ComboBox comboBoxDiasSemana;
        private System.Windows.Forms.Label labelDiaSemana;
        private System.Windows.Forms.Label labelHFin;
        private System.Windows.Forms.Label labelHInicio;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.DateTimePicker dateTimePickerHInicio;
        private System.Windows.Forms.DateTimePicker dateTimePickerHFinal;
        private System.Windows.Forms.BindingSource bindingSourceDiesSetmana;
        private System.Windows.Forms.Button buttonCancelar;
    }
}