function Dictamen(iden) {
    $(".disable").prop("disabled", true);
    $("#Splash_Screen_Load").fadeIn();
    var env_Dictamen = {
        Env_Nombre: $("#Form_env").val(),
        Env_Observa: $("#txtDescription").val(),
        Env_Codot: $("#O_Trabajo").val(),
        Env_NGuia: $("#Env_NGuia").val()
    };

    $.ajax({
        url: "/Dictamen/SendEmailDict",
        type: 'Post',
        data: {
            codOt: $("#O_Trabajo").val(),
            CodProc: iden,
            env_Dictamen: env_Dictamen
        },
        success: function (data) {
            if (data.errorMetodo == null) {
                showAlert(data.message, "Dictamen", "success");
                setTimeout(function () {
                    location.href = '/Dictamen/Index';
                }, 3000);
            } else {
                showAlert(data.message, "Dictamen", "warning");
            }
            $(".disable").removeAttr("disabled");
            $("#Splash_Screen_Load").fadeOut();
        }
    });
}

function formEnvChanged(value) {
    if (value == "Mensajero Local") {
        $("#Env_NGuia").removeAttr("disabled");
    } else {
        $("#Env_NGuia").attr("disabled", true);
    }
}