using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop.ORM
{
    class ORMTipo_Act
    {
        public static List<Tipo_Act> SelectTipo_Act(ref String mensaje)
        {

            List<Tipo_Act> tipo = null;
            try
            {

                var result = (from a in ORM.bd.Tipo_Act
                              select a);

                IEnumerable<Tipo_Act> i = result;
                tipo = i.ToList();

            }
            catch (DbUpdateException ex)
            {
                SqlException exception = (SqlException)ex.InnerException.InnerException;
                mensaje = ORM.MensajeError(exception);
            }


            return tipo;
        }
    }
}
