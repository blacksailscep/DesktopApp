namespace Desktop
{
    partial class FormPlantillaPadre
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
            this.tableLayoutPanelMenu = new System.Windows.Forms.TableLayoutPanel();
            this.labelEntidades = new System.Windows.Forms.Label();
            this.labelInicio = new System.Windows.Forms.Label();
            this.labelInstalaciones = new System.Windows.Forms.Label();
            this.labelUsuarios = new System.Windows.Forms.Label();
            this.labelActividades = new System.Windows.Forms.Label();
            this.tableLayoutPanelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelMenu
            // 
            this.tableLayoutPanelMenu.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tableLayoutPanelMenu.ColumnCount = 5;
            this.tableLayoutPanelMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelMenu.Controls.Add(this.labelActividades, 0, 0);
            this.tableLayoutPanelMenu.Controls.Add(this.labelUsuarios, 0, 0);
            this.tableLayoutPanelMenu.Controls.Add(this.labelInstalaciones, 0, 0);
            this.tableLayoutPanelMenu.Controls.Add(this.labelInicio, 0, 0);
            this.tableLayoutPanelMenu.Controls.Add(this.labelEntidades, 0, 0);
            this.tableLayoutPanelMenu.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelMenu.Name = "tableLayoutPanelMenu";
            this.tableLayoutPanelMenu.RowCount = 1;
            this.tableLayoutPanelMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelMenu.Size = new System.Drawing.Size(1198, 77);
            this.tableLayoutPanelMenu.TabIndex = 0;
            // 
            // labelEntidades
            // 
            this.labelEntidades.AutoSize = true;
            this.labelEntidades.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelEntidades.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEntidades.Location = new System.Drawing.Point(242, 0);
            this.labelEntidades.Name = "labelEntidades";
            this.labelEntidades.Size = new System.Drawing.Size(233, 77);
            this.labelEntidades.TabIndex = 0;
            // 
            // labelInicio
            // 
            this.labelInicio.AutoSize = true;
            this.labelInicio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelInicio.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInicio.Location = new System.Drawing.Point(3, 0);
            this.labelInicio.Name = "labelInicio";
            this.labelInicio.Size = new System.Drawing.Size(233, 77);
            this.labelInicio.TabIndex = 1;
            // 
            // labelInstalaciones
            // 
            this.labelInstalaciones.AutoSize = true;
            this.labelInstalaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelInstalaciones.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInstalaciones.Location = new System.Drawing.Point(481, 0);
            this.labelInstalaciones.Name = "labelInstalaciones";
            this.labelInstalaciones.Size = new System.Drawing.Size(233, 77);
            this.labelInstalaciones.TabIndex = 2;
            // 
            // labelUsuarios
            // 
            this.labelUsuarios.AutoSize = true;
            this.labelUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelUsuarios.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsuarios.Location = new System.Drawing.Point(959, 0);
            this.labelUsuarios.Name = "labelUsuarios";
            this.labelUsuarios.Size = new System.Drawing.Size(236, 77);
            this.labelUsuarios.TabIndex = 3;
            // 
            // labelActividades
            // 
            this.labelActividades.AutoSize = true;
            this.labelActividades.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelActividades.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelActividades.Location = new System.Drawing.Point(720, 0);
            this.labelActividades.Name = "labelActividades";
            this.labelActividades.Size = new System.Drawing.Size(233, 77);
            this.labelActividades.TabIndex = 4;
            // 
            // FormPlantillaPadre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 628);
            this.Controls.Add(this.tableLayoutPanelMenu);
            this.MaximizeBox = false;
            this.Name = "FormPlantillaPadre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPlantillaPadre";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormPlantillaPadre_Load);
            this.tableLayoutPanelMenu.ResumeLayout(false);
            this.tableLayoutPanelMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMenu;
        private System.Windows.Forms.Label labelActividades;
        private System.Windows.Forms.Label labelUsuarios;
        private System.Windows.Forms.Label labelInstalaciones;
        private System.Windows.Forms.Label labelInicio;
        private System.Windows.Forms.Label labelEntidades;
    }
}