function SaveCliente(event) {
    event.preventDefault();
    $("#Splash_Screen_Load").fadeIn();
    $(".disable").prop("disabled", true);

    var ClientesArray = {
        CliCodigo: parseInt($("#Cli_Codigo").val()),
        CliIdenti: parseInt($("#Codigo_Id").val()),
        CliDverif: parseInt($("#CliDverif").val()),
        CliNombre: $("#Cliente_name").val().toUpperCase(),
        CliTelefo: $("#Cliente_tel").val(),
        CliDirecc: $("#Dir_Cli").val().toUpperCase(),
        DepCodigo: parseInt($("#Dep_Cli").val()),
        CiuCodigo: parseInt($("#Ciu_Cli").val())
    }

    $.ajax({
        url: "/Maestros/Add_Clientes",
        type: 'Post',
        data: {
            save: $("#optsave").val(),
            clientes: ClientesArray
        },
        success: function (data) {
            if (data.status) {
                showAlert(data.message, "Creacion de cliente", "success");
                if (parseInt($("#Cli_Codigo").val()) == 0) {
                    $("#Askcreate").modal("show");
                } else {
                    location.href = "/Maestros/Lst_Clientes";
                }
            } else {
                showAlert(data.message, "Creacion de cliente", "warning");
                $(".disable").prop("disabled", false);
            }
            $("#Splash_Screen_Load").fadeOut();
        }
    });
}

function AddSedeCliente(SaveOrEdit) {
    $("#Splash_Screen_Load").fadeIn();

    var SedeArray = {
        SeCodigo: parseInt($("#SeCodigo").val()),
        SeCliIden: parseInt($("#Codigo_Id").val()),
        SeNumIden: parseInt($("#SCodigo_Id").val()),
        SeDigver: parseInt($("#SCliDverif").val()),
        SeNomSed: $("#SCliente_name").val().toUpperCase(),
        SeNumTel: $("#SCliente_tel").val().toUpperCase(),
        SeDirecc: $("#SDir_Cli").val().toUpperCase(),
        SeDepart: parseInt($("#SDep_Cli").val()),
        SeCiudad: parseInt($("#SCiu_Cli").val())
    }

    $.ajax({
        url: "/Maestros/AddSedeCliente",
        type: 'Post',
        data: {
            save: SaveOrEdit,
            sede: SedeArray
        },
        success: function (data) {
            if (data.status) {
                showAlert(data.message, "Sede", "success");
                setTimeout(location.reload(), 3000);
            } else {
                showAlert(data.message, "Sede", "warning");
                $("#Splash_Screen_Load").fadeOut();
            }
        }
    });
}

function Delete_Sede(Cod_sede) {
    $("#Splash_Screen_Load").fadeIn();
    $.ajax({
        url: "/Maestros/Delete_Sede",
        type: 'Post',
        data: {
            Cod_sede: Cod_sede
        },
        success: function (data) {
            if (data.status) {
                showAlert(data.message, "Sede", "success");
                $("#" + Cod_sede).css("display", "none");
            } else {
                showAlert(data.message, "Sede", "warning");
            }
            $("#Splash_Screen_Load").fadeOut();
        }
    });
}

function HideOrShowBtn(opt, Cod_sede) {
    switch (opt) {
        case 1:
            $("#btnsavesede").fadeIn();
            $("#btneditsede").fadeOut();
            break;
        case 2:
            $("#btneditsede").fadeIn();
            $("#btnsavesede").fadeOut();

            $("#Splash_Screen_Load").fadeIn();
            $.ajax({
                url: "/Maestros/Get_Sede",
                type: 'Post',
                data: {
                    Cod_sede: Cod_sede
                },
                success: function (data) {
                    if (data != null) {
                        $("#ModalNewSede").modal("show");
                        $("#SDep_Cli").val(data.seDepart);
                        Lstciudades(true, data.seCiudad);
                        $("#SeCodigo").val(data.seCodigo);
                        $("#Codigo_Id").val(data.seCliIden);
                        $("#SCodigo_Id").val(data.seNumIden);
                        $("#SCliDverif").val(data.seDigver);
                        $("#SCliente_name").val(data.seNomSed);
                        $("#SCliente_tel").val(data.seNumTel);
                        $("#SDir_Cli").val(data.seDirecc);

                        $("#SCodigo_Id").attr("readonly", "readonly");
                        $("#SCliente_name").removeAttr("readonly");
                        $("#SCliente_tel").removeAttr("readonly");
                        $("#SDir_Cli").removeAttr("readonly");
                    } else {
                        showAlert("Sede no encontrada", "Sede", "warning");
                    }
                    $("#Splash_Screen_Load").fadeOut();
                }
            });

            break;
    }
}

