#pragma checksum "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\VisitaTecnica\Visit_Start.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1f4f53b532d50e90dea9a4c948422fcd2b3c351a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_VisitaTecnica_Visit_Start), @"mvc.1.0.view", @"/Views/VisitaTecnica/Visit_Start.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f4f53b532d50e90dea9a4c948422fcd2b3c351a", @"/Views/VisitaTecnica/Visit_Start.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c2109d60e96e4519e16dc63e6b6e47db9e0fbf8", @"/Views/_ViewImports.cshtml")]
    public class Views_VisitaTecnica_Visit_Start : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AsikWeb.Models.ViewModels.AsikViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("charset", new global::Microsoft.AspNetCore.Html.HtmlString("utf8"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "/js/VisitaTecnica.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\VisitaTecnica\Visit_Start.cshtml"
  
    ViewData["Title"] = "Visita Tecnica";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div id=\"Splash_Screen_Load\" style=\"display: none\"></div>\r\n<div class=\"row\">\r\n    <div class=\"col-md-3\">\r\n        <h6>Orden de trabajo</h6>\r\n        <input type=\"text\" class=\"form-control inputText_NoBorder inputHeight\" id=\"Cod_OT\"");
            BeginWriteAttribute("value", "\r\n               value=\"", 330, "\"", 426, 1);
#nullable restore
#line 10 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\VisitaTecnica\Visit_Start.cshtml"
WriteAttributeValue("", 354, Model.Ord_Trabajo.FirstOrDefault().Ord_Codotc.ToString().PadLeft(8,'0'), 354, 72, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" readonly\r\n               name=\"O_Trabajo\" />\r\n        <input type=\"hidden\" id=\"Insp_Codigo\"");
            BeginWriteAttribute("value", " value=\"", 519, "\"", 573, 1);
#nullable restore
#line 12 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\VisitaTecnica\Visit_Start.cshtml"
WriteAttributeValue("", 527, Model.inspeccion.FirstOrDefault().Insp_Codigo, 527, 46, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    </div>\r\n");
#nullable restore
#line 14 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\VisitaTecnica\Visit_Start.cshtml"
     foreach (var rol in User.Claims)
    {
        switch (rol.Value)
        {
            case "5":

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-md-5\">\r\n                    <h6>Nombre Inspector</h6>\r\n                    <input type=\"text\" class=\"form-control inputText_NoBorder inputHeight\"");
            BeginWriteAttribute("value", "\r\n                           value=\"", 876, "\"", 963, 2);
#nullable restore
#line 22 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\VisitaTecnica\Visit_Start.cshtml"
WriteAttributeValue("", 912, Model.Usuarios.UsuNombre, 912, 25, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\VisitaTecnica\Visit_Start.cshtml"
WriteAttributeValue(" ", 937, Model.Usuarios.UsuApelli, 938, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" readonly name=\"Nomtec\" />\r\n                </div>\r\n");
#nullable restore
#line 24 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\VisitaTecnica\Visit_Start.cshtml"
                break;
        }
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n<div class=\"row mt-3\">\r\n    <div class=\"col-md-4\">\r\n        <h6>Nombre del Proyecto</h6>\r\n        <input type=\"text\" class=\"form-control inputText_NoBorder inputHeight\" name=\"N_Proyecto\"\r\n               readonly");
            BeginWriteAttribute("value", " value=\"", 1279, "\"", 1334, 1);
#nullable restore
#line 33 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\VisitaTecnica\Visit_Start.cshtml"
WriteAttributeValue("", 1287, Model.Ord_Trabajo.FirstOrDefault().Ord_Nomproy, 1287, 47, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    </div>\r\n    <div class=\"col-md-4\">\r\n        <h6>Nombre del Cliente</h6>\r\n        <input type=\"text\" class=\"form-control inputText_NoBorder inputHeight\" name=\"N_Cliente\"\r\n               readonly");
            BeginWriteAttribute("value", " value=\"", 1537, "\"", 1587, 1);
#nullable restore
#line 38 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\VisitaTecnica\Visit_Start.cshtml"
WriteAttributeValue("", 1545, Model.Clientes.FirstOrDefault().CliNombre, 1545, 42, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    </div>\r\n    <div class=\"col-md-4\">\r\n        <h6>Fecha</h6>\r\n        <input type=\"date\" readonly class=\"form-control\"");
            BeginWriteAttribute("value", "\r\n               value=\"", 1713, "\"", 1806, 1);
#nullable restore
#line 43 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\VisitaTecnica\Visit_Start.cshtml"
WriteAttributeValue("", 1737, Model.Ord_Trabajo.FirstOrDefault().Ord_Feccre.ToString("yyyy-MM-dd"), 1737, 69, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    </div>\r\n</div>\r\n\r\n<div class=\"row mt-3\">\r\n    <!-- Info adicional -->\r\n    <div class=\"col-md-8 col-sm-12\">\r\n        <div class=\"card\">\r\n            <h6 class=\"color_orange text-center\" style=\"padding:1.2vh\">Detalle visita Orden Tecnica</h6>\r\n");
#nullable restore
#line 52 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\VisitaTecnica\Visit_Start.cshtml"
             foreach (var rol in User.Claims)
            {
                if (rol.Value == "4" && Model.inspeccion.FirstOrDefault().Insp_Inici == null || rol.Value == "4" && Model.inspeccion.FirstOrDefault().Insp_Fin == null && rol.Subject.Name == Model.Usuarios.UsuNombre)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 56 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\VisitaTecnica\Visit_Start.cshtml"
                     if (Model.inspeccion.Count() > 0 && Model.inspeccion.FirstOrDefault().Insp_Acept)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <label class=\"text-center\">Aceptaci&oacute;n <input type=\"checkbox\" checked disabled class=\"ml-1\"></label>\r\n");
#nullable restore
#line 59 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\VisitaTecnica\Visit_Start.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <label class=""text-center"">Aceptaci&oacute;n <input type=""checkbox"" id=""Accept"" class=""ml-1"" value=""1""></label>
                        <small id=""Noacept_text"">En caso de presentar conflicto de interés: Absténgase de aceptar esta orden, informe inmediatamente al Director Técnico o al Coordinador de calidad y declare que está impedido para aceptar esta orden de trabajo.</small>
");
#nullable restore
#line 64 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\VisitaTecnica\Visit_Start.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"row mt-2\">\r\n                        <div class=\"col-md-6 col-sm-12\">\r\n");
#nullable restore
#line 67 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\VisitaTecnica\Visit_Start.cshtml"
                             if (Model.inspeccion.Count > 0 && Model.inspeccion.FirstOrDefault().Insp_Inici != null)
                            {
                                if (Model.Tiem_Insps.Where(w => w.TiemFin == null).Count() > 0)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <input type=\"button\" class=\"form-control btn btn-light border-radius New_OT\" onclick=\"pausar(true)\" value=\"Pausar\" />\r\n");
#nullable restore
#line 72 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\VisitaTecnica\Visit_Start.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <input type=\"button\" class=\"form-control btn btn-light border-radius New_OT btn_visit\" onclick=\"pausar(false)\" value=\"Inicio\" />\r\n");
#nullable restore
#line 76 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\VisitaTecnica\Visit_Start.cshtml"
                                }
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <input type=\"button\" class=\"form-control btn btn-light border-radius New_OT btn_visit\" value=\"Inicio\" onclick=\"start(true)\" />\r\n");
#nullable restore
#line 81 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\VisitaTecnica\Visit_Start.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\r\n                        <div class=\"col-md-6 col-sm-12\">\r\n");
#nullable restore
#line 84 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\VisitaTecnica\Visit_Start.cshtml"
                             if (Model.inspeccion.Count() > 0 && Model.inspeccion.FirstOrDefault().Insp_Inici != null && Model.inspeccion.FirstOrDefault().Insp_Fin != null)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <input type=\"button\" class=\"form-control btn btn-light border-radius New_OT\" disabled value=\"Fin\" />\r\n");
