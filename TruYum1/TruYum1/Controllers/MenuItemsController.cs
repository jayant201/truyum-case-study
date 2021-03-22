using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TruYum1.Models;

namespace TruYum1.Controllers
{
    public class MenuItemsController : Controller
    {
        // GET: MenuItems
        TruYumContext db = new TruYumContext();
        // GET: MenuItems
        public ActionResult Index()
        {
            return View(db.MenuItems.ToList());
        }
        public ActionResult Create()
        {
            var list = db.Categories.ToList();
            ViewBag.Catagory = list;
            return View();
        }
        [HttpPost]
        public ActionResult Create(MenuItem menuItem)
        {
            if (ModelState.IsValid)
            {
                db.MenuItems.Add(menuItem);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                var list = db.Categories.ToList();
                ViewBag.Catagory = list;
                return View();
            }
        }
    }
}