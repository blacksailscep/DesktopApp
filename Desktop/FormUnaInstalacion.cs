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
            bindingSourceEspacios.DataSource = ORM.ORMEspacio.SelectAllEspacios(ref mensaje);
            if (instalacion != null)
            {
                List<Instalacion_Horario> horari = ORM.ORMHorari_Instalacion.SelectAllHorarioInstalacion(instalacion.id, ref mensaje);
              
                if (horari.Count ==0)
                {
                    MessageBox.Show("No hi ha cap horari introduït en aquesta instal·lació", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    bindingSourceHorarioInsta.DataSource = horari;
                    MessageBox.Show("S'ha introduït horaris", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                
                buttonModificar.Text = "Modificar";
                buttonAnyadirEspai.Text = "Modificar";
                buttonAnyadirHoraInsta.Enabled = true;
            }
            else
            {
                buttonModificar.Text = "Añadir";
                buttonAnyadirEspai.Text = "Añadir";
                buttonAnyadirHoraInsta.Enabled = false;
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
            //FormHorarioInsta formHorariInsta;

            //listBoxEspacios.Text;

            //Espacio espacio = (Espacio)listBoxEspacios
            //    .SelectedRows[0].DataBoundItem;

            //if (instaHorario != null)
            //{
            //    formHorariInsta = new FormHorarioInsta(instaHorario);
            //}
            //else
            //{
            //    formHorariInsta = new FormHorarioInsta(instalacion);
            //}

            //formHorariInsta.ShowDialog();
        }

        /*Mètode per ELIMINAR ESPAIS a la instal·lació*/
        private void buttonEliminar_Click(object sender, EventArgs e)
        {

        }

        /* ------------------------------------------------ HORARI INSTAL·LACIÓ ------------------------------------------------ */
        /*Mètode per AFEFIR HORARI a la instal·lació*/
        private void buttonAnyadirHoraInsta_Click(object sender, EventArgs e)
        {
            FormHorarioInsta formHorariInsta;

            Instalacion_Horario instaHorario= (Instalacion_Horario)dataGridViewHorariosInsta.SelectedRows[0].DataBoundItem;
            
            if (instaHorario != null)
            {
                formHorariInsta = new FormHorarioInsta(instaHorario);
            }
            else
            {
                formHorariInsta = new FormHorarioInsta(instalacion);
            }

            formHorariInsta.ShowDialog();
        }

        /*Mètode per ELIMINAR HORARI a la instal·lació*/
        private void buttonEliminarHoraInsta_Click(object sender, EventArgs e)
        {
            String mensaje = "";

            Instalacion_Horario instaHorario = (Instalacion_Horario)dataGridViewHorariosInsta.SelectedRows[0].DataBoundItem;

            DialogResult resultado = MessageBox.Show("¿Está seguro de eliminar este horario?", "BORRAR HORARIO DE INSTALACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                ORM.ORMHorari_Instalacion.DelelteHorariInsta(instaHorario, ref mensaje);
               
                if (!string.IsNullOrWhiteSpace(mensaje))
                {
                    MessageBox.Show(mensaje, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                    //e.Cancel = true;    //Para cancelar el evento
                }
            }
            else
            {
                //Al poner NO igualmente lo borra de la grid pero no de la base de datos y llama al UserDeleteRow.
                //Tenemos que hacer esto para evitarlo

                //e.Cancel = true;

                /*Exception registros relacionados: DbUpdateException
                Dentro habrá un SQL Exception*/
            }

        }

        private void dataGridViewHorariosInsta_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            String mensaje = "";

            DialogResult resultado = MessageBox.Show("¿Está seguro de eliminar este horario?", "BORRAR HORARIO DE INSTALACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            Instalacion_Horario instaHorario = (Instalacion_Horario)dataGridViewHorariosInsta.SelectedRows[0].DataBoundItem;

            if (resultado == DialogResult.Yes)
            {
                ORM.ORMHorari_Instalacion.DelelteHorariInsta(instaHorario, ref mensaje);

                if (!mensaje.Equals(""))
                {
                    MessageBox.Show(mensaje, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;    //Para cancelar el evento
                }
            }
            else
            {
                e.Cancel = true;

            }
        }

        /* ------------------------------------------ MODIFICAR TOTES LES DADES ------------------------------------------ */
        private void buttonModificar_Click(object sender, EventArgs e)
        {

        }

    }
}
