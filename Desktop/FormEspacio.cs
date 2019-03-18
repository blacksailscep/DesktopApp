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
    public partial class FormEspacio : Form
    {
        Espacio espacio;
        public FormEspacio()
        {
            InitializeComponent();
        }

        public FormEspacio(Espacio espacio)
        {
            InitializeComponent();
            this.espacio = espacio;
        }

        private void FormEspacio_Load(object sender, EventArgs e)
        {
            String mensaje = "";
            Instalacion insta = ORM.ORMInstalaciones.SelectInstalacionBynombre(espacio.id_instalacion.ToString(), ref mensaje);

            if (string.IsNullOrEmpty(mensaje))
            {
                MessageBox.Show(mensaje, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                textBoxInstalacion.Text = insta.nombre;
                textBoxInstalacion.Enabled = false;
                if (espacio != null)
                {
                    textBoxNombre.Text = espacio.nombre;
                    textBoxPrecio.Text = espacio.precio.ToString();
                    radioButtonExterior.Checked = espacio.exterior;
                }
            }
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {

            String nombre = textBoxNombre.Text;

            /*Per a assegurar-se que s'ha introduït les comes correctament*/
            string preu = textBoxPrecio.Text;

            if (preu.Contains("."))
            {
                preu = preu.Replace('.', ',');
            }

            //Per assegurar-se que s'ha introduït preus
            float precio = 0;
            bool result = float.TryParse(preu, out precio);

            if (!result){
                MessageBox.Show("Error en la introducción del precio", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxPrecio.Focus();
            }
            if (string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show("Error en la introducción del nombre", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxNombre.Focus();
            }

            Boolean exterior = radioButtonExterior.Checked;

            Espacio espai = new Espacio();
            espai.id_instalacion = espacio.id_instalacion;
            espai.nombre = nombre;
            espai.precio = precio;
            espai.exterior = exterior;

            String mens = "";
            if (espacio != null)
            {
                ORM.ORMEspacio.UpdateEspacio(espai, ref mens);
            }
            else
            {
                ORM.ORMEspacio.InsertEspacio(espai, ref mens);
            }

            if (!string.IsNullOrEmpty(mens))
            {
                MessageBox.Show(mens, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
