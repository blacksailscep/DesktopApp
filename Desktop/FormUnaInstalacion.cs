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

        private void FormUnaInstalacion_Load(object sender, EventArgs e)
        {
            if (instalacion != null)
            {
                textBoxNombre.Text = instalacion.nombre;
                //textBoxDireccion.Text = instalacion.direccion;
                //comboBoxTipoGestion.SelectedIndex = instalacion.id_tipo_gestion;
            }
        }


    }
}
