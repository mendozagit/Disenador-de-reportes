using System;
using System.Collections.Generic;

namespace Report.Models
{
    public partial class Reporte
    {
        public int ReporteId { get; set; }
        public string Clave { get; set; }
        public string Descripcion { get; set; }
        public string Query { get; set; }
        public string Codigo { get; set; }
        public bool Parametrizado { get; set; }
    }
}
