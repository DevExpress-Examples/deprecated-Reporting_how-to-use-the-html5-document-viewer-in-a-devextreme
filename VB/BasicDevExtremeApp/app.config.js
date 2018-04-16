// NOTE object below must be a valid JSON
window.BasicDevExtremeApp = $.extend(true, window.BasicDevExtremeApp, {
    "config": {
        "layoutSet": "navbar",
        "navigation": [
          {
              "title": "Home",
              "onExecute": "#home",
              "icon": "home"
          },
          {
              "title": "Viewer",
              "onExecute": "#viewer",
              "icon": "info"
          }
        ]
    }
});