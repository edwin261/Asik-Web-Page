#pragma checksum "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\VisitaTecnica\VisiTec_OtLst.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bf012dd5cc2521c4232d8dff796e15e7da9e2463"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_VisitaTecnica_VisiTec_OtLst), @"mvc.1.0.view", @"/Views/VisitaTecnica/VisiTec_OtLst.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\_ViewImports.cshtml"
using AsikWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\_ViewImports.cshtml"
using AsikWeb.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf012dd5cc2521c4232d8dff796e15e7da9e2463", @"/Views/VisitaTecnica/VisiTec_OtLst.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c2109d60e96e4519e16dc63e6b6e47db9e0fbf8", @"/Views/_ViewImports.cshtml")]
    public class Views_VisitaTecnica_VisiTec_OtLst : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AsikWeb.Models.ViewModels.AsikViewModel>
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\VisitaTecnica\VisiTec_OtLst.cshtml"
  
    ViewData["Title"] = "Visita Tecnica";
    int rolusu = Model.Rol_Usuario.Where(w => w.RolCodigo == 4).Count();

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/tempusdominus-bootstrap-4/5.0.0-alpha14/css/tempusdominus-bootstrap-4.min.css"" />
<link href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.13.0/css/all.min.css"" rel=""stylesheet"" crossorigin=""anonymous"">

