using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop.ORM
{
    public static class ORM
    {
        public static EntiEspaiEntities bd = new EntiEspaiEntities();


        public static String MensajeError(SqlException sqlEx)
        {
            String mensaje;
            switch (sqlEx.Number)
            {
                case -1:
                    mensaje = "Error de conexion con el servidor";
                    break;
                default:
                    mensaje = sqlEx.Number + " . " + sqlEx.Message;
                    break;
            }


            return mensaje;
        }
        public static void RejectChanges()
        {
            foreach (DbEntityEntry entry in bd.ChangeTracker.Entries())
            {
                switch (entry.State)
                {
                    case EntityState.Modified:
                        entry.State = EntityState.Unchanged;
                        break;
                    case EntityState.Added:
                        entry.State = EntityState.Detached;
                        break;
                    case EntityState.Deleted:
                        entry.Reload();
                        break;
                    default:
                        break;
                }
            }
        }
        public static String SaveChanges()
        {
            String mensaje = "";

            try
            {
                ORM.bd.SaveChanges();
            }
            catch (DbUpdateException e)
            {
                ORM.RejectChanges();
                SqlException exception = (SqlException)e.InnerException.InnerException;
                mensaje = ORM.MensajeError(exception);
            }

            return mensaje;
        }


    }
}
