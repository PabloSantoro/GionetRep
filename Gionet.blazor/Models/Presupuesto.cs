using System;
using System.Collections.Generic;

namespace Gionet.blazor.Models
{
    public partial class Presupuesto
    {
        public string Numpresup { get; set; }
        public string Resp { get; set; }
        public string Cliente { get; set; }
        public string Descrip { get; set; }
        public DateTime? Fechaent { get; set; }
        public double? Montod { get; set; }
        public double? Cotizacion { get; set; }
        public int Id { get; set; }
        public int? Oc { get; set; }
        public bool? Estado { get; set; }
        public byte[] Adjuntar { get; set; }
    }
}
