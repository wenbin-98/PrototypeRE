using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PrototypeSAD.Controllers
{
    public class ERDController : Controller
    {
        // GET: ERDController
        public ActionResult Index()
        {
            return View();
        }

        // GET: ERDController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ERDController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ERDController/Create
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

        // GET: ERDController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ERDController/Edit/5
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

        // GET: ERDController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ERDController/Delete/5
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
