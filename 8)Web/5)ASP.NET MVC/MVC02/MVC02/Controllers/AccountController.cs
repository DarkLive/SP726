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
            return View(new Account());
        }

        public ActionResult Register() {
            return View();
        }

        [HttpPost]
        public bool Register(Account acc, HttpPostedFileBase usrpic) {
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

        [HttpPost]
        public bool Remove(int tempid) {
            DBEntities Cord = new DBEntities();
            Account usr = Cord.Accounts.FirstOrDefault(t => t.usrID == tempid);

            try {
                if (System.IO.File.Exists(Server.MapPath("~/" + usr.usrImg)) && usr.usrImg != "img/content/user/defaultuser.png") {
                    System.IO.File.Move(Server.MapPath("~/" + usr.usrImg), Server.MapPath("~/" + usr.usrImg.Replace("img/content/user", "img/content/olduser")));
                    usr.usrImg = usr.usrImg.Replace("img/content/user", "img/content/olduser");
                    Cord.SaveChanges();

                }

                Cord.Accounts.Remove(usr);
                Cord.SaveChanges();
                return true;
            }
            catch {
                return false;
            }
        }
    }
}