/// <reference path="/Assets/admin/libs/angular/angular.js" />

(function () {
    angular.module('jejeShop',
        ['jejeShop.products',
         'jejeShop.product_categories',
         'jejeShop.common'])
        .config(config);

    config.$inject = ['$stateProvider', '$urlRouterProvider'];

    function config($stateProvider, $urlRouterProvider) {
        $stateProvider.state('home', {
            url: "/admin",
            templateUrl: "/app/components/home/homeView.html",
            controller: "homeController"
        });
        $urlRouterProvider.otherwise('/admin');
    }
})();