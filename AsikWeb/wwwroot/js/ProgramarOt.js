var events = [];
var selectedEvent = null;
var endDate = null;
var modal = false;
var calendar_save = 0;
var cod_cal = [];

function InvoiceCalendar() {
    $('#CalendarModal').modal("show");
    FetchEventAndRenderCalendar();
}

function FetchEventAndRenderCalendar() {
    events = [];
    $.ajax({
        type: "Post",
        url: "/ProgramarOT/GetProgramacion",
        data: {
            codTec: $('#slt_CodiTec').val(),
            codigoOt: $('#hd_Ord_Codotc').val()
        },
        success: function (data) {
            if (data != null) {
                if (data.calendario != null) {
                    for (var i = 0; i < data.calendario.length; i++) {
                        events.push({
                            Nom_Cli: $("#N_Cliente").val(),
                            proyect_name: $("#N_Proyecto").val(),
                            Cal_eventId: data.calendario[i].cal_EventId,
                            title: data.lstUsuarios[i].usuNombre,
                            description: data.calendario[i].descripcion,
                            start: moment(data.calendario[i].inicio),
                            end: data.calendario[i].fin != null ? moment(data.calendario[i].fin) : null,
                            color: data.calendario[i].themeColor,
                            allDay: data.calendario[i].tod_Dia,
                            subjec: data.calendario[i].subjec
                        });
                    }
                    endDate = events.end;
                }
            }
            GenerateCalender(events);
        },
        error: function (error) {
            showAlert("Ha ocurrido un error",
                "Programar OT", "warning");
        }
    })
}

function GenerateCalender(events) {
    endDate = null;
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
            $('#myModal #eventTitle').text(calEvent.title);
            var $description = $('<div/>');
            $description.append($('<p/>').html('<b>Orden de trabajo: </b>' + calEvent.proyect_name));
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
            endDate = $.fullCalendar.moment(end).add(-1, 'days').format('YYYY/MM/DD');
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
        },
        editable: true,
        eventDrop: function (event) {
            var data = {
                Cal_eventId: event.Cal_eventId,
                Subjec: event.subjec,
                Descripcion: event.description,
                Inicio: $.fullCalendar.formatDate(event.start, "Y-MM-DD HH:mm:ss"),
                Fin: $.fullCalendar.formatDate(event.start, "Y-MM-DD HH:mm:ss"),
                Codigo_Ot: $('#hd_Ord_Codotc').val(),
                Codi_Tec: $('#slt_CodiTec').val(),
                ThemeColor: event.color,
                Tod_Dia: event.allDay
            };
            SaveEvent(data);
        }
    });
    $(".fc-month-button").html("Mes");
    $(".fc-basicWeek-button").html("Semana");
    $(".fc-basicDay-button").html("Dia");
    $(".fc-today-button").html("Hoy");
    $('#CalendarModal').modal('show');
}

$('#btnEdit').click(function () {
    modal = true;
    openAddEditForm();
});

$('#btnDelete').click(function () {
    if (selectedEvent != null && confirm('Esta seguro que desea eliminar la programacion tecnica?')) {
        $("#Splash_Screen_Load").fadeIn();
        $.ajax({
            type: "POST",
            url: '/ProgramarOT/DeleteEvent',
            data: { 'calendarId': parseInt(selectedEvent.Cal_eventId) },
            success: function (data) {
                if (data.status) {
                    $('#myModal').modal('hide');
                    showAlert(data.message, "Programar OT", "success");
                    FetchEventAndRenderCalendar();
                    if (parseInt(calendar_save) > 0)
                        calendar_save = parseInt(calendar_save) - 1;
                } else {
                    showAlert(data.message, "Programar OT", "warning");
                }
            },
            error: function () {
                showAlert("Ha ocurrido un error al eliminar la programacion del tecnico.",
                    "Programar OT", "warning");
            }
        })
        $("#Splash_Screen_Load").fadeOut();
    }
})

$('#chkIsFullDay').change(function () {
    if ($(this).is(':checked')) {
        $('#divEndDate').hide();
    }
    else {
        $('#divEndDate').show();
    }
});

function openAddEditForm() {
    if (selectedEvent != null) {
        $("#txtCodigo").val(selectedEvent.Cal_eventId);
        $("#txtStart").val(selectedEvent.start.format('DD/MM/YYYY HH:mm A'));
        if (selectedEvent.end != null) {
            $("#txtEnd").val(selectedEvent.end.format('DD/MM/YYYY HH:mm A'));
        } else {
            $("#txtEnd").val(selectedEvent.end != null ? selectedEvent.end.format('DD/MM/YYYY HH:mm A') : selectedEvent.start.format('DD/MM/YYYY HH:mm A'));
        }
        $('#txtSubject').val(selectedEvent.proyect_name);
        $('#chkIsFullDay').prop("checked", selectedEvent.allDay || false);
        $('#chkIsFullDay').change();
        $('#txtDescription').val(selectedEvent.description);
        $('#ddThemeColor').val(selectedEvent.color);
    }
    endDate = null;
    $('#CalendarModal').modal('hide');

    $('#myModalSave').modal();

}

