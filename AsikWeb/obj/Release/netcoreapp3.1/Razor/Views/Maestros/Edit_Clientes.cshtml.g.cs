#pragma checksum "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\Maestros\Edit_Clientes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "15c63d136224a3f9f4864289fc57b28a6b7cf3f4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Maestros_Edit_Clientes), @"mvc.1.0.view", @"/Views/Maestros/Edit_Clientes.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"15c63d136224a3f9f4864289fc57b28a6b7cf3f4", @"/Views/Maestros/Edit_Clientes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c2109d60e96e4519e16dc63e6b6e47db9e0fbf8", @"/Views/_ViewImports.cshtml")]
    public class Views_Maestros_Edit_Clientes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AsikWeb.Models.ViewModels.AsikViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Maestros/Clientes"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "Post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onsubmit", new global::Microsoft.AspNetCore.Html.HtmlString("SaveCliente(event)"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/js/Maestros.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\Maestros\Edit_Clientes.cshtml"
  
    ViewData["Title"] = "Clientes";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h3>Clientes</h3>\r\n<div id=\"Splash_Screen_Load\" style=\"display: none\"></div>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "15c63d136224a3f9f4864289fc57b28a6b7cf3f45729", async() => {
                WriteLiteral("\r\n    <input type=\"hidden\" class=\"clear\" id=\"optsave\" />\r\n    <input type=\"hidden\" class=\"clear\" id=\"Cli_Codigo\"");
                BeginWriteAttribute("value", " value=\"", 363, "\"", 413, 1);
#nullable restore
#line 10 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\Maestros\Edit_Clientes.cshtml"
WriteAttributeValue("", 371, Model.Clientes.FirstOrDefault().CliCodigo, 371, 42, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n\r\n    <div class=\"row mt-3\">\r\n        <div class=\"col-md-4\">\r\n            <h6>Nit</h6>\r\n            <input type=\"text\" required readonly pattern=\"[0-9]+\" class=\"form-control inputText_NoBorder\"");
                BeginWriteAttribute("value", "\r\n                   value=\"", 612, "\"", 682, 1);
#nullable restore
#line 16 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\Maestros\Edit_Clientes.cshtml"
WriteAttributeValue("", 640, Model.Clientes.FirstOrDefault().CliIdenti, 640, 42, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" id=""Codigo_Id"" name=""Cliente_Id""
                   title=""Solo se permiten numeros"" onchange=""VerifiNit(this.value)"" />
        </div>
        <div class=""col-md-1"">
            <h6>Verif.</h6>
            <input type=""text"" required readonly pattern=""[0-9]+"" class=""form-control inputText_NoBorder clear""");
                BeginWriteAttribute("value", "\r\n                   value=\"", 995, "\"", 1065, 1);
#nullable restore
#line 22 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\Maestros\Edit_Clientes.cshtml"
WriteAttributeValue("", 1023, Model.Clientes.FirstOrDefault().CliDverif, 1023, 42, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@"
                   id=""CliDverif"" name=""CliDverif"" title=""Solo se permiten numeros"" />
        </div>
        <div class=""col-md-7"">
            <h6>Nombre Cliente</h6>
            <input type=""text"" required class=""form-control inputText_NoBorder clear"" name=""Cliente_name""");
                BeginWriteAttribute("value", "\r\n                   value=\"", 1346, "\"", 1416, 1);
#nullable restore
#line 28 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\Maestros\Edit_Clientes.cshtml"
WriteAttributeValue("", 1374, Model.Clientes.FirstOrDefault().CliNombre, 1374, 42, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" id=\"Cliente_name\" />\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"row mt-3\">\r\n        <div class=\"col-md-6\">\r\n            <h6>Telefono</h6>\r\n            <input type=\"text\" required pattern=\"[0-9]+\" class=\"form-control inputText_NoBorder clear\"");
                BeginWriteAttribute("value", "\r\n                   value=\"", 1663, "\"", 1733, 1);
