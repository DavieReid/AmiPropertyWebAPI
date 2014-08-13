//get all properties controller
angular.module('amiproperty').controller('PropertiesController',
    function ($scope, MyProperties) {

        $scope.data = {};
        $scope.data.propertyTypes = [];
        $scope.data.propertyAreas = [];

        MyProperties.query(function (response) {

            $scope.data.properties = response;
        })
            .$promise.then(function () {

                SetupSelectBoxes($scope.data.properties,
                                 $scope.data.propertyTypes,
                                 $scope.data.propertyAreas)
            });

        $scope.orderOptions = [{ name: 'Alphabetical', value: 'Title,false' },
                                { name: 'Price - Highest', value: 'Price,true' },
                                { name: 'Price - Lowest', value: 'Price,false' }, ];

        $scope.orderProp = $scope.orderOptions[0].value;
    });


//property details controller
angular.module('amiproperty').controller('PropertyDetailsController',
    function ($scope, $routeParams, MyProperties) {

        $scope.data = {};

        MyProperties.get({ Id: $routeParams.Id }, (function (response) {
            $scope.data.propertyDetails = response;
            $scope.data.mainImageUrl = response.Images[0].ImageUrl;
        }));

        $scope.setImage = function (imageUrl) {
            $scope.data.mainImageUrl = imageUrl;
        }
    });

//populate the scope with the data used for the filter select boxes
function SetupSelectBoxes(properties, types, areas) {
    properties.forEach(function (property) {
        types.push({ name: property.Type.DisplayName });
        areas.push({ name: property.Address.Area });
    });
}
