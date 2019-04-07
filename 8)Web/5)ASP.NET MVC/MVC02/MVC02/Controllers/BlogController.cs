using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC02.Models;

namespace MVC02.Controllers {
     public class BlogController : Controller {
          // GET: Blog

          [Route("Blog")]
          public ActionResult Index() {
               return View(new DBEntities().Articles.Where(temp => temp.artActive == true).ToList());
          }

          [Route("Blog/Details/{id}")]
          public ActionResult Details(int id) {
               Article detArt = new DBEntities().Articles.First(t => t.artID == id);
               List<Rel_Article_Category> rel = new DBEntities().Rel_Article_Category.Where(t => t.relArtID == id).ToList();
               ViewBag.Rel = rel;
               return View(detArt);
          }
     }
}