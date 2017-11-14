/// <reference path="/Assets/admin/libs/angular/angular.js" />
(function () {
    angular.module('jejeShop.statistics', ['jejeShop.common']).config(config);

    config.$inject = ['$stateProvider', '$urlRouterProvider'];

    function config($stateProvider, $urlRouterProvider) {
        $stateProvider
            .state('statistic_revenue', {
                url: "/statistic_revenue",
                parent: 'base',
                templateUrl: "/app/components/Statistics/revenueStatisticView.html",
                controller: "revenueStatisticController"
            });
    }
})();