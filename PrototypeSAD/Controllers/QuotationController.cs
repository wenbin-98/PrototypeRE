﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrototypeSAD.Controllers
{
    public class QuotationController : Controller
    {
        // GET: QuotationController
        public ActionResult Index()
        {
            return View();
        }

        // GET: QuotationController/Details/5
        public ActionResult Details(int id)
        {
            if (id == 1)
            {
                TempData["Create"] = true;

            }
            if (id == 2)
            {
                TempData["Edit"] = true;

            }
            return View();
        }

        // GET: QuotationController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: QuotationController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: QuotationController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: QuotationController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: QuotationController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: QuotationController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
