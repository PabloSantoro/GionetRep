using System;
using System.Collections.Generic;

namespace Gionet.blazor.Models
{
    public partial class Inkpresup
    {
        public string Numpresup { get; set; }
        public string Resp { get; set; }
        public string Descrip { get; set; }
        public DateTime? Fechaent { get; set; }
        public int Id { get; set; }
        public int? Oc { get; set; }
        public bool? Estado { get; set; }
    }
}
