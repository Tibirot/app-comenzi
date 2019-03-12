using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace app_comenzi.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public string Description { get; set; }
        public int Supply { get; set; }
    }
}