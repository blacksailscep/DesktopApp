using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop.ORM
{
    public static class ORMEspacio
    {
        /*Método para seleccionar todas las instalaciones para la grid Instalaciones*/
        public static List<Espacio> SelectAllEspacios(ref String mensaje)
        {
            List<Espacio> espacios = null;
            try
            {
                espacios = (from espai in ORM.bd.Espacio
                                 orderby espai.nombre
                                 select espai).ToList();

            }
            catch (DbUpdateException ex)
            {
                SqlException exception = (SqlException)ex.InnerException.InnerException;
                mensaje = ORM.MensajeError(exception);
            }

            return espacios;
        }

        /*buscar un espaciopor el nombre*/
        public static Espacio SelectInstalacionBynombre(String nombre, ref String mensaje)
        {

            Espacio Espacio = null;

            try
            {
                Espacio = (from espai in ORM.bd.Espacio
                           orderby espai.nombre
                            where espai.nombre.Contains(nombre)
                            select espai).FirstOrDefault();

            }
            catch (DbUpdateException ex)
            {
                SqlException exception = (SqlException)ex.InnerException.InnerException;
                mensaje = ORM.MensajeError(exception);
            }


            return Espacio;

        }
    }
}
