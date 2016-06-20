using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Webdeveloper.DataAccess;
using WebDeveloper.Model;

namespace WebDeveloper.Controllers
{
    public class ProductController : Controller
    {
        private ProductData _produt = new ProductData();

        public ActionResult Index()
        {
            return View(_produt.GetList());
        }
        // GET: Create Product
        public ActionResult Create()
        {
            return View(new Product());
        }

        [HttpPost]
        public ActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                _produt.Add(product);
                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult Edit(int id)
        {
            return View(_produt.getProductById(id));
        }

        [HttpPost]
        public ActionResult Edit(Product product)
        {
            if (ModelState.IsValid)
            {
                _produt.Update(product);
                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult Delete(int id)
        {
            var product = _produt.getProductById(id);
            if (product == null)
            {
                return RedirectToAction("Index");

            }
            return View(product);
        }
        [HttpPost]
        public ActionResult Delete(Product product)
        {
            if (_produt.Delete(product) > 0)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}