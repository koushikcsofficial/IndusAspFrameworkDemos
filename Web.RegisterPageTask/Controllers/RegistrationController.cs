using System;
using System.Data.Entity;
using System.Threading.Tasks;
using System.Web.Mvc;
using Web.RegisterPageTask.Models;

namespace Web.RegisterPageTask.Controllers
{
    public class RegistrationController : Controller
    {
        Security security = new Security();
        DatabaseContext db = new DatabaseContext();

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Index(string email,string psw)
        {
            try
            {
                if (await db.Registrations.AnyAsync(data=>data.Account_Email==email))
                {
                    ViewBag.Msg = "Email Already Exists.";
                    return View();
                }
                else
                {
                    Registration reg = new Registration();
                    reg.Account_Email = email;
                    reg.Account_Password = security.HashPassword(psw);

                    db.Registrations.Add(reg);
                    await db.SaveChangesAsync();

                    ViewBag.Msg = "Account Created Successfully";
                    return View();
                }
            }catch(Exception e)
            {
                ViewBag.Msg = "Unknown error occured while creating your account";
                return View();
            }
            
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}