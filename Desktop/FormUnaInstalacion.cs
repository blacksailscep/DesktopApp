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

        public void omplir()
        {
            bindingsGrid();

            String mensaje = "";
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

                //Per a que SÍ puguin modificar sino hi ha cap horari ni espai afegit
                botones();
            }
            else
            {
                //Per a que no puguin modificar sino hi ha cap horari ni espai afegit
                botones();
            }
            
        }

        public void botones()
        {
            if (instalacion != null)
            {
                //Per a que SÍ puguin modificar sino hi ha cap horari ni espai afegit
                buttonModificarEspai.Enabled = true;
                buttonModificarHorariInsa.Enabled = true;
                buttonAnyadirEspai.Enabled = true;
                buttonAnyadirHoraInsta.Enabled = true;
            }
            else
            {
                //Per a que no puguin modificar sino hi ha cap horari ni espai afegit
                buttonModificarEspai.Enabled = false;
                buttonModificarHorariInsa.Enabled = false;
                buttonAnyadirEspai.Enabled = false;
                buttonAnyadirHoraInsta.Enabled = false;
            }
        }

        public void bindingsGrid()
        {
            String mensaje = "";
            bindingSourceTipoGestion.DataSource = ORM.ORMInstalaciones.SelectAllTipoGestion(ref mensaje);
            if (!string.IsNullOrEmpty(mensaje))
            {
                MessageBox.Show(mensaje, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //e.Cancel()
            }

            mensaje = "";
            bindingSourceDiasSemana.DataSource = ORM.ORMInstalaciones.SelectAllDiasSemana(ref mensaje);
            if (!string.IsNullOrEmpty(mensaje))
            {
                MessageBox.Show(mensaje, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //e.Cancel()
            }


            if (instalacion != null)
            {
                mensaje = "";
                bindingSourceEspacios.DataSource = ORM.ORMEspacio.SelectAllEspacios(instalacion.id, ref mensaje);
                if (!string.IsNullOrEmpty(mensaje))
                {
                    MessageBox.Show(mensaje, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //e.Cancel()
                }
            }
            
        }

        private void FormUnaInstalacion_Load(object sender, EventArgs e)
        {
            omplir();

            if (instalacion != null)
            {
                textBoxNombre.Text = instalacion.nombre;
                textBoxDireccion.Text = instalacion.direccion;
                comboBoxTipoGestion.SelectedValue = instalacion.id_tipo_gestion;
                buttonModificar.Text = "Modificar";
            }
            else{
                buttonModificar.Text = "Añadir";
            }
        }

        private void FormUnaInstalacion_Activated(object sender, EventArgs e)
        {
            bindingsGrid();
            botones();
        }



        /* ------------------------------------------------ HORARI INSTAL·LACIÓ ------------------------------------------------ */
        /*Mètode per AFEFIR HORARI a la instal·lació*/
        private void buttonAnyadirHoraInsta_Click(object sender, EventArgs e)
        {

            FormHorarioInsta formHorariInsta = new FormHorarioInsta(instalacion);
            formHorariInsta.ShowDialog();
            
            
        }

        /*Mètode per MODIFICAR HORARI a la instal·lació*/
        private void buttonModificarHorariInsa_Click(object sender, EventArgs e)
        {
            Instalacion_Horario instaHorario = (Instalacion_Horario)dataGridViewHorariosInsta.SelectedRows[0].DataBoundItem;

            if (instaHorario == null)
            {
                FormHorarioInsta formHorariInsta = new FormHorarioInsta(instaHorario);
                formHorariInsta.ShowDialog();
            }
            else
            {
                MessageBox.Show("No se puede modificar el horario", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /*Mètode per ELIMINAR HORARI a la instal·lació amb BOTÓ*/
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
                MessageBox.Show("El horario no se borrará", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /*Mètode per ELIMINAR HORARI a la instal·lació amb SUPRIMIR*/
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
                MessageBox.Show("El horario no se borrará", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /* ------------------------------------------------ ESPAIS ------------------------------------------------ */
        /*Mètode per AFEGIR ESPAIS a la instal·lació*/
        private void buttonAnyadirEspai_Click(object sender, EventArgs e)
        {
            FormEspacio formEspacio = new FormEspacio(instalacion);
            formEspacio.ShowDialog();
        }

        /*Mètode per MODIFICAR ESPAIS a la instal·lació*/
        private void buttonModificarEspai_Click(object sender, EventArgs e)
        {
            Espacio espacio = (Espacio)dataGridViewEspacios.SelectedRows[0].DataBoundItem;
            if (espacio != null)
            {
                FormEspacio formEspacio = new FormEspacio(espacio);
                formEspacio.ShowDialog();
            }
            else
            {
                MessageBox.Show("No se puede modificar el espacio", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /*Mètode per ELIMINAR ESPAIS amb BOTÓ*/
        private void buttonEliminarEspai_Click(object sender, EventArgs e)
        {
            String mensaje = "";

            Espacio espacio = (Espacio)dataGridViewEspacios.SelectedRows[0].DataBoundItem;

            DialogResult resultado = MessageBox.Show("¿Está seguro de eliminar este espacio?", "BORRAR ESPACIO DE INSTALACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                ORM.ORMEspacio.DelelteEspacio(espacio, ref mensaje);

                if (!string.IsNullOrWhiteSpace(mensaje))
                {
                    MessageBox.Show(mensaje, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    //e.Cancel = true;    //Para cancelar el evento
                }
            }
            else
            {
                MessageBox.Show("El espacio no se borrará", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /*Mètode per ELIMINAR ESPAIS sense BOTÓ*/
        private void dataGridViewEspacios_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            String mensaje = "";

            DialogResult resultado = MessageBox.Show("¿Está seguro de eliminar este espacio?", "BORRAR ESPACIO DE INSTALACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            Espacio espacio = (Espacio)dataGridViewEspacios.SelectedRows[0].DataBoundItem;

            if (resultado == DialogResult.Yes)
            {
                ORM.ORMEspacio.DelelteEspacio(espacio, ref mensaje);

                if (!mensaje.Equals(""))
                {
                    MessageBox.Show(mensaje, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;    //Para cancelar el evento
                }
            }
            else
            {
                e.Cancel = true;
                MessageBox.Show("El espacio no se borrará", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
