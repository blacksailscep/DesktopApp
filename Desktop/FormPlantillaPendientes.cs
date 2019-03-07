using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace Desktop
{
    public partial class FormPlantillaPendientes : Desktop.FormPlantilla
    {
        private Type myType;
        private IList<PropertyInfo> props;
        private int idAct,m_idEspacio;
        private int m_diaSemana, idHorario;
        private Object m_actividad;

        public FormPlantillaPendientes(Object actividad)
        {
            InitializeComponent();

            m_actividad = actividad;
            myType = actividad.GetType();
            props = new List<PropertyInfo>(myType.GetProperties());
            GetVariables();

            new GenerarHorario(dataGridViewHorarioActividadesPedidas);
            new GenerarHorario(dataGridViewHorarioActAsignadas);

            string mensajeError = "";
            List<Object> lstHorario =
                ORM.ORMAcividadesPendientes.SelectHorarioActividadPendientes(ref mensajeError, idAct);
            if (!mensajeError.Equals(""))
                MessageBox.Show(mensajeError, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            GetScheduleActivity(lstHorario, idAct, dataGridViewHorarioActividadesPedidas, "Horas",Color.YellowGreen);

            List<Object> lstHorario2 =
                ORM.ORMActividadesConcedidas.SelectActividadPorEspacio(ref mensajeError, m_idEspacio);
            if (!mensajeError.Equals(""))
                MessageBox.Show(mensajeError, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            GetScheduleActivity(lstHorario2, idAct,dataGridViewHorarioActAsignadas,"Hora",Color.Red);
            

            foreach (Label label in GetLabels())
            {
                label.Visible = false;
            }

        }
        public void GetScheduleActivity(List<Object> lstHorario, int idAct,DataGridView datagrid,string columnName,
            Color color)
        {
            foreach (Object horario in lstHorario)
            {
                string horaInicio = "";
                string horaFin = "";

                myType = horario.GetType();
                props = new List<PropertyInfo>(myType.GetProperties());
                foreach (PropertyInfo prop in props)
                {
                    if (prop.Name.Equals("hora_inicio"))
                    {
                        Object ot = (Object)prop.GetValue(horario, null);
                        DateTime dt = DateTime.Parse(ot.ToString());
                        horaInicio = ot.ToString();
                        horaInicio = horaInicio.Substring(0, 5);
                    }
                    else if (prop.Name.Equals("hora_final")||prop.Name.Equals("hora_fin"))
                    {
                        Object ot = (Object)prop.GetValue(horario, null);
                        DateTime dt = DateTime.Parse(ot.ToString());
                        horaFin = ot.ToString();
                        horaFin = horaFin.Substring(0, 5);
                    }
                    else if (prop.Name.Equals("id"))
                    {
                        idHorario = (int)prop.GetValue(horario, null);
                    }
                    else if(prop.Name.Equals("id_dia_semana"))
                    {
                        m_diaSemana = (int)prop.GetValue(horario, null);
                    }
                        

                }

                PaintTime(datagrid,horaInicio, horaFin,columnName,color);

            }
        }
        private void GetVariables()
        {
            foreach (PropertyInfo prop in props)
            {
                if (prop.Name.Equals("nombre"))
                    textBoxNombreActividad.Text = (string)prop.GetValue(m_actividad, null);
                else if (prop.Name.Equals("tipo"))
                    textBoxTipo.Text = (string)prop.GetValue(m_actividad, null);
                else if (prop.Name.Equals("espacio"))
                    textBoxEspacio.Text = (string)prop.GetValue(m_actividad, null);
                else if (prop.Name.Equals("equipo"))
                    textBoxInstalacion.Text = (string)prop.GetValue(m_actividad, null);
                else if (prop.Name.Equals("id_espacio"))
                    m_idEspacio = (int)prop.GetValue(m_actividad, null);
                else if (prop.Name.Equals("id"))
                {
                    idAct = (int)prop.GetValue(m_actividad, null);
                }

            }
        }

        private void buttonConceder_Click(object sender, EventArgs e)
        {

        }

        private void ShowMessageBox(string mensaje)
        {
            if (!mensaje.Equals(""))
                MessageBox.Show(mensaje, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void PaintTime(DataGridView dataGrid,string horaInicio, string horaFin,string columnName,Color color)
        {
            int inicio = 0;
            int fin = 0;            

            foreach (DataGridViewRow row in dataGrid.Rows)
            {

                if (row.Cells[columnName].Value.ToString().Equals(horaInicio))
                    inicio = row.Index;
                else if (row.Cells[columnName].Value.ToString().Equals(horaFin))
                    fin = row.Index;
            }

            for (int i = inicio; i < fin + 1; i++)
            {
                dataGrid.Rows[i].Cells[m_diaSemana].Style.BackColor = color;
                dataGrid.Rows[i].Cells[m_diaSemana].Value = textBoxTipo.Text;
            }

        }


    }
}
