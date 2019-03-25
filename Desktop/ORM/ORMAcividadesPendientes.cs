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
        /*enum Estados
        {
            Asignada, Pendiente, Denegada
        }

        Estados e = Estados.Asignada;*/
        
        public static List<Object> SelectHorarioActividadPendientes(ref String mensaje, int idActCon)
        {
            List<Object> horarios = null;
            try
            {

                var result = (
                              from a in ORM.bd.Horario_Act_Dem                              
                              join b in ORM.bd.Dias_Semana on a.id_dia_semana equals b.id
                              join c in ORM.bd.Act_demandadas on a.id_Act_Demandada equals c.id
                              join e in ORM.bd.Equipo on c.id_equipo equals e.id
                              where c.id == idActCon
                              select new
                              {
                                  b.id,
                                  a.hora_inicio,
                                  a.hora_final,
                                  a.id_dia_semana,
                                  equipo = e.nombre
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
        public static List<Object> SelectVistaActvPendientes(ref String mensaje)
        {

            List<Object> actividades = null;
            try
            {

                var result = (from a in ORM.bd.Act_demandadas
                              join b in ORM.bd.Tipo_Act on a.id_tipo equals b.id
                              join e in ORM.bd.Espacio on a.id_espacio equals e.id
                              join eq in ORM.bd.Equipo on a.id_equipo equals eq.id
                              join c in ORM.bd.Sexo on eq.id_sexo equals c.id
                              join f in ORM.bd.Instalacion on e.id_instalacion equals f.id
                              where a.asignada == "pendiente"
                              select new
                              {
                                  duracion = a.durada,
                                  nombre = a.nombre,
                                  tipo = b.nombre,
                                  espacio = e.nombre,
                                  id_espacio = e.id,
                                  equipo = eq.nombre,
                                  id = a.id,
                                  sexo = c.nombre,
                                  instalacion = f.nombre
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
        public static Act_demandadas SelectActvPendiente(ref string mensaje,int idActPendiente)
        {
            Act_demandadas act = null;

            var result = (from a in ORM.bd.Act_demandadas
                          where a.id == idActPendiente
                          select a);
            act = result.FirstOrDefault<Act_demandadas>();

            return act;
        }
        public static Horario_Act_Dem GetHorario(ref string mensaje, int idActPendiente)
        {
            Horario_Act_Dem act = null;

            var result = (from a in ORM.bd.Horario_Act_Dem
                          where a.id_Act_Demandada == idActPendiente
                          select a);

            act = result.FirstOrDefault<Horario_Act_Dem>();

            return act;
        }
        public static string ModificarActividadPendiente(Act_demandadas actividad)
        {
            string mensaje= "";
            ORM.bd.SaveChanges();
            return mensaje;
        }
    }
}
