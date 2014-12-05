using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PruebaServicio.Models
{
    public class ItemCollection
    {
        public List<Item> ItemList { get; set; }

        public ItemCollection()
        {
            ItemList = new List<Item>(); 
        }

    }
}