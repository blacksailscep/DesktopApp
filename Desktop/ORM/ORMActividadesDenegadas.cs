using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop.ORM
{
    class ORMActividadesDenegadas
    {
        public static List<Act_demandadas> SelectActDenegadas(ref String mensaje)
        {

            List<Act_demandadas> actividades = null;
            try
            {

                var result = (from a in ORM.bd.Act_demandadas
                              where a.asignada == "denegada"
                              select a);

                IEnumerable<Act_demandadas> i = result;
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
