var meses = ["", "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"];
function Save(event) {
    event.preventDefault();
    $("#Splash_Screen_Load").fadeIn();
    $("#Btn_SaveOt").attr("disabled", true);
    var OT_List = AddDataToModelOT();
    $.ajax({
        url: '/OrdenTrabajo/Save',
        type: 'POST',
        data: {
            OT: OT_List
        },
        success: function (data) {
            if (data.status) {
                $("#Splash_Screen_Load").fadeOut();
                showAlert("Creada exitosamente.", "Orden de Trabajo", "success");
                location.href = "/OrdenTrabajo/show";
            } else {
                $("#Splash_Screen_Load").fadeOut();
                showAlert(data.message, "Orden de Trabajo", "warning");
            }
            $("#Btn_SaveOt").removeAttr("disabled");
        }
    });
}

function Edit() {
    $("#Splash_Screen_Load").fadeIn();
    $.ajax({
        url: '/OrdenTrabajo/Edit',
        type: 'POST',
        data: {
            Ord_Codigo: $("#Ord_Codigo").val(),
            canvis: $("#Proyect_Visit").val(),
            canrevdoc: $("#Proyect_InsDocument").val()
        },
        success: function (data) {
            if (data == "Orden de trabajo editada") {
                $("#Splash_Screen_Load").fadeOut();
                showAlert("Orden de trabajo editada", "Orden de Trabajo", "success");
                location.href = "/OrdenTrabajo/show";
            } else {
                $("#Splash_Screen_Load").fadeOut();
                showAlert(data, "Orden de Trabajo", "warning");
            }
            $("#Btn_SaveOt").removeAttr("disabled");
        }
    });
}

function AddDataToModelOT() {
    var newOT = {
        ORD_PREFOT: "OT",
        ORD_CODOTC: 0,
        ORD_NOMPROY: $("#Proyect_Name").val().toUpperCase(),
        ORD_TIPPAG: $("#Form_Pag").val().toUpperCase(),
        ORD_CANVIS: $("#Proyect_Visit").val().toUpperCase(),
        ORD_REVDOC: $("#Proyect_InsDocument").val().toUpperCase(),
        ORD_ALCCOD: $("#Alcance").val().toUpperCase(),
        ORD_TALCOD: $("#Tip_Alc").val().toUpperCase(),
        ORD_CODCLI: $("#Cliente_Id").val().toUpperCase(),
        ORD_NOMCAD: $("#AdiCli_Name").val().toUpperCase(),
        ORD_TELCAD: parseInt($("#AdiCli_Tel").val()),
        ORD_CELCAD: $("#ORD_CELCAD").val(),
        ORD_EMACAD: $("#AdiCli_Email").val().toUpperCase(),
        ORD_FECCRE: '',
        ORD_USUCRE: '',
        ORD_FECMOD: '',
        ORD_USUMOD: '',
        ORD_FECFIN: '',
        ORD_ESTADO: 0,
        ORD_CANTALC: parseInt($("#ord_cantalc").val()),
        ORD_CODSED: parseInt($("#Sede_Id").val())
    }
    return newOT;
}

function ClientList() {
    $(".warning").fadeOut();
    $(".search").val('');
    $(".load").css("display", "block");
    $(".search").prop("readonly", true);
    $.ajax({
        url: "/Ordentrabajo/Clientes",
        type: 'POST',
        data: {},
        success: function (data) {
            $(".clientes").remove();
            data.forEach(function (clientes) {
                $('<tr class="clientes" onclick="passData(\'' + clientes.cliNombre +
                    '\'' + ',' + '\'' + clientes.cliIdenti + '\'' + ',' + '\'' +
                    clientes.cliDirecc + '\'' + ',' + '\'' + clientes.cliTelefo + '\')"><td>'

                    + clientes.cliIdenti + '</td><td>'
                    + clientes.cliNombre + '</td></tr>').appendTo("#table_data");
            });

            $(".load").css("display", "none");
            $(".search").prop("readonly", false);
        }
    });
}

function SedeList() {
    $(".warning").fadeOut();
    $(".searchSede").val('');
    $(".load").css("display", "block");
    $(".searchSede").prop("readonly", true);
    $.ajax({
        url: "/Ordentrabajo/Sedes",
        type: 'POST',
        data: {
            codcli: $("#Cliente_Id").val()
        },
        success: function (data) {
            $(".sede").remove();
            debugger
            data.forEach(function (sede) {
                $('<tr class="sede" onclick="passDataSede(\'' + sede.seNomSed +
                    '\'' + ',' + '\'' + sede.seNumIden + '\'' + ',' + '\'' +
                    sede.seDirecc + '\'' + ',' + '\'' + sede.seNumTel + '\')"><td>'
                    + sede.seNumIden + '</td><td>'
                    + sede.seNomSed + '</td></tr>').appendTo("#tableSede_data");
            });
            $(".load").css("display", "none");
            $(".searchSede").prop("readonly", false);
        }
    });
}

