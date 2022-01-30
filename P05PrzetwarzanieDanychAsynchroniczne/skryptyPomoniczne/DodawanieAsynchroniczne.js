


$(document).ready(function () {


    $("#btnPolicz").click(function () {

        var a = $("#txtLiczba1").val();
        var b = $("#txtLiczba2").val();

        $.ajax({
            method: "POST",
            url: "serwer.aspx",
            data: { liczba1: a, liczba2: b}
        })
            .done(function (msg) {
               // alert("Data Saved: " + msg);
                $("#spWynik").html(msg);
            });

    });


});