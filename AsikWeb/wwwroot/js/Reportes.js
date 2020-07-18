function GenExcelDocNoAprov() {
    $("#Splash_Screen_Load").fadeIn();
    $.ajax({
        url: "/Reportes/DictamenReport",
        type: 'Post',
        data: {
            CodCli: $("#Cliente_Id").val(),
            inicio: $("#DateInicio").val(),
            fin: $("#DateFin").val()
        },
        success: function (data) {
            var status = data.split("-");
            if (status[0] == "True") {
                $("#LinkReport").attr("href", status[1]);
                showAlert(status[2], "Reporte", "success");

                $('#LinkReport').get(0).click();                
            } else {
                showAlert(status[1], "Reporte", "warning");
            }
            $("#Splash_Screen_Load").fadeOut();
        }
    });
}

function DictamenReportTecnicos() {
    $("#Splash_Screen_Load").fadeIn();
    $.ajax({
        url: "/Reportes/DictamenReportTecnicos",
        type: 'Post',
        data: {
            CodTec: $("#slt_CodiTec").val(),
            inicio: $("#DateInicio").val(),
            fin: $("#DateFin").val()
        },
        success: function (data) {
            var status = data.split("-");
            if (status[0] == "True") {
                $("#LinkReport").attr("href", status[1]);
                showAlert(status[2], "Reporte", "success");

                $('#LinkReport').get(0).click();
            } else {
                showAlert(status[1], "Reporte", "warning");
            }
            $("#Splash_Screen_Load").fadeOut();
        }
    });
}