<input type=""hidden"" id=""slt_CodiTec""");
            BeginWriteAttribute("value", " value=\"", 496, "\"", 552, 1);
#nullable restore
#line 10 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\VisitaTecnica\VisiTec_OtLst.cshtml"
WriteAttributeValue("", 504, Convert.ToInt32(User.Claims.ElementAt(1).Value), 504, 48, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n\r\n");
#nullable restore
#line 12 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\VisitaTecnica\VisiTec_OtLst.cshtml"
 if (Model.Rol_Usuario.Count() > 1)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <select class=\"form-control mb-2\" id=\"rol_usu\" onchange=\"changeTipoCalendar(this.value)\">\r\n");
#nullable restore
#line 15 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\VisitaTecnica\VisiTec_OtLst.cshtml"
         foreach (var ru in Model.Rol_Usuario)
        {
            if (ru.RolCodigo == 4 && rolusu >= 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bf012dd5cc2521c4232d8dff796e15e7da9e24634993", async() => {
                WriteLiteral("\r\n                    ");
#nullable restore
#line 20 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\VisitaTecnica\VisiTec_OtLst.cshtml"
               Write(Model.LstRol.Where(w => w.RolCodigo == ru.RolCodigo).Select(s => s.RolNombre).FirstOrDefault());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 19 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\VisitaTecnica\VisiTec_OtLst.cshtml"
                            WriteLiteral(Model.LstRol.Where(w=>w.RolCodigo == ru.RolCodigo).Select(s=>s.RolCodigo).FirstOrDefault());

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 22 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\VisitaTecnica\VisiTec_OtLst.cshtml"
            }

            if (ru.RolCodigo == 5 && rolusu == 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bf012dd5cc2521c4232d8dff796e15e7da9e24637719", async() => {
                WriteLiteral("\r\n                    ");
#nullable restore
#line 27 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\VisitaTecnica\VisiTec_OtLst.cshtml"
               Write(Model.LstRol.Where(w => w.RolCodigo == ru.RolCodigo).Select(s => s.RolNombre).FirstOrDefault());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 26 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\VisitaTecnica\VisiTec_OtLst.cshtml"
                            WriteLiteral(Model.LstRol.Where(w=>w.RolCodigo == ru.RolCodigo).Select(s=>s.RolCodigo).FirstOrDefault());

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 29 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\VisitaTecnica\VisiTec_OtLst.cshtml"
            }
            else if (ru.RolCodigo == 5 && rolusu >= 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bf012dd5cc2521c4232d8dff796e15e7da9e246310448", async() => {
                WriteLiteral("\r\n                    ");
#nullable restore
#line 33 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\VisitaTecnica\VisiTec_OtLst.cshtml"
               Write(Model.LstRol.Where(w => w.RolCodigo == ru.RolCodigo).Select(s => s.RolNombre).FirstOrDefault());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 32 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\VisitaTecnica\VisiTec_OtLst.cshtml"
                   WriteLiteral(Model.LstRol.Where(w=>w.RolCodigo == ru.RolCodigo).Select(s=>s.RolCodigo).FirstOrDefault());

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 35 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\VisitaTecnica\VisiTec_OtLst.cshtml"
            }
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </select>\r\n");
#nullable restore
#line 38 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\VisitaTecnica\VisiTec_OtLst.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <input type=\"hidden\" id=\"rol_usu\"");
            BeginWriteAttribute("value", " value=\"", 1907, "\"", 1960, 1);
#nullable restore
#line 41 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\VisitaTecnica\VisiTec_OtLst.cshtml"
WriteAttributeValue("", 1915, Model.Rol_Usuario.FirstOrDefault().RolCodigo, 1915, 45, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
#nullable restore
#line 42 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\VisitaTecnica\VisiTec_OtLst.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div id=""calender""></div>

<div id=""myModal"" class=""modal fade"" role=""dialog"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header text-center"">
                <h4 class=""modal-title""><span id=""eventTitle""></span></h4>
            </div>
            <div class=""modal-body"">
                <p id=""pDetails""></p>
            </div>
            <div class=""modal-footer text-center"">
                <button type=""button"" class=""btn btn-default"" data-dismiss=""modal""
                        onclick=""$('#CalendarModal').modal('show');"">
                    Volver al calendario
                </button>

                <button type=""button"" id=""btnclick"" class=""btn btn-light TextNegrita float-right border-radius New_OT"">
                    Ver Inspeccion
                </button>
            </div>
        </div>
    </div>
</div>

<link href=""//cdnjs.cloudflare.com/ajax/libs/fullcalendar/3.4.0/fullcalendar.min.css"" rel=""stylesheet"" />");
            WriteLiteral("\n<link href=\"//cdnjs.cloudflare.com/ajax/libs/fullcalendar/3.4.0/fullcalendar.print.css\" rel=\"stylesheet\" media=\"print\" />\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/moment.js/2.18.1/moment.min.js""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/fullcalendar/3.4.0/fullcalendar.min.js""></script>

    <script>
        var events = [];
        $(document).ready(function () {
            LoadCalendar($(""#rol_usu"").val());
        })

        function changeTipoCalendar(rol) {
            LoadCalendar(rol);
        }

        function LoadCalendar(rol) {
            $.ajax({
                type: ""Post"",
                url: ""/ProgramarOT/GetProgramacion"",
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
                   ");
                WriteLiteral(@"             events.push({
                                    codOt: data.ord_Trabajo[i].ord_Codotc,
                                    Nom_Cli: data.clientes[i].cliNombre,
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
                            endDate = events.end;
                        }
                    }
                  ");
                WriteLiteral(@"  GenerateCalender(events);
                },
                error: function (error) {
                    showAlert(""Ha ocurrido un error"",
                        ""Visita Tecnica"", ""warning"");
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
      ");
                WriteLiteral(@"          defaultDate: new Date(),
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
                    $("".fc-prevYear-button"").text(y - 1);
                    $("".fc-nextYear-button"").html(y + 1);
                },
                eventLimit: true,
                eventColor: '#378006',
                events: events,
                eventClick: function (calEvent, jsEvent, view) {
                    selectedEvent = calEvent;
                    $('#myModal #eventTitle').text(calEvent.proyect_name);
         ");
                WriteLiteral(@"           var $description = $('<div/>');
                    $description.append($('<p/>').html('<b>Cliente: </b>' + calEvent.Nom_Cli));
                    $description.append($('<p/>').html('<b>Inicio: </b>' + calEvent.start.format(""DD-MMM-YYYY"")));
                    if (calEvent.end != null) {
                        $description.append($('<p/>').html('<b>Fin: </b>' + calEvent.end.format(""DD-MMM-YYYY"")));
                    } else {
                        $description.append($('<p/>').html('<b>Fin: </b>' + calEvent.start.format(""DD-MMM-YYYY"")));
                    }
                    $description.append($('<p/>').html('<b>Descripcion: </b>' + calEvent.description));
                    $('#myModal #pDetails').empty().html($description);

                    $('#CalendarModal').modal('hide');
                    $('#myModal').modal();
                },
            });
            $("".fc-month-button"").html(""Mes"");
            $("".fc-basicWeek-button"").html(""Semana"");
            $");
                WriteLiteral(@"("".fc-basicDay-button"").html(""Dia"");
            $("".fc-today-button"").html(""Hoy"");
            $('#CalendarModal').modal('show');
        }

        $('#btnclick').click(function () {
            LoadEventView();
        });

        function LoadEventView() {
            if (selectedEvent != null) {
                location.href = ""/VisitaTecnica/Visit_Start?Ord_CodOtc="" + selectedEvent.codOt;
            }
        }
    </script>
");
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AsikWeb.Models.ViewModels.AsikViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
