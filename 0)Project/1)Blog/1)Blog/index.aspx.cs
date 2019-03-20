using System;
using System.Linq;
using System.Web.UI.WebControls;

namespace _1_Blog {
   public partial class index : System.Web.UI.Page {
      protected int loadthis = 0;

      protected void Page_Load(object sender, EventArgs e) {
         BlogEntities Cord = new BlogEntities();

         PostRepeater.DataSource = Cord.Articles
            .OrderByDescending(temp => temp.artID)
            .ToList();
         PostRepeater.DataBind();

         CategoriesList.DataSource = Cord.Categories
            .ToList();
         CategoriesList.DataBind();

         Last5Post.DataSource = Cord.Articles
            .OrderByDescending(temp => temp.artID).ToList().Take(5);
         Last5Post.DataBind();
      }
   }
}