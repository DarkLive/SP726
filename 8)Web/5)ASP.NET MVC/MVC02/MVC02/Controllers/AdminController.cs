using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC02.Models;

namespace MVC02.Controllers {
     public class AdminController : Controller {
          // GET: Admin
          public ActionResult Index() {
               return RedirectToAction("Account");
          }

          public ActionResult RoleCheckUp1() {
               //TODO THIS
               int temp = Convert.ToInt32(Session["LoggedInAs"]);
               return RedirectToAction("Index", "Blog");
               //var role = new DBEntities().Accounts.First(m => m.usrID == temp);


               //if (role.usrRole <= 1) Redirect("Blog");
          }

          [Route("Admin/Account")]
          public ActionResult AccountList() {
               RoleCheckUp1();
               return View(new DBEntities().Accounts.ToList());
          }

          [Route("Admin/Account/Details/{id}")]
          public ActionResult AccountDetails(int id) {
               RoleCheckUp1();
               return View(new DBEntities().Accounts.First(m => m.usrID == id));
          }

          [Route("Admin/Account/Remove/{id}")]
          public ActionResult AccountRemove(int? id) {
               RoleCheckUp1();
               return View(new DBEntities().Accounts.First(m => m.usrID == id));
          }

          [HttpPost]
          public bool AccRemove(int usrID) {
               RoleCheckUp1();
               DBEntities Cord = new DBEntities();
               Account acc = Cord.Accounts.FirstOrDefault(m => m.usrID == usrID);

               try {
                    if (System.IO.File.Exists(Server.MapPath("~/" + acc.usrImg)) && acc.usrImg != "img/content/user/defaultuser.png") {
                         System.IO.File.Move(Server.MapPath("~/" + acc.usrImg), Server.MapPath("~/" + acc.usrImg.Replace("img/content/user", "img/content/olduser")));
                         acc.usrImg = acc.usrImg.Replace("img/content/user", "img/content/olduser");
                    }
                    acc.usrRemoved = DateTime.Now;
                    Cord.SaveChanges();

                    Cord.Accounts.Remove(acc);
                    Cord.SaveChanges();
                    return true;
               } catch {
                    return false;
               }
          }

          [Route("Admin/Account/Edit/{id}")]
          public ActionResult AccountEdit(int id) {
               RoleCheckUp1();
               return View(new DBEntities().Accounts.First(m => m.usrID == id));
          }

          [HttpPost]
          public bool AccEdit(Account acc, HttpPostedFileBase usrpic) {
               RoleCheckUp1();
               try {
                    DBEntities Cord = new DBEntities();
                    Account cUser = Cord.Accounts.First(m => m.usrID == acc.usrID);
                    {
                         cUser.usrFullName = acc.usrFullName;
                         cUser.usrEmail = acc.usrEmail;
                         cUser.usrPassword = acc.usrPassword;
                         cUser.usrBirthDay = acc.usrBirthDay;
                         cUser.usrRole = acc.usrRole;
                    }

                    if (usrpic != null && usrpic.FileName != null && usrpic.FileName != "") {
                         if (cUser.usrImg != "img/content/user/defaultuser.png") System.IO.File.Delete(Server.MapPath("~/" + cUser.usrImg));
                         acc.usrImg = $"img/content/user/{DateTime.Now.ToString("dd.MM.yyyy")}_{Guid.NewGuid().ToString().Replace("-", "")}_{usrpic.FileName}";
                         usrpic.SaveAs(Server.MapPath("~/" + acc.usrImg));
                    }

                    if (cUser.usrImg != acc.usrImg && acc.usrImg != "img/content/user/defaultuser.png") {
                         cUser.usrImg = acc.usrImg;
                    }

                    if (cUser.usrActive == false && acc.usrActive == true) {
                         if (System.IO.File.Exists(Server.MapPath("~/" + cUser.usrImg)) && cUser.usrImg != "img/content/user/defaultuser.png") {
                              System.IO.File.Move(Server.MapPath("~/" + acc.usrImg), Server.MapPath("~/" + acc.usrImg.Replace("img/content/olduser", "img/content/user")));
                              cUser.usrImg = acc.usrImg.Replace("img/content/olduser", "img/content/user");
                         }
                         cUser.usrRemoved = null;
                    } else if (cUser.usrActive == true && acc.usrActive == false) {
                         if (System.IO.File.Exists(Server.MapPath("~/" + cUser.usrImg)) && cUser.usrImg != "img/content/user/defaultuser.png") {
                              System.IO.File.Move(Server.MapPath("~/" + acc.usrImg), Server.MapPath("~/" + acc.usrImg.Replace("img/content/user", "img/content/olduser")));
                              cUser.usrImg = acc.usrImg.Replace("img/content/user", "img/content/olduser");
                         }
                         cUser.usrRemoved = DateTime.Now;
                    } else if (cUser.usrActive == false && acc.usrActive == false) {
                         if (System.IO.File.Exists(Server.MapPath("~/" + cUser.usrImg)) && cUser.usrImg != "img/content/user/defaultuser.png") {
                              System.IO.File.Move(Server.MapPath("~/" + acc.usrImg), Server.MapPath("~/" + acc.usrImg.Replace("img/content/user", "img/content/olduser")));
                              cUser.usrImg = acc.usrImg.Replace("img/content/user", "img/content/olduser");
                         }
                    }
                    cUser.usrActive = acc.usrActive;

                    Cord.SaveChanges();
                    return true;
               } catch {
                    return false;
               }
          }

