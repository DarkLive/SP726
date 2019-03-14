using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _1_Blog {
   public partial class entry : System.Web.UI.Page {
      protected void Page_Load(object sender, EventArgs e) {
         if ( IsPostBack ) return;
         UpdateList();
      }

      private void UpdateList() {
         BlogEntities Entries = new BlogEntities();
         EntryList.DataSource = Entries.Articles.ToList();
         EntryList.DataBind();
      }

      protected void articleadd(object sender, EventArgs e) {
         Article ArticleX = new Article() {
            artAuthor = in_author.Text,
            artDate = DateTime.Now,
            artTitle = in_title.Text,
            artText = in_text.Text.ToString()
         };

         BlogEntities Entries = new BlogEntities();
         Entries.Articles.Add(ArticleX);
         Entries.SaveChanges();
         UpdateList();
      }

      protected void EntryList_DeleteCommand(object source, DataListCommandEventArgs e) {
         BlogEntities Entries = new BlogEntities();
         Article ArticleX = Entries.Articles.Find(Convert.ToInt32(e.CommandArgument));
         Entries.Articles.Remove(ArticleX);
         Entries.SaveChanges();
         UpdateList();
      }

      protected void EntryList_UpdateCommand(object source, DataListCommandEventArgs e) {
         BlogEntities Entries = new BlogEntities();
         Article ArticleX = Entries.Articles.Find(Convert.ToInt32(e.CommandArgument));
         ArticleX.artID = Convert.ToInt32(e.CommandArgument);
         ArticleX.artAuthor = ( e.Item.FindControl("in_Up_Author") as TextBox ).Text;
         ArticleX.artDate = DateTime.Now;
         ArticleX.artTitle = ( e.Item.FindControl("in_Up_Title") as TextBox ).Text;
         ArticleX.artText = ( e.Item.FindControl("in_Up_Text") as TextBox ).Text;

         Entries.SaveChanges();
         EntryList.EditItemIndex = -1;
         UpdateList();
      }

      protected void EntryList_EditCommand(object source, DataListCommandEventArgs e) {
         EntryList.EditItemIndex = e.Item.ItemIndex;
         UpdateList();
      }

      protected void EntryList_CancelCommand(object source, DataListCommandEventArgs e) {
         EntryList.EditItemIndex = -1;
         UpdateList();
      }
   }
}