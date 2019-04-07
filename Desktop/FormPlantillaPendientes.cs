using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace Desktop
{


    public partial class FormPlantillaPendientes : Desktop.FormPlantilla
    {
        public class Fecha
        {
            public String hora;
            public int dia;
            public Fecha(String hora, int dia)
            {
                this.hora = hora;
                this.dia = dia;
            }

        }

        private Type myType;
        private IList<PropertyInfo> props;
        private int idAct,m_idEspacio;
        private int m_diaSemana, idHorario;
        private Object m_actividad;
        private bool m_flagConcedida;
        private List<Object> m_lstHorario,m_lstHorario2;
        private TimeSpan m_TimeSpan;
        private String mNomEquipo;
        private int count = 0;
        Act_demandadas act_demandada;

        public FormPlantillaPendientes(Object actividad)
        {
            InitializeComponent();


            new GenerarHorario(dataGridViewHorarioActividadesPedidas);
            new GenerarHorario(dataGridViewHorarioActAsignadas);


            m_actividad = actividad;
            myType = actividad.GetType();
            props = new List<PropertyInfo>(myType.GetProperties());
            GetVariables();

            string mensajeError = "";
            m_lstHorario =
                ORM.ORMAcividadesPendientes.SelectHorarioActividadPendientes(ref mensajeError, idAct);
            if (!mensajeError.Equals(""))
                MessageBox.Show(mensajeError, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            GetScheduleActivity(m_lstHorario, idAct, dataGridViewHorarioActividadesPedidas, "Horas",Color.Orange);

            m_lstHorario2 =
                ORM.ORMActividadesConcedidas.SelectActividadPorEspacio(ref mensajeError, m_idEspacio);
            if (!mensajeError.Equals(""))
                MessageBox.Show(mensajeError, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            GetScheduleActivity(m_lstHorario2, idAct,dataGridViewHorarioActAsignadas,"Hora",Color.YellowGreen);
            

            foreach (Label label in GetLabels())
            {
                label.Visible = false;
                label.Enabled = false;
            }


        }
        private void buttonConceder_Click(object sender, EventArgs e)
        {
            if (!m_flagConcedida)
            {
                TimeSpan prob = m_TimeSpan;                

                if (prob.ToString().Equals(textBoxDuracion.Text))
                {
                    string mensaje = "";

                    act_demandada = ORM.ORMAcividadesPendientes.SelectActvPendiente(ref mensaje, idAct);

                    act_demandada.asignada = "aceptada";
                    Act_concedida act_concedida = new Act_concedida();
                    act_concedida.nombre = act_demandada.nombre;
                    act_concedida.id_equipo = (int)act_demandada.id_equipo;
                    act_concedida.id_tipo = (int)act_demandada.id_tipo;
                    act_concedida.id_espacio = (int)act_demandada.id_espacio;
                    act_concedida.id_act_demandadas = act_demandada.id;

                    ORM.ORMActividadesConcedidas.SaveActividadConcedida(act_concedida);
                    mensaje = ORM.ORMAcividadesPendientes.ModificarActividadPendiente(act_demandada);

                    List<int> lstDiasSemana = ValuesInSelectedActivity(dataGridViewHorarioActAsignadas);
                    List<Fecha> lstFechas = new List<Fecha>();

                    foreach (DataGridViewCell data in dataGridViewHorarioActAsignadas.SelectedCells)
                    {                            
                       String value = dataGridViewHorarioActAsignadas.Rows[data.RowIndex].Cells[0].Value.ToString();
                       Fecha hora = new Fecha(value, data.ColumnIndex);
                       lstFechas.Add(hora);
                    }
                    foreach(Fecha hora in lstFechas)
                    {
                        TimeSpan horaInicio = TimeSpan.Parse(hora.hora);
                        TimeSpan horaFin = TimeSpan.Parse(hora.hora);
                        horaFin += TimeSpan.FromMinutes(15);
                        Horario_Act_Con horario_Act_concedida = new Horario_Act_Con();
                        horario_Act_concedida.id_act_concedida = act_concedida.id;
                        horario_Act_concedida.id_dia_semana =hora.dia;
                        horario_Act_concedida.hora_inicio = horaInicio;
                        horario_Act_concedida.hora_fin = horaFin;
                        ORM.ORMHorarioActConcedida.SaveHorarioActConcedida(horario_Act_concedida);
                    }

                    m_flagConcedida = true;
                    

                    if (!mensaje.Equals(""))
                         MessageBox.Show(mensaje, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        GetScheduleActivity(m_lstHorario, act_demandada.id, dataGridViewHorarioActividadesPedidas, "Horas", Color.White);

                    buttonCancelar.Enabled = false;

                }
                else
                {
                    MessageBox.Show("La duraccion asignada no es la misma que la demandada", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("La actividad ya ha sido asignada", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private List<int> ValuesInSelectedActivity(DataGridView dataGridViewHorarioActAsignadas)
        {
            List<int> lstDiasSemana = new List<int>();
            lstDiasSemana.Add(dataGridViewHorarioActAsignadas.SelectedCells[0].ColumnIndex);


            foreach (DataGridViewCell c in dataGridViewHorarioActAsignadas.SelectedCells)
            {
                
                c.Value = textBoxEquipo.Text;
                c.Style.BackColor = Color.YellowGreen;
                bool findit = false;
                foreach(int index in lstDiasSemana)
                {
                    if (index.Equals(c.ColumnIndex))
                        findit = true;
                }
                if(!findit)
                    lstDiasSemana.Add(c.ColumnIndex);
            }
            return lstDiasSemana;
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
                    else if (prop.Name.Equals("equipo"))
                        mNomEquipo = (string)prop.GetValue(horario, null);

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
                    textBoxEquipo.Text = (string)prop.GetValue(m_actividad, null);
                else if (prop.Name.Equals("id_espacio"))
                    m_idEspacio = (int)prop.GetValue(m_actividad, null);
                else if(prop.Name.Equals("instalacion"))
                    textBoxInstalacion.Text = (string)prop.GetValue(m_actividad, null);
                else if(prop.Name.Equals("duracion"))
                {
                    var c = prop.GetValue(m_actividad, null);
                    textBoxDuracion.Text = c.ToString();   
                }                    
                else if (prop.Name.Equals("id"))
                {
                    idAct = (int)prop.GetValue(m_actividad, null);
                }

            }
        }

        private void dataGridViewHorarioActividadesPedidas_SelectionChanged(object sender, EventArgs e)
        {
           dataGridViewHorarioActividadesPedidas.ClearSelection();
        }
        private void dataGridViewHorarioActAsignadas_SelectionChanged(object sender, EventArgs e)
        {
            //dataGridViewHorarioActAsignadas.ClearSelection();
        }        
        private void dataGridViewHorarioActividadesPedidas_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {            
                
            //MakeBubble(dataGridViewHorarioActividadesPedidas,e, Color.Orange);
        
        }
        public void MakeBubble(DataGridView data ,DataGridViewCellPaintingEventArgs e,Color color)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (data.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor.Name == color.Name)
                {
                    using (Pen pen = new Pen(color))
                    {

                        e.Paint(e.CellBounds, DataGridViewPaintParts.All & ~DataGridViewPaintParts.Border);
                        using (Pen p = new Pen(color, 5))
                        {
                            Rectangle rect = e.CellBounds;
                            rect.Width -= 2;
                            rect.Height -= 2;
                            e.Graphics.DrawRectangle(p, rect);
                        }
                        e.Handled = true;
                    }
                }
                
            }
        }
        private void dataGridViewHorarioActAsignadas_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            MakeBubble(dataGridViewHorarioActAsignadas, e, Color.Orange);

            if (!m_flagConcedida)
            { 
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    if (dataGridViewHorarioActAsignadas.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected == true &&
                        dataGridViewHorarioActAsignadas.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null)
                    {

                        e.Paint(e.CellBounds, DataGridViewPaintParts.All & ~DataGridViewPaintParts.Border);
                        using (Pen p = new Pen(Color.Orange, 1))
                        {
                            Rectangle rect = e.CellBounds;
                            rect.Width -= 2;
                            rect.Height -= 2;
                            e.Graphics.DrawRectangle(p, rect);
                        }
                        e.Handled = true;

                        if (m_TimeSpan.ToString().Equals(textBoxDuracion.Text))
                            textBoxAsignadas.BackColor = Color.YellowGreen;
                        else
                            textBoxAsignadas.BackColor = Color.Red;

                    }
                    else if(dataGridViewHorarioActAsignadas.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected == true &&
                        dataGridViewHorarioActAsignadas.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                    {
                        dataGridViewHorarioActAsignadas.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
                    }
                    else
                    {
                        int num = dataGridViewHorarioActAsignadas.SelectedCells.Count;
                        m_TimeSpan = TimeSpan.FromMinutes(num * 15);
                        textBoxAsignadas.Text = m_TimeSpan.ToString();
                    }
                        
                }

            }
            else
            {
                dataGridViewHorarioActAsignadas.ClearSelection();        
            }
              
            if(count==0)
            {
                dataGridViewHorarioActAsignadas.ClearSelection();
                count = 1;
            }

        }

        private void dataGridViewHorarioActAsignadas_MouseUp(object sender, MouseEventArgs e)
        {
            if (m_TimeSpan.ToString().Equals(textBoxDuracion.Text))
                textBoxAsignadas.BackColor = Color.YellowGreen;
            else
                textBoxAsignadas.BackColor = Color.Red;
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            String mensaje = "";
            act_demandada = ORM.ORMAcividadesPendientes.SelectActvPendiente(ref mensaje, idAct);
            act_demandada.asignada = "denegada";
            mensaje = ORM.ORMAcividadesPendientes.ModificarActividadPendiente(act_demandada);
            if (!mensaje.Equals(""))
                MessageBox.Show(mensaje, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                dataGrid.Rows[i].Cells[m_diaSemana].Style.BackColor = color;

                if (color.Name != Color.White.Name)
                {
                    dataGrid.Rows[i].Cells[m_diaSemana].Value = mNomEquipo;
                }
                else
                {
                    dataGrid.Rows[i].Cells[m_diaSemana].Value = null;            
                }

            }        
            
        }

    }
}
