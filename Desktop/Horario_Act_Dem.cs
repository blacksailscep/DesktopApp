//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Desktop
{
    using System;
    using System.Collections.Generic;
    
    public partial class Horario_Act_Dem
    {
        public int id { get; set; }
        public int id_Act_Demandada { get; set; }
        public int id_dia_semana { get; set; }
        public System.TimeSpan hora_inicio { get; set; }
        public System.TimeSpan hora_final { get; set; }
    
        public virtual Act_demandadas Act_demandadas { get; set; }
        public virtual Dias_Semana Dias_Semana { get; set; }
    }
}
