using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using IdentityTestProject.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security.DataProtection;

namespace IdentityTestProject.Controllers
{

   

    public class ResetAccountController : Controller
    {
        UserManager<ApplicationUser> userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>());

        
        public string SendEmail(string user)
        {

            var provider = new DpapiDataProtectionProvider("Sample");

           userManager.UserTokenProvider = new DataProtectorTokenProvider<ApplicationUser>(
                provider.Create("EmailConfirmation"));

            var result = userManager.CreateAsync(new ApplicationUser()
            {
                UserName = "abc"
            });
            if (result.Result.Succeeded)
            {
                var code = userManager.GenerateEmailConfirmationTokenAsync(user);
                return code.Result;
            }

            return null;

        }
    }
}