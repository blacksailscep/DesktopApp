using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop
{
    public partial class FormActividades : Form
    {
        public FormActividades()
        {
            InitializeComponent();
            tabControlActividades.SelectedIndexChanged += 
                new EventHandler(tabControlActividades_TabIndexChanged);
        }

        private void tabControlActividades_TabIndexChanged(object sender, EventArgs e)
        {
            int index = tabControlActividades.SelectedIndex;
            String mensaje = "";
            if (index==0)
            {                
                bindingSourceAceptadas.DataSource =
                    ORM.ORMActividadesConcedidas.SelectActvConcedidas(ref mensaje);
            }
            else if(index == 1)
            {
                bindingSourcePendientes.DataSource =
                    ORM.ORMAcividadesPendientes.SelectActvPendientes(ref mensaje);
            }


            if (!mensaje.Equals(""))
                MessageBox.Show(mensaje, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            


        }
        private void FormActividades_Load(object sender, EventArgs e)
        {
            String mensaje = "";
            bindingSourceAceptadas.DataSource =
                ORM.ORMActividadesConcedidas.SelectActvConcedidas(ref mensaje);

        }

        private void dataGridViewAceptadas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Object vistaActividad = dataGridViewAceptadas.SelectedRows[0].DataBoundItem;
            new ActividadesAceptadas(vistaActividad).Show();

        }
    }
}
