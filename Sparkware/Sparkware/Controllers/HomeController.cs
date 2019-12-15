using Sparkware.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Sparkware.Controllers {
    public class HomeController : BaseController {
        private readonly IUsersManager usersManager;

        public HomeController(IUsersManager usersManager) {
            this.usersManager = usersManager;
        }

        [HttpGet]
        public ActionResult Index() {
            var users = usersManager.GetAllUsers();

            return View(users);
        }

        public ActionResult Edit(Guid? id) {
            if (!id.HasValue) {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var user = usersManager.GetUserById(id.Value);
            if (user == null) {
                return HttpNotFound();
            }

            return View("Save", user);
        }

        [HttpGet]
        public ActionResult Save() {
            return View();
        }

        [HttpPost]
        public ActionResult Save(DM.User user) {
            if (ModelState.IsValid) {

                throw new Exception("Username already taken!");

                usersManager.SaveUser(user);
                return RedirectToAction("Index");
            }

            return View(user);
        }

        public ActionResult About() {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact() {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}