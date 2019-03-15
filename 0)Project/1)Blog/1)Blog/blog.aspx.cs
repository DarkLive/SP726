using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _1_Blog {
   public partial class index : System.Web.UI.Page {
      protected void Page_Load(object sender, EventArgs e) {
         BlogEntities Entries = new BlogEntities();

         var temp = Entries.Articles.SqlQuery("SELECT * FROM Article INNER JOIN Author ON Article.artAuthor = Author.autID").Last();
      
         {
            con_Image.ImageUrl = temp.artImg;
            con_Author.InnerText = temp.Author.autName;
            con_Title.InnerText = temp.artTitle;
            con_Date.InnerText = temp.artDate.ToString("dd/MM/yyyy");
            con_Text.InnerText = temp.artText;
         }
      }
   }
}