function passData(nomcli, codcli, direccion, telefono) {
    $("#Cliente_name").val(nomcli);
    $("#Cliente_Id").val(codcli);
    $("#Cli_Dir").val(direccion);
    $("#Cli_Tel").val(telefono);

    $.ajax({
        url: "/Ordentrabajo/Sedes",
        type: 'POST',
        data: {
            codcli: codcli
        },
        success: function (data) {
            $("#Sede_name").val('');
            $("#Sede_Id").val('');
            $("#Sede_Dir").val('');
            $("#Sede_Tel").val('');
            if (data.length > 0) {
                $("#Div_Sede").css("display", "flex");
            }
            $(".load").css("display", "none");
            $(".search").prop("readonly", false);
        }
    });

    $("#ModalSearchCliente").modal("hide");
}

function passDataSede(nomsede, codsede, direccion, telefono) {
    $("#Sede_name").val(nomsede);
    $("#Sede_Id").val(codsede);
    $("#Sede_Dir").val(direccion);
    $("#Sede_Tel").val(telefono);

    $("#ModalSearchSede").modal("hide");
}

function SearchOT(Ord_codotc) {
    $(".disable").attr("disabled", true);
    $("#Splash_Screen_Load").fadeIn();
    if (Ord_codotc == null || Ord_codotc == '') {
        showAlert("Debe digitar un numero de orden para realizar la busqueda",
            "Consultar Orden de Trabajo", "warning");
        $(".disable").removeAttr("disabled");
        $("#Splash_Screen_Load").fadeOut();
    } else {
        $("#Splash_Screen_Load").fadeIn();
        $.ajax({
            url: "/ConsultarOT/SearchOT",
            type: 'POST',
            data: {
                Ord_codotc: Ord_codotc
            },
            success: function (data) {
                if (data != null) {
                    if (data.errorMetodo == null) {
                        $("#div_infoOt").fadeIn(300);

                        $("#proy_name").html(data.ord_Trabajo[0].ord_Nomproy);
                        $("#proy_ini").html(data.ord_Trabajo[0].ord_Feccre.split("T")[0]);
                        $("#proy_fin").html(data.ord_Trabajo[0].ord_Fecfin.split("T")[0]);
                        $("#proy_alc").html(data.alcance[0].alcNombre);
                        $("#proy_talc").html(data.tipAlcance[0].tip_alnomb);
                        $("#proy_status").html(data.estados[0].estNombre);

                        var TimeLinelist = [];
                        TimeLinelist.push({
                            fecha: data.ord_Trabajo[0].ord_Feccre.split("-")[2].split("T")[0] + " de " +
                                meses[parseInt(data.ord_Trabajo[0].ord_Feccre.split("-")[1])] + " del " +
                                data.ord_Trabajo[0].ord_Feccre.split("-")[0],
                            text: "La orden de trabajo fue creada"
                        });

                        if (data.ord_Trabajo[0].ord_Estado == 15) {
                            TimeLinelist.push({
                                fecha: data.ord_Trabajo[0].ord_Fecmod.split("-")[2].split("T")[0] + " de " +
                                    meses[parseInt(data.ord_Trabajo[0].ord_Fecmod.split("-")[1])] + " del " +
                                    data.ord_Trabajo[0].ord_Fecmod.split("-")[0],
                                text: "Desde la fecha de creacion pasaron 120 dias y la orden de trabajo ha sido anulada."
                            });
                        } else {
                            if (data.prog_Ot != null)
                                TimeLinelist.push({
                                    fecha: data.prog_Ot.prog_Fech.split("-")[2].split("T")[0] + " de " +
                                        meses[parseInt(data.prog_Ot.prog_Fech.split("-")[1])] + " del " +
                                        data.prog_Ot.prog_Fech.split("-")[0],
                                    text: "La Orden de Trabajo fue programada para el " +
                                        data.calendario[0].inicio.split("-")[2].split("T")[0] + " de " +
                                        meses[parseInt(data.calendario[0].inicio.split("-")[1])] + " del " +
                                        data.calendario[0].inicio.split("-")[0] + " hasta el " +
                                        data.calendario[0].fin.split("-")[2].split("T")[0] + " de " +
                                        meses[parseInt(data.calendario[0].fin.split("-")[1])] + " del " +
                                        data.calendario[0].fin.split("-")[0] + ", con el ingeniero " +
                                        data.usuarios.usuNombre + " " + data.usuarios.usuApelli
                                });

                            if (data.inspeccion != null && data.inspeccion.length > 0)
                                TimeLinelist.push({
                                    fecha: data.inspeccion[0].insp_Dic_Fecha.split("-")[2].split("T")[0] + " de " +
                                        meses[parseInt(data.inspeccion[0].insp_Dic_Fecha.split("-")[1])] + " del " +
                                        data.inspeccion[0].insp_Dic_Fecha.split("-")[0],
                                    text: "La Inspeccion realizada a la orden de trabajo fue Aprobada por el director " +
                                        "tecnico"
                                });

                            if (data.rev_DocOt != null && data.rev_DocOt.length > 0)
                                TimeLinelist.push({
                                    fecha: data.rev_DocOt[0].rev_FecCre.split("-")[2].split("T")[0] + " de " +
                                        meses[parseInt(data.rev_DocOt[0].rev_FecCre.split("-")[1])] + " del " +
                                        data.rev_DocOt[0].rev_FecCre.split("-")[0],
                                    text: "Los documentos enviados para realizar la revision documental fueron aprobados."
                                });           

                            if (data.fac_Cont != null && data.fac_Cont.length > 0)
                                if (data.fac_Cont[0].fac_FacVer) {
                                    TimeLinelist.push({
                                        fecha: data.fac_Cont[0].fac_Fechfa.split("-")[2].split("T")[0] + " de " +
                                            meses[parseInt(data.fac_Cont[0].fac_Fechfa.split("-")[1])] + " del " +
                                            data.fac_Cont[0].fac_Fechfa.split("-")[0],
                                        text: "La orden de trabajo fue facturada."
                                    });
                                } else if (data.fac_Cont[0].fac_Conver) {
                                    TimeLinelist.push({
                                        fecha: data.fac_Cont[0].fac_Feccon.split("-")[2].split("T")[0] + " de " +
                                            meses[parseInt(data.fac_Cont[0].fac_Feccon.split("-")[1])] + " del " +
                                            data.fac_Cont[0].fac_Feccon.split("-")[0],
                                        text: "La orden de trabajo fue contabilizada."
                                    });
                                }

                            if (data.env_Dictamen != null)
                                TimeLinelist.push({
                                    fecha: data.env_Dictamen.env_Fecha.split("-")[2].split("T")[0] + " de " +
                                        meses[parseInt(data.env_Dictamen.env_Fecha.split("-")[1])] + " del " +
                                        data.env_Dictamen.env_Fecha.split("-")[0],
                                    text: "Fue emitido y enviado por correo electronico un dictamen para la orden de trabajo."
                                });
                        }

                        $("#div_Tl").css("display", "block");

                        for (var i = 0; i < TimeLinelist.length; i++) {
                            $("#Tl_D" + i).css("display", "block");
                            $("#Tl" + i + "_D").html(TimeLinelist[i].fecha);
                            $("#Tl" + i + "_F").html(TimeLinelist[i].text);
                        }
                    } else {
                        showAlert(data.errorMetodo, "Consultar Orden de Trabajo", "warning");
                    }
                }
                else {
                    $("#div_Tl").fadeOut();
                    $(".infoOrd").html("");
                    $("#div_infoOt").fadeOut(300);
                    showAlert("No se encontro informacion relacionada a la orden de trabajo " + Ord_codotc,
                        "Consultar Orden de Trabajo", "warning");
                }
                $(".disable").removeAttr("disabled");
                $("#Splash_Screen_Load").fadeOut();
            }
        });
    }
}

function LstTipPago() {
    $.ajax({
        url: "/OrdenTrabajo/GetTipAlcance",
        type: 'Post',
        data: {
            Tip_Alcodi: parseInt($("#Alcance").val())
        },
        success: function (data) {
            $(".OptTipAlcance").remove();
            data.forEach(function (TipAlcance) {
                $('<option class="OptTipAlcance" value="' + TipAlcance.tip_alcodi + '">' + TipAlcance.tip_alnomb + '</option>').appendTo("#Tip_Alc");
            });
            $("#Tip_Alc").prop("disabled", false);
        }
    });
}