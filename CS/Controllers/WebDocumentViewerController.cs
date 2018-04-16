using System.Web.Mvc;
using DevExpress.Web.Mvc.Controllers;

namespace MVCViewerWidgetDemo.Controllers {
    public class WebDocumentViewerController : WebDocumentViewerApiController {
        public ActionResult CustomInvoke() {
            var result = base.Invoke();
            Response.AppendHeader("Access-Control-Allow-Origin", "*");
            return result;
        }
    }
}