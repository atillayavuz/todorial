(function () {
    'use strict';

    angular
        .module('app.todoitem')
        .controller('TodoItem', TodoItem);

    TodoItem.$inject = ['$scope'];

    function TodoItem($scope) {
        $scope.title = "Create new todo item";
    } 
})();