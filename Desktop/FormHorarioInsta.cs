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
        Instalacion instala;
        Instalacion_Horario hInsta;

        public FormHorarioInsta()
        {
            InitializeComponent();
            inicialitzarDataTime();
        }

        //Un nuevo horario de una instalación
        public FormHorarioInsta(Instalacion instalac)
        {
            InitializeComponent();
            inicialitzarDataTime();
            this.instala = instalac;
        }

        //Para modificar un horario de una instalación
        public FormHorarioInsta(Instalacion_Horario hInsta)
        {
            InitializeComponent();
            inicialitzarDataTime();
            this.hInsta = hInsta;
        }

        //Funció que inicialitza els dataTimePicker i treu la opció del calendari
        public void inicialitzarDataTime()
        {
            dateTimePickerHInicio.ShowUpDown = true;          //Quita la opción del calendario
            dateTimePickerHFinal.ShowUpDown = true;          //Quita la opción del calendario
           
        }

        private void FormHorarioInsta_Load(object sender, EventArgs e)
        {

            String mensaje = "";
            bindingSourceDiesSetmana.DataSource = ORM.ORMInstalaciones.SelectAllDiasSemana(ref mensaje);

            if (!string.IsNullOrWhiteSpace(mensaje))
            {
                MessageBox.Show(mensaje, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close(); 
            }

            //Para añadir un horario de una instalación
            if (instala != null)
            {
                List<Instalacion_Horario> horari = ORM.ORMHorari_Instalacion.SelectAllHorarioInstalacion(instala.id, ref mensaje);

                if (!string.IsNullOrWhiteSpace(mensaje))
                {
                    MessageBox.Show(mensaje, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (horari == null)
                {
                    //MessageBox.Show("No hi ha cap horari introduït en aquesta instal·lació", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dateTimePickerHInicio.Enabled = true;
                    comboBoxDiasSemana.Enabled = true;
                }
               
                
            }
            
            if (hInsta != null)
            {
                dateTimePickerHInicio.Text = hInsta.hora_inicio.ToString();
                dateTimePickerHFinal.Text = hInsta.hora_final.ToString();
                comboBoxDiasSemana.SelectedItem = hInsta.id_dia_semana;
                dateTimePickerHInicio.Enabled = false;
                comboBoxDiasSemana.Enabled = false;

            }
           
           
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            
            string hInicio = dateTimePickerHInicio.Text;
            string hFin = dateTimePickerHFinal.Text;
            int diasSemana = (int)comboBoxDiasSemana.SelectedValue;

            if(hInicio.Equals("0:00:00"))
            {
                MessageBox.Show("No se ha seleccionado la hora de inicio", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dateTimePickerHInicio.Focus();
            }
            else if (hFin.Equals("0:00:00"))
            {
                MessageBox.Show("No se ha seleccionado la hora de finalización", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dateTimePickerHFinal.Focus();
            }
            else
            {
                String mensaje = "";

                //Actualizar un horario
                if (hInsta != null)
                {
                    Instalacion_Horario hI = new Instalacion_Horario();
                    hI.id_instalacion = hInsta.id_instalacion;
                    hI.id_dia_semana = diasSemana;
                    hI.hora_inicio = TimeSpan.Parse(hInicio);
                    hI.hora_final = TimeSpan.Parse(hFin);

                    ORM.ORMHorari_Instalacion.UpdateHorariInstalacio(hInsta.id_instalacion, hInsta.id_dia_semana, hInsta.hora_inicio,hI, ref mensaje);
                }
                else
                {

                    //Insertar un horario
                    Instalacion_Horario hI = new Instalacion_Horario();
                    hI.id_instalacion = instala.id;
                    hI.id_dia_semana = diasSemana;
                    hI.hora_inicio = TimeSpan.Parse(hInicio);
                    hI.hora_final = TimeSpan.Parse(hFin);

                    ORM.ORMHorari_Instalacion.InsertHorariInstalacio(hI, ref mensaje);
                }

                //Comprovar que no se produco errores
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
