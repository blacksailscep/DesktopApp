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
    public partial class FormPlantillaAct_Aceptadas : Desktop.FormPlantilla
    {
        private Type myType;
        private IList<PropertyInfo> props;
        private int idAct;
        private int idHorario;
        private string  tipo,  espacio;
        private Object m_actividad;

        public FormPlantillaAct_Aceptadas(Object actividad)
        {
            InitializeComponent();

            m_actividad = actividad;
            myType = actividad.GetType();
            props = new List<PropertyInfo>(myType.GetProperties());
            GetVariables();

            new GenerarHorario(dataGridViewHorarioActividadesAceptadas);

            string mensajeError = "";
            List<Object> lstHorario =
                ORM.ORMActividadesConcedidas.SelectHorarioActividadConcedida(ref mensajeError, idAct);
            if (!mensajeError.Equals(""))
                MessageBox.Show(mensajeError, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            GetScheduleActivity(lstHorario, idAct);

            foreach (Label label in GetLabels())
            {
                label.Visible = false;
            }
        }
        private void GetVariables()
        {
            foreach (PropertyInfo prop in props)
            {
                if (prop.Name.Equals("nombre"))
                    textBoxNombre.Text = (string)prop.GetValue(m_actividad, null);
                else if (prop.Name.Equals("tipo"))
                    textBoxTipo.Text = (string)prop.GetValue(m_actividad, null);
                else if (prop.Name.Equals("espacio"))
                    textBoxEspacio.Text = (string)prop.GetValue(m_actividad, null);
                else if (prop.Name.Equals("equipo"))
                    textBoxEquipo.Text = (string)prop.GetValue(m_actividad, null);
                else if(prop.Name.Equals("id"))
                {
                    idAct = (int)prop.GetValue(m_actividad, null);
                }

            }
        }

        private void dataGridViewHorarioActividadesAceptadas_SelectionChanged(object sender, EventArgs e)
        {
            dataGridViewHorarioActividadesAceptadas.ClearSelection();
        }

        private void dataGridViewHorarioActividadesAceptadas_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (dataGridViewHorarioActividadesAceptadas.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor.Name == Color.YellowGreen.Name)
                {
                    using (Pen pen = new Pen(Color.YellowGreen))
                    {

                        e.Paint(e.CellBounds, DataGridViewPaintParts.All & ~DataGridViewPaintParts.Border);
                        using (Pen p = new Pen(Color.YellowGreen, 5))
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

        public void GetScheduleActivity(List<Object> lstHorario, int idAct)
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
                    else if (prop.Name.Equals("tipo"))
                    {
                        Object ot = (Object)prop.GetValue(horario, null);
                        tipo = ot.ToString();
                    }
                    else if (prop.Name.Equals("hora_fin"))
                    {
                        Object ot = (Object)prop.GetValue(horario, null);
                        DateTime dt = DateTime.Parse(ot.ToString());
                        horaFin = ot.ToString();
                        horaFin = horaFin.Substring(0, 5);
                    }
                    else if (prop.Name.Equals("id"))
                        idHorario = (int)prop.GetValue(horario, null);

                }

                PaintTime(horaInicio, horaFin);

            }
        }

        private void PaintTime(string horaInicio, string horaFin)
        {
            int inicio = 0;
            int fin = 0;

            foreach (DataGridViewRow row in dataGridViewHorarioActividadesAceptadas.Rows)
            {

                if (row.Cells["Horas"].Value.ToString().Equals(horaInicio))
                    inicio = row.Index;
                else if (row.Cells["Horas"].Value.ToString().Equals(horaFin))
                    fin = row.Index;
            }

            //if (fin < inicio)
            //{
                
            //    dataGridViewHorarioActividadesAceptadas.Rows[1].Cells[idHorario].Style.BackColor = Color.YellowGreen;
            //    dataGridViewHorarioActividadesAceptadas.Rows[1].Cells[idHorario].Value =
            //        textBoxEquipo.Text;
            //}
            //else
                for (int i = inicio; i < fin ; i++)
                {
                    dataGridViewHorarioActividadesAceptadas.Rows[i].Cells[idHorario].Style.BackColor = Color.YellowGreen;
                    dataGridViewHorarioActividadesAceptadas.Rows[i].Cells[idHorario].Value =
                        textBoxEquipo.Text;
                }


        }
        private void FillTextBox(object vistaActividad)
        {
            foreach (PropertyInfo prop in props)
            {
                if (prop.Name.Equals("nombre"))
                    textBoxNombre.Text = (string)prop.GetValue(vistaActividad, null);
                else if (prop.Name.Equals("tipo"))
                    textBoxTipo.Text = (string)prop.GetValue(vistaActividad, null);
                else if (prop.Name.Equals("espacio"))
                    textBoxEspacio.Text = (string)prop.GetValue(vistaActividad, null);
                else if (prop.Name.Equals("equipo"))
                    textBoxEquipo.Text = (string)prop.GetValue(vistaActividad, null);
                else
                {
                    idAct = (int)prop.GetValue(vistaActividad, null);
                }

            }
        }
        
    }
}
