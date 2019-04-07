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
        Instalacion instalacion;

        public FormEspacio()
        {
            InitializeComponent();
        }

        //Para modificar un espacio
        public FormEspacio(Espacio espacio)
        {
            InitializeComponent();
            this.espacio = espacio;
        }

        //Para añadir un espacio --> id_instalacion
        public FormEspacio(Instalacion instalacion)
        {
            InitializeComponent();
            this.instalacion = instalacion;
        }

        private void FormEspacio_Load(object sender, EventArgs e)
        {
            String mensaje = "";

            if (espacio != null)
            {
                Instalacion insta = new Instalacion();
                
                //Hago una búsqueda para mostrar el nombre de la instalación por pantalla
                insta = ORM.ORMInstalaciones.SelectInstalacionByID((int)espacio.id_instalacion, ref mensaje);
                textBoxInstalacion.Text = insta.nombre;
                //Se deshabilita para no poder modificarlo
                textBoxInstalacion.Enabled = false;

                if (string.IsNullOrEmpty(mensaje))
                {
                    MessageBox.Show(mensaje, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                textBoxNombre.Text = espacio.nombre;

                //Redondea los decimales a 2
                float numero = (float)(Math.Round((double)espacio.precio, 2));

                textBoxPrecio.Text = numero.ToString();
                radioButtonExterior.Checked = (bool)espacio.exterior;


            }
            else
            {
                textBoxInstalacion.Text = instalacion.nombre;
                textBoxInstalacion.Enabled = false;
               
            }
           
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {

            string nombre = textBoxNombre.Text;
            string preu = textBoxPrecio.Text;

            /*Per a assegurar-se que s'ha introduït les comes correctament*/
            
            if (preu.StartsWith("."))
            {
                preu += "0";
            }

            if (preu.Contains("."))
            {
                preu = preu.Replace('.', ',');
            }
           
            float precio = float.Parse(preu);
            
            if (string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show("Error en la introducción del nombre", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxNombre.Focus();
            }

            Boolean exterior = radioButtonExterior.Checked;

            //Actualizar un espacio
            if (espacio != null)
            {
                Espacio espai = new Espacio();
                espai.id = espacio.id;
                espai.id_instalacion = espacio.id_instalacion;
                espai.nombre = nombre;
                espai.precio = precio;
                espai.exterior = exterior;
                string mens = "";
                
                mens= ORM.ORMEspacio.UpdateEspacio(espai);
                
                
                if (!string.IsNullOrEmpty(mens))
                {
                    MessageBox.Show(mens, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Espacio modificado correctamente", "Modificación espacio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cerrar();
                }
            }
            else if (espacio == null) {
                
                //Insertar un espacio
                Espacio espai = new Espacio();
                espai.id_instalacion = instalacion.id;
                espai.nombre = nombre;
                espai.precio = precio;
                espai.exterior = exterior;

                string mens = "";
                
                mens = ORM.ORMEspacio.InsertEspacio(espai);

                if (!string.IsNullOrEmpty(mens))
                {
                    MessageBox.Show(mens, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Espacio insertado correctamente", "Inserción espacio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cerrar();
                }
            }

            else
            {
                MessageBox.Show("No se puede guardar el espacio", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

           
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            cerrar();
        }
        
        public void cerrar()
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

        //Método que asegura que se ha introducido números correctamente
        private void textBoxPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            // Para permitir números decimales (o float)
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
