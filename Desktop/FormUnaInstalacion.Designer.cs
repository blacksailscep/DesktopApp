﻿namespace Desktop
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.buttonModificarEspai = new System.Windows.Forms.Button();
            this.buttonEliminarEspai = new System.Windows.Forms.Button();
            this.buttonAnyadirEspai = new System.Windows.Forms.Button();
            this.dataGridViewEspacios = new System.Windows.Forms.DataGridView();
            this.bindingSourceEspacios = new System.Windows.Forms.BindingSource(this.components);
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
            this.buttonModificarHorariInsa = new System.Windows.Forms.Button();
            this.buttonEliminarHoraInsta = new System.Windows.Forms.Button();
            this.buttonAnyadirHoraInsta = new System.Windows.Forms.Button();
            this.buttonModificar = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exteriorDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idinstalacionDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actconcedidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actdemandadasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.instalacionDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInstalacion)).BeginInit();
            this.groupBoxDatosInstalacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTipoGestion)).BeginInit();
            this.groupBoxEspacios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEspacios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceEspacios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDiasSemana)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceHorarioInsta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHorariosInsta)).BeginInit();
            this.groupBoxHorario.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxInstalacion
            // 
            this.pictureBoxInstalacion.Location = new System.Drawing.Point(20, 55);
            this.pictureBoxInstalacion.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxInstalacion.Name = "pictureBoxInstalacion";
            this.pictureBoxInstalacion.Size = new System.Drawing.Size(215, 92);
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
            this.groupBoxDatosInstalacion.Location = new System.Drawing.Point(243, 42);
            this.groupBoxDatosInstalacion.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxDatosInstalacion.Name = "groupBoxDatosInstalacion";
            this.groupBoxDatosInstalacion.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxDatosInstalacion.Size = new System.Drawing.Size(472, 123);
            this.groupBoxDatosInstalacion.TabIndex = 1;
            this.groupBoxDatosInstalacion.TabStop = false;
            // 
            // comboBoxTipoGestion
            // 
            this.comboBoxTipoGestion.DataSource = this.bindingSourceTipoGestion;
            this.comboBoxTipoGestion.DisplayMember = "nombre";
            this.comboBoxTipoGestion.FormattingEnabled = true;
            this.comboBoxTipoGestion.Location = new System.Drawing.Point(113, 86);
            this.comboBoxTipoGestion.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxTipoGestion.Name = "comboBoxTipoGestion";
            this.comboBoxTipoGestion.Size = new System.Drawing.Size(349, 24);
            this.comboBoxTipoGestion.TabIndex = 5;
            this.comboBoxTipoGestion.ValueMember = "id";
            // 
            // bindingSourceTipoGestion
            // 
            this.bindingSourceTipoGestion.DataSource = typeof(Desktop.Tipo_gestion);
            // 
            // textBoxDireccion
            // 
            this.textBoxDireccion.Location = new System.Drawing.Point(80, 47);
            this.textBoxDireccion.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDireccion.Name = "textBoxDireccion";
            this.textBoxDireccion.Size = new System.Drawing.Size(383, 22);
            this.textBoxDireccion.TabIndex = 4;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(80, 10);
            this.textBoxNombre.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(383, 22);
            this.textBoxNombre.TabIndex = 3;
            // 
            // labelTipoGestion
            // 
            this.labelTipoGestion.AutoSize = true;
            this.labelTipoGestion.Location = new System.Drawing.Point(8, 90);
            this.labelTipoGestion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTipoGestion.Name = "labelTipoGestion";
            this.labelTipoGestion.Size = new System.Drawing.Size(97, 17);
            this.labelTipoGestion.TabIndex = 2;
            this.labelTipoGestion.Text = "Tipo Gestión: ";
            // 
            // labelDireccion
            // 
            this.labelDireccion.AutoSize = true;
            this.labelDireccion.Location = new System.Drawing.Point(8, 50);
            this.labelDireccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDireccion.Name = "labelDireccion";
            this.labelDireccion.Size = new System.Drawing.Size(71, 17);
            this.labelDireccion.TabIndex = 1;
            this.labelDireccion.Text = "Dirección:";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(9, 14);
            this.labelNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(62, 17);
            this.labelNombre.TabIndex = 0;
            this.labelNombre.Text = "Nombre:";
            // 
            // labelDatosInstalacion
            // 
            this.labelDatosInstalacion.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.labelDatosInstalacion.AutoSize = true;
            this.labelDatosInstalacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDatosInstalacion.Location = new System.Drawing.Point(16, 16);
            this.labelDatosInstalacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDatosInstalacion.Name = "labelDatosInstalacion";
            this.labelDatosInstalacion.Size = new System.Drawing.Size(221, 24);
            this.labelDatosInstalacion.TabIndex = 2;
            this.labelDatosInstalacion.Text = "DATOS INSTALACIÓN";
            // 
            // groupBoxEspacios
            // 
            this.groupBoxEspacios.Controls.Add(this.buttonModificarEspai);
            this.groupBoxEspacios.Controls.Add(this.buttonEliminarEspai);
            this.groupBoxEspacios.Controls.Add(this.buttonAnyadirEspai);
            this.groupBoxEspacios.Controls.Add(this.dataGridViewEspacios);
            this.groupBoxEspacios.Location = new System.Drawing.Point(16, 188);
            this.groupBoxEspacios.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxEspacios.Name = "groupBoxEspacios";
            this.groupBoxEspacios.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxEspacios.Size = new System.Drawing.Size(697, 160);
            this.groupBoxEspacios.TabIndex = 3;
            this.groupBoxEspacios.TabStop = false;
            // 
            // buttonModificarEspai
            // 
            this.buttonModificarEspai.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModificarEspai.Location = new System.Drawing.Point(539, 16);
            this.buttonModificarEspai.Margin = new System.Windows.Forms.Padding(4);
            this.buttonModificarEspai.Name = "buttonModificarEspai";
            this.buttonModificarEspai.Size = new System.Drawing.Size(152, 36);
            this.buttonModificarEspai.TabIndex = 6;
            this.buttonModificarEspai.Text = "Modificar";
            this.buttonModificarEspai.UseVisualStyleBackColor = true;
            this.buttonModificarEspai.Click += new System.EventHandler(this.buttonModificarEspai_Click);
            // 
            // buttonEliminarEspai
            // 
            this.buttonEliminarEspai.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminarEspai.Location = new System.Drawing.Point(537, 103);
            this.buttonEliminarEspai.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEliminarEspai.Name = "buttonEliminarEspai";
            this.buttonEliminarEspai.Size = new System.Drawing.Size(152, 33);
            this.buttonEliminarEspai.TabIndex = 5;
            this.buttonEliminarEspai.Text = "Eliminar";
            this.buttonEliminarEspai.UseVisualStyleBackColor = true;
            this.buttonEliminarEspai.Click += new System.EventHandler(this.buttonEliminarEspai_Click);
            // 
            // buttonAnyadirEspai
            // 
            this.buttonAnyadirEspai.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAnyadirEspai.Location = new System.Drawing.Point(537, 60);
            this.buttonAnyadirEspai.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAnyadirEspai.Name = "buttonAnyadirEspai";
            this.buttonAnyadirEspai.Size = new System.Drawing.Size(152, 36);
            this.buttonAnyadirEspai.TabIndex = 4;
            this.buttonAnyadirEspai.Text = "Añadir";
            this.buttonAnyadirEspai.UseVisualStyleBackColor = true;
            this.buttonAnyadirEspai.Click += new System.EventHandler(this.buttonAnyadirEspai_Click);
            // 
            // dataGridViewEspacios
            // 
            this.dataGridViewEspacios.AllowUserToAddRows = false;
            this.dataGridViewEspacios.AutoGenerateColumns = false;
            this.dataGridViewEspacios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEspacios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.nombreDataGridViewTextBoxColumn,
            this.precioDataGridViewTextBoxColumn,
            this.exteriorDataGridViewCheckBoxColumn,
            this.idinstalacionDataGridViewTextBoxColumn1,
            this.actconcedidaDataGridViewTextBoxColumn,
            this.actdemandadasDataGridViewTextBoxColumn,
            this.instalacionDataGridViewTextBoxColumn1,
            this.equipoDataGridViewTextBoxColumn});
            this.dataGridViewEspacios.DataSource = this.bindingSourceEspacios;
            this.dataGridViewEspacios.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridViewEspacios.Location = new System.Drawing.Point(4, 19);
            this.dataGridViewEspacios.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewEspacios.Name = "dataGridViewEspacios";
            this.dataGridViewEspacios.ReadOnly = true;
            this.dataGridViewEspacios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewEspacios.Size = new System.Drawing.Size(529, 137);
            this.dataGridViewEspacios.TabIndex = 3;
            this.dataGridViewEspacios.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridViewEspacios_UserDeletingRow);
            this.dataGridViewEspacios.DoubleClick += new System.EventHandler(this.dataGridViewEspacios_DoubleClick);
            // 
            // bindingSourceEspacios
            // 
            this.bindingSourceEspacios.DataSource = typeof(Desktop.Espacio);
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
            this.labelHorario.Location = new System.Drawing.Point(17, 366);
            this.labelHorario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHorario.Name = "labelHorario";
            this.labelHorario.Size = new System.Drawing.Size(104, 24);
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
            this.dataGridViewHorariosInsta.Location = new System.Drawing.Point(4, 19);
            this.dataGridViewHorariosInsta.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewHorariosInsta.Name = "dataGridViewHorariosInsta";
            this.dataGridViewHorariosInsta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewHorariosInsta.Size = new System.Drawing.Size(532, 251);
            this.dataGridViewHorariosInsta.TabIndex = 4;
            this.dataGridViewHorariosInsta.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridViewHorariosInsta_UserDeletingRow);
            this.dataGridViewHorariosInsta.DoubleClick += new System.EventHandler(this.dataGridViewHorariosInsta_DoubleClick);
            // 
            // groupBoxHorario
            // 
            this.groupBoxHorario.Controls.Add(this.buttonModificarHorariInsa);
            this.groupBoxHorario.Controls.Add(this.buttonEliminarHoraInsta);
            this.groupBoxHorario.Controls.Add(this.buttonAnyadirHoraInsta);
            this.groupBoxHorario.Controls.Add(this.dataGridViewHorariosInsta);
            this.groupBoxHorario.Location = new System.Drawing.Point(17, 385);
            this.groupBoxHorario.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxHorario.Name = "groupBoxHorario";
            this.groupBoxHorario.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxHorario.Size = new System.Drawing.Size(697, 274);
            this.groupBoxHorario.TabIndex = 6;
            this.groupBoxHorario.TabStop = false;
            // 
            // buttonModificarHorariInsa
            // 
            this.buttonModificarHorariInsa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModificarHorariInsa.Location = new System.Drawing.Point(544, 73);
            this.buttonModificarHorariInsa.Margin = new System.Windows.Forms.Padding(4);
            this.buttonModificarHorariInsa.Name = "buttonModificarHorariInsa";
            this.buttonModificarHorariInsa.Size = new System.Drawing.Size(152, 36);
            this.buttonModificarHorariInsa.TabIndex = 7;
            this.buttonModificarHorariInsa.Text = "Modificar";
            this.buttonModificarHorariInsa.UseVisualStyleBackColor = true;
            this.buttonModificarHorariInsa.Click += new System.EventHandler(this.buttonModificarHorariInsa_Click);
            // 
            // buttonEliminarHoraInsta
            // 
            this.buttonEliminarHoraInsta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminarHoraInsta.Location = new System.Drawing.Point(543, 159);
            this.buttonEliminarHoraInsta.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEliminarHoraInsta.Name = "buttonEliminarHoraInsta";
            this.buttonEliminarHoraInsta.Size = new System.Drawing.Size(153, 33);
            this.buttonEliminarHoraInsta.TabIndex = 6;
            this.buttonEliminarHoraInsta.Text = "Eliminar";
            this.buttonEliminarHoraInsta.UseVisualStyleBackColor = true;
            this.buttonEliminarHoraInsta.Click += new System.EventHandler(this.buttonEliminarHoraInsta_Click);
            // 
            // buttonAnyadirHoraInsta
            // 
            this.buttonAnyadirHoraInsta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAnyadirHoraInsta.Location = new System.Drawing.Point(543, 116);
            this.buttonAnyadirHoraInsta.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAnyadirHoraInsta.Name = "buttonAnyadirHoraInsta";
            this.buttonAnyadirHoraInsta.Size = new System.Drawing.Size(153, 36);
            this.buttonAnyadirHoraInsta.TabIndex = 5;
            this.buttonAnyadirHoraInsta.Text = "Añadir";
            this.buttonAnyadirHoraInsta.UseVisualStyleBackColor = true;
            this.buttonAnyadirHoraInsta.Click += new System.EventHandler(this.buttonAnyadirHoraInsta_Click);
            // 
            // buttonModificar
            // 
            this.buttonModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModificar.Location = new System.Drawing.Point(243, 689);
            this.buttonModificar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(217, 52);
            this.buttonModificar.TabIndex = 7;
            this.buttonModificar.Text = "Modificar";
            this.buttonModificar.UseVisualStyleBackColor = true;
            this.buttonModificar.Click += new System.EventHandler(this.buttonModificar_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // precioDataGridViewTextBoxColumn
            // 
            this.precioDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.precioDataGridViewTextBoxColumn.DataPropertyName = "precio";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.precioDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.precioDataGridViewTextBoxColumn.HeaderText = "Precio";
            this.precioDataGridViewTextBoxColumn.Name = "precioDataGridViewTextBoxColumn";
            this.precioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // exteriorDataGridViewCheckBoxColumn
            // 
            this.exteriorDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.exteriorDataGridViewCheckBoxColumn.DataPropertyName = "exterior";
            this.exteriorDataGridViewCheckBoxColumn.HeaderText = "Exterior";
            this.exteriorDataGridViewCheckBoxColumn.Name = "exteriorDataGridViewCheckBoxColumn";
            this.exteriorDataGridViewCheckBoxColumn.ReadOnly = true;
            this.exteriorDataGridViewCheckBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.exteriorDataGridViewCheckBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // idinstalacionDataGridViewTextBoxColumn1
            // 
            this.idinstalacionDataGridViewTextBoxColumn1.DataPropertyName = "id_instalacion";
            this.idinstalacionDataGridViewTextBoxColumn1.HeaderText = "id_instalacion";
            this.idinstalacionDataGridViewTextBoxColumn1.Name = "idinstalacionDataGridViewTextBoxColumn1";
            this.idinstalacionDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idinstalacionDataGridViewTextBoxColumn1.Visible = false;
            // 
            // actconcedidaDataGridViewTextBoxColumn
            // 
            this.actconcedidaDataGridViewTextBoxColumn.DataPropertyName = "Act_concedida";
            this.actconcedidaDataGridViewTextBoxColumn.HeaderText = "Act_concedida";
            this.actconcedidaDataGridViewTextBoxColumn.Name = "actconcedidaDataGridViewTextBoxColumn";
            this.actconcedidaDataGridViewTextBoxColumn.ReadOnly = true;
            this.actconcedidaDataGridViewTextBoxColumn.Visible = false;
            // 
            // actdemandadasDataGridViewTextBoxColumn
            // 
            this.actdemandadasDataGridViewTextBoxColumn.DataPropertyName = "Act_demandadas";
            this.actdemandadasDataGridViewTextBoxColumn.HeaderText = "Act_demandadas";
            this.actdemandadasDataGridViewTextBoxColumn.Name = "actdemandadasDataGridViewTextBoxColumn";
            this.actdemandadasDataGridViewTextBoxColumn.ReadOnly = true;
            this.actdemandadasDataGridViewTextBoxColumn.Visible = false;
            // 
            // instalacionDataGridViewTextBoxColumn1
            // 
            this.instalacionDataGridViewTextBoxColumn1.DataPropertyName = "Instalacion";
            this.instalacionDataGridViewTextBoxColumn1.HeaderText = "Instalacion";
            this.instalacionDataGridViewTextBoxColumn1.Name = "instalacionDataGridViewTextBoxColumn1";
            this.instalacionDataGridViewTextBoxColumn1.ReadOnly = true;
            this.instalacionDataGridViewTextBoxColumn1.Visible = false;
            // 
            // equipoDataGridViewTextBoxColumn
            // 
            this.equipoDataGridViewTextBoxColumn.DataPropertyName = "Equipo";
            this.equipoDataGridViewTextBoxColumn.HeaderText = "Equipo";
            this.equipoDataGridViewTextBoxColumn.Name = "equipoDataGridViewTextBoxColumn";
            this.equipoDataGridViewTextBoxColumn.ReadOnly = true;
            this.equipoDataGridViewTextBoxColumn.Visible = false;
            // 
            // FormUnaInstalacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(731, 778);
            this.Controls.Add(this.buttonModificar);
            this.Controls.Add(this.groupBoxHorario);
            this.Controls.Add(this.labelHorario);
            this.Controls.Add(this.groupBoxEspacios);
            this.Controls.Add(this.pictureBoxInstalacion);
            this.Controls.Add(this.labelDatosInstalacion);
            this.Controls.Add(this.groupBoxDatosInstalacion);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormUnaInstalacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Instalacion";
            this.Activated += new System.EventHandler(this.FormUnaInstalacion_Activated);
            this.Load += new System.EventHandler(this.FormUnaInstalacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInstalacion)).EndInit();
            this.groupBoxDatosInstalacion.ResumeLayout(false);
            this.groupBoxDatosInstalacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTipoGestion)).EndInit();
            this.groupBoxEspacios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEspacios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceEspacios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDiasSemana)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceHorarioInsta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHorariosInsta)).EndInit();
            this.groupBoxHorario.ResumeLayout(false);
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
        private System.Windows.Forms.DataGridView dataGridViewEspacios;
        private System.Windows.Forms.Button buttonModificarEspai;
        private System.Windows.Forms.Button buttonEliminarEspai;
        private System.Windows.Forms.Button buttonAnyadirEspai;
        private System.Windows.Forms.Button buttonModificarHorariInsa;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn exteriorDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idinstalacionDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn actconcedidaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn actdemandadasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn instalacionDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipoDataGridViewTextBoxColumn;
    }
}