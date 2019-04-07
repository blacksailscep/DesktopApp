using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Desktop
{
    public partial class FormInstalaciones : Desktop.FormPlantilla
    {
        public FormInstalaciones()
        {
            InitializeComponent();
        }

        public void llenar()
        {
            String mensaje = "";

            bindingSourceInstalaciones.DataSource = ORM.ORMInstalaciones.SelectAllInstalaciones(ref mensaje);
            bindingSourceTipoGestion.DataSource = ORM.ORMInstalaciones.SelectAllTipoGestion(ref mensaje);

            if (!string.IsNullOrEmpty(mensaje))
            {
                MessageBox.Show(mensaje, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //e.Cancel()
            }
            
        }

        private void FormInstalaciones_Load(object sender, EventArgs e)
        {
            llenar();  
        }

        private void FormInstalaciones_Activated(object sender, EventArgs e)
        {
            llenar();
        }

        public void modificar()
        {
            Instalacion instalaci = (Instalacion)dataGridViewInstalaciones.SelectedRows[0].DataBoundItem;
            if (instalaci != null)
            {
                FormUnaInstalacion formInstalacion = new FormUnaInstalacion(instalaci);
                formInstalacion.Text = "MODIFICACIÓN DE LA INSTALACIÓN";
                try
                {
                    formInstalacion.ShowDialog();
                }catch(Exception e)
                {
                    MessageBox.Show(e.Message, "BORRAR DE INSTALACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                }
            }
        }

        private void buttonVer_Click(object sender, EventArgs e)
        {
            modificar();
        }

        private void buttonAñadir_Click(object sender, EventArgs e)
        {
            FormUnaInstalacion formInstalacion = new FormUnaInstalacion();
            formInstalacion.Text = "AÑADIR UNA INSTALACIÓN";
            formInstalacion.ShowDialog();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            String mensaje = "";

            DialogResult resultado = MessageBox.Show("¿Está seguro de eliminar este horario?", "BORRAR HORARIO DE INSTALACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            Instalacion insta = (Instalacion)dataGridViewInstalaciones.SelectedRows[0].DataBoundItem;

            if (resultado == DialogResult.Yes)
            {

                if (insta.Espacio != null || insta.Instalacion_Horario != null)
                {
                    DialogResult resultado2 = MessageBox.Show("Tiene registros relacionados ¿Está seguro de continar con la eliminación de esta instalación?", "BORRAR DE INSTALACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (resultado == DialogResult.Yes)
                    {
                        mensaje=ORM.ORMInstalaciones.DelelteInstalacion(insta);

                        if (!mensaje.Equals(""))
                        {
                            MessageBox.Show(mensaje, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            //Para cancelar el evento
                        }
                        else
                        {
                            llenar();
                        }
                    }
                    else
                    {
                        llenar();
                    }
                }
                else
                {
                    mensaje=ORM.ORMInstalaciones.DelelteInstalacion(insta);

                    if (!mensaje.Equals(""))
                    {
                        MessageBox.Show(mensaje, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //Para cancelar el evento
                    }
                    else
                    {
                        llenar();
                    }
                }


                              
            }
            else
            {
                MessageBox.Show("El horario no se borrará", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewInstalaciones_DoubleClick(object sender, EventArgs e)
        {
            modificar();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            String mensaje = "";

            String nombre = textBoxBuscar.Text;

            if (!string.IsNullOrWhiteSpace(nombre))
            {
                bindingSourceInstalaciones.DataSource = ORM.ORMInstalaciones.SelectInstalacionBynombre(nombre, ref mensaje);
            }


            if(!string.IsNullOrWhiteSpace(mensaje))
            {
                MessageBox.Show(mensaje, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxBuscar.Focus();
            }

           
        }

        private void dataGridViewInstalaciones_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {

            String mensaje = "";

            DialogResult resultado = MessageBox.Show("¿Está seguro de eliminar este horario?", "BORRAR HORARIO DE INSTALACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            Instalacion insta = (Instalacion)dataGridViewInstalaciones.SelectedRows[0].DataBoundItem;

            if (resultado == DialogResult.Yes)
            {

                int numE = insta.Espacio.Count;         int numH = insta.Instalacion_Horario.Count;

                if (numE == 0 && numH == 0)
                {
                    mensaje = ORM.ORMInstalaciones.DelelteInstalacion(insta);

                    if (!string.IsNullOrWhiteSpace(mensaje))
                    {
                        MessageBox.Show(mensaje, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        e.Cancel = true;
                    }

                    llenar();
                }
                else
                {
                    DialogResult resultado2 = MessageBox.Show("Tiene registros relacionados ¿Está seguro de continar con la eliminación de esta instalación?", "BORRAR DE INSTALACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (resultado2 == DialogResult.Yes)
                    {
                        mensaje = ORM.ORMInstalaciones.DelelteInstalacion(insta);

                        if (!string.IsNullOrWhiteSpace(mensaje))
                        {
                            MessageBox.Show(mensaje, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            e.Cancel = true;
                        }
                    }
                    else
                    {
                        MessageBox.Show("El horario no se borrará", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        e.Cancel = true;
                        llenar();
                    }
                }   
            }
            else
            {
                MessageBox.Show("El horario no se borrará", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }

            //ORM.ORMInstalaciones.DelelteInstalacion(instalacion, ref mensaje);

            //if (!mensaje.Equals(""))
            //{
            //    MessageBox.Show(mensaje, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    e.Cancel = true;    //Para cancelar el evento
            //}
       

        }
    }
}
