using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop.ORM
{
    public static class ORMHorari_Instalacion
    {
        /*Método para seleccionar todas los tipos de gestión, ComboBox*/
        public static List<Instalacion_Horario> SelectAllHorarioInstalacion(int id_instalacion, ref String mensaje)
        {
            List<Instalacion_Horario> diasSemana = null;
            try
            {
                diasSemana = (from Instalacion_Horario in ORM.bd.Instalacion_Horario
                              orderby Instalacion_Horario.id_dia_semana
                              where Instalacion_Horario.id_instalacion == id_instalacion
                              select Instalacion_Horario).ToList();

            }
            catch (DbUpdateException ex)
            {
                SqlException exception = (SqlException)ex.InnerException.InnerException;
                mensaje = ORM.MensajeError(exception);
            }

            return diasSemana;
        }


        //Seleccionar un horari en concret
        public static Instalacion_Horario SelectUnHorarioInsta(int id_Insta, int diaSem, TimeSpan hIn, ref String mensaje)
        {
           Instalacion_Horario diasSemana = null;
            try
            {
                diasSemana = (from Instalacion_Horario in ORM.bd.Instalacion_Horario
                              orderby Instalacion_Horario.id_dia_semana
                              where Instalacion_Horario.id_instalacion == id_Insta && Instalacion_Horario.id_dia_semana == diaSem && Instalacion_Horario.hora_inicio == hIn
                              select Instalacion_Horario).FirstOrDefault();

            }
            catch (DbUpdateException ex)
            {
                SqlException exception = (SqlException)ex.InnerException.InnerException;
                mensaje = ORM.MensajeError(exception);
            }

            return diasSemana;
        }

        //Insert un horario de una instalación nuevo
        public static String InsertHorariInstalacio(Instalacion_Horario hInsta)
        {
            String mensaje = "";

            ORM.bd.Instalacion_Horario.Add(hInsta);

            mensaje = ORM.SaveChanges();

            return mensaje;
        }

        //Modificar un horario de una instalación nuevo
        public static String UpdateHorariInstalacio(int id_Insta, int diaSem, TimeSpan hIn, Instalacion_Horario hInsta)
        {
            String mensaje = "";

            try
            {
                Instalacion_Horario hI = new Instalacion_Horario();
                hI = ORM.bd.Instalacion_Horario.Find(id_Insta, diaSem, hIn);
               
                hI.hora_final = hInsta.hora_final;
               
                mensaje = ORM.SaveChanges();
            }
            catch (DbUpdateException ex)
            {
                SqlException exception = (SqlException)ex.InnerException.InnerException;
                mensaje = ORM.MensajeError(exception);
            }

            return mensaje;
        }

        //Borrar horario de una instalación de la grid
        public static String DelelteHorariInsta(Instalacion_Horario hI)
        {
            String mensaje = "";
            ORM.bd.Instalacion_Horario.Remove(hI);

            mensaje = ORM.SaveChanges();

            return mensaje;
        }
    }
}
