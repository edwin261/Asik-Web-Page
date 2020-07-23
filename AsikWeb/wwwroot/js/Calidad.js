var events = [];
var cod = [];
var selectedEvent = null;

$(document).ready(function () {
    //LoadCalendar($("#rol_usu").val());
    GenerateCalender(null);
    loadSltTarea(1, true);

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
            codTec: $('#slt_CodiTec').val(),
            codigoOt: 0,
            rol: rol
        },
        success: function (data) {
            events = [];
            if (data != null) {
                if (data.calendario != null) {
                    for (var i = 0; i < data.calendario.length; i++) {
                        events.push({
                            proyect_name: data.ord_Trabajo[i].ord_Nomproy,
                            Cal_eventId: data.calendario[i].cal_EventId,
                            title: data.calendario[i].subjec,
                            description: data.calendario[i].descripcion,
                            start: moment(data.calendario[i].inicio),
                            end: data.calendario[i].fin != null ? moment(data.calendario[i].fin) : null,
                            color: data.calendario[i].themeColor,
                            allDay: data.calendario[i].tod_Dia
                        });
                    }
                }
            }
            GenerateCalender(events);
        },
        error: function (error) {
            showAlert("Ha ocurrido un error",
                "Visita Tecnica", "warning");
        }
    })
}

function GenerateCalender(events) {
    modal = false;
    $('#calender').fullCalendar('destroy');
    $('#calender').fullCalendar({
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
            left: 'month,basicWeek,basicDay,agenda',
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
            selectedEvent = calEvent;
            $('#myModal #eventTitle').text(calEvent.proyect_name);
            var $description = $('<div/>');
            $description.append($('<p/>').html('<b>Cliente: </b>' + calEvent.Nom_Cli));
            $description.append($('<p/>').html('<b>Inicio: </b>' + calEvent.start.format("DD-MMM-YYYY")));
            if (calEvent.end != null) {
                $description.append($('<p/>').html('<b>Fin: </b>' + calEvent.end.format("DD-MMM-YYYY")));
            } else {
                $description.append($('<p/>').html('<b>Fin: </b>' + calEvent.start.format("DD-MMM-YYYY")));
            }
            $description.append($('<p/>').html('<b>Descripcion: </b>' + calEvent.description));
            $('#myModal #pDetails').empty().html($description);

            $('#CalendarModal').modal('hide');
            $('#myModal').modal();
        },
        selectable: true,
        select: function (start, end) {
            //endDate = $.fullCalendar.moment(end).add(-1, 'days').format('YYYY/MM/DD');
            selectedEvent = {
                Nom_Cli: $("#N_Cliente").val(),
                proyect_name: $("#N_Proyecto").val(),
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
        location.href = "/VisitaTecnica/Visit_Start?Ord_CodOtc=" + selectedEvent.codOt;
    }
}

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
                        'value="' + actividad.actNombre + '" id="' + actividad.actCodigo + '" onclick="addValueToArray(' +
                        actividad.actCodigo + '), loadSltTarea(\'' + actividad.actCodigo + '\'' + ',' + '\'' + false + '\')" />' +
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
                    $('#slt_Proceso').append("<option value=" + proceso.proCodigo + ">" + proceso.proNombre + "</option>");
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
                    $('#slt_Actividad').append("<option value=" + actividad.actCodigo + ">" + actividad.actNombre + "</option>");
                });
            } else {
                showAlert("El proceso no tiene actividades relacionadas", "Calidad", "warning");
            }
            loadSltTarea($('#slt_Actividad').val(), true);
            $("#Splash_Screen_Load").fadeOut();
        }
    });
}

function loadSltTarea(Act_Codigo, opt) {
    $("#Splash_Screen_Load").fadeIn();
    $('#slt_Tarea').empty();
    $.ajax({
        url: "/Calidad/Load_Tareas",
        type: 'Post',
        data: {
            Act_Codigo: Act_Codigo
        },
        success: function (data) {
            if (data.length > 0) {
                if (opt == true) {
                    $("#slt_Tarea").empty();
                    data.forEach(function (tarea) {
                        $('#slt_Tarea').append("<option value=" + tarea.tarCodigo + ">" + tarea.tarNombre + "</option>");
                    });
                    $("#divBtn").fadeIn();
                } else {
                    addValueToArray(Act_Codigo);
                    $("#div_Actividades").fadeOut(300);
                    data.forEach(function (tarea) {
                        $('<div class="col-md-4 mt-4">' +
                            '<input type="button" class="btn btn-light TextNegrita border-radius New_OT form-control box-shadow-orange"' +
                            'value="' + tarea.tarNombre + '" id="' + tarea.tarCodigo + '" />' +
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

function SaveNewProgTask() {
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
                showAlert(data, "Calidad", "success");
                $('#myModalSave').modal('hide');
            }
            else {
                showAlert(data, "Calidad", "warning");
            }
        }
    });
}