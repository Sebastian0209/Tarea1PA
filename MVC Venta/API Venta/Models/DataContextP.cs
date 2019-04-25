using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace API_Venta.Models
{
    public class DataContextP:DbContext
    {
        public DataContextP():base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<API_Venta.Models.Producto> Productoes { get; set; }
    }
}