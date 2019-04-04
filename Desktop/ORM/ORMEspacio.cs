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

            Espacio Espaci = null;

            try
            {
                Espaci = (from espai in ORM.bd.Espacio
                           orderby espai.nombre
                            where espai.id==id_espacio
                            select espai).FirstOrDefault();

            }
            catch (DbUpdateException ex)
            {
                SqlException exception = (SqlException)ex.InnerException.InnerException;
                mensaje = ORM.MensajeError(exception);
            }


            return Espaci;

        }

        //Insert un horario de una instalación nuevo
        public static String InsertEspacio(Espacio espaci)
        {
            String mensaje = "";

            ORM.bd.Espacio.Add(espaci);

            mensaje = ORM.SaveChanges();

            return mensaje;
        }

        //Modificar un horario de una instalación nuevo
        public static String UpdateEspacio(Espacio espaci)
        {
            String mensaje = "";

            try
            {
                
                Espacio espai = new Espacio();
                espai=ORM.bd.Espacio.Find(espaci.id);

                espai.nombre = espaci.nombre;
                espai.precio = espaci.precio;
                espai.exterior = espaci.exterior;

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
        public static String DelelteEspacio(Espacio espaci)
        {
            String mensaje = "";
            ORM.bd.Espacio.Remove(espaci);

            mensaje = ORM.SaveChanges();

            return mensaje;
        }

    }
}
