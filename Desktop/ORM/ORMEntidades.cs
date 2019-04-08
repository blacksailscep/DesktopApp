using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop.ORM
{
    class ORMEntidades
    {
        public static List<Object> SelectEntidades(ref String mensaje, int temporada)
        {

            List<Object> entidades = null;
            try
            {

                var result = (from a in ORM.bd.Entidad
                              where a.temporada == temporada
                              select a);

                IEnumerable<Object> i = result;
                entidades = i.ToList();

            }
            catch (DbUpdateException ex)
            {
                SqlException exception = (SqlException)ex.InnerException.InnerException;
                mensaje = ORM.MensajeError(exception);
            }


            return entidades;
        }
        public static List<Object> SelectEntidadesByNombre(ref String mensaje, String nombre, int temporada)
        {

            List<Object> entidades = null;
            try
            {

                var result = (from a in ORM.bd.Entidad
                              where a.nombre.Contains(nombre)
                              where a.temporada == temporada
                              orderby a.nombre
                              select a);

                IEnumerable<Object> i = result;
                entidades = i.ToList();

            }
            catch (DbUpdateException ex)
            {
                SqlException exception = (SqlException)ex.InnerException.InnerException;
                mensaje = ORM.MensajeError(exception);
            }


            return entidades;
        }

        public static void UpdateEntidad(int id, String nombre, String direccion, int temporada)
        {
            Entidad ent = ORM.bd.Entidad.Find(id);

            ent.nombre = nombre;
            ent.direccion = direccion;
            ent.temporada = temporada;

            ORM.bd.SaveChanges();
        }
    }
}
