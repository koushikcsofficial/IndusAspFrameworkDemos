using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
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
        public ActionResult Index(string email,string psw)
        {
            try
            {
                if (db.Registrations.Any(data => data.Account_Email == email))
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
                    db.SaveChanges();
                    ViewBag.Msg = "Account Created Successfully";
                    return View();
                }
            }catch(Exception e)
            {
                ViewBag.Msg = "Unknown error occured while creating your account";
                return View();
            }
            
        }
    }
}