using System.Web.Http;
using DevExpress.Web.Mvc;
using DevExpress.XtraReports.Web.Native.ClientControls;
using DevExpress.XtraReports.Web.WebDocumentViewer;
using DevExpress.XtraReports.Web.WebDocumentViewer.Native.Services;

namespace MVCViewerWidgetDemo.Controllers {
    public class WebDocumentViewerWebApiController : ApiController {
        readonly ManagerModuleSubscriber<IWebDocumentViewerRequestManager> requestProcessor;

        public WebDocumentViewerWebApiController() {
            requestProcessor = new ManagerModuleSubscriber<IWebDocumentViewerRequestManager>(DefaultWebDocumentViewerContainer.Current, "");
        }

        public void Get() {
            System.Web.HttpContext.Current.Response.AppendHeader("Access-Control-Allow-Origin", "*");
            requestProcessor.ProcessRequest();
        }

        public void Post() {
            System.Web.HttpContext.Current.Response.AppendHeader("Access-Control-Allow-Origin", "*");
            requestProcessor.ProcessRequest();
        }
    }
}