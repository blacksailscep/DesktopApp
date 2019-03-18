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
        public static Instalacion_Horario SelectUnHorarioInsta(Instalacion_Horario insta, ref String mensaje)
        {
           Instalacion_Horario diasSemana = null;
            try
            {
                diasSemana = (from Instalacion_Horario in ORM.bd.Instalacion_Horario
                              orderby Instalacion_Horario.id_dia_semana
                              where Instalacion_Horario.id_instalacion == insta.id_instalacion && Instalacion_Horario.id_dia_semana == insta.id_dia_semana && Instalacion_Horario.hora_inicio == insta.hora_inicio
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
        public static String InsertHorariInstalacio(Instalacion_Horario hInsta, ref String mensaje)
        {

            ORM.bd.Instalacion_Horario.Add(hInsta);

            mensaje = ORM.SaveChanges();

            return mensaje;
        }

        //Modificar un horario de una instalación nuevo
        public static String UpdateHorariInstalacio(Instalacion_Horario hInsta, ref String mensaje)
        {
            
            String mens = "";

            try
            {
                Instalacion_Horario hI = new Instalacion_Horario();

                hI = SelectUnHorarioInsta(hInsta, ref mens);

                if (string.IsNullOrEmpty(mens))
                {
                    mensaje = mens;
                }
                else
                {

                    hI.id_instalacion = hInsta.id_instalacion;
                    hI.id_dia_semana = hInsta.id_dia_semana;
                    hI.hora_inicio = hInsta.hora_inicio;
                    hI.hora_final = hInsta.hora_final;

                }

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
        public static String DelelteHorariInsta(Instalacion_Horario hI, ref String mensaje)
        {

            ORM.bd.Instalacion_Horario.Remove(hI);

            mensaje = ORM.SaveChanges();

            return mensaje;
        }
    }
}