function SaveUsuario(event) {
    event.preventDefault();
    $("#Splash_Screen_Load").fadeIn();
    $(".disable").prop("disabled", true);

    var UsuarioArray = {
        UsuCodigo: parseInt($("#Usu_Codigo").val()),
        UsuIdenti: parseInt($("#Codigo_Id").val()),
        UsuNombre: $("#UsuNombre").val().toUpperCase(),
        UsuApelli: $("#UsuApelli").val().toUpperCase(),
        UsuContra: $("#UsuContra").val().toUpperCase(),
        UsuEmail: $("#Usu_Email").val(),
        UsuEstad: 5
    }

    var Usuario_Rol = [];

    $("input:checkbox:checked").each(function () {
        Usuario_Rol.push({
            RolCodigo: parseInt($(this).val()),
            UsuIdenti: parseInt($("#Codigo_Id").val()),
            MenCodigo: 1
        });
    });

    $.ajax({
        url: "/Maestros/Add_Usuarios",
        type: 'Post',
        data: {
            usuarios: UsuarioArray,
            rol_Usuario: Usuario_Rol
        },
        success: function (data) {
            if (data.status) {
                showAlert(data.message, "Creacion de cliente", "success");
                if (parseInt($("#Usu_Codigo").val()) == 0) {
                    $("#Askcreate").modal("show");
                } else {
                    location.href = "/Maestros/Lst_Usuarios";
                }
            } else {
                showAlert(data.message, "Creacion de Usuario", "warning");
                $(".disable").prop("disabled", false);
            }
            $("#Splash_Screen_Load").fadeOut();
        }
    });
}

function Lstciudades(modal, cod_ciu) {
    var depCli = "";
    if (modal) {
        depCli = parseInt($("#SDep_Cli").val());
    } else {
        depCli = parseInt($("#Dep_Cli").val());
    }

    $.ajax({
        url: "/Maestros/Lstciudades",
        type: 'Post',
        data: {
            Dep_Codigo: parseInt(depCli)
        },
        success: function (data) {
            if (modal) {
                $(".SOptciudades").remove();
                data.forEach(function (ciudad) {
                    if (ciudad.ciu_Codigo == cod_ciu) {
                        $('<option selected class="SOptciudades" value="' + ciudad.ciu_Codigo + '">' + ciudad.ciu_Nombre + '</option>').appendTo("#SCiu_Cli");
                    } else {
                        $('<option class="SOptciudades" value="' + ciudad.ciu_Codigo + '">' + ciudad.ciu_Nombre + '</option>').appendTo("#SCiu_Cli");
                    }
                });
            } else {
                $(".Optciudades").remove();
                data.forEach(function (ciudad) {
                    if (ciudad.ciu_Codigo == parseInt($("#CiuCod_Cli").val())) {
                        $('<option selected class="Optciudades" value="' + ciudad.ciu_Codigo + '">' + ciudad.ciu_Nombre + '</option>').appendTo("#Ciu_Cli");
                    } else {
                        $('<option class="Optciudades" value="' + ciudad.ciu_Codigo + '">' + ciudad.ciu_Nombre + '</option>').appendTo("#Ciu_Cli");
                    }
                });
            }

        }
    });
}

function VerifiNit(nit, modal) {
    if (nit != "") {
        $("#Splash_Screen_Load").fadeIn();
        $.ajax({
            url: "/Maestros/VerifiNit",
            type: 'Post',
            data: {
                Nit: parseInt(nit)
            },
            success: function (data) {
                if (modal) {
                    if (data.length > 0) {
                        showAlert(data.message, "Nit creado anteriormente", "warning");
                    } else {
                        $(".Sclear").val("");
                        $(".Sclear").attr("readonly", false);
                    }
                } else {
                    if (data.length > 0) {

                        $("#optsave").val('false');
                        $("#Dep_Cli").val(data[0].depCodigo);
                        Lstciudades(false);

                        $("#Cli_Codigo").val(data[0].cliCodigo);
                        $("#CliDverif").val(data[0].cliDverif);
                        $("#Cliente_name").val(data[0].cliNombre);
                        $("#Cliente_tel").val(data[0].cliTelefo);
                        $("#Dir_Cli").val(data[0].cliDirecc);
                        $("#Ciu_Cli").val(data[0].ciuCodigo);
                        $(".clear").attr("readonly", false);
                        $("#CliDverif").attr("readonly", true);
                    } else {
                        $(".clear").val("");
                        $(".clear").attr("readonly", false);
                        $("#optsave").val('true');
                    }
                }
                $("#Splash_Screen_Load").fadeOut();
            }
        });
    }
}

