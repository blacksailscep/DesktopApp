using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop
{
    public partial class ActividadesAceptadas : Form
    {
        private Type myType;
        private IList<PropertyInfo> props;
        private int idAct;
        private int idHorario;

        public ActividadesAceptadas(Object actividad)
        {
            InitializeComponent();

            

            myType = actividad.GetType();
            props = new List<PropertyInfo>(myType.GetProperties());

            FillTextBox(actividad);
            FillTimeDataGridView();

            GetScheduleActivity(actividad);

            

        }

        private void GetScheduleActivity(Object actividad)
        {
            string mensajeError = "";
            List<Object> lstHorario =
                ORM.ORMActividadesConcedidas.SelectHorarioActividadConcedida(ref mensajeError, idAct);
            if (!mensajeError.Equals(""))
                MessageBox.Show(mensajeError, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

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

            for(int i=inicio;i<fin+1;i++)
            {
                dataGridViewHorarioActividadesAceptadas.Rows[i].Cells[idHorario].Style.BackColor = Color.GreenYellow;
                dataGridViewHorarioActividadesAceptadas.Rows[i].Cells[idHorario].Value =
                    textBoxTipo.Text;
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
                    textBoxInstalacion.Text = (string)prop.GetValue(vistaActividad, null);
                else if (prop.Name.Equals("equipo"))
                    textBoxEspacio.Text = (string)prop.GetValue(vistaActividad, null);
                else
                {
                    idAct = (int)prop.GetValue(vistaActividad, null);
                }                    

            }
        }
        public void FillTimeDataGridView()
        {
            int a = 0;
            int i = 9;
            while(i<21)
            {
                string hora = "";

                a += 15;

                if (a == 60)
                {
                    i++;
                    a = 0;
                    hora = i + ":" + a + "0";
                    if (i < 10)
                        hora = "0" + hora;
                    dataGridViewHorarioActividadesAceptadas.Rows.Add(hora);
                }
                else
                {
                    hora = i + ":" + a;
                    if (i < 10)
                        hora = "0" + hora;
                    dataGridViewHorarioActividadesAceptadas.Rows.Add(hora);
                }

                                
            }      
            
        }
    }
}
