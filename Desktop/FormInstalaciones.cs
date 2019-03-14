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

            bindingSourceInstalaciones.DataSource = ORM.ORMInstalaciones.SelectAllInstalaciones(ref mensaje);
            bindingSourceTipoGestion.DataSource = ORM.ORMInstalaciones.SelectAllTipoGestion(ref mensaje);

            if (!string.IsNullOrEmpty(mensaje))
            {
                MessageBox.Show(mensaje, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //e.Cancel()
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

        private void buttonAñadir_Click(object sender, EventArgs e)
        {
            FormUnaInstalacion formInstalacion = new FormUnaInstalacion();
            formInstalacion.Text = "AÑADIR UNA INSTALACIÓN";
            formInstalacion.ShowDialog();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {

        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            String mensaje = "";

            String nombre = textBoxBuscar.Text;

            if (!string.IsNullOrWhiteSpace(nombre))
            {
                bindingSourceInstalaciones.DataSource = ORM.ORMInstalaciones.SelectInstalacionBynombre(nombre, ref mensaje);
            }


            if(!string.IsNullOrWhiteSpace(mensaje))
            {
                MessageBox.Show(mensaje, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxBuscar.Focus();
            }

           
        }
    }
}
