#pragma checksum "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\OrdenTrabajo\ShowOT.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d24ab9c880143801210e0814f293c7a8d0b7bc19"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_OrdenTrabajo_ShowOT), @"mvc.1.0.view", @"/Views/OrdenTrabajo/ShowOT.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d24ab9c880143801210e0814f293c7a8d0b7bc19", @"/Views/OrdenTrabajo/ShowOT.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c2109d60e96e4519e16dc63e6b6e47db9e0fbf8", @"/Views/_ViewImports.cshtml")]
    public class Views_OrdenTrabajo_ShowOT : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AsikWeb.Models.ViewModels.AsikViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("imgNextToTitle"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Button to open menu"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Img/Open_Menu.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("47"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onclick", new global::Microsoft.AspNetCore.Html.HtmlString("OpenHideMenu(true)"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("OptTipAlcance"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/OrdenTrabajo/Save"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "Post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onsubmit", new global::Microsoft.AspNetCore.Html.HtmlString("Save(event)"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/js/OrdenTrabajo.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\OrdenTrabajo\ShowOT.cshtml"
  
    ViewData["Title"] = "Crear nueva O.T.";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div id=\"Splash_Screen_Load\" style=\"display: none\"></div>\r\n<div class=\"row\">\r\n    <div class=\"col-md-12\" style=\"height: 74.7vh;overflow:auto\">\r\n        <!-- Encabezado -->\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d24ab9c880143801210e0814f293c7a8d0b7bc197953", async() => {
                WriteLiteral("\r\n            <div class=\"row\">\r\n                <div class=\"col-md-9 mt-4\">\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "d24ab9c880143801210e0814f293c7a8d0b7bc198315", async() => {
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
                        Detalle O.T.
                    </h4>
                </div>

                <div class=""col-md-3"">
                    <input type=""hidden"" required class=""form-control"" id=""Ord_Codigo"" readonly");
                BeginWriteAttribute("value", " value=\"", 862, "\"", 943, 1);
#nullable restore
#line 21 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\OrdenTrabajo\ShowOT.cshtml"
WriteAttributeValue("", 870, Model.Ord_Trabajo.FirstOrDefault().Ord_Codigo.ToString().PadLeft(8, '0'), 870, 73, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                    <input type=\"text\" required class=\"form-control\" id=\"DtNewOT\" readonly");
                BeginWriteAttribute("value", " value=\"", 1039, "\"", 1119, 1);
#nullable restore
#line 22 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\OrdenTrabajo\ShowOT.cshtml"
WriteAttributeValue("", 1047, Model.Ord_Trabajo.FirstOrDefault().Ord_Fecmod.Value.ToShortDateString(), 1047, 72, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
                </div>
            </div>
            <!-- Cuerpo -->
            <div class=""row mt-4"">
                <div class=""col-md-5"">
                    <label>
                        Nombre del Proyecto
                    </label>
                    <input type=""text"" autofocus class=""form-control inputText_NoBorder inputHeight"" required readonly
                           name=""Proyect_Name"" id=""Proyect_Name"" placeholder=""Ingrese nombre del proyecto""");
                BeginWriteAttribute("value", " value=\"", 1604, "\"", 1659, 1);
#nullable restore
#line 32 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\OrdenTrabajo\ShowOT.cshtml"
WriteAttributeValue("", 1612, Model.Ord_Trabajo.FirstOrDefault().Ord_Nomproy, 1612, 47, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                </div>\r\n                <div class=\"col-md-2\">\r\n                    <label>\r\n                        Forma de pago\r\n                    </label>\r\n                    <select disabled id=\"Form_Pag\" class=\"form-control\">\r\n");
#nullable restore
#line 39 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\OrdenTrabajo\ShowOT.cshtml"
                         foreach (var item in Model.TipPago.Where(w => w.TipCodigo == Model.Ord_Trabajo.FirstOrDefault().Ord_Tippag))
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d24ab9c880143801210e0814f293c7a8d0b7bc1912646", async() => {
#nullable restore
#line 41 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\OrdenTrabajo\ShowOT.cshtml"
                                                       Write(item.TipNombre);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 41 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\OrdenTrabajo\ShowOT.cshtml"
                               WriteLiteral(item.TipCodigo);

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
#line 42 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\OrdenTrabajo\ShowOT.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                    </select>
                </div>
                <div class=""col-md-3"">
                    <label>
                        Cantidad de visitas
                    </label>
                    <input readonly type=""text"" required class=""form-control inputText_NoBorder inputHeight"" name=""Proyect_Visit""
                           id=""Proyect_Visit"" placeholder=""Visitas""");
                BeginWriteAttribute("value", " value=\"", 2573, "\"", 2627, 1);
#nullable restore
#line 50 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\OrdenTrabajo\ShowOT.cshtml"
WriteAttributeValue("", 2581, Model.Ord_Trabajo.FirstOrDefault().Ord_Canvis, 2581, 46, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
                </div>
                <div class=""col-md-2"">
                    <label>
                        insp. documental
                    </label>
                    <input readonly type=""text"" required class=""form-control inputText_NoBorder inputHeight"" placeholder=""Revision""
                           id=""Proyect_InsDocument""");
                BeginWriteAttribute("value", " value=\"", 2982, "\"", 3036, 1);
#nullable restore
#line 57 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\OrdenTrabajo\ShowOT.cshtml"
WriteAttributeValue("", 2990, Model.Ord_Trabajo.FirstOrDefault().Ord_Revdoc, 2990, 46, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
                </div>
            </div>

            <div class=""row mt-3"">
                <div class=""col-md-2"">
                    <label>
                        Alcance
                    </label>
                    <select onchange=""LstTipPago()"" disabled id=""Alcance"" class=""form-control"">
");
#nullable restore
#line 67 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\OrdenTrabajo\ShowOT.cshtml"
                         foreach (var item in Model.Alcance.Where(w => w.AlcCodigo == Model.Ord_Trabajo.FirstOrDefault().Ord_Alccod))
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d24ab9c880143801210e0814f293c7a8d0b7bc1917172", async() => {
#nullable restore
#line 69 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\OrdenTrabajo\ShowOT.cshtml"
                                                       Write(item.AlcNombre);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 69 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\OrdenTrabajo\ShowOT.cshtml"
                               WriteLiteral(item.AlcCodigo);

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
#line 70 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\OrdenTrabajo\ShowOT.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                    </select>
                </div>
                <div class=""col-md-3"">
                    <label>
                        Tipo de alcance
                    </label>
                    <select disabled id=""Tip_Alc"" class=""form-control"">
");
#nullable restore
#line 78 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\OrdenTrabajo\ShowOT.cshtml"
                         foreach (var item in Model.TipAlcance.Where(w => w.Tip_alcodi == Model.Ord_Trabajo.FirstOrDefault().Ord_Talcod))
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d24ab9c880143801210e0814f293c7a8d0b7bc1920019", async() => {
#nullable restore
#line 80 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\OrdenTrabajo\ShowOT.cshtml"
                                                                              Write(item.Tip_alnomb);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 80 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\OrdenTrabajo\ShowOT.cshtml"
                                                     WriteLiteral(item.Alc_codigo);

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
#line 81 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\OrdenTrabajo\ShowOT.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                    </select>
                </div>
                <div class=""col-md-2"">
                    <label>
                        Cantidad
                    </label>
                    <input readonly type=""text"" required pattern=""[0-9]+"" class=""form-control inputText_NoBorder inputHeight""
                           id=""ord_cantalc"" name=""ord_cantalc"" title=""Solo se permiten numeros""");
                BeginWriteAttribute("value", " value=\"", 4609, "\"", 4664, 1);
#nullable restore
#line 89 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\OrdenTrabajo\ShowOT.cshtml"
WriteAttributeValue("", 4617, Model.Ord_Trabajo.FirstOrDefault().Ord_Cantalc, 4617, 47, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
                </div>
            </div>
            
            <div class=""row mt-3"">
                <div class=""col-md-6"">
                    <label>
                        Cliente
                    </label>
                    <div>
                        <input type=""hidden"" required class=""form-control inputText_NoBorder inputHeight"" name=""Cliente_Id"" id=""Cliente_Id"" placeholder=""Codigo"" />
");
                WriteLiteral("                        <input type=\"text\" required readonly class=\"form-control inputText_NoBorder inputHeight\" name=\"Cliente_name\" id=\"Cliente_name\"\r\n                               placeholder=\"Nombre\"");
                BeginWriteAttribute("value", " value=\"", 5397, "\"", 5447, 1);
#nullable restore
#line 102 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\OrdenTrabajo\ShowOT.cshtml"
WriteAttributeValue("", 5405, Model.Clientes.FirstOrDefault().CliNombre, 5405, 42, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
                    </div>
                </div>
                <div class=""col-md-4"">
                    <label>
                        Direcci&oacute;n
                    </label>
                    <input type=""text"" readonly required id=""Cli_Dir"" class=""form-control inputText_NoBorder"" placeholder=""Direccion""");
                BeginWriteAttribute("value", "\r\n                           value=\"", 5779, "\"", 5857, 1);
#nullable restore
#line 110 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\OrdenTrabajo\ShowOT.cshtml"
WriteAttributeValue("", 5815, Model.Clientes.FirstOrDefault().CliDirecc, 5815, 42, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
                </div>
                <div class=""col-md-4"">
                    <label>
                        Num. Tel&eacute;fono
                    </label>
                    <input type=""text"" readonly required id=""Cli_Tel"" class=""form-control inputText_NoBorder"" placeholder=""Telefono""");
                BeginWriteAttribute("value", "\r\n                           value=\"", 6164, "\"", 6242, 1);
#nullable restore
#line 117 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\OrdenTrabajo\ShowOT.cshtml"
WriteAttributeValue("", 6200, Model.Clientes.FirstOrDefault().CliTelefo, 6200, 42, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
                </div>
            </div>

            <div class=""row mt-3"">
                <!-- Info adicional -->
                <div class=""col-md-8 col-sm-12"">
                    <div class=""card"">
                        <h6 class=""color_orange pt-3 pl-3 pr-3"">Informaci&oacute;n adicional de contacto</h6>
                        <div class=""row ml-3"">
                            <div class=""col-md-10 mt-2"">
                                <label>
                                    Nombres Completos
                                </label>
                                <input type=""text"" readonly class=""form-control inputText_NoBorder"" id=""AdiCli_Name"" placeholder=""Nombre""");
                BeginWriteAttribute("value", "\r\n                                       value=\"", 6953, "\"", 7047, 1);
#nullable restore
#line 132 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\OrdenTrabajo\ShowOT.cshtml"
WriteAttributeValue("", 7001, Model.Ord_Trabajo.FirstOrDefault().Ord_Nomcad, 7001, 46, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
                            </div>
                            <div class=""col-md-10"">
                                <label>
                                    Num. Tel&eacute;fono fijo
                                </label>
                                <input type=""text"" readonly class=""form-control inputText_NoBorder"" id=""AdiCli_Tel"" placeholder=""Telefono""");
                BeginWriteAttribute("value", "\r\n                                       value=\"", 7426, "\"", 7520, 1);
#nullable restore
#line 139 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\OrdenTrabajo\ShowOT.cshtml"
WriteAttributeValue("", 7474, Model.Ord_Trabajo.FirstOrDefault().Ord_Telcad, 7474, 46, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
                            </div>
                            <div class=""col-md-10"">
                                <label>
                                    Num. Tel&eacute;fono movil
                                </label>
                                <input type=""text"" readonly class=""form-control inputText_NoBorder"" id=""ORD_CELCAD"" placeholder=""Telefono""");
                BeginWriteAttribute("value", "\r\n                                       value=\"", 7900, "\"", 7994, 1);
#nullable restore
#line 146 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\OrdenTrabajo\ShowOT.cshtml"
WriteAttributeValue("", 7948, Model.Ord_Trabajo.FirstOrDefault().Ord_Celcad, 7948, 46, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
                            </div>
                            <div class=""col-md-10"">
                                <label>
                                    E-mail
                                </label>
                                <input type=""email"" required readonly class=""form-control inputText_NoBorder"" id=""AdiCli_Email""
                                       placeholder=""Correo Electronico""");
                BeginWriteAttribute("value", " value=\"", 8416, "\"", 8470, 1);
#nullable restore
#line 153 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\OrdenTrabajo\ShowOT.cshtml"
WriteAttributeValue("", 8424, Model.Ord_Trabajo.FirstOrDefault().Ord_Emacad, 8424, 46, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
                            </div>
                        </div>
                    </div>
                </div>

                <!-- Botones-->
                <div class=""col-md-4 col-sm-12"">
                    <div class=""row"" style=""padding-top: 15vh;"">
");
                WriteLiteral(@"                        <input type=""button"" class=""ml-5 col-md-4 btn btn-light TextNegrita float-right border-radius btn_cancel disable"" onclick=""location.href ='/OrdenTrabajo/Show'"" value=""Volver"" />
                    </div>
                </div>
            </div>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d24ab9c880143801210e0814f293c7a8d0b7bc1931717", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_9.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
#nullable restore
#line 174 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\OrdenTrabajo\ShowOT.cshtml"
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
