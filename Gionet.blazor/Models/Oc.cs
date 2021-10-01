using System;
using System.Collections.Generic;

namespace Gionet.blazor.Models
{
    public partial class Oc
    {
        public int Id { get; set; }
        public string Cliente { get; set; }
        public string Oc1 { get; set; }
        public string Tipo { get; set; }
        public int? Ocp { get; set; }
        public string Nombre { get; set; }
        public string Presupuesto { get; set; }
        public DateTime? Fecha { get; set; }
        public string Solicita { get; set; }
        public double? Montop { get; set; }
        public double? Montod { get; set; }
        public DateTime? Desde { get; set; }
        public DateTime? Hasta { get; set; }
    }
}
