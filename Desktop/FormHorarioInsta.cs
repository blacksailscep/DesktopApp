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
    public partial class FormHorarioInsta : Form
    {
        Instalacion instalacion;
        public FormHorarioInsta()
        {
            InitializeComponent();
            inicialitzarDataTime();
        }

        //Funció que inicialitza els dataTimePicker i treu la opció del calendari
        public void inicialitzarDataTime()
        {
            //dateTimePickerHInicio.Format = DateTimePickerFormat.Custom;
            dateTimePickerHInicio.ShowUpDown = true;          //Quita la opción del calendario
            //dateTimePickerHInicio.CustomFormat = "HH:mm tt";  //Formato 24 h

            //dateTimePickerHFinal.Format = DateTimePickerFormat.Custom;
            dateTimePickerHFinal.ShowUpDown = true;          //Quita la opción del calendario
            //dateTimePickerHFinal.CustomFormat = "HH:mm tt";  //Formato 24 h
        }

        private void FormHorarioInsta_Load(object sender, EventArgs e)
        {

            //if (instalacion != null)
            //{
            //    String mensaje = "";
            //    bindingSourceDiesSetmana.DataSource = ORM.ORMInstalaciones.SelectAllDiasSemana(ref mensaje);

            //    if (!string.IsNullOrWhiteSpace(mensaje))
            //    {
            //        MessageBox.Show(mensaje, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Error al cargar la instalación", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

           
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            int diasSemana = 0;

            
            DateTime hInicio = dateTimePickerHInicio.Value;
            DateTime hFin = dateTimePickerHFinal.Value;

            diasSemana = comboBoxDiasSemana.SelectedIndex;

            if(diasSemana!=0 && string.IsNullOrEmpty(hInicio+"") && string.IsNullOrEmpty(hFin + "") )
            {

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
