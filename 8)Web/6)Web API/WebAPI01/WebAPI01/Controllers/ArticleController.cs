using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI01.Models.DTO;
using WebAPI01.Models.ORM;

namespace WebAPI01.Controllers {
    public class ArticleController : ApiController {
        [Route("list")]
        public List<ArticleDTO> GetAllArticle() {

            return (new Cord().Articles.Select(m => new ArticleDTO() {
                ArticleID = m.artID,
                ArticleTitle = m.artTitle,
                ArticleContext = m.artText,
                ArticleIMG = m.artImage
            })).ToList();
        }

        [Route("list/{id}")]
        public ArticleDTO GetArticle(int id) {
            var temp = new Cord().Articles.Find(id);
            return new ArticleDTO() {
                ArticleID = temp.artID,
                ArticleTitle = temp.artTitle,
                ArticleContext = temp.artText,
                ArticleIMG = temp.artImage
            };
        }
    }
}
