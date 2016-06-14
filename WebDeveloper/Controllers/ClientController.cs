using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Webdeveloper.DataAccess;

namespace WebDeveloper.Controllers
{
    public class ClientController : Controller
    {
        // GET: Client
        public ActionResult Index()
        {
            var client = new ClientData();
            return View(client.GetList());
        }

        //DBContext.- Administra la clase.
    }
}