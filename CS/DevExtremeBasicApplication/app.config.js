// NOTE object below must be a valid JSON
window.DevExtremeBasicApplication = $.extend(true, window.DevExtremeBasicApplication, {
    "config": {
        "layoutSet": "desktop",
        "navigation": [
            {
                title: "Home",
                onExecute: "#home",
                icon: "home"
            },
            {
                title: "About",
                onExecute: "#about",
                icon: "info"
            },
            {
                title: "Reports",
                onExecute: "#reports",
                icon: "reports"
            }
        ]
    }
});