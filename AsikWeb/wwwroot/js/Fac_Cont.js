function Save(event) {
    event.preventDefault();
    $("#Splash_Screen_Load").fadeIn();
    $(".disable").prop("disabled", true);

    $.ajax({
        url: "/Fac_Cont/Save",
        type: 'Post',
        data: {
            codOt: $("#hd_Ord_Codotc").val(),
            rol: parseInt($("#rol_factCont").val())
        },
        success: function (data) {
            if (data.errorMetodo == null) {
                showAlert(data.message, "Orden de trabajo", "success");
                setTimeout(function () {
                    location.href = '/Fac_Cont/Show';
                }, 2000);
            } else {
                showAlert(data.message, "Orden de trabajo", "warning");
            }
            $(".disable").removeAttr("disabled");
            $("#Splash_Screen_Load").fadeOut();
        }
    });
}

function ShowBtn(opt) {
    switch (opt) {
        case true:
            $(".disable").removeAttr("disabled");
            break;
        case false:
            $(".disable").prop("disabled", true);
            break;
    }
}