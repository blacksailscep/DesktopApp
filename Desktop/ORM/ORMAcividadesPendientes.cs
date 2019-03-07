using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop.ORM
{
    class ORMAcividadesPendientes
    {
        public static List<Object> SelectHorarioActividadPendientes(ref String mensaje, int idActCon)
        {
            List<Object> horarios = null;
            try
            {

                var result = (
                              from a in ORM.bd.Horario_Act_Dem

                              join b in ORM.bd.Dias_Semana on a.id_dia_semana equals b.id
                              join c in ORM.bd.Act_demandadas on a.id_Act_Demandada equals c.id
                              where c.id == idActCon
                              select new
                              {
                                  b.id,
                                  a.hora_inicio,
                                  a.hora_final,
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
        public static List<Object> SelectActvPendientes(ref String mensaje)
        {

            List<Object> actividades = null;
            try
            {

                var result = (from a in ORM.bd.Act_demandadas
                              join b in ORM.bd.Tipo_Act on a.id_tipo equals b.id
                              join e in ORM.bd.Espacio on a.id_espacio equals e.id
                              join eq in ORM.bd.Equipo on a.id_equipo equals eq.id
                              join c in ORM.bd.Sexo on eq.id_sexo equals c.id
                              where a.asignada==false
                              select new
                              {
                                  nombre = a.nombre,
                                  tipo = b.nombre,
                                  espacio = e.nombre,
                                  id_espacio = e.id,
                                  equipo = eq.nombre,
                                  id = a.id,
                                  sexo = c.nombre
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
