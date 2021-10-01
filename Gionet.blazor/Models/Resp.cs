using System;
using System.Collections.Generic;

namespace Gionet.blazor.Models
{
    public partial class Resp
    {
        public int Id { get; set; }
        public string Responsable { get; set; }
        public string Telefono { get; set; }
        public byte[] Imagen { get; set; }
    }
}
