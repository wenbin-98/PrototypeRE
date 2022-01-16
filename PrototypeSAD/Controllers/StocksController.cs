using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrototypeSAD.Controllers
{
    public class StocksController : Controller
    {
        // GET: StocksController
        public ActionResult Index()
        {
            return View();
        }

        // GET: StocksController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: StocksController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StocksController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                TempData["Create"] = true;
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: StocksController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: StocksController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                TempData["Edit"] = true;
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: StocksController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: StocksController/Delete/5
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