#nullable restore
#line 87 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\VisitaTecnica\Visit_Start.cshtml"
                            }
                            else if (Model.inspeccion.Count() > 0 && Model.inspeccion.FirstOrDefault().Insp_Inici != null && Model.inspeccion.FirstOrDefault().Insp_Fin == null)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <input type=\"button\" class=\"form-control btn btn-light border-radius New_OT\" value=\"Fin\" onclick=\"start(false)\" />\r\n");
#nullable restore
#line 91 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\VisitaTecnica\Visit_Start.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <input type=\"button\" class=\"form-control btn btn-light border-radius New_OT\" disabled value=\"Fin\" />\r\n");
#nullable restore
#line 95 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\VisitaTecnica\Visit_Start.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 98 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\VisitaTecnica\Visit_Start.cshtml"
                }
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <h6 class=\"mt-2 text-center\">Duraci&oacute;n:</h6>\r\n            <div class=\"row\">\r\n");
#nullable restore
#line 102 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\VisitaTecnica\Visit_Start.cshtml"
                 foreach (var insp_times in Model.Tiem_Insps)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 104 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\VisitaTecnica\Visit_Start.cshtml"
                     if (insp_times.TiemIni != null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"col-md-6\">\r\n                            <h6 class=\"mt-2 text-center\">Inicio: ");
