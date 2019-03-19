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

        public FormEspacio(Espacio espacio)
        {
            InitializeComponent();
            this.espacio = espacio;
        }

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
                
                
                insta = ORM.ORMInstalaciones.SelectInstalacionByID(espacio.id_instalacion, ref mensaje);
                textBoxInstalacion.Text = insta.nombre;
                textBoxInstalacion.Enabled = false;

                if (string.IsNullOrEmpty(mensaje))
                {
                    MessageBox.Show(mensaje, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                textBoxNombre.Text = espacio.nombre;
                textBoxPrecio.Text = espacio.precio.ToString();
                radioButtonExterior.Checked = espacio.exterior;


            }
            else
            {
                textBoxInstalacion.Text = instalacion.nombre;
                textBoxInstalacion.Enabled = false;
               
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

            /*System.Globalization.NumberStyles style;
            style = System.Globalization.CultureInfo.*/


            bool result = float.TryParse(preu, out precio);

            

            if (!result){
                MessageBox.Show("Error en la introducción del precio", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxPrecio.Focus();
            }
            else
            {
                //precio = (float)(Math.Truncate((double)precio * 100.0) / 100.0);
                /*value = "1.345,978";
                style = System.Globalization.NumberStyles.AllowDecimalPoint |
                        System.Globalization.NumberStyles.AllowThousands;
                culture = System.Globalization.CultureInfo.CreateSpecificCulture("es-ES");
                if (Single.TryParse(value, style, culture, out number))
                    Console.WriteLine("Converted '{0}' to {1}.", value, number);
                else
                    Console.WriteLine("Unable to convert '{0}'.", value);

                value = "1 345,978";
                if (Single.TryParse(value, style, culture, out number))
                    Console.WriteLine("Converted '{0}' to {1}.", value, number);
                else
                    Console.WriteLine("Unable to convert '{0}'.", value);*/
            }
            if (string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show("Error en la introducción del nombre", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxNombre.Focus();
            }

            Boolean exterior = radioButtonExterior.Checked;

            if (espacio != null)
            {
                Espacio espai = new Espacio();
                espai.id_instalacion = espacio.id_instalacion;
                espai.nombre = nombre;
                espai.precio = precio;
                espai.exterior = exterior;
                String mens = "";
                
                ORM.ORMEspacio.UpdateEspacio(espai, ref mens);
                
                
                if (!string.IsNullOrEmpty(mens))
                {
                    MessageBox.Show(mens, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (espacio == null) {
                Espacio espai = new Espacio();
                espai.id_instalacion = instalacion.id;
                espai.nombre = nombre;
                espai.precio = precio;
                espai.exterior = exterior;

                String mens = "";
                
                ORM.ORMEspacio.InsertEspacio(espai, ref mens);

                if (!string.IsNullOrEmpty(mens))
                {
                    MessageBox.Show(mens, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

                
           
            else
            {
                MessageBox.Show("No se puede guardar el espacio", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
