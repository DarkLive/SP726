using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC02.Models;

namespace MVC02.Controllers {
    public class CategoryController : Controller {
        // GET: Category
        public ActionResult Index() {
            return View(new DBEntities().Categories.ToList());
        }

        public ActionResult Add() {
            return View();
        }

        [HttpPost]
        public bool Add(Category cat) {
            try {
                DBEntities Cord = new DBEntities();
                Cord.Categories.Add(cat);
                Cord.SaveChanges();
                return true;
            }
            catch {
                return false;
            }
        }
    }
}