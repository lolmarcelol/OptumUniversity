(function () {
    var app = angular.module('app', []);

    app.controller('MyController', ['$scope', '$http', function ($scope, $http) {

        $scope.filtra = function (value) {
            if ($scope.sortType === value) {
                $scope.sortType = "-" + value;
                return;
            }
            $scope.sortType = value;
        }

        $http.get('http://localhost:54472/Professor/IndexJson').
            then(function (response) {
                $scope.professores = response.data;
            });
    }]);
})();