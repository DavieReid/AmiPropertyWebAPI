/*define the ami property angular modules*/
//define the main amiProperty module.
angular.module('amiproperty', ['ngRoute', 'ngAnimate', 'ui.utils', 'ui.bootstrap', 'amiproperty.services', 'amiproperty.filters']);

//module for the property filters.
angular.module('amiproperty.filters', []);

//module for querying the database.  
angular.module('amiproperty.services', ['ngResource']);

// ensures that the nav-bar does not overlap the body of the document 
 $(document).ready(function(){
    	var padding = $('#myNavBar').height() + 25;
        $(document.body).css('padding-top', padding);
        $(window).resize(function(){
            $(document.body).css('padding-top', padding);
        });
    });


