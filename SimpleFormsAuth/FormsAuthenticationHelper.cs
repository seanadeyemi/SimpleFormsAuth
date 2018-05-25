using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleFormsAuth
{
    public class FormsAuthenticationHelper : IAuthentication
    {
        private readonly MyDbContext context = new MyDbContext();
        public bool Authenticate(string username, string password)
        {
            var result = context.Users.FirstOrDefault(u => u.UserId == username && u.Password == password);

            if(result == null)
            {
                return false;
            }

            return true;

        }

        public bool Logout()
        {
            return true;
        }
    }
}