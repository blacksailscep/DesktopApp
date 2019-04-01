using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Desktop
{
    public partial class FormEntidad : Desktop.FormPlantilla
    {
        bool mod, modd;
        Entidad entidad;
        public FormEntidad(Entidad entidad, bool mod)
        {
            InitializeComponent();
            this.entidad = entidad;
            this.modd = mod;
        }

        private void buttonVer_Click(object sender, EventArgs e)
        {
            mod = false;

            if (dataGridViewEquipo.SelectedRows.Count > 0)
            {
                Equipo equi = (Equipo)dataGridViewEquipo.SelectedRows[0].DataBoundItem;
                FormEquipo equipo = new FormEquipo(equi, mod);
                equipo.ShowDialog();
            }
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            mod = true;

            if (dataGridViewEquipo.SelectedRows.Count > 0)
            {
                Equipo equi = (Equipo)dataGridViewEquipo.SelectedRows[0].DataBoundItem;
                FormEquipo equipo = new FormEquipo(equi, mod);
                equipo.ShowDialog();
            }
        }
    }
}
