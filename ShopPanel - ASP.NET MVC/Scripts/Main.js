function page(i) {
    $.get("/Home/Index/" + i, function (data) {
        $("body").html(data);
    });
}

$(function () {
    $.ajaxSetup({ cache: false });
    $(".editB").click(function (e) {
        e.preventDefault();
        $.get("/Home/Edit/" + this.id, function (data) {
            $('#dialogContent').html(data);
            $('#modDialog').modal('show');
        });
    });

    $(".addB").click(function (e) {
        e.preventDefault();
        $.get("/Home/Create", function (data) {
            $('#dialogContent').html(data);
            $('#modDialog').modal('show');
        });
    });

    $(".deleteB").click(function (e) {
        e.preventDefault();
        $.post("/Home/Delete/" + this.id, function (data) {
            console.log("ok");
            $.get("/Home/Index", function (data) {
                $("body").html(data);
            });
        });
    });
})