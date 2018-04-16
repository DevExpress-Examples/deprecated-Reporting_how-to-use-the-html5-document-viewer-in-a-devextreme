using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DevExpress.XtraReports.UI;
using DevExpress.XtraReports.Web.WebDocumentViewer.Native.Services;

namespace MVCViewerWidgetDemo.Models {
    public class CustomReportResolver : WebDocumentViewerReportResolver {
        public override XtraReport Resolve(string reportTypeName) {
            var report = base.Resolve(reportTypeName);
            if(report == null) {
                switch(reportTypeName) {
                    case "MVCViewerWidgetDemo.Reports.OrdersReport":
                        report = new Reports.OrdersReport();
                        break;
                    case "MVCViewerWidgetDemo.Reports.ProductsReport":
                        report = new Reports.ProductsReport();
                        break;
                }
            }
            return report;
        }
    }
}