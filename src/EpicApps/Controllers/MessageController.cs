using Recaptcha.Web;
using Recaptcha.Web.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;

namespace EpicApps.Controllers
{
    public class MessageController : Controller
    {
        [HttpPost]
        public async Task<ContentResult> New(string name,string email, string comment,int ignorecaptcha = 0)
        {
            try
            {
                if (ignorecaptcha != 1)
                {
                    RecaptchaVerificationHelper recaptchaHelper = this.GetRecaptchaVerificationHelper();


                    if (String.IsNullOrEmpty(recaptchaHelper.Response))
                    {
                        ModelState.AddModelError("", "Captcha answer cannot be empty.");
                        return Content("{\"success\":false}", "text/plain");
                    }

                    RecaptchaVerificationResult recaptchaResult = await recaptchaHelper.VerifyRecaptchaResponseTaskAsync();

                    if (recaptchaResult != RecaptchaVerificationResult.Success)
                    {
                        ModelState.AddModelError("", "Incorrect captcha answer.");
                        return Content("{\"success\":false}", "text/plain");
                    }
                }
                Random rnd = new Random();
                int id = rnd.Next(10000, 20000);
                StreamReader w = new StreamReader(HostingEnvironment.MapPath("~/email.html"), true);
                var body = await w.ReadToEndAsync();
                body = body.Replace("{name}", name).Replace("{number}", id.ToString()).Replace("{message}", comment);
                var message = new MailMessage();
                message.To.Add(new MailAddress("contact@epicapps.com.br"));  // replace with valid value 
                message.To.Add(new MailAddress(email));
                message.From = new MailAddress("mailer@epicapps.com.br");  // replace with valid value
                message.ReplyToList.Add(email);
                message.Subject = "Support Request #" + id;
                message.Body = body;
                message.IsBodyHtml = true;

                using (var smtp = new SmtpClient())
                {
                    var credential = new NetworkCredential
                    {
                        UserName = "mailer@epicapps.com.br",  // replace with valid value
                        Password = "989dvg58"  // replace with valid value
                    };
                    smtp.Credentials = credential;
                    smtp.Host = "smtp.epicapps.com.br";
                    smtp.Port = 587;
                    smtp.EnableSsl = false;
                    await smtp.SendMailAsync(message);
                }
            }
            catch(Exception e)
            {
                return Content("{\"success\":false, \"message\": "+ e.Message + e.ToString() +"}", "text/plain");
            }
            return Content("{\"success\":true}", "text/plain");
        }
    }
}