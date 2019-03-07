using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop.ORM
{
    class ORMActividadesConcedidas
    {
        public static List<Object> SelectActividadPorEspacio(ref string mensaje,int idEspacio)
        {
            List<Object> actividades = null;

            try
            {

                var result = (
                              from a in ORM.bd.Act_concedida                              
                              join b in ORM.bd.Espacio on a.id_espacio equals b.id                              
                              join d in ORM.bd.Horario_Act_Con on a.id equals d.id_act_concedida
 
                              where b.id == idEspacio
                              select new
                              {
                                  b.id,
                                  d.hora_inicio,
                                  d.hora_fin,
                                  d.id_dia_semana,
       
                              });

                IEnumerable<Object> i = result;
                actividades = i.ToList();

            }
            catch (DbUpdateException ex)
            {
                SqlException exception = (SqlException)ex.InnerException.InnerException;
                mensaje = ORM.MensajeError(exception);
            }



            return actividades;

        }
        public static List<Object> SelectHorarioActividadConcedida(ref String mensaje,int idActCon)
        {
            List<Object> horarios = null;
            try
            {

                var result = (
                              from a in ORM.bd.Horario_Act_Con

                              join b in ORM.bd.Dias_Semana on a.id_dia_semana equals b.id
                              join c in ORM.bd.Act_concedida on a.id_act_concedida equals c.id
                              where c.id == idActCon
                              select new
                              {
                                  b.id,
                                  a.hora_inicio,
                                  a.hora_fin,
                                  a.id_dia_semana
                              });

                IEnumerable<Object> i = result;
                horarios = i.ToList();

            }
            catch (DbUpdateException ex)
            {
                SqlException exception = (SqlException)ex.InnerException.InnerException;
                mensaje = ORM.MensajeError(exception);
            }

            return horarios;

        }
        public static List<Object> SelectActvConcedidas(ref String mensaje)
        {
            List<Object> actividades = null;
            try
            {

                var result =(from a in ORM.bd.Act_concedida
                                 join b in ORM.bd.Tipo_Act on a.id_tipo equals b.id
                                 join e in ORM.bd.Espacio on a.id_espacio equals e.id
                                 join eq in ORM.bd.Equipo on a.id_equipo equals eq.id
                                 join c in ORM.bd.Equipo on a.id_equipo equals c.id
                                 join f in ORM.bd.Sexo on c.id_sexo equals f.id
                             select new
                                 {
                                     id = a.id,
                                     nombre = a.nombre,
                                     tipo = b.nombre,
                                     espacio = e.nombre,
                                     equipo = eq.nombre,
                                     Sexo = f.nombre
                                 });

                IEnumerable<Object> i = result;
                actividades = i.ToList();
                
            }
            catch (DbUpdateException ex)
            {
                SqlException exception = (SqlException)ex.InnerException.InnerException;
                mensaje = ORM.MensajeError(exception);
            }


            return actividades;
        }
    }
}
