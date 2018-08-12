var app = angular.module('myApp',[]);
app.controller("HomeController", function ($scope, $http) {
    debugger;
    $scope.students = [];
    $http(
        {
            method: 'GET',
            url: 'http://localhost:63879/api/values',
            headers: {
                'Content-Type': 'application/json',
                'Access-Control-Allow-Origin': true
            }
        }
    ).then(function (response) {
        debugger;
        $scope.students = response.data;
    });
    debugger;
        $scope.message = "my angular application with MVC";
});
app.controller("AddressController", function ($scope ) {
   
    $scope.message = "my angular application with MVC for address details";
});