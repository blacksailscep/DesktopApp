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
            labelInicio.Text        = "                   Inicio";
            labelEntidades.Text     = "          Entidades";
            labelInstalaciones.Text = "        Instalaciones";
            labelActividades.Text   = "         Actividades";
            labelUsuarios.Text      = "          Usuarios";
        }

        private void labelCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
