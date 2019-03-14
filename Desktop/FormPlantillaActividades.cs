using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Desktop
{
    public partial class FormPlantillaActividades : Desktop.FormPlantilla
    {
        public FormPlantillaActividades()
        {
            InitializeComponent();
            tabControlActividades.SelectedIndexChanged +=
                new EventHandler(tabControlActividades_TabIndexChanged);

            
        }
        private void tabControlActividades_TabIndexChanged(object sender, EventArgs e)
        {
            RellenarTab();
        }
        private void dataGridViewAceptadas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Object vistaActividad = dataGridViewAceptadas.SelectedRows[0].DataBoundItem;
            new FormPlantillaAct_Aceptadas(vistaActividad).Show();

        }

        private void FormPlantillaActividades_Load(object sender, EventArgs e)
        {
            String mensaje = "";
            bindingSourceAceptadas.DataSource =
                ORM.ORMActividadesConcedidas.SelectActvConcedidas(ref mensaje);

            if (!mensaje.Equals(""))
                MessageBox.Show(mensaje, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            
        }

        private void dataGridViewPendientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Object vistaActividad = dataGridViewPendientes.SelectedRows[0].DataBoundItem;
            new FormPlantillaPendientes(vistaActividad).Show();
        }

        private void FormPlantillaActividades_Activated(object sender, EventArgs e)
        {
            RellenarTab();
        }
        private void RellenarTab()
        {
            int index = tabControlActividades.SelectedIndex;
            String mensaje = "";
            if (index == 0)
            {
                bindingSourceAceptadas.DataSource =
                    ORM.ORMActividadesConcedidas.SelectActvConcedidas(ref mensaje);
            }
            else if (index == 1)
            {
                bindingSourcePendientes.DataSource =
                    ORM.ORMAcividadesPendientes.SelectVistaActvPendientes(ref mensaje);
            }


            if (!mensaje.Equals(""))
                MessageBox.Show(mensaje, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
