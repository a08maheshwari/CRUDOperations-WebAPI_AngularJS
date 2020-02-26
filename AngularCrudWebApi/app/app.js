var EmpApp = angular.module('EmpApp', ['ngRoute', 'EmpControllers']);
EmpApp.config(['$routeProvider', function ($routeProvider) {
    $routeProvider.when('/list',
    {
        templateUrl: 'Employee/list.html',
        controller: 'ListController'
    }).
    when('/create',
    {
        templateUrl: 'Employee/Edit.html',
        controller: 'EditController'
    }).
    when('/edit/:id',
    {
        templateUrl: 'Employee/Edit.html',
        controller: 'EditController'
    }).
    when('/delete/:id',
    {
        templateUrl: 'Employee/Delete.html',
        controller: 'DeleteController'
    }).
    otherwise(
    {
        redirectTo: '/list'
    });
}]);