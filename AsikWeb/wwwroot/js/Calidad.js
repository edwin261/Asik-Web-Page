﻿var cod = [];
function Load_Actividades(Pro_Codigo) {
    cod = [];
    $("#Splash_Screen_Load").fadeIn();
    addValueToArray(Pro_Codigo);
    $.ajax({
        url: "/Calidad/Load_Actividades",
        type: 'Post',
        data: {
            Pro_Codigo: Pro_Codigo
        },
        success: function (data) {
            if (data.length > 0) {
                $("#div_Procesos").fadeOut(300);
                data.forEach(function (actividad) {
                    $('<div class="col-md-4 mt-4">' +
                        '<input type="button" class="btn btn-light TextNegrita border-radius New_OT form-control box-shadow-orange"' +
                        'value="' + actividad.act_Nombre + '" id="' + actividad.act_Codigo + '" onclick="addValueToArray(' + actividad.act_Codigo + '), loadSltTarea(\'' + actividad.act_Codigo + '\'' + ',' + '\'' + true + '\')" />' +
                        '</div>').appendTo("#divBtnActivities");
                });
                $("#div_Actividades").fadeIn(300);
            } else {
                showAlert("El proceso no tiene actividades relacionadas", "Calidad", "warning");
            }
            $("#Splash_Screen_Load").fadeOut();
        }
    });
}

function addValueToArray(Codigo) {
    cod.push(Codigo);
}

function loadSelectProceso() {
    $.ajax({
        url: "/Calidad/Index",
        type: 'Get',
        data: {
            calendar: true
        },
        success: function (data) {
            if (data.length > 0) {
                data.forEach(function (proceso) {
                    $('#slt_Proceso').append("<option value=" + proceso.pro_Codigo + ">" + proceso.pro_Nombre + "</option>");
                });
                loadSltActividad(1);
            } else {
                showAlert("No se encontraron procesos para cargar", "Calidad", "warning");
            }
        }
    });
}

function loadSltActividad(Pro_Codigo) {
    $("#Splash_Screen_Load").fadeIn();
    $.ajax({
        url: "/Calidad/Load_Actividades",
        type: 'Post',
        data: {
            Pro_Codigo: Pro_Codigo
        },
        success: function (data) {
            if (data.length > 0) {
                $("#slt_Actividad").empty();
                data.forEach(function (actividad) {
                    $('#slt_Actividad').append("<option value=" + actividad.act_Codigo + ">" + actividad.act_Nombre + "</option>");
                });
            } else {
                showAlert("El proceso no tiene actividades relacionadas", "Calidad", "warning");
            }
            $("#Splash_Screen_Load").fadeOut();
        }
    });
}

function loadSltTarea(Act_Codigo, opt) {
    $("#Splash_Screen_Load").fadeIn();
    $.ajax({
        url: "/Calidad/Load_Tareas",
        type: 'Post',
        data: {
            Act_Codigo: Act_Codigo
        },
        success: function (data) {
            if (data.length > 0) {
                if (opt) {
                    $("#slt_Tarea").empty();
                    data.forEach(function (tarea) {
                        $('#slt_Tarea').append("<option value=" + tarea.tar_Codigo + ">" + tarea.tar_Nombre + "</option>");
                    });
                    $("#divBtn").fadeIn();
                } else {
                    addValueToArray(Act_Codigo);
                    $("#div_Actividades").fadeOut(300);
                    data.forEach(function (tarea) {
                        $('<div class="col-md-4 mt-4">' +
                            '<input type="button" class="btn btn-light TextNegrita border-radius New_OT form-control box-shadow-orange"' +
                            'value="' + tarea.tar_Nombre + '" id="' + tarea.tar_Codigo + '" />' +
                            '</div>').appendTo("#divBtnTrea");
                        $("#div_Tareas").fadeIn(300);
                    });                    
                }
            } else {
                showAlert("La actividad no tiene tareas relacionadas", "Calidad", "warning");
            }
            $("#Splash_Screen_Load").fadeOut();
        }
    });
}