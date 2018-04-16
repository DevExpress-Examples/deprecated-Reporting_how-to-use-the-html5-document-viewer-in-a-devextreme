window.DevExtremeBasicApplication = window.DevExtremeBasicApplication || {};

$(function() {
    // Uncomment the line below to disable platform-specific look and feel and to use the Generic theme for all devices
    // DevExpress.devices.current({ platform: "generic" });
    // To customize the Generic theme, use the DevExtreme Theme Builder (http://js.devexpress.com/ThemeBuilder)
    // For details on how to use themes and the Theme Builder, refer to the http://js.devexpress.com/Documentation/Guide/#themes article

    $(document).on("deviceready", function () {
        navigator.splashscreen.hide();
        $(document).on("backbutton", function () {
            DevExpress.processHardwareBackButton();
        });
    });

    function onNavigatingBack(e) {
        if (e.isHardwareButton && !DevExtremeBasicApplication.app.canBack()) {
            e.cancel = true;
            exitApp();
        }
    }

    function exitApp() {
        switch (DevExpress.devices.real().platform) {
            case "android":
                navigator.app.exitApp();
                break;
            case "win":
                MSApp.terminateApp('');
                break;
        }
    }

    DevExtremeBasicApplication.app = new DevExpress.framework.html.HtmlApplication({
        namespace: DevExtremeBasicApplication,
        layoutSet: DevExpress.framework.html.layoutSets[DevExtremeBasicApplication.config.layoutSet],
        navigation: DevExtremeBasicApplication.config.navigation,
        mode: "webSite",
        commandMapping: DevExtremeBasicApplication.config.commandMapping
    });
    DevExtremeBasicApplication.app.router.register(":view/:id", { view: "home", id: undefined });
    DevExtremeBasicApplication.app.on("navigatingBack", onNavigatingBack);
    DevExtremeBasicApplication.app.navigate();
});
