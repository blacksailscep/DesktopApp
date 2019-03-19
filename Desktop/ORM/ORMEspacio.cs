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
        public static List<Espacio> SelectAllEspacios(int id_instalacion, ref String mensaje)
        {
            List<Espacio> espacios = null;
            try
            {
                espacios = (from espai in ORM.bd.Espacio
                                 orderby espai.nombre
                                 where espai.id_instalacion == id_instalacion
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
        public static Espacio SelectEspacioBynombre(int id_espacio, ref String mensaje)
        {

            Espacio Espacio = null;

            try
            {
                Espacio = (from espai in ORM.bd.Espacio
                           orderby espai.nombre
                            where espai.id==id_espacio
                            select espai).FirstOrDefault();

            }
            catch (DbUpdateException ex)
            {
                SqlException exception = (SqlException)ex.InnerException.InnerException;
                mensaje = ORM.MensajeError(exception);
            }


            return Espacio;

        }

        //Insert un horario de una instalación nuevo
        public static String InsertEspacio(Espacio espacio, ref String mensaje)
        {

            ORM.bd.Espacio.Add(espacio);

            mensaje = ORM.SaveChanges();

            return mensaje;
        }

        //Modificar un horario de una instalación nuevo
        public static String UpdateEspacio(Espacio espacio, ref String mensaje)
        {

            String mens = "";

            try
            {
                Espacio espai = new Espacio();

                espai = SelectEspacioBynombre(espacio.id, ref mens);

                if (string.IsNullOrEmpty(mens))
                {
                    mensaje = mens;
                }
                else
                {

                    espai.id_instalacion = espacio.id_instalacion;
                    espai.nombre = espacio.nombre;
                    espai.precio = espacio.precio;
                    espai.exterior = espacio.exterior;

                }

                mensaje = ORM.SaveChanges();
            }
            catch (DbUpdateException ex)
            {
                SqlException exception = (SqlException)ex.InnerException.InnerException;
                mensaje = ORM.MensajeError(exception);
            }

            return mensaje;
        }

        //Borrar horario de una instalación de la grid
        public static String DelelteEspacio(Espacio espacio, ref String mensaje)
        {

            ORM.bd.Espacio.Remove(espacio);

            mensaje = ORM.SaveChanges();

            return mensaje;
        }

    }
}
