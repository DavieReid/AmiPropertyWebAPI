angular.module('amiproperty.filters', [])
    .filter('propertyTypeFilter', function () {
        return function (properties, type) {
            if (!type) { return properties; }
            var filtered = [];

            angular.forEach(properties, function (property) {
                if (property.Type.DisplayName === type.name) {
                    filtered.push(property);
                }
            });
            return filtered;
        };
    });

angular.module('amiproperty.filters')
    .filter('propertyAreaFilter', function () {
        return function (properties, area) {
            if (!area) { return properties; }
            var filtered = [];

            angular.forEach(properties, function (property) {
                if (property.Address.Area === area.name) {
                    filtered.push(property);
                }
            });
            return filtered;
        };
    });


//reverse = false means ascending
angular.module('amiproperty.filters')
    .filter('orderPropertyBy', function () {
        return function (items, selectedOrder) {

            var filtered = [];
            //convert the list of objects to an array so that it can be ordered
            angular.forEach(items, function (item) {
                filtered.push(item);
            });

            //the selectedOrder will be in the form fieldname,true/false e.g. Title,false
            var orderPropArray = selectedOrder.toString().split(',');
            var myfield = orderPropArray[0];
            var reverse = orderPropArray[1] === 'true';

            filtered.sort(function (a, b) {
                return (a[myfield] > b[myfield] ? 1 : -1);
            });
            if (reverse) filtered.reverse();
            return filtered;
        };
    });

