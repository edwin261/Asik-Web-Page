var events = [];
var cod = [];
var selectedEvent = null;
var divToBack = 0;

$(document).ready(function () {
    periocidad(0);

    $('.validanumericos').keypress(function (e) {
        if (isNaN(this.value + String.fromCharCode(e.charCode)))
            return false;
    })
        .on("cut copy paste", function (e) {
            e.preventDefault();
        });
})

function LoadCalendar(rol) {
    $.ajax({
        type: "Post",
        url: "/Calidad/GetProgramacion",
        data: {
            rol: rol
        },
        success: function (data) {
            events = [];
            if (data != null) {
                if (data.calCalendarios != null) {
                    for (var c = 0; c < data.calCalendarios.length; c++) {
                        events.push({
                            proyect_name: capitalize(data.calCalendarios[c].calTarcodNavigation.tarActcodNavigation.actNombre.toLowerCase()),
                            Tar_eventId: data.calCalendarios[c].calTarcodNavigation.tarCodigo,
                            Cal_eventId: data.calCalendarios[c].calCodigo,
                            title: capitalize(data.calCalendarios[c].calTarcodNavigation.tarActcodNavigation.actNombre.toLowerCase()),
                            description: capitalize(data.calCalendarios[c].calTarcodNavigation.tarNombre.toLowerCase()),
                            start: data.calCalendarios[c].calReprog == false ? moment(data.calCalendarios[c].calFecprog) : moment(data.calCalendarios[c].calFecreprog),
                            end: data.calCalendarios[c].calReprog == false ? data.calCalendarios[c].calFecven != null ? moment(data.calCalendarios[c].calFecven) : null : moment(data.calCalendarios[c].calFecreprog).add(23, 'hours'),
                            color: data.calCalendarios[c].calColor,
                            allDay: false
                        });
                    }
                }
            }
            GenerateCalender(events);
        },
        error: function (error) {
            showAlert("Ha ocurrido un error", "Calidad", "warning");
        }
    })
}

function GenerateCalender(events) {
    modal = false;
    $('#calender').fullCalendar('destroy');
    $('#calender').fullCalendar({
        locale: 'es',
        displayEventTime: false,
        monthNames: ['Enero', 'Febrero', 'Marzo', 'Abril', 'Mayo', 'Junio', 'Julio', 'Agosto', 'Septiembre', 'Octubre', 'Noviembre', 'Diciembre'],
        monthNamesShort: ['Ene', 'Feb', 'Mar', 'Abr', 'May', 'Jun', 'Jul', 'Ago', 'Sep', 'Oct', 'Nov', 'Dic'],
        dayNames: ['Domingo', 'Lunes', 'Martes', 'Miércoles', 'Jueves', 'Viernes', 'Sábado'],
        dayNamesShort: ['Dom', 'Lun', 'Mar', 'Mié', 'Jue', 'Vie', 'Sáb'],
        lang: 'es',
        contentHeight: 600,
        defaultDate: new Date(),
        timeFormat: 'h(:mm)a',
        header: {
            left: 'month,basicDay,agenda',
            center: 'title',
            right: 'today,prevYear,prev,next,nextYear'
        },
        buttonText: {
            prevYear: new moment().year() - 1,
            nextYear: new moment().year() + 1
        },
        viewRender: function (view) {
            var y = moment($('#calender').fullCalendar('getDate')).year();
            $(".fc-prevYear-button").text(y - 1);
            $(".fc-nextYear-button").html(y + 1);
        },
        eventLimit: true,
        eventColor: '#378006',
        events: events,
        eventClick: function (calEvent, jsEvent, view) {
            if (calEvent.color != "red") {
                selectedEvent = calEvent;
                $('#myModal #eventTitle').text(calEvent.proyect_name);
                var $description = $('<div/>');
                $description.append($('<p/>').html('<b>Inicio: </b>' + calEvent.start.format("DD-MMM-YYYY")));
                if (calEvent.end != null) {
                    $description.append($('<p/>').html('<b>Fin: </b>' + calEvent.end.format("DD-MMM-YYYY")));
                } else {
                    $description.append($('<p/>').html('<b>Fin: </b>' + calEvent.start.format("DD-MMM-YYYY")));
                }
                $description.append($('<p/>').html('<b>Descripcion: </b>' + calEvent.description));
                $('#myModal #pDetails').empty().html($description);

                if (calEvent.color == "green") {
                    $("#btnclick").html('Visualizar');
                } else {
                    $("#btnclick").html('Realizar Tarea');
                }

                $('#CalendarModal').modal('hide');
                $('#myModal').modal();
            } else {
                $("#calCodigo").val(calEvent.Cal_eventId);
                $('#ModalConfirmation').modal();
            }
        },
        selectable: true,
        select: function (start, end) {
            //endDate = $.fullCalendar.moment(end).add(-1, 'days').format('YYYY/MM/DD');
            selectedEvent = {
                Nom_Cli: $("#N_Cliente").val(),
                proyect_name: $("#N_Proyecto").val(),
                tarCodigo: 0,
                Cal_eventId: 0,
                title: '',
                description: '',
                start: start,
                end: end,
                color: '',
                allDay: false
            };
            openAddEditForm();
            $('#calendar').fullCalendar('unselect');
        }
    });
    $(".fc-month-button").html("Mes");
    $(".fc-basicWeek-button").html("Semana");
    $(".fc-basicDay-button").html("Dia");
    $(".fc-today-button").html("Hoy");
    $('#CalendarModal').modal('show');
}

