using AccordianPopulateTask.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace AccordianPopulateTask.Controllers
{
    public class AccordionController : Controller
    {
        DatabaseContext db = new DatabaseContext();
        [HttpGet]
        public async Task<ActionResult> Index()
        {
            return View("Accordion",await db.Accordions.ToListAsync());
        }
    }
}