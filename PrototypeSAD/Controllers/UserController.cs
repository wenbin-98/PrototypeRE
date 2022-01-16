using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PrototypeRE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrototypeSAD.Controllers
{
    public class UserController : Controller
    {
        // GET: UserController
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login(int login)
        {
            if (login == 1)
            {
                ModelState.AddModelError("name", "Invalid Credentials");
            }
            return View();
        }

        [HttpPost]
        public ActionResult Login(IFormCollection collection, int login)
        {

            string username = collection["Email"];
            string password = collection["Password"];
            if (username != "admin@gmail.com" || password != "12345")
            {
                ModelState.AddModelError("name", "Invalid Credentials");
                return View();
            }

            HttpContext.Response.Cookies.Append("username", "a",
                new CookieOptions { Expires = DateTime.Now.AddDays(30) });

            return RedirectToAction("Index", "Home");
        }

        // GET: UserController/Details/5
        public ActionResult Details(int id)
        {
            ViewUserModel viewUserModel = new ViewUserModel();
            {
                viewUserModel.Username = "admin";
                viewUserModel.Name = "Manager";
                viewUserModel.Phone = "0167529609";
                viewUserModel.Address = "36, JLN KEBANGSAAN 22";
                viewUserModel.Address2 = "TMN UNIVERSITI";
                viewUserModel.Address3 = "81300 SKUDAI JOHOR";
            }
            return View(viewUserModel);
        }

        // GET: UserController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UserController/Create
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

        // GET: UserController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: UserController/Edit/5
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

        // GET: UserController/Delete/5
        public ActionResult Logout(int id)
        {
            HttpContext.Response.Cookies.Delete("username");
            return RedirectToAction("Login", "User");
        }

        // GET: UserController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: UserController/Delete/5
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
