using System;
using System.Collections.Generic;

namespace Gionet.blazor.Models
{
    public partial class Detparte
    {
        public int Id { get; set; }
        public int? Parte { get; set; }
        public int? Dni { get; set; }
        public TimeSpan? Desde { get; set; }
        public TimeSpan? Hasta { get; set; }
    }
}
