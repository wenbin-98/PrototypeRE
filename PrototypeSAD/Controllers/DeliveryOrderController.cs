using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrototypeSAD.Controllers
{
    public class DeliveryOrderController : Controller
    {
        // GET: DeliveryOrderController
        public ActionResult Index()
        {
            return View();
        }

        // GET: DeliveryOrderController/Details/5
        public ActionResult Details(int id)
        {
            if(id == 1)
            {
                TempData["Create"] = true;

            }
            if(id == 2)
            {
                TempData["Edit"] = true;

            }
            return View();
        }

        // GET: DeliveryOrderController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DeliveryOrderController/Create
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

        // GET: DeliveryOrderController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DeliveryOrderController/Edit/5
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

        // GET: DeliveryOrderController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DeliveryOrderController/Delete/5
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
