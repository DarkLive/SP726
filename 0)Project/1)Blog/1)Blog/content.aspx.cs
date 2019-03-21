using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _1_Blog {
   public partial class content : Page {
      protected void Page_Load(object sender, EventArgs e) {
         string getitem = Request.QueryString.ToString();
         BlogEntities Cord = new BlogEntities();

         CategoriesList.DataSource = Cord.Categories.ToList();
         CategoriesList.DataBind();

         Last5Post.DataSource = Cord.Articles.ToList()
            .OrderByDescending(temp => temp.artID)
            .Where(temp => temp.artActive == true).Take(5);
         Last5Post.DataBind();

         if ( getitem.Contains("cat") ) {
            int that = Convert.ToInt32(getitem.Remove(0, 3));
            CategoryRepeater.DataSource = Cord.Rel_Article_Category.ToList()
               .Where(temp => temp.relCatID == that)
               .Take(10);
            CategoryRepeater.DataBind();
            CategoryRepeater.Visible = true;
         }
         else if ( getitem.Contains("art") ) {
            int that = Convert.ToInt32(getitem.Remove(0, 3));
            PostRepeater.DataSource = Cord.Articles.ToList()
               .Where(temp => temp.artID == that);
            PostRepeater.DataBind();
            PostRepeater.Visible = true;
         }
         else {
            errorcode.Visible = true;
         }
      }
   }
}