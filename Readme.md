<!-- default file list -->
*Files to look at*:

* [RouteConfig.cs](./CS/App_Start/RouteConfig.cs) (VB: [RouteConfig.vb](./VB/App_Start/RouteConfig.vb))
* [WebApiConfig.cs](./CS/App_Start/WebApiConfig.cs) (VB: [WebApiConfig.vb](./VB/App_Start/WebApiConfig.vb))
* [WebDocumentViewerController.cs](./CS/Controllers/WebDocumentViewerController.cs) (VB: [WebDocumentViewerController.vb](./VB/Controllers/WebDocumentViewerController.vb))
* [WebDocumentViewerWebApiController.cs](./CS/Controllers/WebDocumentViewerWebApiController.cs) (VB: [WebDocumentViewerWebApiController.vb](./VB/Controllers/WebDocumentViewerWebApiController.vb))
* [app.config.js](./CS/DevExtremeBasicApplication/app.config.js) (VB: [app.config.js](./VB/DevExtremeBasicApplication/app.config.js))
* [bower.json](./CS/DevExtremeBasicApplication/bower.json) (VB: [bower.json](./VB/DevExtremeBasicApplication/bower.json))
* [index.html](./CS/DevExtremeBasicApplication/index.html) (VB: [index.html](./VB/DevExtremeBasicApplication/index.html))
* [reports.html](./CS/DevExtremeBasicApplication/views/reports.html) (VB: [reports.html](./VB/DevExtremeBasicApplication/views/reports.html))
* [reports.js](./CS/DevExtremeBasicApplication/views/reports.js) (VB: [reports.js](./VB/DevExtremeBasicApplication/views/reports.js))
* [Global.asax.cs](./CS/Global.asax.cs) (VB: [Global.asax.vb](./VB/Global.asax.vb))
* [CustomReportResolver.cs](./CS/Models/CustomReportResolver.cs) (VB: [CustomReportResolver.vb](./VB/Models/CustomReportResolver.vb))
<!-- default file list end -->
# How to use the HTML5 Document Viewer in a DevExtreme application


<p>This example illustrates how to integrate the <a href="https://documentation.devexpress.com/#XtraReports/CustomDocument17738">HTML5 Document Viewer</a> into a <a href="http://js.devexpress.com/">DevExtreme</a>-based Single Page Application project.<br> <br>This example consists of two projects.<br>1. Frontend - a DevExtreme project that includes all necessary styles, scripts and HTML-templates required by the Document Viewer.<br>2. Backend - an ASP.NET MVC 5 application. At the backend, cross-domain requests are enabled (Access-Control-Allow-Origin) and a custom report storage is implemented.<br><br>For a step-by-step tutorial, refer to the following document: <a href="https://documentation.devexpress.com/XtraReports/119331/Creating-End-User-Reporting-Applications/Web-Reporting/Using-Reporting-Controls-in-JS/Document-Viewer-Integration-into-a-DevExtreme-application">Document Viewer Integration into a DevExtreme application</a>.<br><br>To learn about the previous implementation (prior to version <strong>16.1.9</strong>), watch the following webinar video online: <a href="https://www.youtube.com/watch?v=ltXkBXFr0M4">DevExpress Reports in Client-Side Web Apps</a>.<br><br><strong>See also:<br></strong><a href="https://www.devexpress.com/Support/Center/p/T505059">How to use the Web Report Designer within a DevExtreme application</a></p>


<h3>Description</h3>

The DevExtreme front-end application provides all necessary third-party resources (globalize, cldr, knockout and jQuery) except for jQuery-ui and the Document Viewer's resources.<br><br>You can download all necessary client resources using Bower (<a href="https://bower.io/docs/api/">https://bower.io/docs/api/</a>).<br>To download a required HTML5 Document Viewer version (e.g., <strong>16.1.9</strong>), specify this version in bower.json or install it using the following command:<br><em>bower install xtrareportsjs#16.1.9</em><br>&nbsp;<br><strong>Note</strong>: <br>Some modules may not be downloaded (or downloaded incorrectly) on a machine that does not have Git (<a href="https://git-scm.com/">https://git-scm.com/</a>) installed on it. In this example, all client resources are downloaded and installed in advance.<br><br>
<p>The "<strong>Restore Bower packages</strong>" operation in Visual Studio may be executed incorrectly if the downloaded version is different from the last one (e.g., bower.json may define that version <strong>16.1</strong> is required instead of <strong>16.2</strong>).</p>
<p>This is a known issue on part of Visual Studio (<a href="https://github.com/aspnet/Tooling/issues/575">https://github.com/aspnet/Tooling/issues/575</a>) and we recommend that you use the solution provided in the following article: <a href="http://stackoverflow.com/questions/37584520/bootstrap-3-3-6-jquery-2-2-4-version-exception/38460014#38460014">http://stackoverflow.com/questions/37584520/bootstrap-3-3-6-jquery-2-2-4-version-exception/38460014#38460014</a>.</p>

<br/>


