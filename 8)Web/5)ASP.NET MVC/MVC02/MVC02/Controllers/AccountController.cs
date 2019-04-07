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
               return Redirect("Blog");
          }

          [HttpPost]
          public bool Register(Account acc, HttpPostedFileBase usrpic) {
               acc.usrRegistered = DateTime.Now;

               try {
                    if (usrpic != null && usrpic.FileName != null && usrpic.FileName != "") {
                         acc.usrImg = $"img/content/user/{DateTime.Now.ToString("dd.MM.yyyy")}_{Guid.NewGuid().ToString().Replace("-", "")}_{usrpic.FileName}";
                         usrpic.SaveAs(Server.MapPath("~/" + acc.usrImg));
                    }
                    DBEntities Cord = new DBEntities();
                    Cord.Accounts.Add(acc);
                    Cord.SaveChanges();

                    Session["LoggedInAs"] = acc.usrID;
                    return true;
               } catch {
                    return false;
               }
          }

          [HttpPost]
          public bool Login(Account acc) {
               try {
                    Account usr = (new DBEntities()).Accounts.FirstOrDefault(t => t.usrEmail == acc.usrEmail && t.usrPassword == acc.usrPassword);

                    if (usr == null) {
                         return false;
                    } else {
                         Session["LoggedInAs"] = usr.usrID;
                         return true;
                    }

               } catch {
                    return false;
               }
          }

          [HttpPost]
          public void Logout() {
               Session["LoggedInAs"] = null;
          }
     }
}