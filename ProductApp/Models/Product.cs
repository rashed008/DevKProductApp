using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductApp.Models
{
    public class Product
    {
        public int Id { get; set; }
        public String productName { get; set; }
        public decimal productPrice { get; set; }
        public byte[] productImage { get; set; }
        public int productQuantity { get; set; }
    }
}