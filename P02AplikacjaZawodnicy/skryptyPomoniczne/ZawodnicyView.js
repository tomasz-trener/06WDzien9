



$(document).ready(function () {

    // filtrowanie
    $("#navigation .input-group-append").click(function () {
        var coSzukam = $("#navigation input").val();

        $(".card-body").hide();
        $("#imgLadowanie").show();

        wyslijZadanieNaServer(coSzukam, null)
    });


    //sortowanie 

    $("table th").click(function (event) {
        var sortowanie = $(event.target).html();
        var coSzukam = $("#navigation input").val();

        $(".card-body").hide();
        $("#imgLadowanie").show();

        wyslijZadanieNaServer(coSzukam, sortowanie);
    }
    );

    $("#btnLewo").click(function () {
        var s = parseInt($("#txtStrona").val());
        s -= 1;
        $("#txtStrona").val(s);


        var coSzukam = $("#navigation input").val();

        $(".card-body").hide();
        $("#imgLadowanie").show();
        wyslijZadanieNaServer(coSzukam, null, s);
    })
    $("#btnPrawo").click(function () {
        var s = parseInt($("#txtStrona").val());
        s += 1;
        $("#txtStrona").val(s);

        var coSzukam = $("#navigation input").val();

        $(".card-body").hide();
        $("#imgLadowanie").show();
        wyslijZadanieNaServer(coSzukam, null, s);
    })

});


function wyslijZadanieNaServer(coSzukam, poCzymSortuje,ktoraStrona) {
    $.ajax({
        method: "POST",
        url: "ZawodnicyServer.aspx",
        data: { filtr: coSzukam, sortowanie: poCzymSortuje, strona: ktoraStrona }
    })
        .done(function (msg) {
            //alert(msg);
            //$("#spWynik").html(msg);

            // tutaj po drugiej stronie przeprowadzimy deserializacje danych czyli 
            // odwrotny proces do tego co zadzialo sie po stronie servera 

            var zawodnicy = JSON.parse(msg);


            $("table tbody").html('');// usuwamy zaowdnikow z tabelki

            var wiersz = "";
            zawodnicy.forEach(function (kolejnyZawodnik) {
                wiersz += "<tr>" +
                    "<td>" + kolejnyZawodnik.ImieNazwisko + "</td>" +
                    "<td>" + kolejnyZawodnik.Kraj + "</td>" +
                    "<td>" + new Date(parseInt(kolejnyZawodnik.DataUrodzenia.substr(6))).toLocaleDateString("pl-pl") + "</td>" +
                    "<td>" + kolejnyZawodnik.Wzrost + "</td>" +
                    "<td>" + kolejnyZawodnik.Waga + "</td>" +
                    "<\tr>";
            })

            //for (var i = 0; i < zawodnicy.length; i++) {
            //    wiersz += "<tr>" +
            //        "<td>" + zawodnicy[i].ImieNazwisko + "</td>" +
            //        "<td>" + zawodnicy[i].Kraj + "</td>" +
            //        "<td>" + zawodnicy[i].DataUrodzenia + "</td>" +
            //        "<td>" + zawodnicy[i].Wzrost + "</td>" +
            //        "<td>" + zawodnicy[i].Waga + "</td>" +
            //        "<\tr>";
            //}

            $("table tbody").html(wiersz);

            $(".card-body").show();
            $("#imgLadowanie").hide();
        });

}