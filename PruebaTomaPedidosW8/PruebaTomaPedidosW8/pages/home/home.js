(function () {
    "use strict";

    WinJS.UI.Pages.define("/pages/home/home.html", {
        // This function is called whenever a user navigates to this page. It
        // populates the page elements with the app's data.
        ready: function (element, options) {

            WinJS.Namespace.define("Events", {
                login: login
            });

            function login() {
                var user = $('#user-input').val().toLowerCase();
                var pass = $('#password-input').val();

                WinJS.xhr({
                    url: configuration.baseHost + '/login/Authenticate?user=' + user + '&password=' + pass,
                    type: "GET",
                    responseType: "json",
                    headers: configuration.defaultHeader
                }).then(function complete(data) {
                    if (data.status == 200) {
                        configuration.securityToken = data.responseText;
                        WinJS.Navigation.navigate("/pages/main/main.html");
                    } else {
                        //ver que hacer 
                    }
                },
                function error(e) {
                },
                function progress(p) {
                });

            }
        }
    });
})();
