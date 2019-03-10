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
            this.tabControlActividades.SuspendLayout();
            this.tabPageAceptadas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAceptadas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceAceptadas)).BeginInit();
            this.tabPagePendientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPendientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePendientes)).BeginInit();
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
            this.tabPageDenegadas.Location = new System.Drawing.Point(4, 22);
            this.tabPageDenegadas.Name = "tabPageDenegadas";
            this.tabPageDenegadas.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDenegadas.Size = new System.Drawing.Size(1135, 372);
            this.tabPageDenegadas.TabIndex = 2;
            this.tabPageDenegadas.Text = "Denegadas";
            this.tabPageDenegadas.UseVisualStyleBackColor = true;
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
    }
}
