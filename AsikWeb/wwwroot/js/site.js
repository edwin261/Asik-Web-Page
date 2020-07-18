$(document).ready(function () {
    loadMenu();
    setTimeout(function () {
        RemoveAttrDisable();
    }, 2000);
});

function showAlert(message, view, option) {
    switch (option) {
        case "warning":
            toastr.warning(message, view, { "progressBar": true })
            break;
        case "success":
            toastr.success(message, view, { "progressBar": true })
            break;
    }
}

function loadMenu() {
    $.ajax({
        url: "/Home/Menu",
        type: 'Post',
        data: {},
        success: function (data) {
            data.forEach(function (menu) {
                if (parseInt(menu.men_Codigo) <= 7) {
                    $('<img class="imgNextToTitle ml-2" alt="Image of ' + menu.men_Nombre + '" src="' + menu.men_Img + '" width="42" style="width: 5vh !important;" />' +
                        '<li><a tabindex="-1" href="' + menu.men_Url + '" id="Menu_' + menu.men_Codigo + '" class="isDisabled pb-3 btn btn-link Mvistas">' + menu.men_Nombre + '</a></li>').appendTo(".menu");
                } else if (parseInt(menu.men_Codigo) > 7 && parseInt(menu.men_Codigo) <= 11) {
                    $('<img class="imgNextToTitle ml-2" alt="Image of ' + menu.men_Nombre + '" src="' + menu.men_Img + '" width="42" style="width: 5vh !important;" />' +
                        '<li><a tabindex="-1" href="' + menu.men_Url + '" id="Menu_' + menu.men_Codigo + '" class="isDisabled pt-2 pb-3 btn btn-link Mvistas">' + menu.men_Nombre + '</a></li>').appendTo(".menu");
                } else {
                    $('<img class="imgNextToTitle ml-2" alt="Image of ' + menu.men_Nombre + '" src="' + menu.men_Img + '" width="42" style="width: 5vh !important;" />' +
                        '<li><a tabindex="-1" href="' + menu.men_Url + '" id="Menu_' + menu.men_Codigo + '" class="isDisabled pt-2 pb-3 btn btn-link Mvistas">' + menu.men_Nombre + '</a></li>').appendTo(".menu");
                }
            });
        }
    });
}

function getCookie(cname) {
    var name = cname + "=";
    var decodedCookie = decodeURIComponent(document.cookie);
    var ca = decodedCookie.split(';');
    for (var i = 0; i < ca.length; i++) {
        var c = ca[i];
        while (c.charAt(0) == ' ') {
            c = c.substring(1);
        }
        if (c.indexOf(name) == 0) {
            return c.substring(name.length, c.length);
        }
    }
    return "";
}

function RemoveAttrDisable() {
    for (var i = 0; i < parseInt(getCookie("Count")); i++) {
        switch (parseInt(getCookie("RolCod_" + i))) {
            case 1:
                $("#Menu_1").addClass("item");
                $("#Menu_1").removeClass("isDisabled");

                $("#Menu_7").addClass("item");
                $("#Menu_7").removeClass("isDisabled");
                break;
            case 2:
                $("#Menu_3").addClass("item");
                $("#Menu_3").removeClass("isDisabled");
                break;
            case 3:
                $("#Menu_2").addClass("item");
                $("#Menu_2").removeClass("isDisabled");
                break;
            case 4:
                $("#Menu_4").addClass("item");
                $("#Menu_4").removeClass("isDisabled");
                break;
            case 5:
                $("#Menu_4").addClass("item");
                $("#Menu_4").removeClass("isDisabled");
                break;
            case 6:
                $("#Menu_6").addClass("item");
                $("#Menu_6").removeClass("isDisabled");
                break;
            case 7:
                $("#Menu_5").addClass("item");
                $("#Menu_5").removeClass("isDisabled");
                break;
            case 8:
                $(".maestros").addClass("item");
                $(".Mvistas").addClass("item");
                $(".maestros").css("display", "block");
                $(".maestros").removeClass("isDisabled");
                $(".Mvistas").removeClass("isDisabled");
                break;
            case 9:
                break;
            case 10:
                $("#Menu_7").addClass("item");
                $("#Menu_7").removeClass("isDisabled");
                break;
        }
    }
    $(".isDisabled").attr("href", "#");
}

function OpenHideMenu(open) {
    if (open) {
        $("#btn").click();
        $("#Menu_Opt").css("display", "flex");
    } else {
        $("#cancel").click();
        $("#Menu_Opt").css("display", "hidden");
    }
}