$(document).ready(function () {
    $("form").on("submit", function (e) {
        //console.log("radi");
        e.preventDefault();
        var url = $(this).attr('action');
        var method = $(this).attr('method');
        var data = {};

        $(this).find('[name]').each(function (index, value) {
            var name = $(this).attr('name');
            value = $(this).val();
            data[name] = value;
        });
        console.log(data);
        $.ajax({
            url: url,
            type: method,
            data: data,
            ContentType: "application/json",
            dataType: "json",
            success: function (res) {
                
                window.location.href = "http://localhost:51788/";
                console.log(res);
            },
            error: function (err) {
                console.log(err);
            }
        });

        return false;
    });
});