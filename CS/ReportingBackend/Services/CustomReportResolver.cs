using System;
using System.Linq;
using System.Collections.Generic;
using DevExpress.XtraReports.UI;
using DevExpress.XtraReports.Web.WebDocumentViewer;

namespace ReportingBackend.Services {
    class ReportInfo {
        public string DisplayName { get; set; }
        public Func<XtraReport> GetReport { get; set; }
    }
    public class CustomReportResolver : IWebDocumentViewerReportResolver {
        Dictionary<string, ReportInfo> reports = new Dictionary<string, ReportInfo>();

        public CustomReportResolver() {
            reports.Add("ordersReport", new ReportInfo {
                DisplayName = "Orders Report",
                GetReport = () => new OrdersReport()
            });
            reports.Add("categoriesReport", new ReportInfo {
                DisplayName = "Categories Report",
                GetReport = () => new CategoriesReport()
            });
            reports.Add("shapeReport", new ReportInfo {
                DisplayName = "Shapes Report",
                GetReport = () => new ShapeReport()
            });
        }
        
        XtraReport IWebDocumentViewerReportResolver.Resolve(string reportEntry) {
            ReportInfo reportInfo;
            if(!string.IsNullOrEmpty(reportEntry) && reports.TryGetValue(reportEntry, out reportInfo))
                return reportInfo.GetReport.Invoke();
            return null;
        }

        // Get the list of available reports from the server.
        public Dictionary<string, string> GetAvailableReports() {
            return reports.ToDictionary(r => r.Key, r => r.Value.DisplayName);
        }


    }
}