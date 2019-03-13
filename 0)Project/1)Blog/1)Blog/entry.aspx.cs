using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _1_Blog {
   public partial class entry : System.Web.UI.Page {
      protected void Page_Load(object sender, EventArgs e) {
         UpdateList();
      }

      private void UpdateList() {
         BlogEntities Entries = new BlogEntities();
         EntryList.DataSource = Entries.Articles.ToList();
         EntryList.DataBind();
      }

      protected void articleadd(object sender, EventArgs e) {
         BlogEntities Entries = new BlogEntities();
         Article Articles = new Article();
         Articles.artAuthor = in_author.Text;
         Articles.artDate = DateTime.Now;
         Articles.artTitle = in_title.Text;
         Articles.artText = in_text.Text.ToString();
         
         Entries.Articles.Add(Articles);
         Entries.SaveChanges();
         UpdateList();
      }
   }
}