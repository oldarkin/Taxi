var ContactPage = function () {

    return {
        
    	//Basic Map
        initMap: function () {
			var map;
			$(document).ready(function(){
			  map = new GMaps({
				div: '#map',
				scrollwheel: false,				
				lat: 53.255651,
				lng: 50.190369
			  });
			  
			  var marker = map.addMarker({
			      lat: 53.255651,
			      lng: 50.190369,
	            title: 'Company, Inc.'
		       });
			});
        },

        //Panorama Map
        initPanorama: function () {
		    var panorama;
		    $(document).ready(function(){
		      panorama = GMaps.createPanorama({
		          lat: 53.255651,
		          lng: 50.190369
		      });
		    });
		}        

    };
}();