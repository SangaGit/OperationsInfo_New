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
        // GET: Home
        public ActionResult Index()
        {
            //var dbContext = new StudentRegistrationEntitiesDBContext();
            //var students = dbContext.spGetAllStudents().ToList();
            return View();
        }
        public ActionResult ViewStreet()
        {
            return RedirectToAction("ViewAddress");
        }
        public ActionResult ViewAddress()
        {
            return View();
        }
    }
}