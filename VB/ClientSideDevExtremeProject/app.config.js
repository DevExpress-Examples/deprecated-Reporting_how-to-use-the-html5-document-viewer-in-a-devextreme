// NOTE object below must be a valid JSON
window.ClientSideDevExtremeProject = $.extend(true, window.ClientSideDevExtremeProject, {
    "config": {
        "layoutSet": "navbar",
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
                title: "Viewer",
                onExecute: "#viewer",
                icon: "viewer"
            }
        ]
    }
});