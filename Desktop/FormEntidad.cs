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

        private void FormEntidad_Load(object sender, EventArgs e)
        {
            textBoxNombre.Text = entidad.nombre;
            textBoxDireccion.Text = entidad.direccion;
            textBoxTemporada.Text = entidad.temporada.ToString();
            telefonosBindingSource.DataSource = entidad.Telefonos;
            if (modd == false)
            {
                textBoxNombre.ReadOnly = true;
                textBoxDireccion.ReadOnly = true;
                textBoxTemporada.ReadOnly = true;
            }
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

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            if (modd == true)
            {
                String nombre = textBoxNombre.Text;
                String direcion = textBoxDireccion.Text;
                int temporada = int.Parse(textBoxTemporada.Text);
                ORM.ORMEntidades.UpdateEntidad(entidad.id, nombre, direcion, temporada);
            }
            this.Close();
           
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
