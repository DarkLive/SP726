﻿using System;
using System.Linq;
using System.Web.UI.WebControls;

namespace _1_Blog {
   public partial class index : System.Web.UI.Page {
      protected int loadthis = 0;

      protected void Page_Load(object sender, EventArgs e) {
         BlogEntities Cord = new BlogEntities();

         sliderRepeaterCurrent.DataSource = Cord.Articles.ToList()
            .OrderByDescending(temp => temp.artID)
            .Where(temp => temp.artActive == true).Take(1);
         sliderRepeaterCurrent.DataBind();

         sliderRepeater.DataSource = Cord.Articles.ToList()
            .OrderByDescending(temp => temp.artID)
            .Where(temp => temp.artActive == true).Skip(1).Take(4);
         sliderRepeater.DataBind();

         CategoriesList.DataSource = Cord.Categories.ToList();
         CategoriesList.DataBind();

         Last5Post.DataSource = Cord.Articles.ToList()
            .OrderByDescending(temp => temp.artID)
            .Where(temp => temp.artActive == true).Take(5);
         Last5Post.DataBind();
      }
   }
}