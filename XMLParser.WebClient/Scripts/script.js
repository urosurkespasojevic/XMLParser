
$(document).ready(function () {

    $.ajax({
        type: "GET",
        url: "http://localhost:62532/Parser.svc/getview/web",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (res) {
            console.log(res);
            $("#body").html(res);
        },
        error: function (err) {
            console.log(err);
        }
    });
});


