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
            this.groupBoxEspacios = new System.Windows.Forms.GroupBox();
            this.buttonEliminarEspai = new System.Windows.Forms.Button();
            this.buttonAnyadirEspai = new System.Windows.Forms.Button();
            this.listBoxEspacios = new System.Windows.Forms.ListBox();
            this.bindingSourceDiasSemana = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourceHorarioInsta = new System.Windows.Forms.BindingSource(this.components);
            this.labelHorario = new System.Windows.Forms.Label();
            this.instalacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diasSemanaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horafinalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horainicioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iddiasemanaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.idinstalacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewHorariosInsta = new System.Windows.Forms.DataGridView();
            this.groupBoxHorario = new System.Windows.Forms.GroupBox();
            this.buttonEliminarHoraInsta = new System.Windows.Forms.Button();
            this.buttonAnyadirHoraInsta = new System.Windows.Forms.Button();
            this.buttonModificar = new System.Windows.Forms.Button();
            this.bindingSourceEspacios = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInstalacion)).BeginInit();
            this.groupBoxDatosInstalacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTipoGestion)).BeginInit();
            this.groupBoxEspacios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDiasSemana)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceHorarioInsta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHorariosInsta)).BeginInit();
            this.groupBoxHorario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceEspacios)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxInstalacion
            // 
            this.pictureBoxInstalacion.Location = new System.Drawing.Point(15, 45);
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
            this.groupBoxDatosInstalacion.Location = new System.Drawing.Point(182, 34);
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
            this.labelDatosInstalacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDatosInstalacion.Location = new System.Drawing.Point(12, 13);
            this.labelDatosInstalacion.Name = "labelDatosInstalacion";
            this.labelDatosInstalacion.Size = new System.Drawing.Size(176, 18);
            this.labelDatosInstalacion.TabIndex = 2;
            this.labelDatosInstalacion.Text = "DATOS INSTALACIÓN";
            // 
            // groupBoxEspacios
            // 
            this.groupBoxEspacios.Controls.Add(this.buttonEliminarEspai);
            this.groupBoxEspacios.Controls.Add(this.buttonAnyadirEspai);
            this.groupBoxEspacios.Controls.Add(this.listBoxEspacios);
            this.groupBoxEspacios.Location = new System.Drawing.Point(12, 153);
            this.groupBoxEspacios.Name = "groupBoxEspacios";
            this.groupBoxEspacios.Size = new System.Drawing.Size(523, 130);
            this.groupBoxEspacios.TabIndex = 3;
            this.groupBoxEspacios.TabStop = false;
            // 
            // buttonEliminarEspai
            // 
            this.buttonEliminarEspai.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminarEspai.Location = new System.Drawing.Point(407, 69);
            this.buttonEliminarEspai.Name = "buttonEliminarEspai";
            this.buttonEliminarEspai.Size = new System.Drawing.Size(114, 27);
            this.buttonEliminarEspai.TabIndex = 2;
            this.buttonEliminarEspai.Text = "Eliminar";
            this.buttonEliminarEspai.UseVisualStyleBackColor = true;
            this.buttonEliminarEspai.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // buttonAnyadirEspai
            // 
            this.buttonAnyadirEspai.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAnyadirEspai.Location = new System.Drawing.Point(407, 34);
            this.buttonAnyadirEspai.Name = "buttonAnyadirEspai";
            this.buttonAnyadirEspai.Size = new System.Drawing.Size(114, 29);
            this.buttonAnyadirEspai.TabIndex = 1;
            this.buttonAnyadirEspai.Text = "Añadir";
            this.buttonAnyadirEspai.UseVisualStyleBackColor = true;
            this.buttonAnyadirEspai.Click += new System.EventHandler(this.buttonAnyadir_Click);
            // 
            // listBoxEspacios
            // 
            this.listBoxEspacios.DataSource = this.bindingSourceEspacios;
            this.listBoxEspacios.DisplayMember = "nombre";
            this.listBoxEspacios.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBoxEspacios.FormattingEnabled = true;
            this.listBoxEspacios.Location = new System.Drawing.Point(3, 16);
            this.listBoxEspacios.Name = "listBoxEspacios";
            this.listBoxEspacios.Size = new System.Drawing.Size(399, 111);
            this.listBoxEspacios.TabIndex = 0;
            this.listBoxEspacios.ValueMember = "id";
            // 
            // bindingSourceDiasSemana
            // 
            this.bindingSourceDiasSemana.DataSource = typeof(Desktop.Dias_Semana);
            // 
            // bindingSourceHorarioInsta
            // 
            this.bindingSourceHorarioInsta.DataSource = typeof(Desktop.Instalacion_Horario);
            // 
            // labelHorario
            // 
            this.labelHorario.AutoSize = true;
            this.labelHorario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHorario.Location = new System.Drawing.Point(13, 297);
            this.labelHorario.Name = "labelHorario";
            this.labelHorario.Size = new System.Drawing.Size(84, 18);
            this.labelHorario.TabIndex = 5;
            this.labelHorario.Text = "HORARIO";
            // 
            // instalacionDataGridViewTextBoxColumn
            // 
            this.instalacionDataGridViewTextBoxColumn.DataPropertyName = "Instalacion";
            this.instalacionDataGridViewTextBoxColumn.HeaderText = "Instalacion";
            this.instalacionDataGridViewTextBoxColumn.Name = "instalacionDataGridViewTextBoxColumn";
            this.instalacionDataGridViewTextBoxColumn.Visible = false;
            // 
            // diasSemanaDataGridViewTextBoxColumn
            // 
            this.diasSemanaDataGridViewTextBoxColumn.DataPropertyName = "Dias_Semana";
            this.diasSemanaDataGridViewTextBoxColumn.HeaderText = "Dias_Semana";
            this.diasSemanaDataGridViewTextBoxColumn.Name = "diasSemanaDataGridViewTextBoxColumn";
            this.diasSemanaDataGridViewTextBoxColumn.Visible = false;
            // 
            // horafinalDataGridViewTextBoxColumn
            // 
            this.horafinalDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.horafinalDataGridViewTextBoxColumn.DataPropertyName = "hora_final";
            this.horafinalDataGridViewTextBoxColumn.HeaderText = "hora_final";
            this.horafinalDataGridViewTextBoxColumn.Name = "horafinalDataGridViewTextBoxColumn";
            // 
            // horainicioDataGridViewTextBoxColumn
            // 
            this.horainicioDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.horainicioDataGridViewTextBoxColumn.DataPropertyName = "hora_inicio";
            this.horainicioDataGridViewTextBoxColumn.HeaderText = "hora_inicio";
            this.horainicioDataGridViewTextBoxColumn.Name = "horainicioDataGridViewTextBoxColumn";
            // 
            // iddiasemanaDataGridViewTextBoxColumn
            // 
            this.iddiasemanaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.iddiasemanaDataGridViewTextBoxColumn.DataPropertyName = "id_dia_semana";
            this.iddiasemanaDataGridViewTextBoxColumn.DataSource = this.bindingSourceDiasSemana;
            this.iddiasemanaDataGridViewTextBoxColumn.DisplayMember = "nombre";
            this.iddiasemanaDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.iddiasemanaDataGridViewTextBoxColumn.HeaderText = "id_dia_semana";
            this.iddiasemanaDataGridViewTextBoxColumn.Name = "iddiasemanaDataGridViewTextBoxColumn";
            this.iddiasemanaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.iddiasemanaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.iddiasemanaDataGridViewTextBoxColumn.ValueMember = "id";
            // 
            // idinstalacionDataGridViewTextBoxColumn
            // 
            this.idinstalacionDataGridViewTextBoxColumn.DataPropertyName = "id_instalacion";
            this.idinstalacionDataGridViewTextBoxColumn.HeaderText = "id_instalacion";
            this.idinstalacionDataGridViewTextBoxColumn.Name = "idinstalacionDataGridViewTextBoxColumn";
            this.idinstalacionDataGridViewTextBoxColumn.Visible = false;
            // 
            // dataGridViewHorariosInsta
            // 
            this.dataGridViewHorariosInsta.AllowUserToAddRows = false;
            this.dataGridViewHorariosInsta.AutoGenerateColumns = false;
            this.dataGridViewHorariosInsta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHorariosInsta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idinstalacionDataGridViewTextBoxColumn,
            this.iddiasemanaDataGridViewTextBoxColumn,
            this.horainicioDataGridViewTextBoxColumn,
            this.horafinalDataGridViewTextBoxColumn,
            this.diasSemanaDataGridViewTextBoxColumn,
            this.instalacionDataGridViewTextBoxColumn});
            this.dataGridViewHorariosInsta.DataSource = this.bindingSourceHorarioInsta;
            this.dataGridViewHorariosInsta.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridViewHorariosInsta.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewHorariosInsta.Name = "dataGridViewHorariosInsta";
            this.dataGridViewHorariosInsta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewHorariosInsta.Size = new System.Drawing.Size(399, 204);
            this.dataGridViewHorariosInsta.TabIndex = 4;
            this.dataGridViewHorariosInsta.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridViewHorariosInsta_UserDeletingRow);
            // 
            // groupBoxHorario
            // 
            this.groupBoxHorario.Controls.Add(this.buttonEliminarHoraInsta);
            this.groupBoxHorario.Controls.Add(this.buttonAnyadirHoraInsta);
            this.groupBoxHorario.Controls.Add(this.dataGridViewHorariosInsta);
            this.groupBoxHorario.Location = new System.Drawing.Point(13, 313);
            this.groupBoxHorario.Name = "groupBoxHorario";
            this.groupBoxHorario.Size = new System.Drawing.Size(523, 223);
            this.groupBoxHorario.TabIndex = 6;
            this.groupBoxHorario.TabStop = false;
            // 
            // buttonEliminarHoraInsta
            // 
            this.buttonEliminarHoraInsta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminarHoraInsta.Location = new System.Drawing.Point(408, 109);
            this.buttonEliminarHoraInsta.Name = "buttonEliminarHoraInsta";
            this.buttonEliminarHoraInsta.Size = new System.Drawing.Size(115, 27);
            this.buttonEliminarHoraInsta.TabIndex = 6;
            this.buttonEliminarHoraInsta.Text = "Eliminar";
            this.buttonEliminarHoraInsta.UseVisualStyleBackColor = true;
            this.buttonEliminarHoraInsta.Click += new System.EventHandler(this.buttonEliminarHoraInsta_Click);
            // 
            // buttonAnyadirHoraInsta
            // 
            this.buttonAnyadirHoraInsta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAnyadirHoraInsta.Location = new System.Drawing.Point(408, 74);
            this.buttonAnyadirHoraInsta.Name = "buttonAnyadirHoraInsta";
            this.buttonAnyadirHoraInsta.Size = new System.Drawing.Size(115, 29);
            this.buttonAnyadirHoraInsta.TabIndex = 5;
            this.buttonAnyadirHoraInsta.Text = "Añadir";
            this.buttonAnyadirHoraInsta.UseVisualStyleBackColor = true;
            this.buttonAnyadirHoraInsta.Click += new System.EventHandler(this.buttonAnyadirHoraInsta_Click);
            // 
            // buttonModificar
            // 
            this.buttonModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModificar.Location = new System.Drawing.Point(182, 560);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(163, 42);
            this.buttonModificar.TabIndex = 7;
            this.buttonModificar.Text = "Modificar";
            this.buttonModificar.UseVisualStyleBackColor = true;
            this.buttonModificar.Click += new System.EventHandler(this.buttonModificar_Click);
            // 
            // bindingSourceEspacios
            // 
            this.bindingSourceEspacios.DataSource = typeof(Desktop.Espacio);
            // 
            // FormUnaInstalacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(548, 632);
            this.Controls.Add(this.buttonModificar);
            this.Controls.Add(this.groupBoxHorario);
            this.Controls.Add(this.labelHorario);
            this.Controls.Add(this.groupBoxEspacios);
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
            this.groupBoxEspacios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDiasSemana)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceHorarioInsta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHorariosInsta)).EndInit();
            this.groupBoxHorario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceEspacios)).EndInit();
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
        private System.Windows.Forms.GroupBox groupBoxEspacios;
        private System.Windows.Forms.Button buttonEliminarEspai;
        private System.Windows.Forms.Button buttonAnyadirEspai;
        private System.Windows.Forms.ListBox listBoxEspacios;
        private System.Windows.Forms.Label labelHorario;
        private System.Windows.Forms.BindingSource bindingSourceDiasSemana;
        private System.Windows.Forms.BindingSource bindingSourceHorarioInsta;
        private System.Windows.Forms.DataGridViewTextBoxColumn instalacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diasSemanaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horafinalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horainicioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn iddiasemanaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idinstalacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridViewHorariosInsta;
        private System.Windows.Forms.GroupBox groupBoxHorario;
        private System.Windows.Forms.Button buttonEliminarHoraInsta;
        private System.Windows.Forms.Button buttonAnyadirHoraInsta;
        private System.Windows.Forms.Button buttonModificar;
        private System.Windows.Forms.BindingSource bindingSourceEspacios;
    }
}