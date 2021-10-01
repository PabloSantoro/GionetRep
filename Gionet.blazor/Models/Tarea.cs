using System;
using System.Collections.Generic;

namespace Gionet.blazor.Models
{
    public partial class Tarea
    {
        public int Id { get; set; }
        public int IdTarea { get; set; }
        public string Oc { get; set; }
        public string Tarea1 { get; set; }
        public decimal Hhprev { get; set; }
        public DateTime Desde { get; set; }
        public DateTime Hasta { get; set; }
        public string Especialidad { get; set; }
        public int Duracion { get; set; }
        public int Avance { get; set; }
        public int Dependencia { get; set; }
    }
}
