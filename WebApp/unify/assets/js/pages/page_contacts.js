var ContactPage = function () {

    return {
        
    	//Basic Map
        initMap: function () {
			var map;
			$(document).ready(function(){
			  map = new GMaps({
				div: '#map',
				scrollwheel: false,				
				lat: 53.232535,
				lng: 50.240036
			  });
			  
			  var marker = map.addMarker({
			      lat: 53.232535,
			      lng: 50.240036,
	            title: 'Company, Inc.'
		       });
			});
        },

        //Panorama Map
        initPanorama: function () {
		    var panorama;
		    $(document).ready(function(){
		      panorama = GMaps.createPanorama({
		          lat: 53.232535,
		          lng: 50.240036
		      });
		    });
		}        

    };
}();