var directionsDisplay;
var directionsService = new google.maps.DirectionsService();
directionsDisplay = new google.maps.DirectionsRenderer();
var map;


function codeAddress() {
var from=document.getElementById("Fromaddress").value;
var to=document.getElementById("Toaddress").value;
var fromLatLong = getLatLong(from);
var toLatLong = getLatLong(to);
PlotPoints(fromLatLong ,toLatLong);
}

function getLatLong(GeoValue)
{
	if(GeoValue!=null)
	{
		var geocoder = new google.maps.Geocoder();
		geocoder.geocode( { 'address': GeoValue}, function(results, status) {
    		if (status == google.maps.GeocoderStatus.OK) {
		      map.setCenter(results[0].geometry.location);
		      var marker = new google.maps.Marker({
		          map: map,
		          position: results[0].geometry.location
	        });
		} else {
	      alert('Geocode was not successful for the following reason: ' + status);
	    }
  });
	}
}


function PlotPoints(from,to)
{
  
var request = {
    origin:from,
    destination:to,
    travelMode: google.maps.TravelMode[DRIVING]
  };
  directionsService.route(request, function(result, status) {
    if (status == google.maps.DirectionsStatus.OK) {
      directionsDisplay.setDirections(result);
    }
  });
}

google.maps.event.addDomListener(window, 'load', initialize);
