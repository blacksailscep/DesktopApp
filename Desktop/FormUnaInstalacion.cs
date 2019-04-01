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

        //Para ver una instalación
        public FormUnaInstalacion(Instalacion instalacion)
        {
            InitializeComponent();
            this.instalacion = instalacion;
        }

        public void omplir()
        {
            bindingsGrid();

            //String mensaje = "";
            if (instalacion != null)
            {
                //List<Instalacion_Horario> horari = ORM.ORMHorari_Instalacion.SelectAllHorarioInstalacion(instalacion.id, ref mensaje);
              
                //bindingSourceHorarioInsta.DataSource = horari;
               

                //Para que SÍ se puedan modificar si no hay ningún horario ni espacio añadidos
                botonesEspacio();
                botonesHorario();
            }
            else
            {
                //Para que SÍ se puedan modificar si no hay ningún horario ni espacio añadidos
                botonesEspacio();
                botonesHorario();
            }
            
        }

        public void botonesEspacio()
        {
            if (instalacion.Espacio != null)
            {
                //Per a que SÍ puguin modificar sino hi ha cap espai afegit
                buttonModificarEspai.Enabled = true;
                buttonEliminarEspai.Enabled = true;
                
            }
            else
            {
                //Per a que no puguin modificar sino hi ha cap espai afegit
                buttonModificarEspai.Enabled = false;
                buttonEliminarEspai.Enabled = false;
            }
        }

        public void botonesHorario()
        {
            if (dataGridViewHorariosInsta.RowCount != 0)
            {
                //Per a que SÍ puguin modificar sino hi ha cap horari afegit
                buttonModificarHorariInsa.Enabled = true;
                buttonEliminarHoraInsta.Enabled = true;
            }
            else
            {
                //Per a que no puguin modificar sino hi ha cap horari afegit
                buttonModificarHorariInsa.Enabled = false;
                buttonEliminarHoraInsta.Enabled = false;
            }
        }

        public void bindingsGrid()
        {
            string mensaje = "";
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

                List<Instalacion_Horario> horari = ORM.ORMHorari_Instalacion.SelectAllHorarioInstalacion(instalacion.id, ref mensaje);

                bindingSourceHorarioInsta.DataSource = horari;
            }
            
        }

        private void FormUnaInstalacion_Load(object sender, EventArgs e)
        {
            bindingsGrid();
            omplir();

            if (instalacion != null)
            {
                textBoxNombre.Text = instalacion.nombre;
                textBoxDireccion.Text = instalacion.direccion;
                comboBoxTipoGestion.SelectedValue = instalacion.id_tipo_gestion;
                buttonModificar.Text = "Modificar";
            }
            else
            {
                buttonModificar.Text = "Añadir";
            }
        }

        private void FormUnaInstalacion_Activated(object sender, EventArgs e)
        {
            bindingsGrid();
            botonesEspacio();
            botonesHorario();
        }



        /* ------------------------------------------------ HORARI INSTAL·LACIÓ ------------------------------------------------ */
        /*Mètode per AFEFIR HORARI a la instal·lació*/
        private void buttonAnyadirHoraInsta_Click(object sender, EventArgs e)
        {

            FormHorarioInsta formHorariInsta = new FormHorarioInsta(instalacion);
            formHorariInsta.ShowDialog();
            
            
        }

        public void modificarInstalacio()
        {
            Instalacion_Horario instaHorario = (Instalacion_Horario)dataGridViewHorariosInsta.SelectedRows[0].DataBoundItem;

            if (instaHorario == null)
            {
                MessageBox.Show("No se puede modificar el horario", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                FormHorarioInsta formHorariInsta = new FormHorarioInsta(instaHorario);
                formHorariInsta.ShowDialog();
            }
        }

        /*Mètode per MODIFICAR HORARI a la instal·lació*/
        private void buttonModificarHorariInsa_Click(object sender, EventArgs e)
        {
            modificarInstalacio();
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
                else
                {
                    bindingsGrid();
                    botonesEspacio();
                    botonesHorario();
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
                else
                {
                    bindingsGrid();
                    botonesEspacio();
                    botonesHorario();
                }
            }
            else
            {
                e.Cancel = true;
                MessageBox.Show("El horario no se borrará", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void dataGridViewHorariosInsta_DoubleClick(object sender, EventArgs e)
        {
            modificarInstalacio();
        }

        /* ------------------------------------------------ ESPAIS ------------------------------------------------ */
        /*Mètode per AFEGIR ESPAIS a la instal·lació*/
        private void buttonAnyadirEspai_Click(object sender, EventArgs e)
        {
            FormEspacio formEspacio = new FormEspacio(instalacion);
            formEspacio.ShowDialog();
        }

        public void modificarEspai()
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

        /*Mètode per MODIFICAR ESPAIS a la instal·lació*/
        private void buttonModificarEspai_Click(object sender, EventArgs e)
        {
            modificarEspai();
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
                bindingsGrid();
                if (!string.IsNullOrWhiteSpace(mensaje))
                {
                    MessageBox.Show(mensaje, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    //e.Cancel = true;    //Para cancelar el evento
                }
                else
                {
                    bindingsGrid();
                    botonesEspacio();
                    botonesHorario();
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
                else
                {
                    bindingsGrid();
                    botonesEspacio();
                    botonesHorario();
                }
            }
            else
            {
                e.Cancel = true;
                MessageBox.Show("El espacio no se borrará", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void dataGridViewEspacios_DoubleClick(object sender, EventArgs e)
        {
            modificarEspai();
        }


        /*Mètode per modificar tota la instal·lació*/
        private void buttonModificar_Click(object sender, EventArgs e)
        {

            String nombre = textBoxNombre.Text;
            String direccion = textBoxDireccion.Text;
            int gestion = (int)comboBoxTipoGestion.SelectedValue;

            if (string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show("Error en la introducción de nombre", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxNombre.Focus();
            }
            else if (string.IsNullOrWhiteSpace(direccion))
            {
                MessageBox.Show("Error en la introducción de dirección", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxDireccion.Focus();
            }
            else
            {
                
                Instalacion i = new Instalacion();
                i.id = instalacion.id;
                i.nombre = nombre;
                i.direccion = direccion;
                i.id_tipo_gestion = gestion;

                String mensaje = "";

                //Para insertar
                if (instalacion == null)
                {
                    ORM.ORMInstalaciones.InsertInstalacion(i, ref mensaje);
                    if (!mensaje.Equals(""))
                    {
                        MessageBox.Show(mensaje, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //e.Cancel = true;    //Para cancelar el evento
                    }
                    else
                    {
                        MessageBox.Show("Inserción correcta", "Inserción Instalaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }

                }
                else
                {
                    //Para modificar
                    ORM.ORMInstalaciones.UpdateInstalacion(i, ref mensaje);
                    if (!mensaje.Equals(""))
                    {
                        MessageBox.Show(mensaje, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //e.Cancel = true;    //Para cancelar el evento
                    }
                    else
                    {
                        MessageBox.Show("Actualización correcta", "Actualización Instalaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                        this.Close();
                    }
                }
            }

            
           

        }
    }
}
