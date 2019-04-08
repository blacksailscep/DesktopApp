using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop.ORM
{
    class ORMEquipos
    {
        public static void UpdateEquipo(int id, String nombre, String deporte, String categoria, String competicion, String sexo, String nivel)
        {
            Equipo equi = ORM.bd.Equipo.Find(id);

            equi.nombre = nombre;
            equi.Deportes = ORM.bd.Deportes.Find(deporte);
            equi.Categoria_edad = ORM.bd.Categoria_edad.Find(categoria);
            equi.Competicion = ORM.bd.Competicion.Find(competicion);
            equi.Sexo = ORM.bd.Sexo.Find(sexo);
            equi.Nivel = ORM.bd.Nivel.Find(nivel);


            ORM.bd.SaveChanges();
        }
    }
}
