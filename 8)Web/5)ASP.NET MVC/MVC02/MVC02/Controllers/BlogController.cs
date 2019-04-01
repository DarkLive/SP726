using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC02.Models;

namespace MVC02.Controllers {
    public class BlogController : Controller {
        // GET: Blog
        public ActionResult Index() {
            return View((new DBEntities()).Articles.ToList());
        }

        public ActionResult Add() {
            return View();
        }

        [HttpPost]
        public ActionResult Add(Article art, HttpPostedFileBase articlepic) {
            art.artPublishDate = DateTime.Now; art.artUpdateDate = art.artPublishDate;
            art.artImage = $"img/content/article/{DateTime.Now.ToShortDateString()}_{Guid.NewGuid().ToString().Replace("-","")}_{articlepic.FileName}";
            articlepic.SaveAs(Server.MapPath("~/" + art.artImage));

            DBEntities Cord = new DBEntities();
            Cord.Articles.Add(art);
            Cord.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}