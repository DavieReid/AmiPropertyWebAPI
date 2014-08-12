//define a module for some services.  
angular.module('amiproperty.services', ['ngResource']);

angular.module('amiproperty.services')
    .factory('MyProperties', function ($resource) {
        return $resource('/api/properties/:id');

});