using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PruebaServicio.Helpers
{
    public static class Login
    {
        public static bool ValidateCredentials(string user, string password)
        {
            //chequeo user
            if (user == "santicomepibes")
                return false;
            else
                return true;
        }

        public static Guid GenerateToken(string user)
        {
            //blabla

            return Guid.NewGuid();
        }

        public static bool ValidateToken(Guid token)
        {
            //chequeo token
            return true;
        }

    }
}