function VerifiNitUsu(nit) {
    if (nit != "") {
        $("#Splash_Screen_Load").fadeIn();
        $.ajax({
            url: "/Maestros/VerifiNitUsu",
            type: 'Post',
            data: {
                Nit: parseInt(nit)
            },
            success: function (data) {
                if (data != null) {
                    if (data.lstUsuarios.length > 0) {
                        $("#optsave").val('false');
                        $("#UsuNombre").val(data.lstUsuarios[0].usuNombre);
                        $("#UsuApelli").val(data.lstUsuarios[0].usuApelli);
                        $("#UsuContra").val(data.lstUsuarios[0].usuContra);
                        $("#Usu_Email").val(data.lstUsuarios[0].UsuEmail);
                        if (data.lstUsuarios == null) {
                            $("#rol_Usu").val(1)
                        } else {
                            $("#rol_Usu").val(data.rol_Usuario[0].rolCodigo)
                        }
                        $("#RolId").val(data.rol_Usuario[0].rolId)

                        $(".clear").attr("readonly", false);
                    } else {
                        $(".clear").val("");
                        $("#rol_Usu").val(1);
                        $(".clear").attr("readonly", false);
                        $("#optsave").val('true');
                    }
                } else {
                    $(".clear").val("");
                    $("#rol_Usu").val(1);
                    $(".clear").attr("readonly", false);
                    $("#optsave").val('true');
                }
                $("#Splash_Screen_Load").fadeOut();
            }
        });
    }
}

function NewClient(view) {
    $(".clear").val("");
    $(".clear").attr("readonly", true);
    $("#Codigo_Id").val("");
    if (view == "Cli") {
        $("#Dep_Cli").val(1);
        Lstciudades(false);
    } else if (view == "Usu") {
        $("#rol_Usu").val(1);
    }
    $("#Askcreate").modal("hide");
}

function SaveHerramienta(event) {
    event.preventDefault();
    $("#Splash_Screen_Load").fadeIn();
    $(".disable").prop("disabled", true);

    var Herramienta = {
        HerCodigo: parseInt($("#HerCodigo").val()),
        HerNombre: $("#HerNombre").val().toUpperCase(),
        HerNumser: $("#HerNumser").val(),
        HerMarca: $("#Her_Marca").val().toUpperCase(),
        HerObser: $("#slt_her").val()
    };

    var Her_Usu = [];

    $("input:checkbox:checked").each(function () {
        Her_Usu.push({
            Hercodigo: parseInt($("#HerCodigo").val()),
            Usu_identi: parseInt($(this).val())
        });
    });

    $.ajax({
        url: "/Maestros/SaveHerramienta",
        type: 'Post',
        data: {
            herramientas: Herramienta,
            herramientas_Usuarios: Her_Usu
        },
        success: function (data) {
            if (data.status) {
                showAlert(data.message, "Creacion de Herramienta", "success");
                $("#Askcreate").modal("show");
            } else {
                $(".disable").prop("disabled", false);
                showAlert(data.message, "Creacion de Herramienta", "warning");
            }
            $("#Splash_Screen_Load").fadeOut();
        }
    });
}

function ShowOrHideAddHerTec(value) {
    switch (value) {
        case "OFICINA":
            $(".lst_TecHer").css("display", "none");
            break;
        default:
            $(".lst_TecHer").css("display", "flex");
    }
}

function AddorEditTippag() {
    $(".btn-light-green").attr("disabled", true);
    $("#tipag").attr("readonly", "readonly");

    var TipoPago = {
        tipCodigo: $('#TipCodigo').val(),
        TipNombre: $('#tipag').val().toUpperCase(),
        TipEstado: 5
    }
    $.ajax({
        url: "/Maestros/AddOrUpdateTipag",
        type: 'Post',
        data: {
            tipPago: TipoPago,
            save: $('#SaveOrUpdate').val()
        },
        success: function (data) {
            if (data.status) {
                showAlert(data.message, "Forma de pago", "success");
                setTimeout("location.reload()", 2000);
            } else {
                showAlert(data.message, "Forma de pago", "warning");
                $(".btn-light-green").removeAttr("disabled");
                $("#tipag").removeAttr("readonly");
            }
        }
    });
}

function DelFormPag(TipCodigo) {
    $("#Splash_Screen_Load").fadeIn();
    $(".disable").prop("disabled", true);
    $.ajax({
        url: "/Maestros/DeleteFrmPago",
        type: 'Post',
        data: {
            TipCodigo: TipCodigo
        },
        success: function (data) {
            if (data.status) {
                $(".disable").prop("disabled", false);
                showAlert(data.message, "Forma de pago", "success");
                $("#" + TipCodigo).fadeOut("slow");
            } else {
                $(".disable").prop("disabled", false);
                showAlert(data.message, "Forma de pago", "warning");
            }
            $("#Splash_Screen_Load").fadeOut();
        }
    });
}

function SearchTipago(id) {
    $.ajax({
        url: "/Maestros/SearchTipago",
        type: 'Post',
        data: {
            TipCodigo: parseInt(id)
        },
        success: function (data) {
            if (data != null) {
                $('#SaveOrUpdate').val('actualizada');
                $('#TipCodigo').val(data.tipCodigo);
                $('#tipag').val(data.tipNombre);
            } else {
                showAlert(data.message, "Forma de pago", "warning");
            }
        }
    });
}