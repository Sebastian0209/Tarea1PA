using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Venta.Models
{
    public class Venta
    {

        [key]

        public int VentaId { get; set; }

        [required]
        public DateTime Fecha { get; set; }

        [required]
        public int ProductoId { get; set; }
        [required]
        public int ClienteId { get; set; }
    }
}