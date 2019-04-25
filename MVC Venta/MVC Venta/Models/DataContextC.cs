using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVC_Venta.Models
{
    public class DataContextC:DbContext
    {
        public DataContextC():base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<MVC_Venta.Models.Cliente> Clientes { get; set; }
    }
}