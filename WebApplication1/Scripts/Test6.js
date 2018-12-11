console.log("test");

var knap = jQuery("#minKnap");
knap.click(function () {
    //console.log("25");
    $.getJSON("/home/test5").done(function (data) {
        var ol = $("#minListe");
        ol.empty();
        for (var i = 0; i < data.length; i++) {
            var li = $("<li />").html(data[i].Navn);
            ol.append(li);
        }
    })
})