(function () {
    "use strict";
    angular
        .module("commonservice", [])
        .constant("appSettings",
        {
            serverPath: "http://localhost:52203"
        });
}())