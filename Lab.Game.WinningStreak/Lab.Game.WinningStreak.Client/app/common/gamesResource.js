(function () {
    "use strict";
    function gamesResource(appSettings, $http) {
        var result = function (throws) {
            var resp = $http({
                url: appSettings.serverPath + "/api/games/largestwinningstreak/" + throws,
                method: "GET"
            });
            return resp;
        };
        return {
            getResult: result
        };

    }

    angular.module("commonservice")
        .factory("gamesResource", ["appSettings", "$http", gamesResource]);
}());