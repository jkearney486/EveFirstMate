(function () {
    "use strict";

    $(function () {
        /*$.getJSON("api/MarketGroups", {}, function (data) {
            console.log(data);
        });*/
        $.ajax({
            type: "GET",
            url: "api/MarketGroups",
            success: function (msg) {
                if (msg) {
                    console.log(msg);
                }
            },
            error: function (jqXHR, textStatus, errorThrown) {
                var exception = jqXHR;
            }
        });
    });
}());
