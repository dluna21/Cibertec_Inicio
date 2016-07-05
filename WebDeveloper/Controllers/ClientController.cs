﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Webdeveloper.DataAccess;
using WebDeveloper.Model;

namespace WebDeveloper.Controllers
{
    public class ClientController : Controller
    {
        private ClientData _client;

        //Para la injeccion de dependencia es importante que la clase tenga un constructor
        public ClientController(ClientData client)
        {
            _client = client;
        }

        // GET: Client
        public ActionResult Index()
        {
            return View(_client.GetList());
        }
        public ActionResult Create()
        {
            return View(new Client());
        }

        public ActionResult Edit(int id)
        {
            return View(_client.getClientById(id));
        }
        //Permite diferenciar al enrutador que metodo create tomar.
        [HttpPost]
        public ActionResult Create(Client client)
        {
            if (ModelState.IsValid)
            {
                _client.Add(client);
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpPost]
        public ActionResult Edit(Client client)
        {
            if (ModelState.IsValid)
            {
                _client.Update(client);
                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult Delete(int id)
        {
            var client = _client.getClientById(id);
            if (client == null)
            {
                return RedirectToAction("Index");
            }

            return View(client);
        }

        [HttpPost]
        public ActionResult Delete(Client client)
        {
            //if (ModelState.IsValid)
            //{
            if (_client.Delete(client) > 0)
                return RedirectToAction("Index");
            //}
            return View();
        }
        //DBContext.- Administra la clase.
    }
}