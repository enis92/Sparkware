using Sparkware.Models;
using System;
using System.Web.Mvc;

namespace Sparkware.Controllers {
    public class BaseController : Controller {
        public const string DefaultErrorMessage = "An error occured on the server. Don't worry, it's not you fault. A programmer will suffer.";

        public BaseController() {
            RedirectToAction("Index", "Home");
        }

        public RedirectResult HomeRedirect {
            get { return new RedirectResult(Url.Action("Index", "Home")); }
        }

        protected override IAsyncResult BeginExecuteCore(AsyncCallback callback, object state) {
            return base.BeginExecuteCore(callback, state);
        }

        public ActionResult Error() {
            var errorMessage = ((TempData.ContainsKey("error") ? TempData["error"] : null) ?? string.Empty).ToString();
            var model = new Error(errorMessage);

            return View("DefaultError", model);
        }

        protected override void OnException(ExceptionContext filterContext) {
            base.OnException(filterContext);

            filterContext.ExceptionHandled = true;

            string errorMessage = filterContext.Exception.Message;

            if (filterContext.HttpContext.Request.IsAjaxRequest()) {
                filterContext.Result = new JsonResult {
                    Data = new { Success = false, Error = errorMessage },
                    JsonRequestBehavior = JsonRequestBehavior.AllowGet
                };
            }
            else
                filterContext.Result = ShowError(errorMessage, (string)filterContext.RouteData.Values["action"], filterContext.Controller.TempData["model"]);
        }

        private ActionResult ShowError(string message, string action, object model) {
            if (string.IsNullOrWhiteSpace(message))
                message = DefaultErrorMessage;

            if (TempData.ContainsKey("error"))
                TempData["error"] = message;
            else TempData.Add("error", message);

            TempData[Alerts.ERROR] = message;

            if (model is DM.User) {
                return RedirectToAction("Edit", new { ((DM.User)model).Id });
            }
            else {
                return RedirectToAction(action, model);
            }
        }
    }
}