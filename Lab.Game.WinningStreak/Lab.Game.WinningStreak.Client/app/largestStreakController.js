(function (module) {
    "use strict";
    function largestStreakController(resource) {
        var vm = this;
        vm.errorMessage = "";
        vm.success = false;

        vm.throw = function (throws) {
            resource.getResult(throws)
                .then(function (response) {
                    vm.largestStreak = response.data;
                    vm.success = true;
                }, function (err) {
                    vm.errorMessage = err.statusText;
                    vm.success = false;
                    vm.largestStreak = "";
                });

        }
        vm.onChange = function () {
            vm.largestStreak = "";
            vm.success = false;
        }
    }

    module.controller("largestStreakController", ["gamesResource", largestStreakController]);

}(angular.module("games")));