﻿namespace Desktop
{
    partial class FormInstalaciones
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
            this.groupBoxBuscaInsta = new System.Windows.Forms.GroupBox();
            this.labelBuscar = new System.Windows.Forms.Label();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.buttonGenerarInforme = new System.Windows.Forms.Button();
            this.pictureBoxBusca = new System.Windows.Forms.PictureBox();
            this.textBoxBuscar = new System.Windows.Forms.TextBox();
            this.dataGridViewInstalaciones = new System.Windows.Forms.DataGridView();
            this.bindingSourceTipoGestion = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourceInstalaciones = new System.Windows.Forms.BindingSource(this.components);
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonVer = new System.Windows.Forms.Button();
            this.buttonAñadir = new System.Windows.Forms.Button();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idtipogestionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.espacioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.instalacionHorarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxBuscaInsta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBusca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInstalaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTipoGestion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceInstalaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxBuscaInsta
            // 
            this.groupBoxBuscaInsta.Controls.Add(this.labelBuscar);
            this.groupBoxBuscaInsta.Controls.Add(this.buttonBuscar);
            this.groupBoxBuscaInsta.Controls.Add(this.buttonGenerarInforme);
            this.groupBoxBuscaInsta.Controls.Add(this.pictureBoxBusca);
            this.groupBoxBuscaInsta.Controls.Add(this.textBoxBuscar);
            this.groupBoxBuscaInsta.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxBuscaInsta.Location = new System.Drawing.Point(0, 54);
            this.groupBoxBuscaInsta.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxBuscaInsta.Name = "groupBoxBuscaInsta";
            this.groupBoxBuscaInsta.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxBuscaInsta.Size = new System.Drawing.Size(1355, 63);
            this.groupBoxBuscaInsta.TabIndex = 1;
            this.groupBoxBuscaInsta.TabStop = false;
            // 
            // labelBuscar
            // 
            this.labelBuscar.AutoSize = true;
            this.labelBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBuscar.Location = new System.Drawing.Point(47, 25);
            this.labelBuscar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBuscar.Name = "labelBuscar";
            this.labelBuscar.Size = new System.Drawing.Size(146, 17);
            this.labelBuscar.TabIndex = 4;
            this.labelBuscar.Text = "Buscar Instalación:";
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscar.Location = new System.Drawing.Point(648, 21);
            this.buttonBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(92, 28);
            this.buttonBuscar.TabIndex = 3;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // buttonGenerarInforme
            // 
            this.buttonGenerarInforme.Location = new System.Drawing.Point(1400, 18);
            this.buttonGenerarInforme.Margin = new System.Windows.Forms.Padding(4);
            this.buttonGenerarInforme.Name = "buttonGenerarInforme";
            this.buttonGenerarInforme.Size = new System.Drawing.Size(259, 37);
            this.buttonGenerarInforme.TabIndex = 2;
            this.buttonGenerarInforme.Text = "Generar Informe";
            this.buttonGenerarInforme.UseVisualStyleBackColor = true;
            // 
            // pictureBoxBusca
            // 
            this.pictureBoxBusca.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBoxBusca.ErrorImage = global::Desktop.Properties.Resources.lupa;
            this.pictureBoxBusca.Image = global::Desktop.Properties.Resources.lupa;
            this.pictureBoxBusca.Location = new System.Drawing.Point(4, 14);
            this.pictureBoxBusca.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxBusca.Name = "pictureBoxBusca";
            this.pictureBoxBusca.Size = new System.Drawing.Size(33, 39);
            this.pictureBoxBusca.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBusca.TabIndex = 1;
            this.pictureBoxBusca.TabStop = false;
            // 
            // textBoxBuscar
            // 
            this.textBoxBuscar.Location = new System.Drawing.Point(209, 23);
            this.textBoxBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxBuscar.Name = "textBoxBuscar";
            this.textBoxBuscar.Size = new System.Drawing.Size(428, 22);
            this.textBoxBuscar.TabIndex = 0;
            // 
            // dataGridViewInstalaciones
            // 
            this.dataGridViewInstalaciones.AllowUserToAddRows = false;
            this.dataGridViewInstalaciones.AutoGenerateColumns = false;
            this.dataGridViewInstalaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInstalaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn,
            this.idtipogestionDataGridViewTextBoxColumn,
            this.espacioDataGridViewTextBoxColumn,
            this.instalacionHorarioDataGridViewTextBoxColumn});
            this.dataGridViewInstalaciones.DataSource = this.bindingSourceInstalaciones;
            this.dataGridViewInstalaciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewInstalaciones.Location = new System.Drawing.Point(0, 117);
            this.dataGridViewInstalaciones.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewInstalaciones.Name = "dataGridViewInstalaciones";
            this.dataGridViewInstalaciones.ReadOnly = true;
            this.dataGridViewInstalaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewInstalaciones.Size = new System.Drawing.Size(1355, 610);
            this.dataGridViewInstalaciones.TabIndex = 2;
            this.dataGridViewInstalaciones.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridViewInstalaciones_UserDeletingRow);
            this.dataGridViewInstalaciones.DoubleClick += new System.EventHandler(this.dataGridViewInstalaciones_DoubleClick);
            // 
            // bindingSourceTipoGestion
            // 
            this.bindingSourceTipoGestion.DataSource = typeof(Desktop.Tipo_gestion);
            // 
            // bindingSourceInstalaciones
            // 
            this.bindingSourceInstalaciones.DataSource = typeof(Desktop.Instalacion);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Location = new System.Drawing.Point(1444, 747);
            this.buttonEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(211, 49);
            this.buttonEliminar.TabIndex = 3;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // buttonVer
            // 
            this.buttonVer.Location = new System.Drawing.Point(1225, 747);
            this.buttonVer.Margin = new System.Windows.Forms.Padding(4);
            this.buttonVer.Name = "buttonVer";
            this.buttonVer.Size = new System.Drawing.Size(211, 49);
            this.buttonVer.TabIndex = 4;
            this.buttonVer.Text = "Ver";
            this.buttonVer.UseVisualStyleBackColor = true;
            this.buttonVer.Click += new System.EventHandler(this.buttonVer_Click);
            // 
            // buttonAñadir
            // 
            this.buttonAñadir.Location = new System.Drawing.Point(1007, 747);
            this.buttonAñadir.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAñadir.Name = "buttonAñadir";
            this.buttonAñadir.Size = new System.Drawing.Size(211, 49);
            this.buttonAñadir.TabIndex = 5;
            this.buttonAñadir.Text = "Añadir";
            this.buttonAñadir.UseVisualStyleBackColor = true;
            this.buttonAñadir.Click += new System.EventHandler(this.buttonAñadir_Click);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            this.direccionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.direccionDataGridViewTextBoxColumn.DataPropertyName = "direccion";
            this.direccionDataGridViewTextBoxColumn.HeaderText = "Direccion";
            this.direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            this.direccionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idtipogestionDataGridViewTextBoxColumn
            // 
            this.idtipogestionDataGridViewTextBoxColumn.DataPropertyName = "id_tipo_gestion";
            this.idtipogestionDataGridViewTextBoxColumn.HeaderText = "id_tipo_gestion";
            this.idtipogestionDataGridViewTextBoxColumn.Name = "idtipogestionDataGridViewTextBoxColumn";
            this.idtipogestionDataGridViewTextBoxColumn.ReadOnly = true;
            this.idtipogestionDataGridViewTextBoxColumn.Visible = false;
            // 
            // espacioDataGridViewTextBoxColumn
            // 
            this.espacioDataGridViewTextBoxColumn.DataPropertyName = "Espacio";
            this.espacioDataGridViewTextBoxColumn.HeaderText = "Espacio";
            this.espacioDataGridViewTextBoxColumn.Name = "espacioDataGridViewTextBoxColumn";
            this.espacioDataGridViewTextBoxColumn.ReadOnly = true;
            this.espacioDataGridViewTextBoxColumn.Visible = false;
            // 
            // instalacionHorarioDataGridViewTextBoxColumn
            // 
            this.instalacionHorarioDataGridViewTextBoxColumn.DataPropertyName = "Instalacion_Horario";
            this.instalacionHorarioDataGridViewTextBoxColumn.HeaderText = "Instalacion_Horario";
            this.instalacionHorarioDataGridViewTextBoxColumn.Name = "instalacionHorarioDataGridViewTextBoxColumn";
            this.instalacionHorarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.instalacionHorarioDataGridViewTextBoxColumn.Visible = false;
            // 
            // FormInstalaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1355, 734);
            this.Controls.Add(this.buttonAñadir);
            this.Controls.Add(this.buttonVer);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.dataGridViewInstalaciones);
            this.Controls.Add(this.groupBoxBuscaInsta);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormInstalaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation;
            this.Activated += new System.EventHandler(this.FormInstalaciones_Activated);
            this.Load += new System.EventHandler(this.FormInstalaciones_Load);
            this.Controls.SetChildIndex(this.groupBoxBuscaInsta, 0);
            this.Controls.SetChildIndex(this.dataGridViewInstalaciones, 0);
            this.Controls.SetChildIndex(this.buttonEliminar, 0);
            this.Controls.SetChildIndex(this.buttonVer, 0);
            this.Controls.SetChildIndex(this.buttonAñadir, 0);
            this.groupBoxBuscaInsta.ResumeLayout(false);
            this.groupBoxBuscaInsta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBusca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInstalaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTipoGestion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceInstalaciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxBuscaInsta;
        private System.Windows.Forms.PictureBox pictureBoxBusca;
        private System.Windows.Forms.TextBox textBoxBuscar;
        private System.Windows.Forms.Button buttonGenerarInforme;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.DataGridView dataGridViewInstalaciones;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonVer;
        private System.Windows.Forms.Button buttonAñadir;
        private System.Windows.Forms.BindingSource bindingSourceInstalaciones;
        private System.Windows.Forms.BindingSource bindingSourceTipoGestion;
        private System.Windows.Forms.Label labelBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idtipogestionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn espacioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn instalacionHorarioDataGridViewTextBoxColumn;
    }
}