(function () {

    function routeConfig($routeProvider) {
        $routeProvider.when("/todoitem", {
            controller: "TodoItem",
            templateUrl: "/app/todoitem/todoitem.html"
        }); 
    }

    angular
       .module('app.todoitem').config(routeConfig);

})();