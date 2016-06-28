using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Webdeveloper.DataAccess;
using WebDeveloper.ActionFilters;
using WebDeveloper.Model;

namespace WebDeveloper.Controllers
{
    [LogActionFilter]
    [RoutePrefix("Razor")]
    public class RazorController : Controller
    {
        // GET: Razor
        [Route] //Toma la accion definida
        public ActionResult Index()
        {

            //var client = new Client() { ID = 1, LastName = "Cueva", Name = "Aladino" };
            var clients = new List<Client>() {
                new Client() {ID=1,LastName="Cueva", Name="Aladino"},
                new Client() {ID=2,LastName="Reyna", Name="Jordy"},
                new Client() {ID=3,LastName="Trauco", Name="Diego"},
                new Client() {ID=4,LastName="Lopez", Name="Fernando"},
            };
            return View(clients);
        }

        public ActionResult Product()
        {
            var product = new ProductData();
            return View(product.GetFakeProducts());
        }

        [Route("Entry/{id:int}")]
        public string EntryId(int id)
        {
            return id.ToString();
        }

        [Route("Entry/{date:DateTime}")]
        public ActionResult EntryDate(DateTime? date) {
            ViewBag.Date = date.Value.ToShortDateString();
            return View();     
        }
        
    }
}