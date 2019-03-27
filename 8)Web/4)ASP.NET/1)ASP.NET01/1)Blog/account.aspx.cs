using System;
using System.Linq;
using System.Web.UI;

namespace _1_Blog {
   public partial class account : Page {
      protected void Page_Load(object sender, EventArgs e) {

      }

      protected void register(object sender, EventArgs e) {
         alertthis.Attributes.CssStyle.Remove("display");

         try {
            BlogEntities Cord = new BlogEntities();

            Account User = new Account() {
               usrFullName = in_Reg_FullName.Text.Replace("'", ""),
               usrEmail = in_Reg_Email.Text.Replace("'", ""),
               usrPassword = in_Reg_Password.Text.Replace("'", ""),
               usrBirthDay = Convert.ToDateTime(Convert.ToDateTime(in_Reg_Birthday.Text).ToString("yyyy/MM/dd")),
               usrRegistered = DateTime.Now
            };

            if ( in_Reg_Avatar.PostedFile != null || in_Reg_Avatar.PostedFile.FileName != null || in_Reg_Avatar.PostedFile.FileName != "" ) {
               User.usrImg = $"imgs/user/avatar/{DateTime.Today.ToString("dd-MM-yyyy")}_{Guid.NewGuid().ToString().Replace("-", "")}_{in_Reg_Avatar.FileName}";
               in_Reg_Avatar.SaveAs(Server.MapPath("~/" + User.usrImg));
            }

            Cord.Accounts.Add(User);
            Cord.SaveChanges();

            Session["LoggedInAs"] = User.usrID;
            Response.Redirect("index.aspx");
         }
         catch {
            alertthis.InnerHtml = "Please fill all the fields with <span class='badge badge-primary'>*</span> tag.";
         }
      }
      protected void login(object sender, EventArgs e) {
         BlogEntities Cord = new BlogEntities();
         alertthis.Attributes.CssStyle.Remove("display");

         if ( in_Log_Email.Text == "" || in_Log_Password.Text == "" || in_Log_Email.Text == null || in_Log_Password.Text == null) alertthis.InnerHtml = "Please fill all the fields with <span class='badge badge-primary'>*</span> tag.";

         try {
            var User = Cord.Accounts
               .Where(temp => temp.usrEmail == in_Log_Email.Text && temp.usrPassword == in_Log_Password.Text)
               .FirstOrDefault();

            if(User == null) alertthis.InnerHtml = "Coudn't find a Account with presented information. Email or Password is wrong.";

            else {
               Session["LoggedInAs"] = User.usrID;
               Response.Redirect("index.aspx");
            }
         }
         catch {
            alertthis.InnerHtml = "Error on DB Connection";
         }
      }
   }
}