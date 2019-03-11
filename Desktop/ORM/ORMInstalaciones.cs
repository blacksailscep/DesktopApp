﻿using System;
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
        public static List<Instalacion> SelectAllInstalaciones(ref String mensaje)
        {
            List<Instalacion> instalaciones = null;
            try
            {
                instalaciones = (from insta in ORM.bd.Instalacion
                                 orderby insta.nombre
                                 select insta).ToList();

            }
            catch (DbUpdateException ex)
            {
                SqlException exception = (SqlException)ex.InnerException.InnerException;
                mensaje = ORM.MensajeError(exception);
            }

            return instalaciones;
        }

        /*Método creado para el buscador: buscarinstalaciones*/
        public static List<Instalacion> SelectInstalacionBynombre(String nombre, ref String mensaje)
        {

            List<Instalacion> _Instalaciones = null;
            try
            {
                _Instalaciones = (from insta in ORM.bd.Instalacion
                                  orderby insta.nombre
                                  where insta.nombre.Contains(nombre)
                                  select insta).ToList();
                               
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
