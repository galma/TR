using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PruebaServicio.Models;

namespace PruebaServicio.Controllers
{
    public class ClientController : Controller
    {
        //
        // GET: /Client/
        [HttpGet]
        public ActionResult GetClients(Guid token)
        {
            if(!Helpers.Login.ValidateToken(token))
            {
                return new HttpUnauthorizedResult("Invalid Security Token");
            }

            ClientCollection rv = Helpers.GenerateTestEntities.GenerateClientList();

            return Json(rv.ClientList, JsonRequestBehavior.AllowGet);
        }

    }
}
