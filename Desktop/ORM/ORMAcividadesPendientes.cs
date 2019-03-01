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
        public static List<Object> SelectActvPendientes(ref String mensaje)
        {

            List<Object> actividades = null;
            try
            {

                var result = (from a in ORM.bd.Act_demandadas
                              join b in ORM.bd.Tipo_Act on a.id_tipo equals b.id
                              join e in ORM.bd.Espacio on a.id_espacio equals e.id
                              join eq in ORM.bd.Equipo on a.id_equipo equals eq.id
                              select new
                              {
                                  nombre = a.nombre,
                                  tipo = b.nombre,
                                  espacio = e.nombre,
                                  equipo = eq.nombre
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
