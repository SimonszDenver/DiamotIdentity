using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SendGrid;
using SendGrid.Helpers.Mail;

namespace IdentityTest_Dev.Controllers
{
    public class EmailController : Controller
    {
        [HttpGet]
        public ActionResult SendMail(string email)
        {
            var apiKey = "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";
            var client = new SendGridClient(apiKey);
            var from = new EmailAddress("diamottest@outlook.com", "Example User");
            var subject = "Sending with SendGrid is Fun";
            var to = new EmailAddress(email, "Example User");
            var plainTextContent = "and easy to do anywhere, even with C#";
            var htmlContent = "<strong>and easy to do anywhere, even with C#</strong>";
            var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
            var response = client.SendEmailAsync(msg);
            return Json(response, JsonRequestBehavior.AllowGet);
        }
    }
}