function btnSubmitOnClick(data) {

    var data = JSON.stringify({
        'bandAColor': $('#ddlBandA').val(),
        'bandBColor': $('#ddlBandB').val(),
        'bandCColor': $('#ddlBandC').val(),
        'bandDColor': $('#ddlBandD').val()
    });

    $.ajax({
        type: "POST",
        url: "/Home/GetResistanceValue",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        data: data,
        success: function (result) {
            //if error
            if (result.error != undefined) {
                $("#divError").html(result.error);
            }
            else {
                $("#divError").empty();
                $("#txtMaxResistance").val(result.value);
            }
        }
    });
}
