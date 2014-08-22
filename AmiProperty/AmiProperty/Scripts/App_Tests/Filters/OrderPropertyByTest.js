describe('Order Property By Test', function () {
    'use strict';

    var Filter;

    //load the filters module
    beforeEach(module('amiproperty.filters'));

    // load filter function into variable
    beforeEach(inject(function ($filter) {
        Filter = $filter('orderPropertyBy');
    }));

    //data source for the tests
    var properties = [];
    var prop1 = { "Address": { "HouseNumber": "23", "Street": "Fraser Avenue", "Town": "Dumbarton", "Area": "West Dunbartonshire", "Country": "Scotland", "PostCode": "G82 3LS", "Latitude": "12", "Longitude": "12", "Id": 1000 }, "Images": [{ "Id": 1009, "PropertyId": 1000, "ImageUrl": "http://media.rightmove.co.uk/63k/62846/43547401/62846_414236_IMG_00_0000.jpg", "IsCoverImage": true }, { "Id": 1010, "PropertyId": 1000, "ImageUrl": "http://li.zoocdn.com/5716aacd88be4a4e14c344d8d21b11ce001fed10_645_430.jpg", "IsCoverImage": false }], "Status": { "DisplayOrder": 1, "DisplayName": "for sale", "Id": 1000 }, "Type": { "DisplayOrder": 1, "DisplayName": "flat", "Id": 1000 }, "Title": "Davie", "Price": 160000.0000, "StatusId": 1000, "TypeId": 1000, "AddressId": 1000, "Summary": "Great Property in secluded area.", "FullDescription": "FD 1", "Available": true, "Id": 1000 };
    var prop2 = { "Address": { "HouseNumber": "23", "Street": "Fraser Avenue", "Town": "Dumbarton", "Area": "Glasgow", "Country": "Scotland", "PostCode": "G82 3LS", "Latitude": "12", "Longitude": "12", "Id": 1000 }, "Images": [{ "Id": 1009, "PropertyId": 1000, "ImageUrl": "http://media.rightmove.co.uk/63k/62846/43547401/62846_414236_IMG_00_0000.jpg", "IsCoverImage": true }, { "Id": 1010, "PropertyId": 1000, "ImageUrl": "http://li.zoocdn.com/5716aacd88be4a4e14c344d8d21b11ce001fed10_645_430.jpg", "IsCoverImage": false }], "Status": { "DisplayOrder": 1, "DisplayName": "for sale", "Id": 1000 }, "Type": { "DisplayOrder": 1, "DisplayName": "flat", "Id": 1000 }, "Title": "Lauren", "Price": 100000.0000, "StatusId": 1000, "TypeId": 1000, "AddressId": 1000, "Summary": "Great Property in secluded area.", "FullDescription": "FD 2", "Available": true, "Id": 1000 };

    properties.push(prop1);
    properties.push(prop2);

    var result = [];

    //Test 1
    it('should order the properties alphabetically ', function () {
        // Arrange.
        var alphabetical = { name: 'Alphabetical', value: 'Title,false' };

        // Act
        result = Filter(properties, alphabetical.value);

        // Assert
        expect(result.length).toEqual(2);
        expect(result[0].Title).toEqual('Davie');
    });

    //Test 2
    it('should order the properties by price desc ', function () {
        // Arrange.
        var highPrice = { name: 'Price - Highest', value: 'Price,true' };

        //Act
        result = Filter(properties, highPrice.value);

        //Assert
        expect(result.length).toEqual(2);
        expect(result[0].Title).toEqual('Davie');

    });

    //Test 3
    it('should order the properties by price asc ', function () {
        // Arrange.
        var lowPrice = { name: 'Price - Lowest', value: 'Price,false' };

        //Act
        result = [];
        result = Filter(properties, lowPrice.value);

        // Assert
        expect(result.length).toEqual(2);
        expect(result[0].Title).toEqual('Lauren');
    });

    
});