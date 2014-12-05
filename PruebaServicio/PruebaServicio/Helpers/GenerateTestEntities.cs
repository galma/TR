using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PruebaServicio.Models;

namespace PruebaServicio.Helpers
{
    public static class GenerateTestEntities
    {
        public static ItemCollection GenerateItemList()
        {
            ItemCollection rv = new ItemCollection();
            Item i1 = new Item(1);
            Item i2 = new Item(2);
            Item i3 = new Item(3);
            rv.ItemList.Add(i1);
            rv.ItemList.Add(i2);
            rv.ItemList.Add(i3);
            return rv;
        }

        public static ClientCollection GenerateClientList()
        {
            ClientCollection rv = new ClientCollection();
            
            Client cliente1 = new Client();            
            cliente1.Code = 1;
            cliente1.Name = "Guido Alma";

            Client cliente2 = new Client();
            cliente2.Code = 2;
            cliente2.Name = "Santiago Cruz";

            Client cliente3 = new Client();
            cliente3.Code = 3;
            cliente3.Name = "Denis Kormakov";

            rv.ClientList.Add(cliente1);
            rv.ClientList.Add(cliente2);
            rv.ClientList.Add(cliente3);

            return rv;            
        }

    }
}