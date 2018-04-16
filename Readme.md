# How to use the HTML5 Document Viewer in a DevExtreme application


<p>This example illustrates how to integrate the <a href="https://documentation.devexpress.com/#XtraReports/CustomDocument17738">HTML5 Document Viewer</a> into a <a href="http://js.devexpress.com/">DevExtreme</a>-based Single Page Application project.<br> <br>This example consists of two projects.<br>1. Frontend - a DevExtreme project that includes all necessary styles, scripts and HTML-templates required by the Document Viewer.<br>2. Backend - an ASP.NET MVC 5 application. At the backend, cross-domain requests are enabled (Access-Control-Allow-Origin) and a custom report storage is implemented.<br><br>For a step-by-step tutorial, refer to the following document: <a href="https://documentation.devexpress.com/XtraReports/119331/Creating-End-User-Reporting-Applications/Web-Reporting/Using-Reporting-Controls-in-JS/Document-Viewer-Integration-into-a-DevExtreme-application">Document Viewer Integration into a DevExtreme application</a>.<br><br>To learn about the previous implementation (prior to version <strong>16.1.9</strong>), watch the following webinar video online: <a href="https://www.youtube.com/watch?v=ltXkBXFr0M4">DevExpress Reports in Client-Side Web Apps</a>.<br><br><strong>See also:<br></strong><a href="https://www.devexpress.com/Support/Center/p/T505059">How to use the Web Report Designer within a DevExtreme application</a></p>


<h3>Description</h3>

The front-end application downloads all necessary client libraries using Bower (<a href="https://bower.io/docs/api/">https://bower.io/docs/api/</a>) and NuGet.<br>It is required to execute the &ldquo;Restore Nuget packages&rdquo; command to download the necessary packages for both the back-end and front-end applications.<br>Next, it is required to install the necessary client modules using the following command from the root directory of a DevExtremeApp project.<br><em>bower install xtrareportsjs</em><br>Note: knockout and globalize modules are not downloaded with Bower if the machine does not have Git (<a href="https://git-scm.com/">https://git-scm.com/</a>) installed on it. In this example, they are downloaded and installed in advance.

<br/>


