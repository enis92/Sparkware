using System.Web.Mvc;

namespace Sparkware.Models {
    public class UserModelBinder : DefaultModelBinder {
        protected override void OnModelUpdated(ControllerContext controllerContext, ModelBindingContext bindingContext) {
            base.OnModelUpdated(controllerContext, bindingContext);

            controllerContext.Controller.TempData["model"] = bindingContext.Model;
        }
    }
}