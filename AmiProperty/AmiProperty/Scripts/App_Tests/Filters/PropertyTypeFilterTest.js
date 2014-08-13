describe('Property Type Filter Test', function () {
    'use strict';

    var propertyTypeFilter;

    //load the filters module
    beforeEach(module('amiproperty.filters'));

    // load filter function into variable
    beforeEach(inject(function ($filter) {
        propertyTypeFilter = $filter('propertyTypeFilter');
    }));
    


    it('should return a property with type of flat', function () {
        // Arrange.
        var type = { name: "flat" }; //type is an object that has a name property
        var result = []; //the filter returns an array

        //add 2 properties, 1 flat, 1 mansion
        var properties = [];
        var flat = {
            "Type": { "DisplayOrder": 1, "DisplayName": "flat", "Id": 1000 },
            "Title": "Davie", "Price": 160000.0000, "StatusId": 1000, "TypeId": 1000, "AddressId": 1000, "Summary": "Great Property in secluded area.",
            "FullDescription": "property 1 full description", "Available": true, "Id": 1000 };
        var mansion ={
            "Type": { "DisplayOrder": 3, "DisplayName": "mansion", "Id": 1002 },
            "Title": "Lauren", "Price": 342.0000, "StatusId": 1001, "TypeId": 1002, "AddressId": 1001, "Summary": "Test 2",
            "FullDescription": "property 2 full description", "Available": true, "Id": 1001
        };

        properties.push(flat);
        properties.push(mansion);
    
        // Act.
        result = propertyTypeFilter(properties, type);

        // Assert.
        expect(result.length).toEqual(1);
        expect(result[0].Type.DisplayName).toEqual('flat');
    });
});

