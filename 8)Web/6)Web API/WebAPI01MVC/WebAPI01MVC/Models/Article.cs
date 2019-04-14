using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI01MVC.Models {
    public class Article {
        public int ArticleID { get; set; }
        public string ArticleTitle { get; set; }
        public string ArticleContext { get; set; }
        public string ArticleIMG { get; set; }
    }
}