using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using WebAPI01MVC.Models;

namespace WebAPI01MVC.Controllers {
    public class ArticleController : Controller {
        // GET: Article
        [Route("")]
        public ActionResult Index() {
            var Client = new HttpClient() {
                BaseAddress = new Uri("http://webapitest.egeeturan.com"),
            };
            Client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage resp = Client.GetAsync("list").Result;

            if (resp.IsSuccessStatusCode) {
                return View(resp.Content.ReadAsAsync<List<Article>>().Result);
            }
            else {
                return View();
            }
        }

        [Route("Show")]
        public ActionResult Show() {
            return View();
        }

        [HttpPost]
        [Route("Show")]
        public ActionResult Show(int id) {
            var Client = new HttpClient() {
                BaseAddress = new Uri("http://webapitest.egeeturan.com/"),
            };
            Client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage resp = Client.GetAsync("list/" + id).Result;

            if (resp.IsSuccessStatusCode) {
                return View(resp.Content.ReadAsAsync<Article>().Result);
            }
            else {
                return View(new Article() { ArticleIMG = "Cant find any article with this id" });
            }
        }
    }
}