namespace Desktop
{
    partial class FormEntidad
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
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxDireccion = new System.Windows.Forms.TextBox();
            this.textBoxTemporada = new System.Windows.Forms.TextBox();
            this.buttonVer = new System.Windows.Forms.Button();
            this.buttonModificar = new System.Windows.Forms.Button();
            this.dataGridViewEquipo = new System.Windows.Forms.DataGridView();
            this.dataGridViewTelefono = new System.Windows.Forms.DataGridView();
            this.telefonosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonAceptar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEquipo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTelefono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.telefonosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(415, 81);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(655, 20);
            this.textBoxNombre.TabIndex = 1;
            // 
            // textBoxDireccion
            // 
            this.textBoxDireccion.Location = new System.Drawing.Point(415, 134);
            this.textBoxDireccion.Name = "textBoxDireccion";
            this.textBoxDireccion.Size = new System.Drawing.Size(655, 20);
            this.textBoxDireccion.TabIndex = 2;
            // 
            // textBoxTemporada
            // 
            this.textBoxTemporada.Location = new System.Drawing.Point(415, 181);
            this.textBoxTemporada.Name = "textBoxTemporada";
            this.textBoxTemporada.Size = new System.Drawing.Size(655, 20);
            this.textBoxTemporada.TabIndex = 3;
            // 
            // buttonVer
            // 
            this.buttonVer.Location = new System.Drawing.Point(1149, 624);
            this.buttonVer.Name = "buttonVer";
            this.buttonVer.Size = new System.Drawing.Size(75, 23);
            this.buttonVer.TabIndex = 6;
            this.buttonVer.Text = "Ver";
            this.buttonVer.UseVisualStyleBackColor = true;
            this.buttonVer.Click += new System.EventHandler(this.buttonVer_Click);
            // 
            // buttonModificar
            // 
            this.buttonModificar.Location = new System.Drawing.Point(589, 624);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(75, 23);
            this.buttonModificar.TabIndex = 7;
            this.buttonModificar.Text = "Modificar";
            this.buttonModificar.UseVisualStyleBackColor = true;
            this.buttonModificar.Click += new System.EventHandler(this.buttonModificar_Click);
            // 
            // dataGridViewEquipo
            // 
            this.dataGridViewEquipo.AllowUserToAddRows = false;
            this.dataGridViewEquipo.AllowUserToDeleteRows = false;
            this.dataGridViewEquipo.AutoGenerateColumns = false;
            this.dataGridViewEquipo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEquipo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.nombreDataGridViewTextBoxColumn});
            this.dataGridViewEquipo.DataSource = this.equipoBindingSource;
            this.dataGridViewEquipo.Location = new System.Drawing.Point(13, 430);
            this.dataGridViewEquipo.Name = "dataGridViewEquipo";
            this.dataGridViewEquipo.ReadOnly = true;
            this.dataGridViewEquipo.Size = new System.Drawing.Size(1225, 160);
            this.dataGridViewEquipo.TabIndex = 8;
            // 
            // dataGridViewTelefono
            // 
            this.dataGridViewTelefono.AllowUserToAddRows = false;
            this.dataGridViewTelefono.AllowUserToDeleteRows = false;
            this.dataGridViewTelefono.AutoGenerateColumns = false;
            this.dataGridViewTelefono.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTelefono.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.telefonoDataGridViewTextBoxColumn,
            this.razonDataGridViewTextBoxColumn});
            this.dataGridViewTelefono.DataSource = this.telefonosBindingSource;
            this.dataGridViewTelefono.Location = new System.Drawing.Point(13, 238);
            this.dataGridViewTelefono.Name = "dataGridViewTelefono";
            this.dataGridViewTelefono.ReadOnly = true;
            this.dataGridViewTelefono.Size = new System.Drawing.Size(1225, 186);
            this.dataGridViewTelefono.TabIndex = 9;
            // 
            // telefonosBindingSource
            // 
            this.telefonosBindingSource.DataSource = typeof(Desktop.Telefonos);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            this.telefonoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.telefonoDataGridViewTextBoxColumn.DataPropertyName = "telefono";
            this.telefonoDataGridViewTextBoxColumn.HeaderText = "telefono";
            this.telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            this.telefonoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // razonDataGridViewTextBoxColumn
            // 
            this.razonDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.razonDataGridViewTextBoxColumn.DataPropertyName = "razon";
            this.razonDataGridViewTextBoxColumn.HeaderText = "razon";
            this.razonDataGridViewTextBoxColumn.Name = "razonDataGridViewTextBoxColumn";
            this.razonDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // equipoBindingSource
            // 
            this.equipoBindingSource.DataSource = typeof(Desktop.Equipo);
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(27, 624);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(75, 23);
            this.buttonAceptar.TabIndex = 10;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // FormEntidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1250, 659);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.dataGridViewTelefono);
            this.Controls.Add(this.dataGridViewEquipo);
            this.Controls.Add(this.buttonModificar);
            this.Controls.Add(this.buttonVer);
            this.Controls.Add(this.textBoxTemporada);
            this.Controls.Add(this.textBoxDireccion);
            this.Controls.Add(this.textBoxNombre);
            this.Name = "FormEntidad";
            this.Load += new System.EventHandler(this.FormEntidad_Load);
            this.Controls.SetChildIndex(this.textBoxNombre, 0);
            this.Controls.SetChildIndex(this.textBoxDireccion, 0);
            this.Controls.SetChildIndex(this.textBoxTemporada, 0);
            this.Controls.SetChildIndex(this.buttonVer, 0);
            this.Controls.SetChildIndex(this.buttonModificar, 0);
            this.Controls.SetChildIndex(this.dataGridViewEquipo, 0);
            this.Controls.SetChildIndex(this.dataGridViewTelefono, 0);
            this.Controls.SetChildIndex(this.buttonAceptar, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEquipo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTelefono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.telefonosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxDireccion;
        private System.Windows.Forms.TextBox textBoxTemporada;
        private System.Windows.Forms.Button buttonVer;
        private System.Windows.Forms.Button buttonModificar;
        private System.Windows.Forms.DataGridView dataGridViewEquipo;
        private System.Windows.Forms.DataGridView dataGridViewTelefono;
        private System.Windows.Forms.BindingSource telefonosBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource equipoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn razonDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonAceptar;
    }
}
