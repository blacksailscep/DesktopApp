using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop.ORM
{
    public static class ORMInstalaciones
    {
        /*Método para seleccionar todas las instalaciones para la grid Instalaciones*/
        public static List<Object> SelectAllInstalaciones(ref String mensaje)
        {
            List<Object> instalaciones = null;
            try
            {
                var select = (from insta in ORM.bd.Instalacion
                              join tipoGes in ORM.bd.Tipo_gestion on insta.id_tipo_gestion equals tipoGes.id
                              select new
                              {
                                  id = insta.id,
                                  nombre = insta.nombre,
                                  direccion = insta.direccion,
                                  tipoGestion = tipoGes.nombre
                              });

                IEnumerable<Object> resultado = select;
                instalaciones = resultado.ToList();

            }
            catch (DbUpdateException ex)
            {
                SqlException exception = (SqlException)ex.InnerException.InnerException;
                mensaje = ORM.MensajeError(exception);
            }

            return instalaciones;
        }

        /*Método creado para el buscador: buscarinstalaciones*/
        public static List<Object> SelectInstalacionBynombre(String nombre, ref String mensaje)
        {

            List<Object> _Instalaciones = null;
            try
            {
                var select = (from insta in ORM.bd.Instalacion
                              orderby insta.nombre
                              join tipoGes in ORM.bd.Tipo_gestion on insta.id_tipo_gestion equals tipoGes.id
                              where insta.nombre.Contains(nombre)
                              select new
                              {
                                  id = insta.id,
                                  nombre = insta.nombre,
                                  direccion = insta.direccion,
                                  tipoGestion = tipoGes.nombre
                              });

                IEnumerable<Object> resultado = select;
                _Instalaciones = resultado.ToList();
            }
            catch (DbUpdateException ex)
            {
                SqlException exception = (SqlException)ex.InnerException.InnerException;
                mensaje = ORM.MensajeError(exception);
            }


            return _Instalaciones;

        }

        /*Método para seleccionar todas los tipos de gestión, ComboBox*/
        public static List<Tipo_gestion> SelectAllTipoGestion(ref String mensaje)
        {
            List<Tipo_gestion> tipoGestion = null;
            try
            {
                tipoGestion = (from tipoGest in ORM.bd.Tipo_gestion
                              select tipoGest).ToList();

            }
            catch (DbUpdateException ex)
            {
                SqlException exception = (SqlException)ex.InnerException.InnerException;
                mensaje = ORM.MensajeError(exception);
            }

            return tipoGestion;
        }

    }
}
