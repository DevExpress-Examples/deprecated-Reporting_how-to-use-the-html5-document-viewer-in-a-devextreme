(function onLoad() {
    var promises = $("script[type='text/html']").map(function(_, script) {
        if(script.src) {
            var deffered = $.Deferred();
            $.get(script.src, function(tmpl) {
                script.text = tmpl;
                if(tmpl.indexOf('type="text/html"') !== -1 || tmpl.indexOf("type='text/html'") !== -1) {
                    $(document.body).append(tmpl);
                }
                deffered.resolve();
            })
            return deffered.promise();
        }
    });

    $.when.apply($.when, promises).done(function() {
        initViewer();
    });
    function initViewer() {
        var backendPrefix = 'http://localhost:55755/',
        dxxrdViewerElement = $('.dx-designer')[0],
        toolbarElement = $('.custom-toolbar')[0],
        useWebApiController = ko.observable(false);
        function getHandlerUri(webApiController) {
            return backendPrefix + (webApiController ? 'api/WebDocumentViewerWebApi' : 'WebDocumentViewer/CustomInvoke');
        }
        useWebApiController.subscribe(function(webApiController) {
            DevExpress.Report.Preview.HandlerUri = getHandlerUri(webApiController);
        });
        var viewerModel = { handlerUri: getHandlerUri(useWebApiController()) };
        //var callbacks = {
        //customizeParameterEditors: function(parameter, info) { },
        //customizeActions: function(actions) { }
        //};
        var availableReports = [
            { value: 'MVCViewerWidgetDemo.Reports.OrdersReport', text: 'OrdersReport' },
            { value: 'MVCViewerWidgetDemo.Reports.ProductsReport', text: 'ProductsReport' }
        ];
        var previewModel = DevExpress.Report.Preview.createAndInitPreviewModel(viewerModel, dxxrdViewerElement/*, callbacks*/);
        ko.applyBindings({ previewModel: previewModel, selectedReport: ko.observable(""), reportList: availableReports, webApiController: useWebApiController }, toolbarElement);
    }
})()