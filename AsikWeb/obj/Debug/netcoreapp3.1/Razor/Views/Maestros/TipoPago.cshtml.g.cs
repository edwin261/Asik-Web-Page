#pragma checksum "/Users/edwinmarquezmelendez/Documents/Asik/Web Page/Asik-Web-Page/AsikWeb/Views/Maestros/TipoPago.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2c577a321bd4d5bb98a5ceab32e02aff2951ee21"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Maestros_TipoPago), @"mvc.1.0.view", @"/Views/Maestros/TipoPago.cshtml")]
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
#line 1 "/Users/edwinmarquezmelendez/Documents/Asik/Web Page/Asik-Web-Page/AsikWeb/Views/_ViewImports.cshtml"
using AsikWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/edwinmarquezmelendez/Documents/Asik/Web Page/Asik-Web-Page/AsikWeb/Views/_ViewImports.cshtml"
using AsikWeb.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2c577a321bd4d5bb98a5ceab32e02aff2951ee21", @"/Views/Maestros/TipoPago.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c2109d60e96e4519e16dc63e6b6e47db9e0fbf8", @"/Views/_ViewImports.cshtml")]
    public class Views_Maestros_TipoPago : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<AsikWeb.Models.Entidades.TipPago>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("imgNextToTitle"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Button to open menu"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Img/Open_Menu.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("47"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onclick", new global::Microsoft.AspNetCore.Html.HtmlString("OpenHideMenu(true)"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/js/Maestros.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/Users/edwinmarquezmelendez/Documents/Asik/Web Page/Asik-Web-Page/AsikWeb/Views/Maestros/TipoPago.cshtml"
  
    ViewData["Title"] = "TipoPago";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<link rel=""stylesheet"" type=""text/css"" href=""https://cdn.datatables.net/1.10.20/css/jquery.dataTables.css"">
<style>
    .row {
        margin-right: 0;
        margin-left: 0;
    }

    .dataTables_scrollBody {
        height: 317px !important;
    }

    table.dataTable thead .sorting:after,
    table.dataTable thead .sorting:before,
    table.dataTable thead .sorting_asc:after,
    table.dataTable thead .sorting_asc:before,
    table.dataTable thead .sorting_asc_disabled:after,
    table.dataTable thead .sorting_asc_disabled:before,
    table.dataTable thead .sorting_desc:after,
    table.dataTable thead .sorting_desc:before,
    table.dataTable thead .sorting_desc_disabled:after,
    table.dataTable thead .sorting_desc_disabled:before {
        bottom: .5em;
    }

    .col, .col-1, .col-10, .col-11, .col-12, .col-2, .col-3, .col-4, .col-5, .col-6, .col-7, .col-8, .col-9, .col-auto, .col-lg, .col-lg-1, .col-lg-10, .col-lg-11, .col-lg-12, .col-lg-2, .col-lg-3, .col-lg-4, .col-lg-5");
            WriteLiteral(@", .col-lg-6, .col-lg-7, .col-lg-8, .col-lg-9, .col-lg-auto, .col-md, .col-md-1, .col-md-10, .col-md-11, .col-md-12, .col-md-2, .col-md-3, .col-md-4, .col-md-5, .col-md-6, .col-md-7, .col-md-8, .col-md-9, .col-md-auto, .col-sm, .col-sm-1, .col-sm-10, .col-sm-11, .col-sm-12, .col-sm-2, .col-sm-3, .col-sm-4, .col-sm-5, .col-sm-6, .col-sm-7, .col-sm-8, .col-sm-9, .col-sm-auto, .col-xl, .col-xl-1, .col-xl-10, .col-xl-11, .col-xl-12, .col-xl-2, .col-xl-3, .col-xl-4, .col-xl-5, .col-xl-6, .col-xl-7, .col-xl-8, .col-xl-9, .col-xl-auto {
        width: unset;
    }
</style>

<div id=""Splash_Screen_Load"" style=""display: none""></div>
<div class=""row"">
    <div class=""col-md-4 mt-4"">
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "2c577a321bd4d5bb98a5ceab32e02aff2951ee217685", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

        <h4 class=""color_orange text-shadow"">
            Lista formas de Pago
        </h4>
    </div>

    <!-- btn crear nueva OT -->
    <div class=""col-md-7 mt-4"">
        <button type=""button"" class=""btn btn-light TextNegrita float-right border-radius New_OT"" data-toggle=""modal"" data-target=""#AddorEditTippag"" onclick=""$('#SaveOrUpdate').val('agregada')"">
            Crear nueva forma de pago
        </button>
    </div>

    <!-- tabla lista OT -->
    <div class=""col-md-12 mt-2"" style=""margin-bottom:4.5rem"">
        <table id=""dtBasicExample"" class=""table table-sm"" cellspacing=""0"" width=""100%"">
            <thead>
                <tr>
                    <th class=""text-center"">Nombre</th>
                    <th class=""text-center"">Opciones</th>
                </tr>
            </thead>
            <tbody id=""tb_TipPago"">
");
#nullable restore
#line 62 "/Users/edwinmarquezmelendez/Documents/Asik/Web Page/Asik-Web-Page/AsikWeb/Views/Maestros/TipoPago.cshtml"
                 foreach (var tipPago in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr");
            BeginWriteAttribute("id", " id=\"", 2892, "\"", 2915, 1);
#nullable restore
#line 64 "/Users/edwinmarquezmelendez/Documents/Asik/Web Page/Asik-Web-Page/AsikWeb/Views/Maestros/TipoPago.cshtml"
WriteAttributeValue("", 2897, tipPago.TipCodigo, 2897, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <td class=\"text-center\">");
#nullable restore
#line 65 "/Users/edwinmarquezmelendez/Documents/Asik/Web Page/Asik-Web-Page/AsikWeb/Views/Maestros/TipoPago.cshtml"
                                           Write(tipPago.TipNombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td class=\"text-center\">\r\n                            <button type=\"button\" class=\"btn btn-link TextNegrita disable\" style=\"color:black !important\" data-toggle=\"modal\" data-target=\"#AddorEditTippag\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3214, "\"", 3256, 3);
            WriteAttributeValue("", 3224, "SearchTipago(", 3224, 13, true);
#nullable restore
#line 67 "/Users/edwinmarquezmelendez/Documents/Asik/Web Page/Asik-Web-Page/AsikWeb/Views/Maestros/TipoPago.cshtml"
WriteAttributeValue("", 3237, tipPago.TipCodigo, 3237, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3255, ")", 3255, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                Editar\r\n                            </button>\r\n                            <button type=\"button\" class=\"btn btn-link TextNegrita disable\" style=\"color:red !important\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3458, "\"", 3498, 3);
            WriteAttributeValue("", 3468, "DelFormPag(", 3468, 11, true);
#nullable restore
#line 70 "/Users/edwinmarquezmelendez/Documents/Asik/Web Page/Asik-Web-Page/AsikWeb/Views/Maestros/TipoPago.cshtml"
WriteAttributeValue("", 3479, tipPago.TipCodigo, 3479, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3497, ")", 3497, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                Eliminar\r\n                            </button>\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 75 "/Users/edwinmarquezmelendez/Documents/Asik/Web Page/Asik-Web-Page/AsikWeb/Views/Maestros/TipoPago.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </tbody>
        </table>
    </div>
</div>

<div class=""modal fade"" id=""AddorEditTippag"" tabindex=""-1"" role=""dialog"" aria-labelledby=""Askcreate"" aria-hidden=""true"" data-backdrop=""static"" data-keyboard=""false"">
    <div class=""modal-dialog modal-dialog-centered"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""AskcreateClientTitle"">Forma de Pago</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                <h6>Forma de Pago</h6>
                <input type=""hidden"" class=""form-control col-md-12"" id=""SaveOrUpdate"" />
                <input type=""hidden"" class=""form-control col-md-12"" id=""TipCodigo"" />
                <input type=""text"" class=""form-control"" id=""tipag"" />
            </div>
            <d");
            WriteLiteral(@"iv class=""modal-footer"">
                <button type=""button"" class=""btn btn-light TextNegrita border-radius New_OT btn-light-green disable"" onclick=""AddorEditTippag()"">Guardar</button>
                <button type=""button"" class=""btn btn-light TextNegrita border-radius New_OT btn-light-green disable"" data-dismiss=""modal"" onclick=""$('#tipag').val('')"">Cancelar</button>
            </div>
        </div>
    </div>
</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2c577a321bd4d5bb98a5ceab32e02aff2951ee2114498", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
#nullable restore
#line 106 "/Users/edwinmarquezmelendez/Documents/Asik/Web Page/Asik-Web-Page/AsikWeb/Views/Maestros/TipoPago.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <script type=""text/javascript"" charset=""utf8"" src=""/js/jquery.dataTables.js""></script>
    <script>
        $(document).ready(function () {
            $('#dtBasicExample').DataTable({

                language: {
                    url: '/js/Spanish.json'
                },
                lengthMenu: [5, 10, 20, 50, 100, 200, 500, 10000]
            });
            $('.dataTables_length').addClass('bs-select');
        });
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<AsikWeb.Models.Entidades.TipPago>> Html { get; private set; }
    }
}
#pragma warning restore 1591
