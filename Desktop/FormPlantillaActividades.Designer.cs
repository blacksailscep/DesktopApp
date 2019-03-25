namespace Desktop
{
    partial class FormPlantillaActividades
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonGestionar = new System.Windows.Forms.Button();
            this.buttonGenerarInforme = new System.Windows.Forms.Button();
            this.tabControlActividades = new System.Windows.Forms.TabControl();
            this.tabPageAceptadas = new System.Windows.Forms.TabPage();
            this.dataGridViewAceptadas = new System.Windows.Forms.DataGridView();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Equipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.espacio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceAceptadas = new System.Windows.Forms.BindingSource(this.components);
            this.tabPagePendientes = new System.Windows.Forms.TabPage();
            this.dataGridViewPendientes = new System.Windows.Forms.DataGridView();
            this.NombreActividadPendiente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexo_pendientes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EquipoActividadPendiente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EspacioActPen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoActPen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourcePendientes = new System.Windows.Forms.BindingSource(this.components);
            this.tabPageDenegadas = new System.Windows.Forms.TabPage();
            this.dataGridViewDenegadas = new System.Windows.Forms.DataGridView();
            this.bindingSourceDenegdas = new System.Windows.Forms.BindingSource(this.components);
            this.equipoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.espacioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tipoActBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idtipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.idespacioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.idequipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tabControlActividades.SuspendLayout();
            this.tabPageAceptadas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAceptadas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceAceptadas)).BeginInit();
            this.tabPagePendientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPendientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePendientes)).BeginInit();
            this.tabPageDenegadas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDenegadas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDenegdas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.espacioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoActBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonGestionar
            // 
            this.buttonGestionar.Location = new System.Drawing.Point(63, 598);
            this.buttonGestionar.Name = "buttonGestionar";
            this.buttonGestionar.Size = new System.Drawing.Size(182, 23);
            this.buttonGestionar.TabIndex = 5;
            this.buttonGestionar.Text = "Gestionar / Ver";
            this.buttonGestionar.UseVisualStyleBackColor = true;
            // 
            // buttonGenerarInforme
            // 
            this.buttonGenerarInforme.Location = new System.Drawing.Point(990, 91);
            this.buttonGenerarInforme.Name = "buttonGenerarInforme";
            this.buttonGenerarInforme.Size = new System.Drawing.Size(178, 23);
            this.buttonGenerarInforme.TabIndex = 4;
            this.buttonGenerarInforme.Text = "Generar Informe";
            this.buttonGenerarInforme.UseVisualStyleBackColor = true;
            // 
            // tabControlActividades
            // 
            this.tabControlActividades.Controls.Add(this.tabPageAceptadas);
            this.tabControlActividades.Controls.Add(this.tabPagePendientes);
            this.tabControlActividades.Controls.Add(this.tabPageDenegadas);
            this.tabControlActividades.Location = new System.Drawing.Point(56, 141);
            this.tabControlActividades.Name = "tabControlActividades";
            this.tabControlActividades.SelectedIndex = 0;
            this.tabControlActividades.Size = new System.Drawing.Size(1143, 398);
            this.tabControlActividades.TabIndex = 3;
            // 
            // tabPageAceptadas
            // 
            this.tabPageAceptadas.Controls.Add(this.dataGridViewAceptadas);
            this.tabPageAceptadas.Location = new System.Drawing.Point(4, 22);
            this.tabPageAceptadas.Name = "tabPageAceptadas";
            this.tabPageAceptadas.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAceptadas.Size = new System.Drawing.Size(1135, 372);
            this.tabPageAceptadas.TabIndex = 0;
            this.tabPageAceptadas.Text = "Aceptadas";
            this.tabPageAceptadas.UseVisualStyleBackColor = true;
            // 
            // dataGridViewAceptadas
            // 
            this.dataGridViewAceptadas.AllowUserToAddRows = false;
            this.dataGridViewAceptadas.AllowUserToDeleteRows = false;
            this.dataGridViewAceptadas.AutoGenerateColumns = false;
            this.dataGridViewAceptadas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAceptadas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewAceptadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAceptadas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombre,
            this.Sexo,
            this.Equipo,
            this.espacio,
            this.tipo});
            this.dataGridViewAceptadas.DataSource = this.bindingSourceAceptadas;
            this.dataGridViewAceptadas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewAceptadas.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewAceptadas.Name = "dataGridViewAceptadas";
            this.dataGridViewAceptadas.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewAceptadas.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewAceptadas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAceptadas.Size = new System.Drawing.Size(1129, 366);
            this.dataGridViewAceptadas.TabIndex = 0;
            this.dataGridViewAceptadas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAceptadas_CellDoubleClick);
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // Sexo
            // 
            this.Sexo.DataPropertyName = "Sexo";
            this.Sexo.HeaderText = "Sexo";
            this.Sexo.Name = "Sexo";
            this.Sexo.ReadOnly = true;
            // 
            // Equipo
            // 
            this.Equipo.DataPropertyName = "equipo";
            this.Equipo.HeaderText = "Equipo";
            this.Equipo.Name = "Equipo";
            this.Equipo.ReadOnly = true;
            // 
            // espacio
            // 
            this.espacio.DataPropertyName = "espacio";
            this.espacio.HeaderText = "Espacio";
            this.espacio.Name = "espacio";
            this.espacio.ReadOnly = true;
            // 
            // tipo
            // 
            this.tipo.DataPropertyName = "tipo";
            this.tipo.HeaderText = "Tipo Actividad";
            this.tipo.Name = "tipo";
            this.tipo.ReadOnly = true;
            // 
            // tabPagePendientes
            // 
            this.tabPagePendientes.Controls.Add(this.dataGridViewPendientes);
            this.tabPagePendientes.Location = new System.Drawing.Point(4, 22);
            this.tabPagePendientes.Name = "tabPagePendientes";
            this.tabPagePendientes.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePendientes.Size = new System.Drawing.Size(1135, 372);
            this.tabPagePendientes.TabIndex = 1;
            this.tabPagePendientes.Text = "Pendientes";
            this.tabPagePendientes.UseVisualStyleBackColor = true;
            // 
            // dataGridViewPendientes
            // 
            this.dataGridViewPendientes.AllowUserToAddRows = false;
            this.dataGridViewPendientes.AllowUserToDeleteRows = false;
            this.dataGridViewPendientes.AutoGenerateColumns = false;
            this.dataGridViewPendientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPendientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewPendientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPendientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreActividadPendiente,
            this.sexo_pendientes,
            this.EquipoActividadPendiente,
            this.EspacioActPen,
            this.TipoActPen});
            this.dataGridViewPendientes.DataSource = this.bindingSourcePendientes;
            this.dataGridViewPendientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewPendientes.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewPendientes.Name = "dataGridViewPendientes";
            this.dataGridViewPendientes.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewPendientes.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewPendientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPendientes.Size = new System.Drawing.Size(1129, 366);
            this.dataGridViewPendientes.TabIndex = 0;
            this.dataGridViewPendientes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPendientes_CellDoubleClick);
            // 
            // NombreActividadPendiente
            // 
            this.NombreActividadPendiente.DataPropertyName = "nombre";
            this.NombreActividadPendiente.HeaderText = "Nombre";
            this.NombreActividadPendiente.Name = "NombreActividadPendiente";
            this.NombreActividadPendiente.ReadOnly = true;
            // 
            // sexo_pendientes
            // 
            this.sexo_pendientes.DataPropertyName = "sexo";
            this.sexo_pendientes.HeaderText = "Sexo";
            this.sexo_pendientes.Name = "sexo_pendientes";
            this.sexo_pendientes.ReadOnly = true;
            // 
            // EquipoActividadPendiente
            // 
            this.EquipoActividadPendiente.DataPropertyName = "equipo";
            this.EquipoActividadPendiente.HeaderText = "Equipo";
            this.EquipoActividadPendiente.Name = "EquipoActividadPendiente";
            this.EquipoActividadPendiente.ReadOnly = true;
            // 
            // EspacioActPen
            // 
            this.EspacioActPen.DataPropertyName = "espacio";
            this.EspacioActPen.HeaderText = "Espacio";
            this.EspacioActPen.Name = "EspacioActPen";
            this.EspacioActPen.ReadOnly = true;
            // 
            // TipoActPen
            // 
            this.TipoActPen.DataPropertyName = "tipo";
            this.TipoActPen.HeaderText = "Tipo Actividad";
            this.TipoActPen.Name = "TipoActPen";
            this.TipoActPen.ReadOnly = true;
            // 
            // tabPageDenegadas
            // 
            this.tabPageDenegadas.Controls.Add(this.dataGridViewDenegadas);
            this.tabPageDenegadas.Location = new System.Drawing.Point(4, 22);
            this.tabPageDenegadas.Name = "tabPageDenegadas";
            this.tabPageDenegadas.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDenegadas.Size = new System.Drawing.Size(1135, 372);
            this.tabPageDenegadas.TabIndex = 2;
            this.tabPageDenegadas.Text = "Denegadas";
            this.tabPageDenegadas.UseVisualStyleBackColor = true;
            // 
            // dataGridViewDenegadas
            // 
            this.dataGridViewDenegadas.AllowUserToDeleteRows = false;
            this.dataGridViewDenegadas.AutoGenerateColumns = false;
            this.dataGridViewDenegadas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDenegadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDenegadas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.idtipoDataGridViewTextBoxColumn,
            this.idespacioDataGridViewTextBoxColumn,
            this.idequipoDataGridViewTextBoxColumn});
            this.dataGridViewDenegadas.DataSource = this.bindingSourceDenegdas;
            this.dataGridViewDenegadas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDenegadas.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewDenegadas.Name = "dataGridViewDenegadas";
            this.dataGridViewDenegadas.ReadOnly = true;
            this.dataGridViewDenegadas.Size = new System.Drawing.Size(1129, 366);
            this.dataGridViewDenegadas.TabIndex = 0;
            // 
            // bindingSourceDenegdas
            // 
            this.bindingSourceDenegdas.DataSource = typeof(Desktop.Act_demandadas);
            // 
            // equipoBindingSource
            // 
            this.equipoBindingSource.DataSource = typeof(Desktop.Equipo);
            // 
            // espacioBindingSource
            // 
            this.espacioBindingSource.DataSource = typeof(Desktop.Espacio);
            // 
            // tipoActBindingSource
            // 
            this.tipoActBindingSource.DataSource = typeof(Desktop.Tipo_Act);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idtipoDataGridViewTextBoxColumn
            // 
            this.idtipoDataGridViewTextBoxColumn.DataPropertyName = "id_tipo";
            this.idtipoDataGridViewTextBoxColumn.DataSource = this.tipoActBindingSource;
            this.idtipoDataGridViewTextBoxColumn.DisplayMember = "nombre";
            this.idtipoDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.idtipoDataGridViewTextBoxColumn.HeaderText = "id_tipo";
            this.idtipoDataGridViewTextBoxColumn.Name = "idtipoDataGridViewTextBoxColumn";
            this.idtipoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idtipoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idtipoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idtipoDataGridViewTextBoxColumn.ValueMember = "id";
            // 
            // idespacioDataGridViewTextBoxColumn
            // 
            this.idespacioDataGridViewTextBoxColumn.DataPropertyName = "id_espacio";
            this.idespacioDataGridViewTextBoxColumn.DataSource = this.espacioBindingSource;
            this.idespacioDataGridViewTextBoxColumn.DisplayMember = "nombre";
            this.idespacioDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.idespacioDataGridViewTextBoxColumn.HeaderText = "id_espacio";
            this.idespacioDataGridViewTextBoxColumn.Name = "idespacioDataGridViewTextBoxColumn";
            this.idespacioDataGridViewTextBoxColumn.ReadOnly = true;
            this.idespacioDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idespacioDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idespacioDataGridViewTextBoxColumn.ValueMember = "id";
            // 
            // idequipoDataGridViewTextBoxColumn
            // 
            this.idequipoDataGridViewTextBoxColumn.DataPropertyName = "id_equipo";
            this.idequipoDataGridViewTextBoxColumn.DataSource = this.equipoBindingSource;
            this.idequipoDataGridViewTextBoxColumn.DisplayMember = "nombre";
            this.idequipoDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.idequipoDataGridViewTextBoxColumn.HeaderText = "id_equipo";
            this.idequipoDataGridViewTextBoxColumn.Name = "idequipoDataGridViewTextBoxColumn";
            this.idequipoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idequipoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idequipoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idequipoDataGridViewTextBoxColumn.ValueMember = "id";
            // 
            // FormPlantillaActividades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1250, 659);
            this.Controls.Add(this.buttonGestionar);
            this.Controls.Add(this.buttonGenerarInforme);
            this.Controls.Add(this.tabControlActividades);
            this.Name = "FormPlantillaActividades";
            this.Text = "Actividades";
            this.Activated += new System.EventHandler(this.FormPlantillaActividades_Activated);
            this.Load += new System.EventHandler(this.FormPlantillaActividades_Load);
            this.Controls.SetChildIndex(this.tabControlActividades, 0);
            this.Controls.SetChildIndex(this.buttonGenerarInforme, 0);
            this.Controls.SetChildIndex(this.buttonGestionar, 0);
            this.tabControlActividades.ResumeLayout(false);
            this.tabPageAceptadas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAceptadas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceAceptadas)).EndInit();
            this.tabPagePendientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPendientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePendientes)).EndInit();
            this.tabPageDenegadas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDenegadas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDenegdas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.espacioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoActBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonGestionar;
        private System.Windows.Forms.Button buttonGenerarInforme;
        private System.Windows.Forms.TabControl tabControlActividades;
        private System.Windows.Forms.TabPage tabPageAceptadas;
        private System.Windows.Forms.DataGridView dataGridViewAceptadas;
        private System.Windows.Forms.TabPage tabPagePendientes;
        private System.Windows.Forms.DataGridView dataGridViewPendientes;
        private System.Windows.Forms.TabPage tabPageDenegadas;
        private System.Windows.Forms.BindingSource bindingSourceAceptadas;
        private System.Windows.Forms.BindingSource bindingSourcePendientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Equipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn espacio;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreActividadPendiente;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexo_pendientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn EquipoActividadPendiente;
        private System.Windows.Forms.DataGridViewTextBoxColumn EspacioActPen;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoActPen;
        private System.Windows.Forms.DataGridView dataGridViewDenegadas;
        private System.Windows.Forms.BindingSource bindingSourceDenegdas;
        private System.Windows.Forms.BindingSource equipoBindingSource;
        private System.Windows.Forms.BindingSource espacioBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn idtipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tipoActBindingSource;
        private System.Windows.Forms.DataGridViewComboBoxColumn idespacioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn idequipoDataGridViewTextBoxColumn;
    }
}