#nullable restore
#line 36 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\Maestros\Edit_Clientes.cshtml"
WriteAttributeValue("", 1691, Model.Clientes.FirstOrDefault().CliTelefo, 1691, 42, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@"
                   id=""Cliente_tel"" name=""Tel_Cli"" title=""Solo se permiten numeros"" />
        </div>
        <div class=""col-md-6"">
            <h6>Direccion</h6>
            <input type=""text"" required class=""form-control col-md-12 inputText_NoBorder clear""");
                BeginWriteAttribute("value", "\r\n                   value=\"", 1999, "\"", 2069, 1);
#nullable restore
#line 42 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\Maestros\Edit_Clientes.cshtml"
WriteAttributeValue("", 2027, Model.Clientes.FirstOrDefault().CliDirecc, 2027, 42, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" id=\"Dir_Cli\" name=\"Dir_Cli\" />\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"row mt-3\">\r\n        <div class=\"col-md-6\">\r\n            <h6>Departamento</h6>\r\n            <select id=\"Dep_Cli\" onchange=\"Lstciudades(false)\" class=\"form-control\">\r\n");
#nullable restore
#line 50 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\Maestros\Edit_Clientes.cshtml"
                 foreach (var dep in Model.Deparcol)
                {
                    if (dep.Dep_Codigo != Model.Clientes.FirstOrDefault().DepCodigo)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "15c63d136224a3f9f4864289fc57b28a6b7cf3f410862", async() => {
#nullable restore
#line 54 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\Maestros\Edit_Clientes.cshtml"
                                                   Write(dep.Dep_Nombre);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 54 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\Maestros\Edit_Clientes.cshtml"
                           WriteLiteral(dep.Dep_Codigo);

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
#line 55 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\Maestros\Edit_Clientes.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "15c63d136224a3f9f4864289fc57b28a6b7cf3f413097", async() => {
#nullable restore
#line 58 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\Maestros\Edit_Clientes.cshtml"
                                                            Write(dep.Dep_Nombre);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 58 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\Maestros\Edit_Clientes.cshtml"
                                    WriteLiteral(dep.Dep_Codigo);

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
#line 59 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\Maestros\Edit_Clientes.cshtml"
                    }
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </select>\r\n        </div>\r\n        <div class=\"col-md-6\">\r\n            <h6>Ciudad</h6>\r\n            <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 2915, "\"", 2965, 1);
#nullable restore
#line 65 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\Maestros\Edit_Clientes.cshtml"
WriteAttributeValue("", 2923, Model.Clientes.FirstOrDefault().CiuCodigo, 2923, 42, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" id=""CiuCod_Cli"" />
            <select id=""Ciu_Cli"" class=""form-control"">
            </select>
        </div>
    </div>

    <div class=""row mt-3"">
        <div class=""col-md-1"">
        </div>
        <div class=""col-md-3 col-sm-12"">
            <input type=""button"" class=""btn btn-primary col-md-12 btn-md disable"" onclick=""Lstciudades(true);HideOrShowBtn(1)"" data-toggle=""modal"" data-target=""#ModalNewSede"" value=""Agregar Sede"" />
        </div>
        <div class=""col-md-3 col-sm-12"">
            <input type=""submit"" class=""btn btn-success col-md-12 btn-md disable"" value=""Actualizar"" />
        </div>
        <div class=""col-md-3 col-sm-12"">
            <input type=""button"" class=""btn btn-danger btn-md col-md-12 disable"" value=""Cancelar"" onclick=""location.href='/Maestros/Lst_Clientes'"" />
        </div>
    </div>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<div class=\"row\">\r\n");
#nullable restore
#line 87 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\Maestros\Edit_Clientes.cshtml"
     if (Model.Sedes_Cli.Count() > 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h3 class=\"col-md-12 TextNegrita mt-3\">Sedes</h3>\r\n");
#nullable restore
#line 90 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\Maestros\Edit_Clientes.cshtml"
        foreach (var sedes in Model.Sedes_Cli)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-md-6 mt-2\"");
            BeginWriteAttribute("id", " id=\"", 4046, "\"", 4066, 1);
#nullable restore
#line 92 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\Maestros\Edit_Clientes.cshtml"
WriteAttributeValue("", 4051, sedes.SeCodigo, 4051, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                <div class=\"card\">\r\n                    <div class=\"card-header\">\r\n                        <strong>NIT</strong> ");
#nullable restore
#line 95 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\Maestros\Edit_Clientes.cshtml"
                                        Write(sedes.SeNumIden);

#line default
#line hidden
#nullable disable
            WriteLiteral("-");
#nullable restore
#line 95 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\Maestros\Edit_Clientes.cshtml"
                                                         Write(sedes.SeDigver);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"card-body\">\r\n                        <h5 class=\"card-title\">");
#nullable restore
#line 98 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\Maestros\Edit_Clientes.cshtml"
                                          Write(sedes.SeNomSed);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                        <p class=\"card-text\">\r\n                            <strong>Departamento:</strong> ");
#nullable restore
#line 100 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\Maestros\Edit_Clientes.cshtml"
                                                      Write(Model.Deparcol.Where(w => w.Dep_Codigo == sedes.SeDepart).FirstOrDefault().Dep_Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                            <strong>Ciudad:</strong> ");
#nullable restore
#line 101 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\Maestros\Edit_Clientes.cshtml"
                                                Write(Model.Munidep.Where(w => w.Ciu_Codigo == sedes.SeCiudad).FirstOrDefault().Ciu_Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                            <strong>Telefono:</strong> ");
#nullable restore
#line 102 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\Maestros\Edit_Clientes.cshtml"
                                                  Write(sedes.SeNumTel);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </p>\r\n                        <div class=\"row pull-right\">\r\n                            <div class=\"col-md-4\">\r\n                                <input type=\"button\" class=\"btn btn-sm btn-success\"");
            BeginWriteAttribute("onclick", " onclick=\"", 5011, "\"", 5054, 3);
            WriteAttributeValue("", 5021, "HideOrShowBtn(2,", 5021, 16, true);
#nullable restore
#line 106 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\Maestros\Edit_Clientes.cshtml"
WriteAttributeValue(" ", 5037, sedes.SeCodigo, 5038, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5053, ")", 5053, 1, true);
            EndWriteAttribute();
            WriteLiteral(" value=\"Editar\">\r\n                            </div>\r\n                            <div class=\"col-md-4\">\r\n                                <input type=\"button\" value=\"Eliminar\" class=\"btn btn-sm btn-danger\"");
            BeginWriteAttribute("onclick", " onclick=\"", 5260, "\"", 5298, 3);
            WriteAttributeValue("", 5270, "Delete_Sede(", 5270, 12, true);
#nullable restore
#line 109 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\Maestros\Edit_Clientes.cshtml"
WriteAttributeValue("", 5282, sedes.SeCodigo, 5282, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5297, ")", 5297, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 115 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\Maestros\Edit_Clientes.cshtml"
        }
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>

<div class=""modal fade"" id=""Askcreate"" tabindex=""-1"" role=""dialog"" aria-labelledby=""Askcreate"" aria-hidden=""true"" data-backdrop=""static"" data-keyboard=""false"">
    <div class=""modal-dialog modal-dialog-centered"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""AskcreateClientTitle"">Crear nuevo Cliente</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                <p>¿Desea crear un nuevo cliente?</p>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-success"" onclick=""NewClient('Cli')"">Si</button>
                <button type=""button"" class=""btn btn-danger"" onclick=""location.href='/Maestros/Lst_Clientes'"">No</button>
            </div>
        </div>");
            WriteLiteral(@"
    </div>
</div>

<div class=""modal fade mt-4"" id=""ModalNewSede"" tabindex=""-1"" role=""dialog"" aria-labelledby=""myModalLabel"" aria-hidden=""true"" data-backdrop=""static"" data-keyboard=""false"">
    <div class=""modal-dialog modal-dialog-centered modal-lg"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h4 class=""modal-title w-100"" id=""myModalLabel"">Nueva Sede</h4>
            </div>
            <div class=""modal-body"">
                <div class=""row mt-3"">
                    <div class=""col-md-3"">
                        <h6>Nit</h6>
                        <input type=""hidden"" value=""0"" id=""SeCodigo"" />
                        <input type=""text"" required pattern=""[0-9]+"" class=""form-control inputText_NoBorder""
                               id=""SCodigo_Id"" name=""SCliente_Id"" title=""Solo se permiten numeros"" onchange=""VerifiNit(this.value, true)"" />
                    </div>
                    <div class=""col-md-2"">
              ");
            WriteLiteral("          <h6>Verif.</h6>\r\n                        <input type=\"text\" required readonly pattern=\"[0-9]+\" class=\"form-control inputText_NoBorder Sclear\"");
            BeginWriteAttribute("value", " value=\"", 7659, "\"", 7667, 0);
            EndWriteAttribute();
            WriteLiteral(@"
                               id=""SCliDverif"" name=""SCliDverif"" title=""Solo se permiten numeros"" />
                    </div>
                    <div class=""col-md-7"">
                        <h6>Nombre Sede</h6>
                        <input type=""text"" readonly required class=""form-control inputText_NoBorder Sclear"" name=""SCliente_name"" id=""SCliente_name"" />
                    </div>
                </div>

                <div class=""row mt-3"">
                    <div class=""col-md-6"">
                        <h6>Telefono</h6>
                        <input type=""text"" required readonly pattern=""[0-9]+"" class=""form-control inputText_NoBorder Sclear""");
            BeginWriteAttribute("value", " value=\"", 8347, "\"", 8355, 0);
            EndWriteAttribute();
            WriteLiteral(@"
                               id=""SCliente_tel"" name=""STel_Cli"" title=""Solo se permiten numeros"" />
                    </div>
                    <div class=""col-md-6"">
                        <h6>Direccion</h6>
                        <input type=""text"" required readonly class=""form-control col-md-12 inputText_NoBorder Sclear""");
            BeginWriteAttribute("value", " value=\"", 8693, "\"", 8701, 0);
            EndWriteAttribute();
            WriteLiteral(@" id=""SDir_Cli"" name=""SDir_Cli"" />
                    </div>
                </div>

                <div class=""row mt-3"">
                    <div class=""col-md-6"">
                        <h6>Departamento</h6>
                        <select id=""SDep_Cli"" onchange=""Lstciudades(true)"" class=""form-control"">
");
#nullable restore
#line 180 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\Maestros\Edit_Clientes.cshtml"
                             foreach (var dep in Model.Deparcol)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "15c63d136224a3f9f4864289fc57b28a6b7cf3f428287", async() => {
#nullable restore
#line 182 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\Maestros\Edit_Clientes.cshtml"
                                                           Write(dep.Dep_Nombre);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 182 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\Maestros\Edit_Clientes.cshtml"
                                   WriteLiteral(dep.Dep_Codigo);

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
#line 183 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\Maestros\Edit_Clientes.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </select>
                    </div>
                    <div class=""col-md-6"">
                        <h6>Ciudad</h6>
                        <select id=""SCiu_Cli"" class=""form-control"">
                        </select>
                    </div>
                </div>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary btn-sm"" onclick=""$('#ModalNewSede').modal('hide')"">Cancelar</button>
                <button type=""button"" class=""btn btn-success btn-sm"" id=""btnsavesede"" onclick=""AddSedeCliente(true)"">Guardar</button>
                <button type=""button"" class=""btn btn-success btn-sm"" id=""btneditsede"" onclick=""AddSedeCliente(false)"">Editar</button>
            </div>
        </div>
    </div>
</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "15c63d136224a3f9f4864289fc57b28a6b7cf3f431358", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
#nullable restore
#line 204 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\Maestros\Edit_Clientes.cshtml"
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
                WriteLiteral("\r\n    <script>\r\n        $(document).ready(function () {\r\n            Lstciudades(false);\r\n        });\r\n    </script>\r\n");
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
