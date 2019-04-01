﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Desktop
{
    public partial class FormEntidades : Desktop.FormPlantilla
    {
        bool mod;
        public FormEntidades()
        {
            InitializeComponent();
        }

        private void buttonVer_Click(object sender, EventArgs e)
        {
            mod = false;
            if (dataGridViewEntidades.SelectedRows.Count > 0)
            {
                Entidad en = (Entidad)dataGridViewEntidades.SelectedRows[0].DataBoundItem;
                FormEntidad enti = new FormEntidad(en, mod);
                enti.ShowDialog();
            }
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            mod = true;
            if (dataGridViewEntidades.SelectedRows.Count > 0)
            {
                Entidad en = (Entidad)dataGridViewEntidades.SelectedRows[0].DataBoundItem;
                FormEntidad enti = new FormEntidad(en, mod);
                enti.ShowDialog();
            }
        }
    }
}
