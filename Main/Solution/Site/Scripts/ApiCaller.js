$(document).ready(function () {
    var vechileTypes = $('#vt');
    $.getJSON("/api/GreenBoxApi/GetAllVehicleTypes").
        done(function (data) {
            $.each(data, function (key, item) {
                alert("Value retrieved: Index - " + key + " with id : " + item.Id + " and value : "+ item.Description);
            });
        });
});