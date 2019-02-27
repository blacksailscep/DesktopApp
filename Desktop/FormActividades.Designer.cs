namespace Desktop
{
    partial class FormActividades
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
            this.tabControlActividades = new System.Windows.Forms.TabControl();
            this.tabPageActividades = new System.Windows.Forms.TabPage();
            this.dataGridViewAceptadas = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.buttonGenerarInforme = new System.Windows.Forms.Button();
            this.buttonGestionar = new System.Windows.Forms.Button();
            this.bindingSourceAceptadas = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idtipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idequipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idactdemandadasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idespacioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actdemandadasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.espacioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoActDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horarioActConDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControlActividades.SuspendLayout();
            this.tabPageActividades.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAceptadas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceAceptadas)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlActividades
            // 
            this.tabControlActividades.Controls.Add(this.tabPageActividades);
            this.tabControlActividades.Controls.Add(this.tabPage2);
            this.tabControlActividades.Controls.Add(this.tabPage3);
            this.tabControlActividades.Location = new System.Drawing.Point(47, 110);
            this.tabControlActividades.Name = "tabControlActividades";
            this.tabControlActividades.SelectedIndex = 0;
            this.tabControlActividades.Size = new System.Drawing.Size(562, 260);
            this.tabControlActividades.TabIndex = 0;
            this.tabControlActividades.TabIndexChanged += new System.EventHandler(this.tabControlActividades_TabIndexChanged);
            // 
            // tabPageActividades
            // 
            this.tabPageActividades.Controls.Add(this.dataGridViewAceptadas);
            this.tabPageActividades.Location = new System.Drawing.Point(4, 22);
            this.tabPageActividades.Name = "tabPageActividades";
            this.tabPageActividades.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageActividades.Size = new System.Drawing.Size(554, 234);
            this.tabPageActividades.TabIndex = 0;
            this.tabPageActividades.Text = "Aceptadas";
            this.tabPageActividades.UseVisualStyleBackColor = true;
            // 
            // dataGridViewAceptadas
            // 
            this.dataGridViewAceptadas.AllowUserToAddRows = false;
            this.dataGridViewAceptadas.AllowUserToDeleteRows = false;
            this.dataGridViewAceptadas.AutoGenerateColumns = false;
            this.dataGridViewAceptadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAceptadas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.idtipoDataGridViewTextBoxColumn,
            this.idequipoDataGridViewTextBoxColumn,
            this.idactdemandadasDataGridViewTextBoxColumn,
            this.idespacioDataGridViewTextBoxColumn,
            this.actdemandadasDataGridViewTextBoxColumn,
            this.equipoDataGridViewTextBoxColumn,
            this.espacioDataGridViewTextBoxColumn,
            this.tipoActDataGridViewTextBoxColumn,
            this.horarioActConDataGridViewTextBoxColumn});
            this.dataGridViewAceptadas.DataSource = this.bindingSourceAceptadas;
            this.dataGridViewAceptadas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewAceptadas.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewAceptadas.Name = "dataGridViewAceptadas";
            this.dataGridViewAceptadas.ReadOnly = true;
            this.dataGridViewAceptadas.Size = new System.Drawing.Size(548, 228);
            this.dataGridViewAceptadas.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(554, 234);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Pendientes";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(554, 234);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Denegadas";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // buttonGenerarInforme
            // 
            this.buttonGenerarInforme.Location = new System.Drawing.Point(417, 62);
            this.buttonGenerarInforme.Name = "buttonGenerarInforme";
            this.buttonGenerarInforme.Size = new System.Drawing.Size(178, 23);
            this.buttonGenerarInforme.TabIndex = 1;
            this.buttonGenerarInforme.Text = "Generar Informe";
            this.buttonGenerarInforme.UseVisualStyleBackColor = true;
            // 
            // buttonGestionar
            // 
            this.buttonGestionar.Location = new System.Drawing.Point(123, 396);
            this.buttonGestionar.Name = "buttonGestionar";
            this.buttonGestionar.Size = new System.Drawing.Size(182, 23);
            this.buttonGestionar.TabIndex = 2;
            this.buttonGestionar.Text = "Gestionar / Ver";
            this.buttonGestionar.UseVisualStyleBackColor = true;
            // 
            // bindingSourceAceptadas
            // 
            this.bindingSourceAceptadas.DataSource = typeof(Desktop.Act_concedida);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
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
            this.idtipoDataGridViewTextBoxColumn.HeaderText = "id_tipo";
            this.idtipoDataGridViewTextBoxColumn.Name = "idtipoDataGridViewTextBoxColumn";
            this.idtipoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idequipoDataGridViewTextBoxColumn
            // 
            this.idequipoDataGridViewTextBoxColumn.DataPropertyName = "id_equipo";
            this.idequipoDataGridViewTextBoxColumn.HeaderText = "id_equipo";
            this.idequipoDataGridViewTextBoxColumn.Name = "idequipoDataGridViewTextBoxColumn";
            this.idequipoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idequipoDataGridViewTextBoxColumn.Visible = false;
            // 
            // idactdemandadasDataGridViewTextBoxColumn
            // 
            this.idactdemandadasDataGridViewTextBoxColumn.DataPropertyName = "id_act_demandadas";
            this.idactdemandadasDataGridViewTextBoxColumn.HeaderText = "id_act_demandadas";
            this.idactdemandadasDataGridViewTextBoxColumn.Name = "idactdemandadasDataGridViewTextBoxColumn";
            this.idactdemandadasDataGridViewTextBoxColumn.ReadOnly = true;
            this.idactdemandadasDataGridViewTextBoxColumn.Visible = false;
            // 
            // idespacioDataGridViewTextBoxColumn
            // 
            this.idespacioDataGridViewTextBoxColumn.DataPropertyName = "id_espacio";
            this.idespacioDataGridViewTextBoxColumn.HeaderText = "id_espacio";
            this.idespacioDataGridViewTextBoxColumn.Name = "idespacioDataGridViewTextBoxColumn";
            this.idespacioDataGridViewTextBoxColumn.ReadOnly = true;
            this.idespacioDataGridViewTextBoxColumn.Visible = false;
            // 
            // actdemandadasDataGridViewTextBoxColumn
            // 
            this.actdemandadasDataGridViewTextBoxColumn.DataPropertyName = "Act_demandadas";
            this.actdemandadasDataGridViewTextBoxColumn.HeaderText = "Act_demandadas";
            this.actdemandadasDataGridViewTextBoxColumn.Name = "actdemandadasDataGridViewTextBoxColumn";
            this.actdemandadasDataGridViewTextBoxColumn.ReadOnly = true;
            this.actdemandadasDataGridViewTextBoxColumn.Visible = false;
            // 
            // equipoDataGridViewTextBoxColumn
            // 
            this.equipoDataGridViewTextBoxColumn.DataPropertyName = "Equipo";
            this.equipoDataGridViewTextBoxColumn.HeaderText = "Equipo";
            this.equipoDataGridViewTextBoxColumn.Name = "equipoDataGridViewTextBoxColumn";
            this.equipoDataGridViewTextBoxColumn.ReadOnly = true;
            this.equipoDataGridViewTextBoxColumn.Visible = false;
            // 
            // espacioDataGridViewTextBoxColumn
            // 
            this.espacioDataGridViewTextBoxColumn.DataPropertyName = "Espacio";
            this.espacioDataGridViewTextBoxColumn.HeaderText = "Espacio";
            this.espacioDataGridViewTextBoxColumn.Name = "espacioDataGridViewTextBoxColumn";
            this.espacioDataGridViewTextBoxColumn.ReadOnly = true;
            this.espacioDataGridViewTextBoxColumn.Visible = false;
            // 
            // tipoActDataGridViewTextBoxColumn
            // 
            this.tipoActDataGridViewTextBoxColumn.DataPropertyName = "Tipo_Act";
            this.tipoActDataGridViewTextBoxColumn.HeaderText = "Tipo_Act";
            this.tipoActDataGridViewTextBoxColumn.Name = "tipoActDataGridViewTextBoxColumn";
            this.tipoActDataGridViewTextBoxColumn.ReadOnly = true;
            this.tipoActDataGridViewTextBoxColumn.Visible = false;
            // 
            // horarioActConDataGridViewTextBoxColumn
            // 
            this.horarioActConDataGridViewTextBoxColumn.DataPropertyName = "Horario_Act_Con";
            this.horarioActConDataGridViewTextBoxColumn.HeaderText = "Horario_Act_Con";
            this.horarioActConDataGridViewTextBoxColumn.Name = "horarioActConDataGridViewTextBoxColumn";
            this.horarioActConDataGridViewTextBoxColumn.ReadOnly = true;
            this.horarioActConDataGridViewTextBoxColumn.Visible = false;
            // 
            // FormActividades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 479);
            this.Controls.Add(this.buttonGestionar);
            this.Controls.Add(this.buttonGenerarInforme);
            this.Controls.Add(this.tabControlActividades);
            this.Name = "FormActividades";
            this.Text = "Actividades";
            this.Load += new System.EventHandler(this.FormActividades_Load);
            this.tabControlActividades.ResumeLayout(false);
            this.tabPageActividades.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAceptadas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceAceptadas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlActividades;
        private System.Windows.Forms.TabPage tabPageActividades;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button buttonGenerarInforme;
        private System.Windows.Forms.Button buttonGestionar;
        private System.Windows.Forms.DataGridView dataGridViewAceptadas;
        private System.Windows.Forms.BindingSource bindingSourceAceptadas;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idtipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idequipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idactdemandadasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idespacioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn actdemandadasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn espacioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoActDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horarioActConDataGridViewTextBoxColumn;
    }
}

