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
    public partial class FormUnaInstalacion : Form
    {
        Instalacion instalacion;
        public FormUnaInstalacion()
        {
            InitializeComponent();
        }

        public FormUnaInstalacion(Instalacion instalacion)
        {
            InitializeComponent();
            this.instalacion = instalacion;
        }

        public void omplir(Instalacion instalacion)
        {
            String mensaje = "";
            bindingSourceTipoGestion.DataSource = ORM.ORMInstalaciones.SelectAllTipoGestion(ref mensaje);
            bindingSourceDiasSemana.DataSource = ORM.ORMInstalaciones.SelectAllDiasSemana(ref mensaje);

            if (instalacion != null)
            {
                bindingSourceHorarioInsta.DataSource = ORM.ORMInstalaciones.SelectAllHorarioInstalacion(instalacion.id, ref mensaje);
            }
           

            if (!string.IsNullOrEmpty(mensaje))
            {
                MessageBox.Show(mensaje, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //e.Cancel()
            }
        }
       

        private void FormUnaInstalacion_Load(object sender, EventArgs e)
        {
            omplir(instalacion);

            if (instalacion != null)
            {
                textBoxNombre.Text = instalacion.nombre;
                textBoxDireccion.Text = instalacion.direccion;
                comboBoxTipoGestion.SelectedValue = instalacion.id_tipo_gestion;
            }
        }


    }
}