$('#btnSave').click(function () {
    $("#Splash_Screen_Load").fadeIn();
    if ($('#txtSubject').val().trim() == "") {
        showAlert("Debe ingresar un titulo para la programacion",
            "Programar OT", "warning");
        $("#Splash_Screen_Load").fadeOut();
        return;
    }
    if ($('#txtStart').val().trim() == "") {
        showAlert("Debe ingresar una fecha de Inicio valida",
            "Programar OT", "warning");
        $("#Splash_Screen_Load").fadeOut();
        return;
    }
    //if ($('#chkIsFullDay').is(':checked') == false && $('#dtp2').val().trim() == "") {
    //    showAlert("Debe ingresar una fecha de fin valida", "Programar OT", "warning");
    //    return;
    //}

    //if ($('#chkIsFullDay').is(':checked') == false && $('#dtp2').val() < $('#dtp1').val()) {
    //    showAlert("Debe ingresar una fecha de fin valida", "Programar OT", "warning");
    //    return;
    //}

    if ($('#chkIsFullDay').is(':checked') == false && $('#txtEnd').val().trim() == "") {
        showAlert("Debe ingresar una fecha de Fin valida", "Programar OT", "warning");
        $("#Splash_Screen_Load").fadeOut();
        return;
    }
    else {
        var startDate = moment($('#txtStart').val(), "DD/MM/YYYY HH:mm A").toDate();
        var endDate = moment($('#txtEnd').val(), "DD/MM/YYYY HH:mm A").toDate();
        if (endDate < startDate) {
            showAlert("Debe ingresar una fecha de Fin valida", "Programar OT", "warning");
            $("#Splash_Screen_Load").fadeOut();
            return;
        }
    }

    var data = {
        Cal_EventId: $("#txtCodigo").val(),
        Subjec: $('#txtSubject').val().trim(),
        Descripcion: $('#txtDescription').val(),
        Inicio: $('#txtStart').val().trim(), //$('#dtp1').val(),
        Fin: $('#chkIsFullDay').is(':checked') ? null : $('#txtEnd').val().trim(), //$('#dtp2').val(),
        Codigo_Ot: $('#hd_Ord_Codotc').val(),
        Codi_Tec: $('#slt_CodiTec').val(),
        ThemeColor: $('#ddThemeColor').val(),
        Tod_Dia: $('#chkIsFullDay').is(':checked')
    }
    SaveEvent(data);

})

function SaveEvent(data) {
    $("#Splash_Screen_Load").fadeIn();
    $.ajax({
        type: "POST",
        url: '/ProgramarOT/SaveEvent',
        data: data,
        success: function (data) {
            if (data.status) {
                showAlert(data.message.split("-")[0], "Programar OT", "success");
                cod_cal.push(data.message.split("-")[1]);
                FetchEventAndRenderCalendar();
                $('#myModalSave').modal('hide');
                $('#myModal').modal('hide');
                calendar_save = parseInt(calendar_save) + 1;
            } else {
                showAlert(data.message, "Programar OT", "warning");
            }
            $("#Splash_Screen_Load").fadeOut();
        },
        error: function () {
            showAlert("Ha ocurrido un error al guardar la programacion del tecnico",
                "Programar OT", "warning");
        }
    })
    $("#Splash_Screen_Load").fadeOut();
}

function showCalendarModal() {
    if (!modal)
        $('#CalendarModal').modal('show');
    modal = false;
}

function Save(event) {
    event.preventDefault();
    $("#Splash_Screen_Load").fadeIn();
    if (parseInt(calendar_save) > 0) {
        $(".disable").attr("disabled", true);

        var PROG_OT = {
            Prog_Cod: 0,
            Prog_CodOt: parseInt($("#hd_Ord_Codotc").val()),
            Prog_CodTec: parseInt($("#slt_CodiTec").val()),
            Pro_Plan_Imp: $("#Pl_Imp").val(),
            Prog_Fech: ''
        }

        $.ajax({
            url: '/ProgramarOt/Save',
            type: 'POST',
            data: {
                prog_Ot: PROG_OT
            },
            success: function (data) {
                if (data.status) {
                    showAlert(data.message, "Programacion Orden de trabajo", "success");
                    setTimeout(function () {
                        location.href = '/ProgramarOT/Show';
                    }, 2000);
                } else {
                    showAlert(data.message, "Programacion Orden de trabajo", "warning");
                }
                $(".disable").removeAttr("disabled");
                $("#Splash_Screen_Load").fadeOut();
            }
        });
    } else {
        $("#Splash_Screen_Load").fadeOut();
        showAlert("Debe realizar una programacion tecnica", "Programacion Orden de trabajo", "warning");
    }
}

function Check_CalEvents() {
    if (cod_cal != null) {
        $("#Splash_Screen_Load").fadeIn();
        for (var i = 0; i < cod_cal.length; i++) {
            $.ajax({
                type: "POST",
                url: '/ProgramarOT/DeleteEvent',
                data: { 'CalendarId': parseInt(cod_cal[i]) },
                success: function (data) {
                    console.log(data);
                },
                error: function () {
                    console.log("Ha ocurrido un error al eliminar la programacion del tecnico.");
                }
            })
        }
        $("#Splash_Screen_Load").fadeOut();
    }
    location.href = '/ProgramarOT/Show';
}