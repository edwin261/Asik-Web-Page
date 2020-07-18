$(document).ready(function () {
    $(".menu").remove();
    $(".content_body").removeClass("col-md-10");
    $(".content_body").addClass("col-md-12");
    document.cookie.split(";").forEach(function (c) { document.cookie = c.replace(/^ +/, "").replace(/=.*/, "=;expires=" + new Date().toUTCString() + ";path=/"); });
});

function LogIn(event) {
    event.preventDefault();
    $("#Splash_Screen_Load").fadeIn();
    $("#btn_Login").attr("disabled", true);
    $(".inputText_NoBorder").attr("disabled", true);
    $.ajax({
        url: '/Acceso/LogIn',
        type: 'POST',
        data: {
            UserAsik: $("#UserAsik").val(),
            PassAsik: $("#PassAsik").val().toUpperCase()
        },
        success: function (data) {
            if (data.status) {
                switch (data.rol[0].rolCodigo) {
                    case 1:
                        location.href = "/OrdenTrabajo/show";
                        break;
                    case 2:
                        location.href = "/ProgramarOT/Show";
                        break;
                    case 3:
                        location.href = "/RevDocumental/Show";
                        break;
                    case 4:
                        location.href = "/VisitaTecnica/VisiTec_OtLst";
                        break;
                    case 5:
                        location.href = "/VisitaTecnica/VisiTec_OtLst";
                        break;
                    case 6:
                        location.href = "/Fac_Cont/Show";
                        break;
                    case 7:
                        location.href = "/Fac_Cont/Show";
                        break;
                    case 8: 
                        location.href = "/OrdenTrabajo/show";
                        break;
                    case 9:
                        break;
                    case 10:
                        location.href = "/Dictamen/Index";
                        break;
                }
                $("#Splash_Screen_Load").fadeOut();
            } else {
                showAlert(data.message, "Login", "warning");
                $("#UserAsik").val('');
                $("#PassAsik").val('');
                $("#Splash_Screen_Load").fadeOut();
            }
            $("#btn_Login").removeAttr("disabled");
            $(".inputText_NoBorder").removeAttr("disabled");
        }
    });
}