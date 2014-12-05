using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PruebaServicio.Models
{
    public class ClientCollection
    {
        public List<Client> ClientList { get; set; }

        public ClientCollection()
        {
            ClientList = new List<Client>();
        }
    }
}