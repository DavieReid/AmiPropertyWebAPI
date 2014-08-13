describe('Property Area Filter Test', function () {
    'use strict';

    var propertyAreaFilter;

    //load the filters module
    beforeEach(module('amiproperty.filters'));

    // load filter function into variable
    beforeEach(inject(function ($filter) {
        propertyAreaFilter = $filter('propertyAreaFilter');
    }));

    
    it('should return a property with an area of Glasgow', function () {
        // Arrange.
        var area = { name: "Glasgow" }; //area is an object that has a name property
        var result = []; //the filter returns an array

        //add 2 properties, 1 flat, 1 mansion
        var properties = [];
        var prop1 = {"Address":{"HouseNumber":"23","Street":"Fraser Avenue","Town":"Dumbarton","Area":"West Dunbartonshire","Country":"Scotland","PostCode":"G82 3LS","Latitude":"12","Longitude":"12","Id":1000},"Images":[{"Id":1009,"PropertyId":1000,"ImageUrl":"http://media.rightmove.co.uk/63k/62846/43547401/62846_414236_IMG_00_0000.jpg","IsCoverImage":true},{"Id":1010,"PropertyId":1000,"ImageUrl":"http://li.zoocdn.com/5716aacd88be4a4e14c344d8d21b11ce001fed10_645_430.jpg","IsCoverImage":false}],"Status":{"DisplayOrder":1,"DisplayName":"for sale","Id":1000},"Type":{"DisplayOrder":1,"DisplayName":"flat","Id":1000},"Title":"Davie","Price":160000.0000,"StatusId":1000,"TypeId":1000,"AddressId":1000,"Summary":"Great Property in secluded area.","FullDescription":"FD 1","Available":true,"Id":1000};
        var prop2 = {"Address":{"HouseNumber":"23","Street":"Fraser Avenue","Town":"Dumbarton","Area":"Glasgow","Country":"Scotland","PostCode":"G82 3LS","Latitude":"12","Longitude":"12","Id":1000},"Images":[{"Id":1009,"PropertyId":1000,"ImageUrl":"http://media.rightmove.co.uk/63k/62846/43547401/62846_414236_IMG_00_0000.jpg","IsCoverImage":true},{"Id":1010,"PropertyId":1000,"ImageUrl":"http://li.zoocdn.com/5716aacd88be4a4e14c344d8d21b11ce001fed10_645_430.jpg","IsCoverImage":false}],"Status":{"DisplayOrder":1,"DisplayName":"for sale","Id":1000},"Type":{"DisplayOrder":1,"DisplayName":"flat","Id":1000},"Title":"Davie","Price":160000.0000,"StatusId":1000,"TypeId":1000,"AddressId":1000,"Summary":"Great Property in secluded area.","FullDescription":"FD 2","Available":true,"Id":1000};

        properties.push(prop1);
        properties.push(prop2);

        // Act.
        result = propertyAreaFilter(properties, area);

        // Assert.
        expect(result.length).toEqual(1);
        expect(result[0].Address.Area).toEqual('Glasgow');
    });
});