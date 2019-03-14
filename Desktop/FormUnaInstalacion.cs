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
    public partial class FormUnaInstalacion : Form
    {
        Instalacion instalacion;
        

        public FormUnaInstalacion()
        {
            InitializeComponent();
        }

        public FormUnaInstalacion(Instalacion instalacion)
        {
            InitializeComponent();
            this.instalacion = instalacion;
        }

        public void omplir(Instalacion instalacion)
        {
            String mensaje = "";
            bindingSourceTipoGestion.DataSource = ORM.ORMInstalaciones.SelectAllTipoGestion(ref mensaje);
            bindingSourceDiasSemana.DataSource = ORM.ORMInstalaciones.SelectAllDiasSemana(ref mensaje);

            if (instalacion != null)
            {
                bindingSourceHorarioInsta.DataSource = ORM.ORMInstalaciones.SelectAllHorarioInstalacion(instalacion.id, ref mensaje);
                buttonModificar.Text = "Modificar";
            }
            else
            {
                buttonModificar.Text = "Añadir";
            }
           

            if (!string.IsNullOrEmpty(mensaje))
            {
                MessageBox.Show(mensaje, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //e.Cancel()
            }
        }
       

        private void FormUnaInstalacion_Load(object sender, EventArgs e)
        {
            omplir(instalacion);

            if (instalacion != null)
            {
                textBoxNombre.Text = instalacion.nombre;
                textBoxDireccion.Text = instalacion.direccion;
                comboBoxTipoGestion.SelectedValue = instalacion.id_tipo_gestion;
            }
        }

        /* ------------------------------------------------ ESPAIS ------------------------------------------------ */
        /*Mètode per AFEGIR ESPAIS a la instal·lació*/
        private void buttonAnyadir_Click(object sender, EventArgs e)
        {

        }

        /*Mètode per ELIMINAR ESPAIS a la instal·lació*/
        private void buttonEliminar_Click(object sender, EventArgs e)
        {

        }

        /*Mètode per VEURE/MODIFICAR ESPAIS a la instal·lació*/
        private void buttonVer_Click(object sender, EventArgs e)
        {

        }

        /* ------------------------------------------------ HORARI INSTAL·LACIÓ ------------------------------------------------ */
        /*Mètode per AFEFIR HORARI a la instal·lació*/
        private void buttonAnyadirHoraInsta_Click(object sender, EventArgs e)
        {
            FormHorarioInsta formHorariInsta = new FormHorarioInsta();
            formHorariInsta.ShowDialog();
        }

        /*Mètode per ELIMINAR HORARI a la instal·lació*/
        private void buttonEliminarHoraInsta_Click(object sender, EventArgs e)
        {

        }

        /* ------------------------------------------ MODIFICAR TOTES LES DADES ------------------------------------------ */
        /*Mètode per MODIFICAR la INSTAL·LACIÓ*/
        private void buttonModificar_Click(object sender, EventArgs e)
        {

        }
    }
}
