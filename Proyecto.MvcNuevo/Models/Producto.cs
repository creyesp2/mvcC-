using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace Proyecto.MvcNuevo.Models
{
    public class Producto
    {

        [Key]
        public int ProductoID { get; set;}
        public string nombreProducto{get;set;}
        public int cantidad {get; set; }
        public decimal precio { get; set; }
        public DateTime fecha { get; set; }
        

    }
}