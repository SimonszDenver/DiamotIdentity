using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;

namespace IdentityTestProject.Controllers
{
    public class User : IUser
    {
        public string Id { get; }
        public string UserName { get; set; }
    }
    public class ResetAccountController : Controller
    {
//        private UserManager<IUser<string>> _userManager = new UserManager<>();
        public void SendEmail(string user)
        {
            
//            var code = 
        }
    }
}