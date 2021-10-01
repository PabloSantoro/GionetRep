using System;
using System.Collections.Generic;

namespace Gionet.blazor.Models
{
    public partial class Contacto
    {
        public int Id { get; set; }
        public string Responsable { get; set; }
        public string Cliente { get; set; }
        public string Provincia { get; set; }
        public string Nombre { get; set; }
        public string Posicion { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
    }
}
