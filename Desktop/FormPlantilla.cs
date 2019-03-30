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
    public partial class FormPlantilla : Form
    {
        public FormPlantilla()
        {
            InitializeComponent();
        }

        private void FormPlantilla_Load(object sender, EventArgs e)
        {
            labelInicio.Text        = "             Inicio";
            labelEntidades.Text     = "          Entidades";
            labelInstalaciones.Text = "         Instalaciones";
            labelActividades.Text   = "          Actividades";
            labelUsuarios.Text      = "            Usuarios";
        }
    }
}

        }

        private void FormPlantilla_Load(object sender, EventArgs e)
        {
            labelInicio.Text        = "             Inicio";
            labelEntidades.Text     = "          Entidades";
            labelInstalaciones.Text = "         Instalaciones";
            labelActividades.Text   = "          Actividades";
            labelUsuarios.Text      = "            Usuarios";
        }
        public List<Label> GetLabels()
        {
            List<Label> lst_labels = new List<Label>();
            lst_labels.Add(labelInicio);
            lst_labels.Add(labelEntidades);
            lst_labels.Add(labelInstalaciones);
            lst_labels.Add(labelActividades);
            lst_labels.Add(labelUsuarios);

            return lst_labels;
        }
        