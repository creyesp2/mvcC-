using Proyecto.MvcNuevo.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Proyecto.MvcNuevo.Models;

namespace Proyecto.MvcNuevo.Context
{
    public class TiendaContext : DbContext
    {
        public DbSet<Producto> Productos{ get; set; }
    }
}