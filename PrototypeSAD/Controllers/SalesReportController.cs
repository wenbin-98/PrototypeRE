using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace PrototypeSAD.Controllers
{
    public class SalesReportController : Controller
    {
        // GET: SalesReportController
        public ActionResult Index()
        {
            return View();
        }

        // GET: SalesReportController/Details/5
        public FileResult Download(int id)
        {
            string fileName = "sales report.pdf";
            //Build the File Path.
            string path = Path.Combine(Environment.CurrentDirectory, "wwwroot/", "Files/") + fileName;

            //Read the File data into Byte Array.
            byte[] bytes = System.IO.File.ReadAllBytes(path);

            //Send the File to Download.
            return File(bytes, "application/octet-stream", fileName);
        }

        // GET: SalesReportController/Details/5
        public FileResult GetReport(int id)
        {
            string fileName = "sales report.pdf";
            //Build the File Path.
            string path = Path.Combine(Environment.CurrentDirectory, "wwwroot/", "Files/") + fileName;

            //Read the File data into Byte Array.
            byte[] bytes = System.IO.File.ReadAllBytes(path);

            //Send the File to Download.
            return File(bytes, "application/pdf");
        }

        // GET: SalesReportController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SalesReportController/Create
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

        // GET: SalesReportController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SalesReportController/Edit/5
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

        // GET: SalesReportController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SalesReportController/Delete/5
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
