#pragma checksum "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\Maestros\Edit_herramientas.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fbaee6a740ac891f3eb7b8e9d9d4655fa5c6893e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Maestros_Edit_herramientas), @"mvc.1.0.view", @"/Views/Maestros/Edit_herramientas.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fbaee6a740ac891f3eb7b8e9d9d4655fa5c6893e", @"/Views/Maestros/Edit_herramientas.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c2109d60e96e4519e16dc63e6b6e47db9e0fbf8", @"/Views/_ViewImports.cshtml")]
    public class Views_Maestros_Edit_herramientas : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AsikWeb.Models.ViewModels.AsikViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("imgNextToTitle"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Button to open menu"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Img/Open_Menu.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("47"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onclick", new global::Microsoft.AspNetCore.Html.HtmlString("OpenHideMenu(true)"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "OFICINA", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "ASIGNADA", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Maestros/Herramientas"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "Post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onsubmit", new global::Microsoft.AspNetCore.Html.HtmlString("SaveHerramienta(event)"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/js/Maestros.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\Maestros\Edit_herramientas.cshtml"
  
    ViewData["Title"] = "Herramientas";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"col-md-4 mt-5 mb-5\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "fbaee6a740ac891f3eb7b8e9d9d4655fa5c6893e8088", async() => {
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
            WriteLiteral("\r\n\r\n    <h4 class=\"color_orange text-shadow\">\r\n        Editar Herramienta\r\n    </h4>\r\n</div>\r\n\r\n<div id=\"Splash_Screen_Load\" style=\"display: none\"></div>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fbaee6a740ac891f3eb7b8e9d9d4655fa5c6893e9624", async() => {
                WriteLiteral("\r\n    <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 524, "\"", 578, 1);
#nullable restore
#line 16 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\Maestros\Edit_herramientas.cshtml"
WriteAttributeValue("", 532, Model.Herramientas.FirstOrDefault().HerCodigo, 532, 46, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" id=\"HerCodigo\" />\r\n\r\n    <div class=\"row mt-3\">\r\n        <div class=\"col-md-6\">\r\n            <h6>Nombre de la Herramienta</h6>\r\n            <input type=\"text\" required class=\"form-control inputText_NoBorder\"");
                BeginWriteAttribute("value", " value=\"", 787, "\"", 841, 1);
#nullable restore
#line 21 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\Maestros\Edit_herramientas.cshtml"
WriteAttributeValue("", 795, Model.Herramientas.FirstOrDefault().HerNombre, 795, 46, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@"
                   id=""HerNombre"" name=""HerNombre"" placeholder=""Nombre"" />
        </div>
        <div class=""col-md-6"">
            <h6>Marca de la herramienta</h6>
            <input type=""text"" required class=""form-control inputText_NoBorder clear"" name=""Her_Marca"" id=""Her_Marca""
                   placeholder=""Marca""");
                BeginWriteAttribute("value", " value=\"", 1171, "\"", 1224, 1);
#nullable restore
#line 27 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\Maestros\Edit_herramientas.cshtml"
WriteAttributeValue("", 1179, Model.Herramientas.FirstOrDefault().HerMarca, 1179, 45, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"row mt-3\">\r\n        <div class=\"col-md-6\">\r\n            <h6>Serie de la herramienta</h6>\r\n            <input type=\"text\" required class=\"form-control inputText_NoBorder inputHeight clear\" name=\"HerNumser\"");
                BeginWriteAttribute("value", "\r\n                   value=\"", 1480, "\"", 1554, 1);
#nullable restore
#line 35 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\Maestros\Edit_herramientas.cshtml"
WriteAttributeValue("", 1508, Model.Herramientas.FirstOrDefault().HerNumser, 1508, 46, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" id=\"HerNumser\" placeholder=\"Marca\" />\r\n        </div>\r\n\r\n        <div class=\"col-md-6\">\r\n            <h6>Estado de la herramienta</h6>\r\n            <select id=\"slt_her\" class=\"form-control\" onchange=\"ShowOrHideAddHerTec(this.value)\">\r\n");
#nullable restore
#line 41 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\Maestros\Edit_herramientas.cshtml"
                 switch (Model.Herramientas.FirstOrDefault().HerObser)
                {
                    case "OFICINA":

#line default
#line hidden
#nullable disable
                WriteLiteral("                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fbaee6a740ac891f3eb7b8e9d9d4655fa5c6893e13148", async() => {
                    WriteLiteral("Completo en Oficina");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fbaee6a740ac891f3eb7b8e9d9d4655fa5c6893e14732", async() => {
                    WriteLiteral("Asignar Tecnico");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 46 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\Maestros\Edit_herramientas.cshtml"
                        break;
                    default:

#line default
#line hidden
#nullable disable
                WriteLiteral("                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fbaee6a740ac891f3eb7b8e9d9d4655fa5c6893e16271", async() => {
                    WriteLiteral("Completo en Oficina");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fbaee6a740ac891f3eb7b8e9d9d4655fa5c6893e17532", async() => {
                    WriteLiteral("Asignar Tecnico");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 50 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\Maestros\Edit_herramientas.cshtml"
                        break;
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </select>\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"row mt-3 lst_TecHer\" style=\"display:none\">\r\n");
#nullable restore
#line 57 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\Maestros\Edit_herramientas.cshtml"
         foreach (var tecnicos in Model.LstUsuarios)
        {
            if (Model.herramientas_Usuarios == null)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <div class=\"col-md-4\">\r\n                    <input type=\"checkbox\"");
                BeginWriteAttribute("id", " id=\"", 2685, "\"", 2709, 1);
#nullable restore
#line 62 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\Maestros\Edit_herramientas.cshtml"
WriteAttributeValue("", 2690, tecnicos.UsuIdenti, 2690, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 2710, "\"", 2737, 1);
#nullable restore
#line 62 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\Maestros\Edit_herramientas.cshtml"
WriteAttributeValue("", 2718, tecnicos.UsuIdenti, 2718, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("> <label");
                BeginWriteAttribute("for", " for=\"", 2746, "\"", 2771, 1);
#nullable restore
#line 62 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\Maestros\Edit_herramientas.cshtml"
WriteAttributeValue("", 2752, tecnicos.UsuIdenti, 2752, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 62 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\Maestros\Edit_herramientas.cshtml"
                                                                                                                             Write(tecnicos.UsuNombre);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n                </div>\r\n");
#nullable restore
#line 64 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\Maestros\Edit_herramientas.cshtml"
            }
            else
            {
                int UsuhaveHerra = (Model.herramientas_Usuarios.Where(w => w.Usu_identi == tecnicos.UsuIdenti).Count());

                

#line default
#line hidden
#nullable disable
#nullable restore
#line 69 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\Maestros\Edit_herramientas.cshtml"
                 if (UsuhaveHerra > 0)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <div class=\"col-md-4\">\r\n                        <input type=\"checkbox\" checked");
                BeginWriteAttribute("id", " id=\"", 3155, "\"", 3179, 1);
#nullable restore
#line 72 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\Maestros\Edit_herramientas.cshtml"
WriteAttributeValue("", 3160, tecnicos.UsuIdenti, 3160, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 3180, "\"", 3207, 1);
#nullable restore
#line 72 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\Maestros\Edit_herramientas.cshtml"
WriteAttributeValue("", 3188, tecnicos.UsuIdenti, 3188, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("> <label");
                BeginWriteAttribute("for", " for=\"", 3216, "\"", 3241, 1);
#nullable restore
#line 72 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\Maestros\Edit_herramientas.cshtml"
WriteAttributeValue("", 3222, tecnicos.UsuIdenti, 3222, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 72 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\Maestros\Edit_herramientas.cshtml"
                                                                                                                                         Write(tecnicos.UsuNombre);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n                    </div>\r\n");
#nullable restore
#line 74 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\Maestros\Edit_herramientas.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <div class=\"col-md-4\">\r\n                        <input type=\"checkbox\"");
                BeginWriteAttribute("id", " id=\"", 3450, "\"", 3474, 1);
#nullable restore
#line 78 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\Maestros\Edit_herramientas.cshtml"
WriteAttributeValue("", 3455, tecnicos.UsuIdenti, 3455, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 3475, "\"", 3502, 1);
#nullable restore
#line 78 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\Maestros\Edit_herramientas.cshtml"
WriteAttributeValue("", 3483, tecnicos.UsuIdenti, 3483, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("> <label");
                BeginWriteAttribute("for", " for=\"", 3511, "\"", 3536, 1);
#nullable restore
#line 78 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\Maestros\Edit_herramientas.cshtml"
WriteAttributeValue("", 3517, tecnicos.UsuIdenti, 3517, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 78 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\Maestros\Edit_herramientas.cshtml"
                                                                                                                                 Write(tecnicos.UsuNombre);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n                    </div>\r\n");
#nullable restore
#line 80 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\Maestros\Edit_herramientas.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 80 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\Maestros\Edit_herramientas.cshtml"
                 
            }
        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"    </div>

    <div class=""row mt-3"">
        <div class=""col-md-3"">
        </div>
        <div class=""col-md-3 col-sm-12"">
            <input type=""submit"" class=""btn btn-success col-md-12 btn-md disable"" value=""Guardar"" />
        </div>
        <div class=""col-md-3 col-sm-12"">
            <input type=""button"" class=""btn btn-danger btn-md col-md-12 disable"" value=""Cancelar"" onclick=""location.href='/Maestros/Lst_Herramientas'"" />
        </div>
    </div>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fbaee6a740ac891f3eb7b8e9d9d4655fa5c6893e28291", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_10.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
#nullable restore
#line 99 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\Maestros\Edit_herramientas.cshtml"
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
                WriteLiteral("\r\n    <script>\r\n        $(document).ready(function () {\r\n            if ($(\"#slt_her\").val() == \"ASIGNADA\") {\r\n                ShowOrHideAddHerTec(\"ASIGNADA\");\r\n            }\r\n        });\r\n    </script>\r\n");
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