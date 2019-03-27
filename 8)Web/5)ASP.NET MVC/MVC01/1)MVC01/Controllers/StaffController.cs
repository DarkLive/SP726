using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _1_MVC01.Models;

namespace _1_MVC01.Controllers
{
    public class StaffController : Controller
    {
        // GET: Staff
        public ActionResult ListStaff()
        {
            TESTEntities Cord = new TESTEntities();
            ViewBag.StaffList = Cord.Elemen.ToList();
            return View();
        }

        public ActionResult AddStaff()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddStaff(string name, string surname, string city)
        {
            TESTEntities Cord = new TESTEntities();
            Eleman staff = new Eleman(){
                Ad = name,
                Soyad = surname,
                Sehir = city
            };
            Cord.Elemen.Add(staff);
            Cord.SaveChanges();
            return RedirectToAction("ListStaff");
        }
    }
}