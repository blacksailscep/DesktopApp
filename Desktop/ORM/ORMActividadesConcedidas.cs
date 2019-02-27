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
        public static List<Act_concedida> SelectActvConcedidas(ref String mensaje)
        {
            List<Act_concedida> lstActividades = null;

            try
            {
                lstActividades =
                (
                    from p in ORM.bd.Act_concedida
                    orderby p.nombre
                    select p
                ).ToList();
            }
            catch (DbUpdateException ex)
            {
                SqlException exception = (SqlException)ex.InnerException.InnerException;
                mensaje = ORM.MensajeError(exception);
            }


            return lstActividades;
        }
    }
}
