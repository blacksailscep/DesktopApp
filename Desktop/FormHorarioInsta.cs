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
        Instalacion_Horario hInsta;
        public FormHorarioInsta()
        {
            InitializeComponent();
            inicialitzarDataTime();
        }

        public FormHorarioInsta(Instalacion instalacion)
        {
            InitializeComponent();
            inicialitzarDataTime();
        }

        public FormHorarioInsta(Instalacion_Horario hInsta)
        {
            InitializeComponent();
            inicialitzarDataTime();
            this.hInsta = hInsta;
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

            if (instalacion != null)
            {
                String mensaje = "";

                List<Instalacion_Horario> horari = ORM.ORMHorari_Instalacion.SelectAllHorarioInstalacion(instalacion.id, ref mensaje);

                if (!string.IsNullOrWhiteSpace(mensaje))
                {
                    MessageBox.Show(mensaje, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (horari == null)
                {
                    MessageBox.Show("No hi ha cap horari introduït en aquesta instal·lació", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //dateTimePickerHInicio.Value = horari
                    //DateTime hFin = dateTimePickerHFinal.Value;

                    //diasSemana = comboBoxDiasSemana.SelectedIndex;
                    MessageBox.Show("S'ha introduït horaris", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            
            if (hInsta != null)
            {
                dateTimePickerHInicio.Text = hInsta.hora_inicio+"";
                dateTimePickerHFinal.Text = hInsta.hora_inicio + "";
                comboBoxDiasSemana.SelectedItem = hInsta.id_dia_semana;
            }
            else
            {
                MessageBox.Show("Error al cargar el horario de la instalación", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

           
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            int diasSemana = 0;

            
            //DateTime hInicio = dateTimePickerHInicio.Value;
            //DateTime hFin = dateTimePickerHFinal.Value;

            String hInicio = dateTimePickerHInicio.Text;
            String hFin = dateTimePickerHFinal.Text;

            diasSemana = comboBoxDiasSemana.SelectedIndex;

            if(diasSemana!=0 && string.IsNullOrEmpty(hInicio) && string.IsNullOrEmpty(hFin) )
            {
                String mensaje = "";

                if (hInsta != null)
                {
                    Instalacion_Horario hI = new Instalacion_Horario();
                    hI.id_instalacion = hInsta.id_instalacion;
                    hI.id_dia_semana = diasSemana;
                    hI.hora_inicio = TimeSpan.Parse(hInicio);
                    hI.hora_final = TimeSpan.Parse(hFin);
                    ORM.ORMHorari_Instalacion.UpdateHorariInstalacio(hI, ref mensaje);
                }
                else
                {
                    Instalacion_Horario hI = new Instalacion_Horario();
                    hI.id_instalacion = instalacion.id;
                    hI.id_dia_semana = diasSemana;
                    hI.hora_inicio = TimeSpan.Parse(hInicio);
                    hI.hora_final = TimeSpan.Parse(hFin);

                    ORM.ORMHorari_Instalacion.InsertHorariInstalacio(hI, ref mensaje);
                }

                

                if (!string.IsNullOrWhiteSpace(mensaje))
                {
                    MessageBox.Show(mensaje, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("El horario de la instalación se introdujo correctamente", "Insert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cerrar();
                }

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
    }
}
