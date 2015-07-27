(function () {
     
    function routeConfig($routeProvider) { 
        $routeProvider.otherwise({ redirectTo: "/todoitem" });
    }

    angular.module('app').config(routeConfig);

})();
