DevExtremeBasicApplication.reports = function (params, viewInfo) {
    "use strict";

    var id = params.id,
		viewerModel = ko.observable(null),
		selectedReport = ko.observable(""),
		backendPrefix = 'http://localhost:55755/',
        useWebApiController = ko.observable(false);
    var availableReports = [{ value: 'MVCViewerWidgetDemo.Reports.OrdersReport', text: 'OrdersReport' }, { value: 'MVCViewerWidgetDemo.Reports.ProductsReport', text: 'ProductsReport' }];
    var callbacks = {
        //customizeParameterEditors: function(parameter, info) { },
        //customizeActions: function(actions) { }
    };
    function setViewerBackendUri(webApiController) {
        DevExpress.Report.Preview.HandlerUri = backendPrefix + (webApiController ? 'api/WebDocumentViewerWebApi' : 'WebDocumentViewer/CustomInvoke');
    }
    useWebApiController.subscribe(setViewerBackendUri);
    setViewerBackendUri(useWebApiController());

    function openReportClick(e) {
        selectedReport() && viewerModel() && viewerModel().reportPreview.openReport(selectedReport());
    }

    return {
        id: id,
        callbacks: callbacks,
        viewerModel: viewerModel,
        selectedReport: selectedReport,
        reportList: availableReports,
        webApiController: useWebApiController,
        openReportClick: openReportClick,
    };
};