using MVC02.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC02.Controllers {
    public class AccountController : Controller {
        // GET: Account
        public ActionResult Index() {
            return View((new DBEntities()).Accounts.ToList());
        }

        public ActionResult Add() {
            return View();
        }

        [HttpPost]
        public bool Add(Account acc, HttpPostedFileBase usrpic) {
            acc.usrRegistered = DateTime.Now;

            try {
                if (usrpic != null && usrpic.FileName != null && usrpic.FileName != "") {
                    acc.usrImg = $"img/content/user/{DateTime.Now.ToShortDateString()}_{Guid.NewGuid().ToString().Replace("-", "")}_{usrpic.FileName}";
                    usrpic.SaveAs(Server.MapPath("~/" + acc.usrImg));
                }

                DBEntities Cord = new DBEntities();
                Cord.Accounts.Add(acc);
                Cord.SaveChanges();
                return true;
            }
            catch {
                return false;
            }
        }
    }
}