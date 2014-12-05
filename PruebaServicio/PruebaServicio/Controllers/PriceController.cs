using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PruebaServicio.Models;

namespace PruebaServicio.Controllers
{
    public class PriceController : Controller
    {
        
        [HttpGet]
        public ActionResult GetPrices(Guid token)
        {
            if (!Helpers.Login.ValidateToken(token))
            {
                return new HttpUnauthorizedResult("Invalid Security Token");
            }

            ItemCollection rv = Helpers.GenerateTestEntities.GenerateItemList();

            return Json(rv, JsonRequestBehavior.AllowGet);
        }

    }
}
