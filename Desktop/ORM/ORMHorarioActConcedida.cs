using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop.ORM
{
    public class ORMHorarioActConcedida
    {
        public static String SaveHorarioActConcedida(Horario_Act_Con horario)
        {
            ORM.bd.Horario_Act_Con.Add(horario);
            String mensaje = "";

            mensaje = ORM.SaveChanges();

            return mensaje;
        }
    }
}
