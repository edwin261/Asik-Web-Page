#pragma checksum "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\OrdenTrabajo\Show.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "407b9a5a30cc054486bae08b2ba444f65155fbbe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_OrdenTrabajo_Show), @"mvc.1.0.view", @"/Views/OrdenTrabajo/Show.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"407b9a5a30cc054486bae08b2ba444f65155fbbe", @"/Views/OrdenTrabajo/Show.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c2109d60e96e4519e16dc63e6b6e47db9e0fbf8", @"/Views/_ViewImports.cshtml")]
    public class Views_OrdenTrabajo_Show : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AsikWeb.Models.ViewModels.AsikViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("imgNextToTitle"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Button to open menu"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Img/Open_Menu.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("47"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onclick", new global::Microsoft.AspNetCore.Html.HtmlString("OpenHideMenu(true)"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\OrdenTrabajo\Show.cshtml"
  
    ViewData["Title"] = "Ver O.T.";

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

    .col, .col-1, .col-10, .col-11, .col-12, .col-2, .col-3, .col-4, .col-5, .col-6, .col-7, .col-8, .col-9, .col-auto, .col-lg, .col-lg-1, .col-lg-10, .col-lg-11, .col-lg-12, .col-lg-2, .col-lg-3, .col-lg-4, .col-lg-5,");
            WriteLiteral(@" .col-lg-6, .col-lg-7, .col-lg-8, .col-lg-9, .col-lg-auto, .col-md, .col-md-1, .col-md-10, .col-md-11, .col-md-12, .col-md-2, .col-md-3, .col-md-4, .col-md-5, .col-md-6, .col-md-7, .col-md-8, .col-md-9, .col-md-auto, .col-sm, .col-sm-1, .col-sm-10, .col-sm-11, .col-sm-12, .col-sm-2, .col-sm-3, .col-sm-4, .col-sm-5, .col-sm-6, .col-sm-7, .col-sm-8, .col-sm-9, .col-sm-auto, .col-xl, .col-xl-1, .col-xl-10, .col-xl-11, .col-xl-12, .col-xl-2, .col-xl-3, .col-xl-4, .col-xl-5, .col-xl-6, .col-xl-7, .col-xl-8, .col-xl-9, .col-xl-auto {
        width: unset;
    }
</style>

<div class=""row"">
    <div class=""col-md-4 mt-4"">
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "407b9a5a30cc054486bae08b2ba444f65155fbbe6864", async() => {
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
            WriteLiteral("\r\n\r\n        <h4 class=\"color_orange text-shadow\">\r\n            Lista Ordenes de trabajo\r\n        </h4>\r\n    </div>\r\n\r\n    <!-- btn crear nueva OT -->\r\n    <div class=\"col-md-7 mt-4\">\r\n");
#nullable restore
#line 45 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\OrdenTrabajo\Show.cshtml"
         foreach (var identities in User.Identities.ToList())
        {
            foreach (var rol in identities.Claims)
            {
                switch (rol.Value)
                {
                    case "1":

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <a href=\"/OrdenTrabajo/Index\" class=\"btn btn-light TextNegrita float-right border-radius New_OT\">\r\n                            Crear nueva OT\r\n                        </a>\r\n");
#nullable restore
#line 55 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\OrdenTrabajo\Show.cshtml"
                        break;
                }
            }
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </div>

    <!-- tabla lista OT -->
    <div class=""col-md-12 mt-2"" style=""margin-bottom:4.5rem"">
        <table id=""dtBasicExample"" class=""table table-sm"" cellspacing=""0"" width=""100%"">
            <thead>
                <tr>
                    <th class=""text-center"">Codigo</th>
                    <th class=""text-center"">Nombre</th>
                    <th class=""text-center"">Cliente</th>
                    <th class=""text-center"">Fecha Creacion</th>
                    <th class=""text-center"">Estado</th>
                    <th class=""text-center"">Accion</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 75 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\OrdenTrabajo\Show.cshtml"
                 if (Model != null)
                {
                    foreach (var LstOt in Model.Ord_Trabajo.Where(w => w.Ord_Estado != 6))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td class=\"text-center\">");
#nullable restore
#line 80 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\OrdenTrabajo\Show.cshtml"
                                               Write(LstOt.Ord_Prefot);

#line default
#line hidden
#nullable disable
            WriteLiteral("-");
#nullable restore
#line 80 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\OrdenTrabajo\Show.cshtml"
                                                                 Write(LstOt.Ord_Codotc.ToString().PadLeft(8, '0'));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td class=\"text-center\">");
#nullable restore
#line 81 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\OrdenTrabajo\Show.cshtml"
                                               Write(LstOt.Ord_Nomproy);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td class=\"text-center\">");
#nullable restore
#line 82 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\OrdenTrabajo\Show.cshtml"
                                               Write(Model.Clientes.Where(w => w.CliIdenti == LstOt.Ord_Codcli).Select(s => s.CliNombre).FirstOrDefault());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td class=\"text-center\">");
#nullable restore
#line 83 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\OrdenTrabajo\Show.cshtml"
                                               Write(LstOt.Ord_Feccre.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td class=\"text-center\">");
#nullable restore
#line 84 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\OrdenTrabajo\Show.cshtml"
                                               Write(Model.Estados.Where(w => w.EstCodigo == LstOt.Ord_Estado).Select(s => s.EstNombre).FirstOrDefault());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td class=\"text-center\">\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 4116, "\"", 4172, 2);
            WriteAttributeValue("", 4123, "/OrdenTrabajo/ShowOT?Ord_CodOtc=", 4123, 32, true);
#nullable restore
#line 86 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\OrdenTrabajo\Show.cshtml"
WriteAttributeValue("", 4155, LstOt.Ord_Codotc, 4155, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-light TextNegrita float-right border-radius New_OT\">\r\n                                    Ver\r\n                                </a>\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 91 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\OrdenTrabajo\Show.cshtml"
                    }
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AsikWeb.Models.ViewModels.AsikViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
