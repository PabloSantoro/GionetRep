using System;
using System.Collections.Generic;

namespace Gionet.blazor.Models
{
    public partial class Npresup
    {
        public int Id { get; set; }
        public string Cliente { get; set; }
        public string Presup { get; set; }
        public string Nombre { get; set; }
        public string Contacto { get; set; }
        public double Montop { get; set; }
        public double Montod { get; set; }
        public bool Ganado { get; set; }
    }
}
