namespace Desktop
{
    partial class FormEntidades
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
            this.dataGridViewEntidades = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceEntidades = new System.Windows.Forms.BindingSource(this.components);
            this.textBoxBuscar = new System.Windows.Forms.TextBox();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.buttonInforme = new System.Windows.Forms.Button();
            this.buttonVer = new System.Windows.Forms.Button();
            this.buttonModificar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEntidades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceEntidades)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewEntidades
            // 
            this.dataGridViewEntidades.AllowUserToAddRows = false;
            this.dataGridViewEntidades.AllowUserToDeleteRows = false;
            this.dataGridViewEntidades.AutoGenerateColumns = false;
            this.dataGridViewEntidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEntidades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn});
            this.dataGridViewEntidades.DataSource = this.bindingSourceEntidades;
            this.dataGridViewEntidades.Location = new System.Drawing.Point(12, 135);
            this.dataGridViewEntidades.Name = "dataGridViewEntidades";
            this.dataGridViewEntidades.ReadOnly = true;
            this.dataGridViewEntidades.Size = new System.Drawing.Size(1226, 506);
            this.dataGridViewEntidades.TabIndex = 1;
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
            this.nombreDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bindingSourceEntidades
            // 
            this.bindingSourceEntidades.DataSource = typeof(Desktop.Entidad);
            // 
            // textBoxBuscar
            // 
            this.textBoxBuscar.Location = new System.Drawing.Point(26, 74);
            this.textBoxBuscar.Name = "textBoxBuscar";
            this.textBoxBuscar.Size = new System.Drawing.Size(321, 20);
            this.textBoxBuscar.TabIndex = 2;
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(367, 72);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscar.TabIndex = 3;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // buttonInforme
            // 
            this.buttonInforme.Location = new System.Drawing.Point(1079, 72);
            this.buttonInforme.Name = "buttonInforme";
            this.buttonInforme.Size = new System.Drawing.Size(145, 23);
            this.buttonInforme.TabIndex = 4;
            this.buttonInforme.Text = "Generar informe";
            this.buttonInforme.UseVisualStyleBackColor = true;
            // 
            // buttonVer
            // 
            this.buttonVer.Location = new System.Drawing.Point(59, 670);
            this.buttonVer.Name = "buttonVer";
            this.buttonVer.Size = new System.Drawing.Size(75, 23);
            this.buttonVer.TabIndex = 5;
            this.buttonVer.Text = "Ver";
            this.buttonVer.UseVisualStyleBackColor = true;
            this.buttonVer.Click += new System.EventHandler(this.buttonVer_Click);
            // 
            // buttonModificar
            // 
            this.buttonModificar.Location = new System.Drawing.Point(1113, 670);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(75, 23);
            this.buttonModificar.TabIndex = 6;
            this.buttonModificar.Text = "Modificar";
            this.buttonModificar.UseVisualStyleBackColor = true;
            this.buttonModificar.Click += new System.EventHandler(this.buttonModificar_Click);
            // 
            // FormEntidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1250, 716);
            this.Controls.Add(this.buttonModificar);
            this.Controls.Add(this.buttonVer);
            this.Controls.Add(this.buttonInforme);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.textBoxBuscar);
            this.Controls.Add(this.dataGridViewEntidades);
            this.Name = "FormEntidades";
            this.Load += new System.EventHandler(this.FormEntidades_Load);
            this.Controls.SetChildIndex(this.dataGridViewEntidades, 0);
            this.Controls.SetChildIndex(this.textBoxBuscar, 0);
            this.Controls.SetChildIndex(this.buttonBuscar, 0);
            this.Controls.SetChildIndex(this.buttonInforme, 0);
            this.Controls.SetChildIndex(this.buttonVer, 0);
            this.Controls.SetChildIndex(this.buttonModificar, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEntidades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceEntidades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewEntidades;
        private System.Windows.Forms.TextBox textBoxBuscar;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Button buttonInforme;
        private System.Windows.Forms.Button buttonVer;
        private System.Windows.Forms.Button buttonModificar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bindingSourceEntidades;
    }
}
