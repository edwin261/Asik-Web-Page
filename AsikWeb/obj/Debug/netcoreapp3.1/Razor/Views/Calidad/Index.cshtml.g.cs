#pragma checksum "C:\Users\edwin\Documents\Asik-Web-Page\AsikWeb\Views\Calidad\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0cc2e3b914a2dcf0f2a87a80317d29143a18dfe1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Calidad_Index), @"mvc.1.0.view", @"/Views/Calidad/Index.cshtml")]
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
#line 1 "C:\Users\edwin\Documents\Asik-Web-Page\AsikWeb\Views\_ViewImports.cshtml"
using AsikWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\edwin\Documents\Asik-Web-Page\AsikWeb\Views\_ViewImports.cshtml"
using AsikWeb.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0cc2e3b914a2dcf0f2a87a80317d29143a18dfe1", @"/Views/Calidad/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"072945db5cad0261ce6f311db448242628f845f2", @"/Views/_ViewImports.cshtml")]
    public class Views_Calidad_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<AsikWeb.Models.Entidades.Proceso>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/js/Calidad.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\edwin\Documents\Asik-Web-Page\AsikWeb\Views\Calidad\Index.cshtml"
  
    ViewData["Title"] = "Calidad";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div id=""Splash_Screen_Load"" style=""display: none""></div>

<button type=""button"" class=""btn btn-success btn-circle btn-xl"" data-toggle=""modal"" data-target=""#saveProceso"">
    <i class=""fas fa-angle-right""></i>
</button>

<div id=""div_Procesos"">
    <div class=""col-md-12 text-center mt-3""><strong class=""h4 text-shadow"">Procesos</strong></div>

    <div class=""row mt-3"">
");
#nullable restore
#line 16 "C:\Users\edwin\Documents\Asik-Web-Page\AsikWeb\Views\Calidad\Index.cshtml"
         foreach (var procesos in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-md-5 mt-4 ml-md-5\">\r\n                <input type=\"button\" class=\"btn btn-light TextNegrita btn_save_color border-radius New_OT form-control box-shadow-green text-capitalize\"");
            BeginWriteAttribute("id", "\r\n                       id=\"", 728, "\"", 776, 1);
#nullable restore
#line 20 "C:\Users\edwin\Documents\Asik-Web-Page\AsikWeb\Views\Calidad\Index.cshtml"
WriteAttributeValue("", 757, procesos.ProCodigo, 757, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 777, "\"", 814, 1);
#nullable restore
#line 20 "C:\Users\edwin\Documents\Asik-Web-Page\AsikWeb\Views\Calidad\Index.cshtml"
WriteAttributeValue("", 785, procesos.ProNombre.ToLower(), 785, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("onclick", " onclick=\"", 815, "\"", 885, 6);
            WriteAttributeValue("", 825, "Load_Actividades(", 825, 17, true);
#nullable restore
#line 20 "C:\Users\edwin\Documents\Asik-Web-Page\AsikWeb\Views\Calidad\Index.cshtml"
WriteAttributeValue("", 842, procesos.ProCodigo, 842, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 861, ",", 861, 1, true);
            WriteAttributeValue(" ", 862, "\'", 863, 2, true);
#nullable restore
#line 20 "C:\Users\edwin\Documents\Asik-Web-Page\AsikWeb\Views\Calidad\Index.cshtml"
WriteAttributeValue("", 864, procesos.ProNombre, 864, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 883, "\')", 883, 2, true);
            EndWriteAttribute();
            WriteLiteral(" />\r\n            </div>\r\n");
#nullable restore
#line 22 "C:\Users\edwin\Documents\Asik-Web-Page\AsikWeb\Views\Calidad\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </div>
</div>

<div id=""div_Actividades"" style=""display:none"">
    <div class=""col-md-12 text-center mt-3""><strong class=""h4 text-shadow"">Actividades</strong></div>

    <div class=""row mt-3"" id=""divBtnActivities""></div>
</div>

<div id=""div_Tareas"" style=""display:none"">
    <div class=""col-md-12 text-center mt-3""><strong class=""h4 text-shadow"">Tarea</strong></div>

    <div class=""row mt-3"" id=""divBtnTrea""></div>
</div>

<div id=""saveProceso"" class=""modal fade"" role=""dialog"" tabindex=""-1"">
    <div class=""modal-dialog modal-lg"">
        <div class=""modal-content"" style=""border-radius: 7vh; box-shadow: 1em 1em 11.3em rgba(255, 143, 46, 0.94);"">
            <div class=""modal-body"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0cc2e3b914a2dcf0f2a87a80317d29143a18dfe18122", async() => {
                WriteLiteral(@"
                    <div class=""form-group"">
                        <h4 class=""TextNegrita text-center text-shadow"">Datos</h4>
                    </div>
                    <div class=""form-group"">
                        <label>Proceso</label>
                        <input type=""text"" class=""form-control"" id=""txtProceso"" />
                        <input type=""hidden"" class=""form-control"" id=""txtProcesoId"" value=""0"" />
                    </div>

                    <div class=""form-group"">
                        <label>Actividad</label>
                        <input type=""text"" class=""form-control"" id=""txtActividad"" />
                        <input type=""hidden"" class=""form-control"" id=""txtActividadId"" value=""0"" />
                    </div>

                    <div class=""form-group"">
                        <label>Tarea</label>
                        <input type=""text"" class=""form-control"" id=""txtTarea"" />
                    </div>

                    <div class=""form-group");
                WriteLiteral(@""">
                        <label>Periocidad</label>
                        <select class=""form-control"" id=""sltPeriocidad"" onchange=""periocidad(this.value)"">
                        </select>
                    </div>

                    <div class=""form-group"" id=""fechaPeriocidad"" style=""display:none"">
                        <div class=""row"">
                            <div class=""col-md-6"">
                                <label>Dia inicial</label>
                                <input type=""date"" id=""datePeriocidad"" class=""form-control col-md-11""");
                BeginWriteAttribute("value", " value=\"", 3277, "\"", 3321, 1);
#nullable restore
#line 73 "C:\Users\edwin\Documents\Asik-Web-Page\AsikWeb\Views\Calidad\Index.cshtml"
WriteAttributeValue("", 3285, DateTime.Now.ToString("yyyy-MM-dd"), 3285, 36, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
                            </div>
                            <div class=""col-md-6"">
                                <label>Dias de prorroga</label>
                                <input type=""text"" value=""1"" min=""1"" class=""form-control col-md-11 validanumericos"" id=""DiasProrroga"" />
                            </div>
                        </div>

                    </div>

                    <div class=""modal-footer"" id=""divBtn"">
                        <button type=""button"" onclick=""SaveNewProg()"" id=""btnSave"" class=""btn btn-success btn_save_color disable"" style=""color:black"">Guardar</button>
                        <button type=""button"" class=""btn btn-danger btn_cancel disable"" data-dismiss=""modal"">
                            Cerrar
                        </button>
                    </div>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0cc2e3b914a2dcf0f2a87a80317d29143a18dfe112577", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
#nullable restore
#line 97 "C:\Users\edwin\Documents\Asik-Web-Page\AsikWeb\Views\Calidad\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<AsikWeb.Models.Entidades.Proceso>> Html { get; private set; }
    }
}
#pragma warning restore 1591
