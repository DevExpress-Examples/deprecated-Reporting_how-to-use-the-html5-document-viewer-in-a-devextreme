using System.Web.Mvc;
using System.Web.Routing;
using DevExpress.XtraReports.Web.WebDocumentViewer;
using ReportingBackend.Services;

namespace ReportingBackend {
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            DefaultWebDocumentViewerContainer.Register<IWebDocumentViewerReportResolver, CustomReportResolver>();
        }
    }
}
