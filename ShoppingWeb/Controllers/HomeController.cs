using AutoMapper;
using ShoppingWeb.Models;
using ShoppingWeb.ShoppingAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShoppingWeb.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult LogIn()
        {
            return View();
        }
        [HttpPost]
        public ActionResult LogIn(User loginData)
        {

            ShoppingClient sc = new ShoppingClient();
            Session["userId"] = sc.Login(loginData.Login, loginData.Password).ToString();
            if (Session["userId"].ToString() != "00000000-0000-0000-0000-000000000000")
            {
                return RedirectToAction("List", new { userId = (Guid.Parse(Session["userId"].ToString())) });
            }
            else
                return View();
        }
        public ActionResult List(Guid? userId)
        {
            if (userId == null)
                userId = Guid.Parse(Session["userId"].ToString());
            ShoppingClient sc = new ShoppingClient();
            List<ListUser> list = new List<ListUser>();
            list = sc.GetUserList((Guid)userId);



            return View(list);
        }
        public ActionResult LogOut()
        {
            Session.Abandon();

            return RedirectToAction("Index");
        }
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(Register user)
        {

            if (ModelState.IsValid)
            {

                ShoppingClient sc = new ShoppingClient();
                bool value;
                value = sc.Register(user.login, user.email, user.password);
                return RedirectToAction("LogIn");
            }
            else
            {
                return View();
            }


        }

        public ActionResult ListDetail(string id)
        {
            List<ListProduct> l = new List<ListProduct>();

            ShoppingClient sc = new ShoppingClient();
            l = sc.GetProductsFromList((Guid.Parse(id))).ToList();
            Mapper.CreateMap<ListProduct, Product>();
            List<Product> list = Mapper.Map<List<ListProduct>, List<Product>>(l);
            ProductModel p = new ProductModel();
            p.Product = list;
            ViewBag.ListId = id;
            return View(p);
        }
        [AllowAnonymous]
        public JsonResult IsLoginAlredyExist(string login)
        {
            ShoppingClient sc = new ShoppingClient();
            return Json(!sc.CheckLoginIsExist(login), JsonRequestBehavior.AllowGet);
        }
        [AllowAnonymous]
        public JsonResult IsEmailAlredyExist(string email)
        {
            ShoppingClient sc = new ShoppingClient();
            return Json(!sc.CheckEmailIsExist(email), JsonRequestBehavior.AllowGet);
        }


    }
}