function updateCheckDoc(event) {
    event.preventDefault();
    $("#Splash_Screen_Load").fadeIn();
    var Docs = [];
    var desc = [];
    var DocsNoApr = [];

    $("input:checkbox:checked").each(function () {
        Docs.push(parseInt($(this).val()));
    });

    $("input:checkbox:not(:checked)").each(function () {
        DocsNoApr.push(parseInt($(this).val()));
        desc.push($("#txt_" + $(this).val()).val());
    });

    $.ajax({
        url: "/RevDocumental/updateCheckDoc",
        type: 'Post',
        data: {
            Docs: Docs,
            DocsNoApr: DocsNoApr,
            Observa: desc,
            CodOt: parseInt($("#O_Trabajo").val())
        },
        success: function (data) {
            if (data.status) {
                showAlert(data.message, "Revision Documental", "success");
                setTimeout(function () {
                    location.href = "/RevDocumental/show";
                }, 2000);
            } else {
                showAlert(data.message, "Revision Documental", "warning");
            }
            $("#Splash_Screen_Load").fadeOut();
        }
    });
}

function hideorshowtxt(cod) {
    if ($("#" + cod).prop("checked")) {
        $("#txt_" + cod).fadeOut();
    } else {
        $("#txt_" + cod).fadeIn();
    }
}