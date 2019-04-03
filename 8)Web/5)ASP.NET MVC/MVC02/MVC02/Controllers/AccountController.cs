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
        public bool Login(Account acc) {

            try {
                Account usr = (new DBEntities()).Accounts.FirstOrDefault(t => t.usrEmail == acc.usrEmail && t.usrPassword == acc.usrPassword);

                if (usr == null)
                return false;

                Session["LoggedInAs"] = usr.usrID;
                return true;
            }
            catch {
                return false;
            }
        }

        [HttpPost]
        public bool Edit(Account acc, HttpPostedFileBase usrpic) {
            try {
                if (usrpic != null && usrpic.FileName != null && usrpic.FileName != "") {
                    if (acc.usrImg != "img/content/user/defaultuser.png") System.IO.File.Delete(Server.MapPath("~/" + acc.usrImg));
                    acc.usrImg = $"img/content/user/{DateTime.Now.ToShortDateString()}_{Guid.NewGuid().ToString().Replace("-", "")}_{usrpic.FileName}";
                    usrpic.SaveAs(Server.MapPath("~/" + acc.usrImg));
                }
                else {
                    acc.usrImg = "img/content/user/defaultuser.png";
                }
                DBEntities Cord = new DBEntities();
                Account cUser = Cord.Accounts.First(l => l.usrID == acc.usrID);
                {
                    cUser.usrFullName = acc.usrFullName;
                    cUser.usrEmail = acc.usrEmail;
                    cUser.usrPassword = acc.usrPassword;
                    cUser.usrBirthDay = acc.usrBirthDay;
                    cUser.usrImg = acc.usrImg;
                    cUser.usrActive = acc.usrActive;
                    cUser.usrRole = acc.usrRole;
                }
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
            Account acc = Cord.Accounts.FirstOrDefault(l => l.usrID == tempid);

            try {
                if (System.IO.File.Exists(Server.MapPath("~/" + acc.usrImg)) && acc.usrImg != "img/content/user/defaultuser.png") {
                    System.IO.File.Move(Server.MapPath("~/" + acc.usrImg), Server.MapPath("~/" + acc.usrImg.Replace("img/content/user", "img/content/olduser")));
                    acc.usrImg = acc.usrImg.Replace("img/content/user", "img/content/olduser");
                    acc.usrRemoved = DateTime.Now;
                    Cord.SaveChanges();
                }

                Cord.Accounts.Remove(acc);
                Cord.SaveChanges();
                return true;
            }
            catch {
                return false;
            }
        }
    }
}