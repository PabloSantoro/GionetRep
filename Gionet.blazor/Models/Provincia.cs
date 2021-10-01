using System;
using System.Collections.Generic;

namespace Gionet.blazor.Models
{
    public partial class Provincia
    {
        public int Id { get; set; }
        public string Provincia1 { get; set; }
        public string IsoId { get; set; }
        public string Idp { get; set; }
        public double? Lat { get; set; }
        public double? Lon { get; set; }
    }
}
