using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _1_Blog {
   public partial class account : System.Web.UI.Page {
      protected void Page_Load(object sender, EventArgs e) {

      }

      protected void register(object sender, EventArgs e) {
         try {
            var Cord = new BlogEntities();
            var User = new Account() {
               usrFullName = in_Reg_FullName.Text.Replace("'", ""),
               usrEmail = in_Reg_Email.Text.Replace("'", ""),
               usrPassword = in_Reg_Password.Text.Replace("'", ""),
               usrBirthDay = Convert.ToDateTime(Convert.ToDateTime(in_Reg_Birthday.Text).ToString("yyyy/MM/dd")),
               usrRegistered = DateTime.Now
            };
            if ( in_Reg_Avatar.PostedFile != null || in_Reg_Avatar.PostedFile.FileName != null || in_Reg_Avatar.PostedFile.FileName != "" ) {
               User.usrImg = $"imgs/user/avatar/{DateTime.Today.ToString("dd-MM-yyyy")}-{Guid.NewGuid().ToString().Replace("-", "")}-{in_Reg_Avatar.FileName}";
               in_Reg_Avatar.SaveAs(Server.MapPath("~/" + User.usrImg));
            }

            Cord.Accounts.Add(User);
            Cord.SaveChanges();

            Session.Add("LoggedIn", User.usrID);
            Response.Redirect("index.aspx");
         }
         catch {
            alertthis.Visible = true;
            alertthis.InnerHtml = "Please fill all the fields with <span class='badge badge-primary'>*</span> tag.";
         }
      }
      protected void login(object sender, EventArgs e) {
         var Cord = new BlogEntities();

         try {
            var User = Cord.Accounts
               .Where(temp => temp.usrEmail == in_Log_Email.Text || temp.usrPassword == in_Log_Password.Text)
               .FirstOrDefault();

            if(User == null) {
               alertthis.Visible = true;
               alertthis.InnerHtml = "Coudn't find a Account with presented information. Email or Password is wrong.";
            }
            else {
               Session.Add("LoggedIn", User.usrID);
               Response.Redirect("index.aspx");
            }
         }
         catch {
            alertthis.Visible = true;
            alertthis.InnerHtml = "Please fill all the fields with <span class='badge badge-primary'>*</span> tag.";
         }
      }
   }
}