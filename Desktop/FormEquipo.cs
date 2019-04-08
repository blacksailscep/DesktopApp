using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Desktop
{
    public partial class FormEquipo : Desktop.FormPlantilla
    {
        bool mod;
        Equipo equip;

        public FormEquipo(Equipo equipo, bool mod)
        {
            InitializeComponent();
            this.equip = equipo;
            this.mod = mod;
        }

        private void FormEquipo_Load(object sender, EventArgs e)
        {
            actconcedidaBindingSource.DataSource = equip.Act_concedida;
            textBoxNombre.Text = equip.nombre;
            textBoxDeporte.Text = equip.Deportes.nombre;
            textBoxCategoria.Text = equip.Categoria_edad.nombre;
            textBoxCompeticion.Text = equip.Competicion.nombre;
            textBoxSexo.Text = equip.Sexo.nombre;
            textBoxNivel.Text = equip.Nivel.nombre;
            if(mod == false)
            {
                textBoxNombre.ReadOnly = true;
                textBoxDeporte.ReadOnly = true;
                textBoxCategoria.ReadOnly = true;
                textBoxCompeticion.ReadOnly = true;
                textBoxSexo.ReadOnly = true;
                textBoxNivel.ReadOnly = true;
            }
            
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            if(mod == true)
            {
                String nombre = textBoxNombre.Text;
                String deportes = textBoxDeporte.Text;
                String categoria_edad = textBoxCategoria.Text;
                String competicion = textBoxCompeticion.Text;
                String sexo = textBoxSexo.Text;
                String nivel = textBoxNivel.Text;

                ORM.ORMEquipos.UpdateEquipo(equip.id, nombre, deportes, categoria_edad, competicion, sexo, nivel);
            }

            this.Close();
        }
    }
}
