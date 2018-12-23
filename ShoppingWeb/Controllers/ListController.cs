using ShoppingWeb.Models;
using ShoppingWeb.ShoppingAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShoppingWeb.Controllers
{
    public class ListController : Controller
    {
        // GET: List
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(List l)
        {
            ShoppingClient sc = new ShoppingClient();
            bool value;
            value = sc.CreateNewList(l.ListName, (Guid.Parse(Session["userId"].ToString())));
            if (value)
                return RedirectToAction("List", "Home", new { userId = (Guid.Parse(Session["userId"].ToString())) });
            else
                return View();
        }

        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add(ListProduct l, string id)
        {
            ShoppingClient sc = new ShoppingClient();
            bool value;
            value = sc.AddProductToList(l.ProductName, Guid.Parse(id));
            if (value)
                return RedirectToAction("ListDetail", "Home", new { id = (Guid.Parse(id)) });
            else
                return View();
        }
        [HttpPost]
        public ActionResult Sync(ProductModel products)
        {
            Dictionary<Guid, bool> p = new Dictionary<Guid, bool>();
            foreach (var item in products.Product)
            {
                p.Add(item.ProductId, item.IsBought);
            }
            ShoppingClient sc = new ShoppingClient();
            Guid id = new Guid();
            id = products.Product[1].ListId;
            bool value = false;
            value = sc.Sync(p, id);

            return View();


        }
        public ActionResult Delete(string userId, string listId)
        {
            ShoppingClient sc = new ShoppingClient();
            bool value;
            value = sc.DeleteList(Guid.Parse(listId), Guid.Parse(userId));
            return RedirectToAction("List", "Home");
        }

    }
}