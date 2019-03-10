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
        private bool m_flagCoincide,m_flagConcedida;
        private List<Object> m_lstHorario,m_lstHorario2;

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
            m_lstHorario =
                ORM.ORMAcividadesPendientes.SelectHorarioActividadPendientes(ref mensajeError, idAct);
            if (!mensajeError.Equals(""))
                MessageBox.Show(mensajeError, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            GetScheduleActivity(m_lstHorario, idAct, dataGridViewHorarioActividadesPedidas, "Horas",Color.YellowGreen);

            m_lstHorario2 =
                ORM.ORMActividadesConcedidas.SelectActividadPorEspacio(ref mensajeError, m_idEspacio);
            if (!mensajeError.Equals(""))
                MessageBox.Show(mensajeError, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            GetScheduleActivity(m_lstHorario2, idAct,dataGridViewHorarioActAsignadas,"Hora",Color.Red);
            

            foreach (Label label in GetLabels())
            {
                label.Visible = false;
            }

        }
        private void buttonConceder_Click(object sender, EventArgs e)
        {
            GetScheduleActivity(m_lstHorario, idAct, dataGridViewHorarioActAsignadas, "Hora", Color.Red);
            if(m_flagCoincide)
            {
                if(!m_flagConcedida)
                    MessageBox.Show("La actividad que estas intentando aceptar en ese horario ya tiene otra actividad asignada", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("La actividad ya ha sido concedida", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string mensaje = "";
                Act_demandadas act_demandada = ORM.ORMAcividadesPendientes.SelectActvPendiente(ref mensaje,idAct);

                act_demandada.asignada = true;

                Act_concedida act_concedida = new Act_concedida();
                act_concedida.nombre = act_demandada.nombre;
                act_concedida.id_equipo = act_demandada.id_equipo;
                act_concedida.id_tipo = act_demandada.id_tipo;
                act_concedida.id_espacio = act_demandada.id_espacio;
                act_concedida.id_act_demandadas = act_demandada.id;

                ORM.ORMActividadesConcedidas.SaveActividadConcedida(act_concedida);

                mensaje = ORM.ORMAcividadesPendientes.ModificarActividadPendiente(act_demandada);

                Horario_Act_Dem horario_Act_demandada = ORM.ORMAcividadesPendientes.GetHorario(ref mensaje, idAct);
                Horario_Act_Con horario_Act_concedida = new Horario_Act_Con();
                horario_Act_concedida.id_act_concedida = act_concedida.id;
                horario_Act_concedida.id_dia_semana = horario_Act_demandada.id_dia_semana;
                horario_Act_concedida.hora_inicio = horario_Act_demandada.hora_inicio;
                horario_Act_concedida.hora_fin = horario_Act_demandada.hora_final;
                ORM.ORMHorarioActConcedida.SaveHorarioActConcedida(horario_Act_concedida);

                if (!mensaje.Equals(""))
                    MessageBox.Show(mensaje, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

       
                GetScheduleActivity(m_lstHorario2, act_concedida.id, dataGridViewHorarioActAsignadas, "Hora", Color.Red);
                GetScheduleActivity(m_lstHorario, act_demandada.id, dataGridViewHorarioActividadesPedidas, "Horas", Color.White);

                buttonCancelar.Enabled = false;
                m_flagConcedida = true;

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
        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ShowMessageBox(string mensaje)
        {
            if (!mensaje.Equals(""))
                MessageBox.Show(mensaje, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void PaintTime(DataGridView dataGrid, string horaInicio, string horaFin, string columnName, Color color)
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

                if (dataGrid.Rows[i].Cells[m_diaSemana].Value != null)
                    m_flagCoincide = true;
            }

            for (int i = inicio; i < fin + 1; i++)
            {
                dataGrid.Rows[i].Cells[m_diaSemana].Style.BackColor = color;
                if (color.Name != Color.White.Name)
                {
                    dataGrid.Rows[i].Cells[m_diaSemana].Value = textBoxTipo.Text;
                }
                else
                {
                    dataGrid.Rows[i].Cells[m_diaSemana].Value = null;                    
                }                
                                           
            }
        
            
        }


    }
}