#nullable restore
#line 107 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\VisitaTecnica\Visit_Start.cshtml"
                                                            Write(insp_times.TiemIni);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                        </div>\r\n");
#nullable restore
#line 109 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\VisitaTecnica\Visit_Start.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 110 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\VisitaTecnica\Visit_Start.cshtml"
                     if (insp_times.TiemFin != null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"col-md-6\">\r\n                            <h6 class=\"mt-2 text-center\">Fin: ");
#nullable restore
#line 113 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\VisitaTecnica\Visit_Start.cshtml"
                                                         Write(insp_times.TiemFin);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                        </div>\r\n");
#nullable restore
#line 115 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\VisitaTecnica\Visit_Start.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 115 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\VisitaTecnica\Visit_Start.cshtml"
                     
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 118 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\VisitaTecnica\Visit_Start.cshtml"
                 if (Model.inspeccion.Count > 0 && Model.inspeccion.FirstOrDefault().Insp_Inici != null && Model.inspeccion.FirstOrDefault().Insp_Fin != null && Model.inspeccion.FirstOrDefault().Insp_Ttotal != null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-md-12\">\r\n                        <h6 class=\"mt-2 text-center\">Duracion: ");
#nullable restore
#line 121 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\VisitaTecnica\Visit_Start.cshtml"
                                                          Write(Model.inspeccion.FirstOrDefault().Insp_Ttotal);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                    </div>\r\n");
#nullable restore
#line 123 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\VisitaTecnica\Visit_Start.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 127 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\VisitaTecnica\Visit_Start.cshtml"
     foreach (var rol in User.Claims)
    {
        if (rol.Value == "4" && rol.Subject.Name == Model.Usuarios.UsuNombre && Model.inspeccion.FirstOrDefault().Insp_Con_Cam && !Model.inspeccion.FirstOrDefault().Insp_Final)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div class=""col-md-4 col-sm-12 mt-2 pl-3"">
                <div class=""row"">
                    <div class=""col-md-12"">
                        <input type=""button"" class=""form-control btn btn-light border-radius New_OT"" onclick=""ConformeCampo(true)""
                               value=""Entregar Carpeta"" />
                    </div>

                    <div class=""col-md-12 mt-2"">
                        <textarea rows=""5"" class=""col-md-12 form-control"" id=""tec_carpet""></textarea>
                    </div>
                </div>
            </div>
");
#nullable restore
#line 143 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\VisitaTecnica\Visit_Start.cshtml"
        }

        if (rol.Value == "5" && rol.Subject.Name != Model.Usuarios.UsuNombre && Model.inspeccion.FirstOrDefault().Insp_Con_Cam && Model.inspeccion.FirstOrDefault().Insp_Dic_Fecha == null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div class=""col-md-4 col-sm-12 mt-2 pl-3"">
                <div class=""row"">
                    <div class=""col-md-12"">
                        <input type=""button"" class=""form-control btn btn-light border-radius New_OT"" onclick=""ConformeDirTec(true)""
                               value=""Aprobar"" />
                    </div>

                    <div class=""col-md-12 mt-2"">
                        <input type=""button"" class=""form-control btn btn-light border-radius New_OT"" value=""Rechazado""
                               onclick=""ConformeDirTec(false)"" />
                    </div>
                </div>
            </div>
");
#nullable restore
#line 160 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\VisitaTecnica\Visit_Start.cshtml"
        }
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1f4f53b532d50e90dea9a4c948422fcd2b3c351a21945", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#nullable restore
#line 166 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\VisitaTecnica\Visit_Start.cshtml"
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
                WriteLiteral("\r\n");
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
