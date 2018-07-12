using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        // on appel notre BD depuis le Model
        private ApplicationDbContext db = new ApplicationDbContext();

        public ActionResult Index()
        {
            /* on retourne la liste des catégories et l'envoyer vers le View correspondant qui la page 
            Views/Home/Index.cshtml */
            return View(db.Categories.ToList());
        }

        public ActionResult About()
        {
            /* View correspondant qui la page Views/Home/About.cshtml */

            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            /* Le View correspondant qui la page Views/Home/Contact.cshtml */
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}