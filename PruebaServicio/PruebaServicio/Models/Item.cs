using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PruebaServicio.Models
{
    public class Item
    {
        public int Code { get; set; }
        public string Name { get; set; }

        public float Price { get; set; }

        public Item(int code)
        {
            Code = code;
            Name = "Name " + code.ToString();
            Price = float.Parse(code.ToString());
        }
    }
}