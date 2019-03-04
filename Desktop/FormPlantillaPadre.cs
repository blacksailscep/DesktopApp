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
    public partial class FormPlantillaPadre : Form
    {
        public FormPlantillaPadre()
        {
            InitializeComponent();
        }

        private void FormPlantillaPadre_Load(object sender, EventArgs e)
        {
            labelInicio.Text        = "\n        Inicio";
            labelEntidades.Text     = "\n       Entidades";
            labelInstalaciones.Text = "\n     Instalaciones";
            labelActividades.Text   = "\n      Actividades";
            labelUsuarios.Text      = "\n       Usuarios";
        }
    }
}
