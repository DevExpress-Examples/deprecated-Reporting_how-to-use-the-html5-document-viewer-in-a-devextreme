using DevExpress.Web.Mvc.Controllers;
using DevExpress.XtraReports.Web.Extensions;
using System.Linq;
using System.Web.Mvc;

namespace ServerSide.Controllers {
    public class WebDocumentViewerController : WebDocumentViewerApiController {
        public override ActionResult Invoke() {
            var result = base.Invoke();
            // Allow cross-domain requests.
            Response.AppendHeader("Access-Control-Allow-Origin", "*");
            return result;
        }

        [HttpPost]
        public ActionResult GetReports() {
            Response.AppendHeader("Access-Control-Allow-Origin", "*");
            var result = new JsonResult {
                Data = ReportStorageWebService.GetUrls().ToArray()
            };
            return result;
        }
    }
}