          [Route("Admin/Article")]
          public ActionResult ArticleList() {
               RoleCheckUp1();
               return View(new DBEntities().Articles.ToList());
          }

          [Route("Admin/Article/Create")]
          public ActionResult ArticleCreate() {
               RoleCheckUp1();
               return View(new Article());
          }

          [HttpPost]
          public bool ArtCreate(Article art, HttpPostedFileBase artpic, int[] selectedCat) {
               RoleCheckUp1();
               try {
                    art.artPublishDate = DateTime.Now; art.artUpdateDate = art.artPublishDate; art.artWriter = Convert.ToInt32(Session["LoggedInAs"]);
                    art.artImage = $"img/content/article/{DateTime.Now.ToString("dd.MM.yyyy")}_{Guid.NewGuid().ToString().Replace("-", "")}_{artpic.FileName}";
                    artpic.SaveAs(Server.MapPath("~/" + art.artImage));

                    {
                         DBEntities Cord = new DBEntities();
                         Cord.Articles.Add(art);
                         Cord.SaveChanges();
                    }

                    if (selectedCat != null)
                         foreach (var item in selectedCat) {
                              Rel_Article_Category rel = new Rel_Article_Category();
                              rel.relArtID = art.artID;
                              rel.relCatID = item;
                              DBEntities Cord = new DBEntities();
                              Cord.Rel_Article_Category.Add(rel);
                              Cord.SaveChanges();
                         }

                    return true;
               } catch { return false; }
          }

          [Route("Admin/Article/Details/{id}")]
          public ActionResult ArticleDetails(int id) {
               RoleCheckUp1();
               return View(new DBEntities().Articles.First(m => m.artID == id));
          }

          [Route("Admin/Article/Edit/{id}")]
          public ActionResult ArticleEdit(int id) {
               RoleCheckUp1();
               return View(new DBEntities().Articles.First(m => m.artID == id));
          }

          [HttpPost]
          public bool ArtEdit(Article art, HttpPostedFileBase artpic) {
               RoleCheckUp1();
               try {
                    DBEntities Cord = new DBEntities();
                    Article cArticle = Cord.Articles.First(m => m.artID == art.artID);
                    {
                         cArticle.artTitle = art.artTitle;
                         cArticle.artText = art.artText;
                         cArticle.artUpdateDate = DateTime.Now;
                    }

                    if (artpic != null && artpic.FileName != null && artpic.FileName != "") {
                         if (cArticle.artImage != "img/content/user/defaultuser.png") System.IO.File.Delete(Server.MapPath("~/" + cArticle.artImage));
                         art.artImage = $"img/content/article/{DateTime.Now.ToString("dd.MM.yyyy")}_{Guid.NewGuid().ToString().Replace("-", "")}_{artpic.FileName}";
                         artpic.SaveAs(Server.MapPath("~/" + art.artImage));
                    }

                    Cord.SaveChanges();
                    return true;
               } catch { return false; }
          }

          [Route("Admin/Article/Remove/{id}")]
          public ActionResult ArticleRemove(int id) {
               RoleCheckUp1();
               return View(new DBEntities().Articles.First(m => m.artID == id));
          }

          [HttpPost]
          public bool ArtRemove(int artID) {
               RoleCheckUp1();
               try {
                    DBEntities Cord = new DBEntities();
                    Article cArt = Cord.Articles.First(m => m.artID == artID);

                    Cord.Articles.Remove(cArt);
                    Cord.SaveChanges();
                    return true;
               } catch { return false; }
          }

          [Route("Admin/Category")]
          public ActionResult CategoryList() {
               RoleCheckUp1();
               return View(new DBEntities().Categories.ToList());
          }

          [Route("Admin/Category/Create")]
          public ActionResult CategoryCreate() {
               RoleCheckUp1();
               return View(new Category());
          }

          public bool CatCreate(Category cat) {
               RoleCheckUp1();
               try {
                    DBEntities Cord = new DBEntities();
                    Cord.Categories.Add(cat);
                    Cord.SaveChanges();
                    return true;
               } catch { return false; }
          }

          [Route("Admin/Category/Edit/{id}")]
          public ActionResult CategoryEdit(int id) {
               RoleCheckUp1();
               return View(new DBEntities().Categories.First(m => m.catID == id));
          }

          public bool CatEdit(Category cat) {
               RoleCheckUp1();
               try {
                    DBEntities Cord = new DBEntities();
                    Category cCat = Cord.Categories.First(m => m.catID == cat.catID);
                    { cCat.catName = cat.catName; }

                    Cord.SaveChanges();
                    return true;
               } catch { return false; }
          }
     }
}