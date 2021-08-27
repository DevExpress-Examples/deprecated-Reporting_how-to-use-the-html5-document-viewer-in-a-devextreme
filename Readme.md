<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128596766/17.1.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T370591)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [app.config.js](./CS/BasicDevExtremeApp/app.config.js) (VB: [app.config.js](./VB/BasicDevExtremeApp/app.config.js))
* [index.html](./CS/BasicDevExtremeApp/index.html) (VB: [index.html](./VB/BasicDevExtremeApp/index.html))
* [viewer.css](./CS/BasicDevExtremeApp/views/viewer.css)
* [viewer.html](./CS/BasicDevExtremeApp/views/viewer.html) (VB: [viewer.html](./VB/BasicDevExtremeApp/views/viewer.html))
* **[viewer.js](./CS/BasicDevExtremeApp/views/viewer.js) (VB: [viewer.js](./VB/BasicDevExtremeApp/views/viewer.js))**
* [WebDocumentViewerController.cs](./CS/ReportingBackend/Controllers/WebDocumentViewerController.cs) (VB: [WebDocumentViewerController.vb](./VB/ReportingBackend/Controllers/WebDocumentViewerController.vb))
* [Global.asax.cs](./CS/ReportingBackend/Global.asax.cs) (VB: [Global.asax.vb](./VB/ReportingBackend/Global.asax.vb))
* [CustomReportResolver.cs](./CS/ReportingBackend/Services/CustomReportResolver.cs) (VB: [CustomReportResolver.vb](./VB/ReportingBackend/Services/CustomReportResolver.vb))
<!-- default file list end -->
# How to use the HTML5 Document Viewer in a DevExtreme application


<p>This example illustrates how to integrate the <a href="https://documentation.devexpress.com/#XtraReports/CustomDocument17738">HTML5 Document Viewer</a> into a <a href="http://js.devexpress.com/">DevExtreme</a>-based Single Page Application project.<br> <br>This example consists of two projects.<br>1. Frontend - a DevExtreme project that includes all necessary styles, scripts and HTML-templates required by the Document Viewer.<br>2. Backend - an ASP.NET MVC 5 application. At the backend, cross-domain requests are enabled (Access-Control-Allow-Origin) and a custom report storage is implemented.<br><br>For a step-by-step tutorial, refer to the following document: <a href="https://documentation.devexpress.com/XtraReports/119331/Creating-End-User-Reporting-Applications/Web-Reporting/Using-Reporting-Controls-in-JS/Document-Viewer-Integration-into-a-DevExtreme-application">Document Viewer Integration into a DevExtreme application</a>.<br><br>To learn about the previous implementation (prior to version <strong>16.1.9</strong>), watch the following webinar video online: <a href="https://www.youtube.com/watch?v=ltXkBXFr0M4">DevExpress Reports in Client-Side Web Apps</a>.<br><br><strong>See also:<br></strong><a href="https://www.devexpress.com/Support/Center/p/T505059">How to use the Web Report Designer within a DevExtreme application</a></p>


<h3>Description</h3>

In this example, all necessary client resources are downloaded and installed in advance using Bower (<a href="https://bower.io/docs/api/">https://bower.io/docs/api/</a>).<br>To download a required Web Document Viewer&nbsp;version (e.g., <strong>17.1.3</strong>), specify this version in bower.json or install it using the following command:<br><em>bower install xtrareportsjs#17.1.3&nbsp; </em><br><br><strong>Note:</strong> <br>Some modules may not be downloaded (or downloaded incorrectly) on a machine that does not have Git (<a href="https://git-scm.com/">https://git-scm.com/</a>) installed on it. In this example, all client resources are downloaded and installed in advance.<br><br>
<p>The "<strong>Restore Bower packages</strong>" operation in Visual Studio may be executed incorrectly if the downloaded version is different from the last one.</p>
<p>This is a known issue on part of Visual Studio (<a href="https://github.com/aspnet/Tooling/issues/575">https://github.com/aspnet/Tooling/issues/575</a>) and we recommend that you use the solution provided in the following article: <a href="http://stackoverflow.com/questions/37584520/bootstrap-3-3-6-jquery-2-2-4-version-exception/38460014#38460014">http://stackoverflow.com/questions/37584520/bootstrap-3-3-6-jquery-2-2-4-version-exception/38460014#38460014</a>.</p>

<br/>


