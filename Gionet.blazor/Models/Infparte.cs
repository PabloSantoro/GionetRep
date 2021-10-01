using System;
using System.Collections.Generic;

namespace Gionet.blazor.Models
{
    public partial class Infparte
    {
        public string Oc { get; set; }
        public string Tarea { get; set; }
        public DateTime? Fecha { get; set; }
        public string Detalle { get; set; }
        public string Especialidad { get; set; }
        public int? Dni { get; set; }
        public TimeSpan? Desde { get; set; }
        public TimeSpan? Hasta { get; set; }
        public string Categoria { get; set; }
    }
}
