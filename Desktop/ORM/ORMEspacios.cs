using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop.ORM
{
    class ORMEspacios
    {
        public static List<Espacio> SelectEspacios(ref String mensaje)
        {

            List<Espacio> equipos = null;
            try
            {

                var result = (from a in ORM.bd.Espacio
                              select a);

                IEnumerable<Espacio> i = result;
                equipos = i.ToList();

            }
            catch (DbUpdateException ex)
            {
                SqlException exception = (SqlException)ex.InnerException.InnerException;
                mensaje = ORM.MensajeError(exception);
            }


            return equipos;
        }
    }
}
