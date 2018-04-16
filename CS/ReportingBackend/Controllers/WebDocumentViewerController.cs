using System.Linq;
using System.Web.Mvc;
using System.Web.Routing;
using DevExpress.Web.Mvc.Controllers;
using ReportingBackend.Services;

namespace ReportingBackend.Controllers {
    public class WebDocumentViewerController : WebDocumentViewerApiController {
        #region WebDocumentViewer Overrides
        // This action processes each request from the Web Document Viewer.
        public override ActionResult Invoke() {
            Response.AddHeader("Access-Control-Allow-Origin", "*");// Allow cross-domain requests.
            return base.Invoke();
        }
        #endregion

        // Create an action to provide the Web Document Viewer with available reports.
        public ActionResult GetReportList() {
            var reports = new CustomReportResolver().GetAvailableReports().ToArray();
            Response.AddHeader("Access-Control-Allow-Origin", "*");// Allow cross-domain requests.
            return new JsonResult() { ContentType = "application/json", Data = reports };
        }
    }
}