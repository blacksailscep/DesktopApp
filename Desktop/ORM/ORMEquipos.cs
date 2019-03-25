using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop.ORM
{
    class ORMEquipos
    {
        public static List<Equipo> SelectEquipos(ref String mensaje)
        {

            List<Equipo> equipos = null;
            try
            {

                var result = (from a in ORM.bd.Equipo
                              select a);

                IEnumerable<Equipo> i = result;
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

