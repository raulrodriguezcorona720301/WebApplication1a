using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    [Bind(Include = "id,descripcion,price")]
    public class EntProduct
    {
        [Required(ErrorMessage = "Falta id")]
        public string id { get; set; }
        [Required(ErrorMessage = "Falta descripcion")]
        public string descripcion { get; set; }
        [Required(ErrorMessage = "Falta precio")]
        public double price { get; set; }
    }
}