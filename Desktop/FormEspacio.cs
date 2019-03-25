﻿using System;
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

                float numero = (float)(Math.Round((double)espacio.precio, 2));

                textBoxPrecio.Text = numero.ToString();
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
           
            float precio = float.Parse(preu);
            
            if (string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show("Error en la introducción del nombre", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxNombre.Focus();
            }

            Boolean exterior = radioButtonExterior.Checked;

            if (espacio != null)
            {
                Espacio espai = new Espacio();
                espai.id = espacio.id;
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
                else
                {
                    MessageBox.Show("Espacio modificado correctamente", "Modificación espacio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cerrar();
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

        //Mètode que asegura que s'ha introduït números correctament
        private void textBoxPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            // Si deseas, puedes permitir numeros decimales (o float)
            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
