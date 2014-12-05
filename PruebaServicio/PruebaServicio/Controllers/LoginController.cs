using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PruebaServicio.Models;


namespace PruebaServicio.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        public ActionResult Authenticate(string user, string password)
        {
            if (!Helpers.Login.ValidateCredentials(user, password))
            {
                return new HttpUnauthorizedResult("Invalid Credentials");
            }

            Guid Token = Helpers.Login.GenerateToken(user);

            return Content(Token.ToString());
        }

    }
}
