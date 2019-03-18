//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Web;
//using System.Web.UI;
//using System.Web.UI.WebControls;

//namespace _1_Blog {
//   public partial class entry : Page {
//      protected void Page_Load(object sender, EventArgs e) {
//         if ( IsPostBack ) return;
//         UpdateList(AuthorList);
//         UpdateList(ArticleList);
//         UpdateAuthCombo();
//      }

//      private void UpdateList(DataList e) {
//         BlogEntities Entries = new BlogEntities();

//         if ( e.ID == "AuthorList" ) { e.DataSource = Entries.Authors.ToList(); UpdateList(ArticleList); }
//         if ( e.ID == "ArticleList" ) e.DataSource = Entries.ListEntriesWithAuthorNames.ToList();
//         e.DataBind();
//      }

//      private void UpdateAuthCombo() {
//         BlogEntities Entries = new BlogEntities();
//         in_author.DataSource = Entries.Authors.ToList();
//         in_author.DataTextField = "autName";
//         in_author.DataValueField = "autID";
//         in_author.DataBind();
//      }

//      protected void authoradd(object sender, EventArgs e) {
//         Author AuthorX = new Author() {
//            autName = in_authname.Text
//         };

//         BlogEntities Entries = new BlogEntities();
//         Entries.Authors.Add(AuthorX);
//         Entries.SaveChanges();
//         UpdateAuthCombo();
//         UpdateList(AuthorList);
//      }

//      protected void articleadd(object sender, EventArgs e) {
//         string filepath = "";
//         if ( !( in_articlepic.PostedFile == null ) ) {
//            filepath = $"imgs/article/{DateTime.Today.ToString("dd-MM-yyyy")}-{Guid.NewGuid().ToString().Replace("-", "")}-{in_articlepic.FileName}";
//            in_articlepic.SaveAs(Server.MapPath("~/" + filepath));
//         }
//         Article ArticleX = new Article() {
//            artAuthor = Convert.ToInt32(in_author.SelectedValue),
//            artDate = DateTime.Now,
//            artTitle = in_title.Text,
//            artText = in_text.Text.ToString(),
//            artImg = filepath
//         };

//         BlogEntities Entries = new BlogEntities();
//         Entries.Articles.Add(ArticleX);
//         Entries.SaveChanges();
//         UpdateList(ArticleList);
//      }

//      protected void EntryList_DeleteCommand(object source, DataListCommandEventArgs e) {
//         BlogEntities Entries = new BlogEntities();
//         Article ArticleX = Entries.Articles.Find(Convert.ToInt32(e.CommandArgument));
//         Entries.Articles.Remove(ArticleX);
//         Entries.SaveChanges();
//         UpdateList(ArticleList);
//      }

//      protected void EntryList_UpdateCommand(object source, DataListCommandEventArgs e) {
//         BlogEntities Entries = new BlogEntities();
//         Article ArticleX = Entries.Articles.Find(Convert.ToInt32(e.CommandArgument));
//         var temp = ( e.Item.FindControl("in_Up_Author") as DropDownList ).SelectedValue;
//         ArticleX.artAuthor = Convert.ToInt32( temp );
//         ArticleX.artDate = DateTime.Now;
//         ArticleX.artTitle = ( e.Item.FindControl("in_Up_Title") as TextBox ).Text;
//         ArticleX.artText = ( e.Item.FindControl("in_Up_Text") as TextBox ).Text;

//         Entries.SaveChanges();
//         ArticleList.EditItemIndex = -1;
//         UpdateList(ArticleList);
//      }

//      protected void EntryList_EditCommand(object source, DataListCommandEventArgs e) {
//         ArticleList.EditItemIndex = e.Item.ItemIndex;
//         UpdateList(ArticleList);
//      }

//      protected void EntryList_CancelCommand(object source, DataListCommandEventArgs e) {
//         ArticleList.EditItemIndex = -1;
//         UpdateList(ArticleList);
//      }

//      protected void AuthorList_DeleteCommand(object source, DataListCommandEventArgs e) {
//         BlogEntities Entries = new BlogEntities();
//         Author AuthorX = Entries.Authors.Find(Convert.ToInt32(e.CommandArgument));
//         Entries.Authors.Remove(AuthorX);
//         Entries.SaveChanges();
//         UpdateList(AuthorList);
//      }

//      protected void AuthorList_UpdateCommand(object source, DataListCommandEventArgs e) {
//         BlogEntities Entries = new BlogEntities();
//         Author AuthorX = Entries.Authors.Find(Convert.ToInt32(e.CommandArgument));
//         AuthorX.autName = ( e.Item.FindControl("in_Up_AuthorName") as TextBox ).Text;

//         Entries.SaveChanges();
//         AuthorList.EditItemIndex = -1;
//         UpdateList(AuthorList);
//      }

//      protected void AuthorList_EditCommand(object source, DataListCommandEventArgs e) {
//         AuthorList.EditItemIndex = e.Item.ItemIndex;
//         UpdateList(AuthorList);
//      }

//      protected void AuthorList_CancelCommand(object source, DataListCommandEventArgs e) {
//         AuthorList.EditItemIndex = -1;
//         UpdateList(AuthorList);
//      }

//      protected void in_Up_Author_Load(object sender, EventArgs e) {
//         BlogEntities Entries = new BlogEntities();
//         ( (DropDownList)sender ).DataSource = Entries.Authors.ToList();
//         ( (DropDownList)sender ).DataTextField = "autName";
//         ( (DropDownList)sender ).DataValueField = "autID";
//         ( (DropDownList)sender ).DataBind();
//      }
//   }

//}