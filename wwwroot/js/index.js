let watchId;

function startTracking() {
    console.log("1");
    if (navigator.geolocation) {
        console.log("2");
        watchId = navigator.geolocation.watchPosition(updateLocation, showError, {
            enableHighAccuracy: true,
            maximumAge: 0,
            timeout: 5000
        });
        // Use setInterval to submit the form every 10 seconds
        setInterval(submitForm, 10000);
    } else {
        alert("Geolocation is not supported by this browser.");
    }
}

function updateLocation(position) {
    document.getElementById('latitude').value = position.coords.latitude;
    document.getElementById('longitude').value = position.coords.longitude;
    console.log("Updated latitude and longitude to", position.coords.latitude, position.coords.longitude);
}

function submitForm() {
    console.log("Submitting form with latitude and longitude");
    // Ensure the latest location is set before submitting the form
    navigator.geolocation.getCurrentPosition(function (position) {
        document.getElementById('latitude').value = position.coords.latitude;
        document.getElementById('longitude').value = position.coords.longitude;
        setTimeout(function () {
            console.log("Submitting form with updated latitude and longitude");
            document.getElementById('updateLocationForm').submit();
        }, 2000);
    }, showError, {
        enableHighAccuracy: true,
        maximumAge: 0,
        timeout: 5000
    });
}

function showError(error) {
    switch (error.code) {
        case error.PERMISSION_DENIED:
            alert("User denied the request for Geolocation.");
            break;
        case error.POSITION_UNAVAILABLE:
            alert("Location information is unavailable.");
            break;
        case error.TIMEOUT:
            alert("The request to get user location timed out.");
            break;
        case error.UNKNOWN_ERROR:
            alert("An unknown error occurred.");
            break;
    }
}