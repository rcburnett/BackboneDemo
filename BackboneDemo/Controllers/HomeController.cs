using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BackboneDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }

        public ActionResult TemplateExample()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult ModelsExample()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult CollectionsExample()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult ViewsExample()
        {
            ViewBag.Message = "Views";

            return View();
        }

        public ActionResult EventsExample()
        {
            ViewBag.Message = "Views";

            return View();
        }

    }
}
