using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Desktop
{
    public partial class FormInstalaciones : Desktop.FormPlantilla
    {
        public FormInstalaciones()
        {
            InitializeComponent();
        }

        public void llenar()
        {
            String mensaje = "";
            List<Object> _i;

            _i = ORM.ORMInstalaciones.SelectAllInstalaciones(ref mensaje);

            if (!string.IsNullOrEmpty(mensaje))
            {
                MessageBox.Show(mensaje, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //e.Cancel()
            }
            else
            {
                bindingSourceInstalaciones.DataSource = _i;
                dataGridViewInstalaciones.SelectedCells[3].Value = _i;
            }
            
        }

        private void FormInstalaciones_Load(object sender, EventArgs e)
        {
            llenar();  
        }

        private void FormInstalaciones_Activated(object sender, EventArgs e)
        {
            llenar();
        }

        private void buttonVer_Click(object sender, EventArgs e)
        {
            Instalacion instalacion = (Instalacion)dataGridViewInstalaciones.SelectedRows[0].DataBoundItem;

            
            FormUnaInstalacion formInstalacion = new FormUnaInstalacion(instalacion);
            formInstalacion.Text = "MODIFICACIÓN DE LA INSTALACIÓN";
            formInstalacion.ShowDialog();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {

        }
    }
}
