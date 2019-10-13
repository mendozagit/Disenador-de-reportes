using System;
using System.Collections.Generic;

namespace Report.Models
{
    public partial class FormaPago
    {
        public FormaPago()
        {
            Cliente = new HashSet<Cliente>();
        }

        public string FormaPagoId { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<Cliente> Cliente { get; set; }
    }
}
