using System;
using System.Collections.Generic;

namespace Gionet.blazor.Models
{
    public partial class Personal
    {
        public int Dni { get; set; }
        public string Nombre { get; set; }
        public string Tipoc { get; set; }
        public string Categoria { get; set; }
        public string Telefono { get; set; }
        public byte[] Imagen { get; set; }
    }
}