$('#btnclick').click(function () {
    LoadEventView();
});

function openAddEditForm() {
    loadSelectProceso();
    //if (selectedEvent != null) {
    //    $("#txtCodigo").val(selectedEvent.Cal_eventId);
    //    $("#txtStart").val(selectedEvent.start.format('DD/MM/YYYY HH:mm A'));
    //    if (selectedEvent.end != null) {
    //        $("#txtEnd").val(selectedEvent.end.format('DD/MM/YYYY HH:mm A'));
    //    } else {
    //        $("#txtEnd").val(selectedEvent.end != null ? selectedEvent.end.format('DD/MM/YYYY HH:mm A') : selectedEvent.start.format('DD/MM/YYYY HH:mm A'));
    //    }
    //    $('#txtSubject').val(selectedEvent.proyect_name);
    //    $('#chkIsFullDay').prop("checked", selectedEvent.allDay || false);
    //    $('#chkIsFullDay').change();
    //    $('#txtDescription').val(selectedEvent.description);
    //    $('#ddThemeColor').val(selectedEvent.color);
    //}
    $("#txtStart").val(selectedEvent.start.format('DD/MM/YYYY'));
    $('#CalendarModal').modal('hide');

    $('#myModalSave').modal();

}

function LoadEventView() {
    if (selectedEvent != null) {
        //$("#myModal").modal('hide');
        //$("#txtStart").val(selectedEvent.start._i);
        //$("#loadDocument").css("display", "flex");
        //$("#btnSave").css("display", "none");
        //$("#btnSaveDocument").css("display", "block");
        //$("#myModalSave").modal();
        $("#Splash_Screen_Load").fadeIn();
        location.href = '/Calidad/SaveFiles?tarCodigo=' +
            selectedEvent.Tar_eventId + '&calCodigo=' + selectedEvent.Cal_eventId;
    }
}

function Load_Actividades(proCodigo, proNombre) {
    $("#Splash_Screen_Load").fadeIn();
    $.ajax({
        url: "/Calidad/Load_Actividades",
        type: 'Post',
        data: {
            Pro_Codigo: proCodigo
        },
        success: function (data) {
            if (data.length > 0) {
                $("#div_Procesos").fadeOut(300);
                $(".loadActividad").remove();
                data.forEach(function (actividad) {
                    $('<div class="col-md-5 mt-4 ml-md-5 loadActividad">' +
                        '<input type="button" class="btn btn-light TextNegrita border-radius New_OT form-control box-shadow-orange"' +
                        'value="' + capitalize(actividad.actNombre.toLowerCase()) + '" id="' + actividad.actCodigo + '" onclick="loadSltTarea(\'' + actividad.actCodigo + '\'' + ',' + '\'' + actividad.actNombre + '\'' + ',' + '\'' + false + '\')" />' +
                        '</div>').appendTo("#divBtnActivities");
                });
                $("#txtProceso").val(proNombre);
                $("#txtProcesoId").val(proCodigo);
                $('#txtProceso').prop('readonly', true);
                divToBack = 1;
                $(".btn-circleLeft").fadeIn();
                $("#div_Actividades").fadeIn(300);
            } else {
                showAlert("El proceso no tiene actividades relacionadas", "Calidad", "warning");
            }
            $("#Splash_Screen_Load").fadeOut();
        }
    });
}

