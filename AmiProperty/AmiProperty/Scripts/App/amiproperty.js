// ensures that the nav-bar does not overlap the body of the document 
 $(document).ready(function(){
    	var padding = $('#myNavBar').height() + 25;
        $(document.body).css('padding-top', padding);
        $(window).resize(function(){
            $(document.body).css('padding-top', padding);
        });
    });


