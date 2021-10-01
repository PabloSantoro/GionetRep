using System;
using System.Collections.Generic;

namespace Gionet.blazor.Models
{
    public partial class Parte
    {
        public int Id { get; set; }
        public DateTime? Fecha { get; set; }
        public int? Tarea { get; set; }
        public string Detalle { get; set; }
        public int Oc { get; set; }
        public string Especialidad { get; set; }
    }
}
