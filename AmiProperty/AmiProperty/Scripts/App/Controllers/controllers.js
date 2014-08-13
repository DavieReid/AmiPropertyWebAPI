angular.module('amiproperty')
    .config(function ($routeProvider, $locationProvider, $httpProvider) {

        $routeProvider.when('/home',
        {
            templateUrl: 'home.html'
        });

        $routeProvider.when('/about',
        {
            templateUrl: 'about.html'
        });

        $routeProvider.when('/contact',
        {
            templateUrl: 'contact.html'
        });

        $routeProvider.when('/properties',
        {
            controller: 'PropertiesController',
            templateUrl: 'properties.html'
        });

        $routeProvider.when('/properties/:Id',
        {
            controller: 'PropertyDetailsController',
            templateUrl: 'property-detail.html'
        });

        $routeProvider.when('/rent',
        {
            templateUrl: 'rentals.html'
        });

        $routeProvider.otherwise(
        {
            redirectTo: '/home'
        }
      );
    });

//navigation controller
angular.module('amiproperty').controller('NavCtrl',
['$scope', '$location', function ($scope, $location) {
    $scope.navClass = function (page) {
        var currentRoute = $location.path().substring(1) || 'home';
        return page === currentRoute ? 'active' : '';
    };

    $scope.loadHome = function () {
        $location.url('/home');
    };

    $scope.loadAbout = function () {
        $location.url('/about');
    };

    $scope.loadProperties = function () {
        $location.url('/properties');
    };

    $scope.loadContact = function () {
        $location.url('/contact');
    };

}]);

//scroll the page back to the top when the link at the footer is clicked
angular.module('amiproperty').controller('BackTopCtrl', function ($scope, $location, $anchorScroll) {
    $scope.scrollTo = function (id) {
        $location.hash(id);
        console.log($location.hash());
        $anchorScroll();
    };
});

//scroll to the latest news
angular.module('amiproperty').controller('LatestNewsCtrl', function ($scope, $location, $anchorScroll) {
    $scope.scrollTo = function (id) {
        $location.hash(id);
        console.log($location.hash());
        $anchorScroll();
    };
});

angular.module('amiproperty').controller('ModalCtrl', function ($scope, $modal) {

    $scope.open = function (templateName) {

        templateToUse = 'landlord_template.html';
        if (templateName === 'tenant') {
            templateToUse = 'tenant_template.html';
        }

        var modalInstance = $modal.open({
            templateUrl: templateToUse,
            controller: ModalInstanceCtrl
        });
    };
});

var ModalInstanceCtrl = function ($scope, $modalInstance) {
    $scope.close = function () {
        $modalInstance.dismiss('close');
    };
};


