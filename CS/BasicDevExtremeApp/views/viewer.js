BasicDevExtremeApp.viewer = function (params) {
    "use strict";

    var viewerModel = ko.observable(null);
    var reportList = ko.observable(null);
    var reportListPlaceholder = ko.observable("Report List is Loading...");

    var currentReport = ko.observable(null);
    currentReport.subscribe(function (newVal) {
        newVal && viewerModel() && viewerModel().reportPreview.openReport(newVal);
    });

    var backendPrefix = "http://localhost:1992/";// URI of your backend project.
    DevExpress.Report.Preview.HandlerUri = backendPrefix + "WebDocumentViewer/Invoke";

    $.post(backendPrefix + "WebDocumentViewer/GetReportList")
        .done(function (response) {
            reportListPlaceholder("Select a report...");
            reportList(response);
        })
        .fail(function (error) {
            reportListPlaceholder("No reports to show...");
        });

    var viewModel = {
        viewerModel: viewerModel,   //An output parameter for the dxReportViewer binding.  
        // This object provides client API to customize the Web Document Viewer.
        callbacks: {},  // An input parameter for the dxReportViewer binding.  
        // Use this object to customize specific Web Document Viewer callbacks.
        reportListPlaceholder: reportListPlaceholder,
        reportList: reportList,
        currentReport: currentReport
    };
    return viewModel;
};