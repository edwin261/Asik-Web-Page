$("#Accept").on('change', function () {
    if ($(this).is(':checked')) {
        $(".btn_visit").removeAttr("disabled");
        $("#Noacept_text").css("display", "none");
    } else {
        $(".btn_visit").attr('disabled', true);
        $("#Noacept_text").css("display", "block");
    }
});

function start(IsStart) {
    $("#Splash_Screen_Load").fadeIn();
    $.ajax({
        url: '/VisitaTecnica/start',
        type: 'POST',
        data: {
            codOt: parseInt($("#Cod_OT").val()),
            start: IsStart
        },
        success: function (data) {
            if (data.status) {
                if (IsStart) {
                    $("#Splash_Screen_Load").fadeOut();
                    showAlert("Visita Tecnica Iniciada", "Visita tecnica", "success");
                    setTimeout("location.reload()", 2000);
                } else {
                    $("#Splash_Screen_Load").fadeOut();
                    showAlert("Visita Tecnica Finalizada", "Visita tecnica", "success");
                    setTimeout(function () {
                        location.href = '/VisitaTecnica/VisiTec_OtLst';
                    }, 2000);
                }
            } else {
                showAlert("Ocurrio un error al iniciar", "Visita tecnica", "warning");
            }
            $(".btn_visit").attr("disabled", true);
        }
    });
}

function pausar(pausa) {
    $("#Splash_Screen_Load").fadeIn();
    $.ajax({
        url: '/VisitaTecnica/Pausar',
        type: 'POST',
        data: {
            Insp_Codigo: parseInt($("#Insp_Codigo").val()),
            pausar: pausa
        },
        success: function (data) {
            if (data.status) {
                $("#Splash_Screen_Load").fadeOut();
                showAlert(data.message, "Visita tecnica", "success");
                setTimeout("location.reload()", 2000);
            } else {
                showAlert(data.message, "Visita tecnica", "warning");
            }
        }
    });
}

function ConformeCampo(Isconforme) {
    $("#Splash_Screen_Load").fadeIn();
    $.ajax({
        url: '/VisitaTecnica/ConformeCampo',
        type: 'POST',
        data: {
            Insp_Codigo: parseInt($("#Insp_Codigo").val()),
            Isconforme: Isconforme,
            observa: $("#tec_carpet").val().toUpperCase()
        },
        success: function (data) {
            if (data.status) {
                showAlert(data.message, "Visita tecnica", "success");
                setTimeout("location.href= '/VisitaTecnica/VisiTec_OtLst'", 2000);
            } else {
                showAlert(data.message, "Visita tecnica", "warning");
            }
            $(".btn_visit").attr("disabled", true);
            $("#Splash_Screen_Load").fadeOut();
        }
    });
}

function ConformeDirTec(Isconforme) {
    $("#Splash_Screen_Load").fadeIn();
    $.ajax({
        url: '/VisitaTecnica/ConformeDirTec',
        type: 'POST',
        data: {
            codOt: parseInt($("#Cod_OT").val()),
            Insp_Codigo: parseInt($("#Insp_Codigo").val()),
            Isconforme: Isconforme
        },
        success: function (data) {
            if (data.status) {
                showAlert(data.message, "Visita tecnica", "success");
                setTimeout("location.href= '/VisitaTecnica/VisiTec_OtLst'", 2000);
            } else {
                showAlert(data.message, "Visita tecnica", "warning");
            }
            $(".btn_visit").attr("disabled", true);
            $("#Splash_Screen_Load").fadeOut();
        }
    });
}