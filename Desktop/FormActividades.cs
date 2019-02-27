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
        }

        private void tabControlActividades_TabIndexChanged(object sender, EventArgs e)
        {


        }

        private void FormActividades_Load(object sender, EventArgs e)
        {
            String mensaje = "";
            bindingSourceAceptadas.DataSource =
                ORM.ORMActividadesConcedidas.SelectActvConcedidas(ref mensaje);

            //dataGridView1.Rows[0].Cells["DeclaredBy"].Value = "changed test value";

            dataGridViewAceptadas.Rows[0].Cells[2].Value = 22;
        }
    }
}