function loadSelectProceso() {
    $("#DiasPg").val(1);
    $("#slt_Proceso").empty();
    $.ajax({
        url: "/Calidad/Index",
        type: 'Get',
        data: {
            calendar: true
        },
        success: function (data) {
            if (data.length > 0) {
                data.forEach(function (proceso) {
                    $('#slt_Proceso').append("<option value=" + proceso.proCodigo + ">" + capitalize(proceso.proNombre.toLowerCase()) + "</option>");
                });
                loadSltActividad($('#slt_Proceso').val());
            } else {
                showAlert("No se encontraron procesos para cargar", "Calidad", "warning");
            }
        }
    });
}

function loadSltActividad(Pro_Codigo) {
    $("#Splash_Screen_Load").fadeIn();
    $("#slt_Actividad").empty();
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
                    $('#slt_Actividad').append("<option value=" + actividad.actCodigo + ">" + capitalize(actividad.actNombre.toLowerCase()) + "</option>");
                });
            } else {
                showAlert("El proceso no tiene actividades relacionadas", "Calidad", "warning");
            }
            loadSltTarea($('#slt_Actividad').val(), "", true);
            $("#Splash_Screen_Load").fadeOut();
        }
    });
}

function loadSltTarea(actCodigo, actNombre, opt) {
    $("#Splash_Screen_Load").fadeIn();
    $('#slt_Tarea').empty();
    $.ajax({
        url: "/Calidad/Load_Tareas",
        type: 'Post',
        data: {
            Act_Codigo: actCodigo
        },
        success: function (data) {
            if (data.length > 0) {
                if (opt == true) {
                    $("#slt_Tarea").empty();
                    data.forEach(function (tarea) {
                        $('#slt_Tarea').append("<option value=" + tarea.tarCodigo + ">" + capitalize(tarea.tarNombre.toLowerCase()) + "</option>");
                    });
                    $("#divBtn").fadeIn();
                } else {
                    $("#div_Actividades").fadeOut(300);
                    $(".loadTarea").remove();
                    data.forEach(function (tarea) {
                        $('<div class="col-md-5 mt-4 ml-md-5 loadTarea">' +
                            '<input type="button" class="btn btn-light TextNegrita border-radius New_OT form-control box-shadow-orange"' +
                            'value="' + capitalize(tarea.tarNombre.toLowerCase()) + '" id="' + tarea.tarCodigo + '" />' +
                            '</div>').appendTo("#divBtnTrea");
                        $("#txtActividad").val(actNombre);
                        $("#txtActividadId").val(actCodigo);
                        $('#txtActividad').prop('readonly', true);
                        divToBack = 2;
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

function periocidad(id) {
    if (id == 0) {
        $.ajax({
            url: "/Calidad/Periocidad",
            type: 'Post',
            data: {},
            success: function (data) {
                if (data != null) {
                    $("#sltPeriocidad").empty();
                    data.forEach(function (periocidad) {
                        if (periocidad.perCodigo == 8)
                            $('#sltPeriocidad').append("<option selected value=" + periocidad.perCodigo + ">" + capitalize(periocidad.perNombre.toLowerCase()) + "</option>");
                        else
                            $('#sltPeriocidad').append("<option value=" + periocidad.perCodigo + ">" + capitalize(periocidad.perNombre.toLowerCase()) + "</option>");
                    });
                } else {
                    showAlert("No se encontraron datos de periocidad", "Calidad", "warning");
                }
            }
        });
    } else {
        if (id != 8)
            $("#fechaPeriocidad").css("display", "block");
        else
            $("#fechaPeriocidad").css("display", "none");
    }
}

function SaveNewProgTask(codUsu) {
    $("#Splash_Screen_Load").fadeIn();
    $.ajax({
        url: "/Calidad/SaveNewProgTask",
        type: 'Post',
        data: {
            tarCodigo: $("#slt_Tarea").val(),
            CalFecprog: $("#txtStart").val(),
            Calfecvenc: $("#DiasPg").val()
        },
        success: function (data) {
            $("#Splash_Screen_Load").fadeOut();
            if (data = "Tarea programada exitosamente") {
                LoadCalendar(null);
                showAlert(data, "Calidad", "success");
                $('#myModalSave').modal('hide');
            }
            else {
                showAlert(data, "Calidad", "warning");
            }
        }
    });
}

function SaveFiles(event) {
    $("#Splash_Screen_Load").fadeIn();
}

function sendMailToReprog(codUsu) {
    $("#Splash_Screen_Load").fadeIn();
    if ($("#calReprogObserva").val().trim() == "") {
        showAlert("Debe especificar un motivo por el cual no realizo la tarea en la fecha indicada", "Calidad", "warning");
        $("#Splash_Screen_Load").fadeOut();
    } else {
        $.ajax({
            url: "/Calidad/sendMailToReprog",
            type: 'Post',
            data: {
                calCodigo: parseInt($("#calCodigo").val()),
                calObserva: $("#calReprogObserva").val(),
                codUsu: codUsu
            },
            success: function (data) {
                if (data.status) {
                    showAlert(data.message, "Calidad", "success");
                    $("#ModalConfirmation").modal('hide');
                }
                else {
                    showAlert(data.message, "Calidad", "warning");
                }
                $("#Splash_Screen_Load").fadeOut(100);
            }
        });
    }
}

function UpdateCalendarTask() {
    $("#Splash_Screen_Load").fadeIn();
    $.ajax({
        url: "/Calidad/UpdateCalendarTask",
        type: 'Post',
        data: {
            CalCodigo: $("#txtCalCodigo").val(),
            CalFecreprog: $("#CalFecreprog").val()
        },
        success: function (data) {
            $("#Splash_Screen_Load").fadeOut();
            if (data) {
                $("#tr_" + $("#txtCalCodigo").val()).fadeOut(200);
                showAlert("Tarea reprogramada exitosamente.", "Calidad", "success");
                $("#ModalReprog").modal("hide");
            }
            else {
                showAlert("Ocurrio un error al intentar guardar la tarea, intentar nuevamente.", "Calidad", "warning");
            }
        }
    });
}

function loadDatoToReprog(calCodigo) {
    $("#Splash_Screen_Load").fadeIn();
    $("#txt_Actividad").val($("#ActNombre_" + calCodigo).html());
    $("#txt_Tarea").val($("#TarNombre_" + calCodigo).html());
    $("#txt_Comentario").val($("#CalObserv_" + calCodigo).html());
    $("#txtCalCodigo").val(calCodigo);
    $("#Splash_Screen_Load").fadeOut(200);
    $("#ModalReprog").modal();
}

function SaveNewProg() {
    $("#Splash_Screen_Load").fadeIn();
    $.ajax({
        url: "/Calidad/SaveNewProg",
        type: 'Post',
        data: {
            proceso: $("#txtProcesoId").val(),
            procesoName: $("#txtProceso").val().toUpperCase(),
            actividad: $("#txtActividadId").val(),
            actividadName: $("#txtActividad").val().toUpperCase(),
            tareaName: $("#txtTarea").val().toUpperCase(),
            periocidad: $("#sltPeriocidad").val(),
            fecha: $("#datePeriocidad").val(),
            prorroga: $("#DiasProrroga").val()
        },
        success: function (data) {
            showAlert(data.message, "Calidad", "success");
            setTimeout(function () {
                location.href = '/Calidad/Index';
            }, 3000);
        }
    });
}

function capitalize(word) {
    return $.camelCase("-" + word);
}

function backDiv() {
    switch (divToBack) {
        case 1:
            $("#div_Procesos").fadeIn(200);
            $("#div_Actividades").fadeOut(190);
            divToBack = 0;
            $(".btn-circleLeft").fadeOut();
            break;
        case 2:
            $("#div_Actividades").fadeIn(200);
            $("#div_Tareas").fadeOut(190);
            divToBack = 1;
            break;
    }
}