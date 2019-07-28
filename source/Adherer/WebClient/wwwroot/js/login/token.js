
function checkToken() {
    var data = sessionStorage.getItem('token_session');
    if (!data) {
        window.location.href = "/login";
    }
    else {
        $.ajax({
            url: linkserver + "auth/checkToken",
            type: 'POST',
            dataType: 'json',
            data: data,
            async: false,
            processData: false,
            contentType: "application/json",
            error: function (err) {
                window.location.href = "/login";
            },
            success: function (data) {
                if (!data.success) {
                    window.location.href = "/login";
                }
            }
        });
    }
}