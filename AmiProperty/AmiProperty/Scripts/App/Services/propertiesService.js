angular.module('amiproperty.services')
    .factory('MyProperties', function ($resource) {
        return $resource('/api/properties/:id');

});