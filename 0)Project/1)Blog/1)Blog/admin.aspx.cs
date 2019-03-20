using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _1_Blog {
   public partial class entry : Page {
      protected void Page_Load(object sender, EventArgs e) {
         if ( IsPostBack ) return;
         if ( Session["LoggedInAs"] == null ) {
            Response.Redirect("index.aspx");
         }
         else {
            var Cord = new BlogEntities();
            int sesID = Convert.ToInt32(Session["LoggedInAs"].ToString());
            var tempID = Cord.Accounts
               .Where(temp => temp.usrID == sesID)
               .FirstOrDefault();

            if ( !( tempID.usrRole == 3 && tempID.usrActive == true ) ) {
               Response.Redirect("index.aspx");
            }
         }
         UpdateList(ArticleList);
      }

      private void UpdateList(DataList e) {
         BlogEntities Entries = new BlogEntities();

         if ( e.ID == "ArticleList" ) e.DataSource = Entries.Articles.ToList();
         e.DataBind();
      }

      protected void getusername(object sender, EventArgs e) {
         BlogEntities Cord = new BlogEntities();
         var sesID = Convert.ToInt32(Session["LoggedInAs"].ToString());
         var tempID = Cord.Accounts
            .Where(temp => temp.usrID == sesID)
            .FirstOrDefault();
         ((TextBox)sender).Text = tempID.usrFullName;
      }

      protected void publishArticle(object sender, EventArgs e) {

         Article Art = new Article() {
            artWriter = Convert.ToInt32(Session["LoggedInAs"].ToString()),
            artPublishDate = DateTime.Now,
            artUpdateDate = DateTime.Now,
            artTitle = in_add_title.Text,
            artText = in_add_text.Text.ToString(),
         };

         if ( in_add_articlepic.PostedFile != null || in_add_articlepic.PostedFile.FileName != null || in_add_articlepic.PostedFile.FileName != "" ) {
            Art.artImage = $"imgs/article/{DateTime.Today.ToString("dd-MM-yyyy")}_{Guid.NewGuid().ToString().Replace("-", "")}_{in_add_articlepic.FileName}";
            in_add_articlepic.SaveAs(Server.MapPath("~/" + Art.artImage));
         }

         BlogEntities Cord = new BlogEntities();
         Cord.Articles.Add(Art);
         Cord.SaveChanges();
         UpdateList(ArticleList);
      }

      protected void ArticleList_DeleteCommand(object source, DataListCommandEventArgs e) {
         BlogEntities Cord = new BlogEntities();
         Article ArticleX = Cord.Articles.Find(Convert.ToInt32(e.CommandArgument));
         Cord.Articles.Remove(ArticleX);
         Cord.SaveChanges();
         UpdateList(ArticleList);
      }

      protected void ArticleList_UpdateCommand(object source, DataListCommandEventArgs e) {
         BlogEntities Cord = new BlogEntities();
         Article ArticleX = Cord.Articles.Find(Convert.ToInt32(e.CommandArgument));
         ArticleX.artWriter = Convert.ToInt32(Session["LoggedInAs"].ToString());
         ArticleX.artUpdateDate = DateTime.Now;
         ArticleX.artTitle = ( e.Item.FindControl("in_Up_Title") as TextBox ).Text;
         ArticleX.artText = ( e.Item.FindControl("in_Up_Text") as TextBox ).Text;

         Cord.SaveChanges();
         ArticleList.EditItemIndex = -1;
         UpdateList(ArticleList);
      }

      protected void ArticleList_EditCommand(object source, DataListCommandEventArgs e) {
         ArticleList.EditItemIndex = e.Item.ItemIndex;
         UpdateList(ArticleList);
      }

      protected void ArticleList_CancelCommand(object source, DataListCommandEventArgs e) {
         ArticleList.EditItemIndex = -1;
         UpdateList(ArticleList);
      }

      protected void addCategory(object sender, EventArgs e) {
         BlogEntities Cord = new BlogEntities();
         Category Cat = new Category() {
            catName = in_add_catname.Text
         };

         Cord.Categories.Add(Cat);
         Cord.SaveChanges();
      }
   }
}