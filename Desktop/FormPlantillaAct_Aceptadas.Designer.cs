namespace Desktop
{
    partial class FormPlantillaAct_Aceptadas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewHorarioActividadesAceptadas = new System.Windows.Forms.DataGridView();
            this.Horas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lunes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Martes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Miercoles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Jueves = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Viernes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sabado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Domingo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxEquipo = new System.Windows.Forms.TextBox();
            this.textBoxEspacio = new System.Windows.Forms.TextBox();
            this.textBoxTipo = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHorarioActividadesAceptadas)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewHorarioActividadesAceptadas
            // 
            this.dataGridViewHorarioActividadesAceptadas.AllowUserToAddRows = false;
            this.dataGridViewHorarioActividadesAceptadas.AllowUserToDeleteRows = false;
            this.dataGridViewHorarioActividadesAceptadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHorarioActividadesAceptadas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Horas,
            this.Lunes,
            this.Martes,
            this.Miercoles,
            this.Jueves,
            this.Viernes,
            this.Sabado,
            this.Domingo});
            this.dataGridViewHorarioActividadesAceptadas.Location = new System.Drawing.Point(47, 222);
            this.dataGridViewHorarioActividadesAceptadas.Name = "dataGridViewHorarioActividadesAceptadas";
            this.dataGridViewHorarioActividadesAceptadas.ReadOnly = true;
            this.dataGridViewHorarioActividadesAceptadas.RowHeadersWidth = 10;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.dataGridViewHorarioActividadesAceptadas.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewHorarioActividadesAceptadas.Size = new System.Drawing.Size(1134, 388);
            this.dataGridViewHorarioActividadesAceptadas.TabIndex = 17;
            this.dataGridViewHorarioActividadesAceptadas.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGridViewHorarioActividadesAceptadas_CellPainting);
            this.dataGridViewHorarioActividadesAceptadas.SelectionChanged += new System.EventHandler(this.dataGridViewHorarioActividadesAceptadas_SelectionChanged);
            // 
            // Horas
            // 
            this.Horas.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Horas.HeaderText = "Horas";
            this.Horas.Name = "Horas";
            this.Horas.ReadOnly = true;
            // 
            // Lunes
            // 
            this.Lunes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Lunes.HeaderText = "Lunes";
            this.Lunes.Name = "Lunes";
            this.Lunes.ReadOnly = true;
            // 
            // Martes
            // 
            this.Martes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Martes.HeaderText = "Martes";
            this.Martes.Name = "Martes";
            this.Martes.ReadOnly = true;
            // 
            // Miercoles
            // 
            this.Miercoles.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Miercoles.HeaderText = "Miercoles";
            this.Miercoles.Name = "Miercoles";
            this.Miercoles.ReadOnly = true;
            // 
            // Jueves
            // 
            this.Jueves.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Jueves.HeaderText = "Jueves";
            this.Jueves.Name = "Jueves";
            this.Jueves.ReadOnly = true;
            // 
            // Viernes
            // 
            this.Viernes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Viernes.HeaderText = "Viernes";
            this.Viernes.Name = "Viernes";
            this.Viernes.ReadOnly = true;
            // 
            // Sabado
            // 
            this.Sabado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Sabado.HeaderText = "Sabado";
            this.Sabado.Name = "Sabado";
            this.Sabado.ReadOnly = true;
            // 
            // Domingo
            // 
            this.Domingo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Domingo.HeaderText = "Domingo";
            this.Domingo.Name = "Domingo";
            this.Domingo.ReadOnly = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Equipo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Espacio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Tipo Actividad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Nombre Actividad";
            // 
            // textBoxEquipo
            // 
            this.textBoxEquipo.Enabled = false;
            this.textBoxEquipo.Location = new System.Drawing.Point(167, 174);
            this.textBoxEquipo.Name = "textBoxEquipo";
            this.textBoxEquipo.Size = new System.Drawing.Size(411, 20);
            this.textBoxEquipo.TabIndex = 12;
            // 
            // textBoxEspacio
            // 
            this.textBoxEspacio.Enabled = false;
            this.textBoxEspacio.Location = new System.Drawing.Point(167, 148);
            this.textBoxEspacio.Name = "textBoxEspacio";
            this.textBoxEspacio.Size = new System.Drawing.Size(411, 20);
            this.textBoxEspacio.TabIndex = 11;
            // 
            // textBoxTipo
            // 
            this.textBoxTipo.Enabled = false;
            this.textBoxTipo.Location = new System.Drawing.Point(167, 121);
            this.textBoxTipo.Name = "textBoxTipo";
            this.textBoxTipo.Size = new System.Drawing.Size(411, 20);
            this.textBoxTipo.TabIndex = 10;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Enabled = false;
            this.textBoxNombre.Location = new System.Drawing.Point(167, 95);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(411, 20);
            this.textBoxNombre.TabIndex = 9;
            // 
            // FormPlantillaAct_Aceptadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1250, 659);
            this.Controls.Add(this.dataGridViewHorarioActividadesAceptadas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxEquipo);
            this.Controls.Add(this.textBoxEspacio);
            this.Controls.Add(this.textBoxTipo);
            this.Controls.Add(this.textBoxNombre);
            this.Name = "FormPlantillaAct_Aceptadas";
            this.Text = "Actividades Aceptadas";
            this.Controls.SetChildIndex(this.textBoxNombre, 0);
            this.Controls.SetChildIndex(this.textBoxTipo, 0);
            this.Controls.SetChildIndex(this.textBoxEspacio, 0);
            this.Controls.SetChildIndex(this.textBoxEquipo, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.dataGridViewHorarioActividadesAceptadas, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHorarioActividadesAceptadas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewHorarioActividadesAceptadas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Horas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lunes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Martes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Miercoles;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jueves;
        private System.Windows.Forms.DataGridViewTextBoxColumn Viernes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sabado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Domingo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxEquipo;
        private System.Windows.Forms.TextBox textBoxEspacio;
        private System.Windows.Forms.TextBox textBoxTipo;
        private System.Windows.Forms.TextBox textBoxNombre;
    }
}
