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
            Instalacion instalacion = (Instalacion)dataGridViewInstalaciones.SelectedRows[0].DataBoundItem;

            FormUnaInstalacion formInstalacion = new FormUnaInstalacion(instalacion);
            formInstalacion.Text = "MODIFICACIÓN DE LA INSTALACIÓN";
            formInstalacion.ShowDialog();
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
                        ORM.ORMInstalaciones.DelelteInstalacion(insta, ref mensaje);

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
                    ORM.ORMInstalaciones.DelelteInstalacion(insta, ref mensaje);

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

            DialogResult resultado = MessageBox.Show("¿Está seguro de eliminar esta instalación?", "BORRAR INSTALACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            Instalacion instalacion = (Instalacion)dataGridViewInstalaciones.SelectedRows[0].DataBoundItem;

            if (resultado == DialogResult.Yes)
            {
                ORM.ORMInstalaciones.DelelteInstalacion(instalacion, ref mensaje);

                if (!mensaje.Equals(""))
                {
                    MessageBox.Show(mensaje, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;    //Para cancelar el evento
                }
            }
            else
            {
                e.Cancel = true;
                MessageBox.Show("La instalación no se borrará", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
