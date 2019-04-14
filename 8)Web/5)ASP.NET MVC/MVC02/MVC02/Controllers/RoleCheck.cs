using MVC02.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC02.Controllers {
     public class RoleCheck {
          public void AdminCheck(object id) {
               int temp = Convert.ToInt32(id);
               if (temp == 0) HttpContext.Current.Response.Redirect("/");
               else {
                    var currentAcc = new DBEntities().Accounts.Find(temp);
                    if (currentAcc.usrRole < 3) HttpContext.Current.Response.Redirect("/");
               }
          }

          public bool AdminCheckBool(object id) {
               int temp = Convert.ToInt32(id);
               if (temp == 0) return false;
               else {
                    var currentAcc = new DBEntities().Accounts.Find(temp);
                    if (currentAcc.usrRole < 3) return false;
                    else return true;
               }
          }
     }
}