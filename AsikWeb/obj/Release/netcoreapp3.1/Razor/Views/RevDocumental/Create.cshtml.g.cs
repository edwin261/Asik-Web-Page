#pragma checksum "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\RevDocumental\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6a317f47672a8487a99451c5b3fe781cc4ad1dca"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_RevDocumental_Create), @"mvc.1.0.view", @"/Views/RevDocumental/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6a317f47672a8487a99451c5b3fe781cc4ad1dca", @"/Views/RevDocumental/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c2109d60e96e4519e16dc63e6b6e47db9e0fbf8", @"/Views/_ViewImports.cshtml")]
    public class Views_RevDocumental_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AsikWeb.Models.ViewModels.AsikViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/RevDocumental/updateCheckDoc"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "Post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onsubmit", new global::Microsoft.AspNetCore.Html.HtmlString("updateCheckDoc(event)"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/js/RevDocumental.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\RevDocumental\Create.cshtml"
  
    ViewData["Title"] = "Revision Documental";

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div id=\"Splash_Screen_Load\" style=\"display: none\"></div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6a317f47672a8487a99451c5b3fe781cc4ad1dca5598", async() => {
                WriteLiteral(@"
        <div class=""row"">
            <div class=""col-md-7"">
                <h4 class=""color_orange"">
                    Programar OT
                </h4>
            </div>
            <div class=""col-md-3"">
                <h6>Orden de trabajo</h6>
                <input type=""text"" class=""form-control inputText_NoBorder inputHeight"" readonly id=""O_Trabajo""");
                BeginWriteAttribute("value", "\r\n                       value=\"", 637, "\"", 741, 1);
#nullable restore
#line 16 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\RevDocumental\Create.cshtml"
WriteAttributeValue("", 669, Model.Ord_Trabajo.FirstOrDefault().Ord_Codotc.ToString().PadLeft(8,'0'), 669, 72, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />    \r\n            </div>\r\n\r\n            <div class=\"col-md-4\">\r\n                <h6>Fecha O.T.</h6>\r\n                <input type=\"text\" class=\"form-control\" readonly");
                BeginWriteAttribute("value", "\r\n                       value=\"", 910, "\"", 1014, 1);
#nullable restore
#line 22 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\RevDocumental\Create.cshtml"
WriteAttributeValue("", 942, Model.Ord_Trabajo.FirstOrDefault().Ord_Fecmod.Value.ToShortDateString(), 942, 72, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
            </div>
        </div>

        <div class=""row mt-3"">
            <div class=""col-md-4"">
                <h6>Nombre del Proyecto</h6>
                <input type=""text"" class=""form-control inputText_NoBorder inputHeight"" readonly name=""N_Proyecto""");
                BeginWriteAttribute("value", "\r\n                       value=\"", 1285, "\"", 1364, 1);
#nullable restore
#line 30 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\RevDocumental\Create.cshtml"
WriteAttributeValue("", 1317, Model.Ord_Trabajo.FirstOrDefault().Ord_Nomproy, 1317, 47, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n            </div>\r\n            <div class=\"col-md-4\">\r\n                <h6>Nombre del Cliente</h6>\r\n                <input type=\"text\" readonly class=\"form-control inputText_NoBorder inputHeight\" name=\"N_Cliente\"");
                BeginWriteAttribute("value", "\r\n                       value=\"", 1583, "\"", 1657, 1);
#nullable restore
#line 35 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\RevDocumental\Create.cshtml"
WriteAttributeValue("", 1615, Model.Clientes.FirstOrDefault().CliNombre, 1615, 42, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n            </div>\r\n        </div>\r\n\r\n");
#nullable restore
#line 39 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\RevDocumental\Create.cshtml"
         if (Model.Ord_Trabajo.FirstOrDefault().Ord_RevDoc_Rest > 0)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <div class=\"mt-3\">\r\n                <h5 class=\"mt-3\">Se debe marcar los documentos que se recibieron para la orden de trabajo.</h5>\r\n\r\n");
#nullable restore
#line 44 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\RevDocumental\Create.cshtml"
                 foreach (var itemDistinct in Model.rev_DocItems.Select(s => s.Rev_LisCheck).Distinct())
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <div class=\"row\">\r\n                        <div class=\"col-md-12 col-sm-12 mt-2\">\r\n                            <div class=\"card\">\r\n                                <h6 class=\"color_orange pt-3 pl-3 pr-3\" style=\"padding:1.2vh\">");
#nullable restore
#line 49 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\RevDocumental\Create.cshtml"
                                                                                         Write(itemDistinct);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h6>\r\n");
#nullable restore
#line 50 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\RevDocumental\Create.cshtml"
                                 foreach (var item in Model.rev_DocItems.Where(w => w.Rev_LisCheck == itemDistinct))
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 52 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\RevDocumental\Create.cshtml"
                                     if (!item.Rev_Estado)
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <div class=\"row\">\r\n                                            <div class=\"col-md-7\">\r\n                                                <input type=\"checkbox\"");
                BeginWriteAttribute("id", " id=\"", 2768, "\"", 2793, 1);
#nullable restore
#line 56 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\RevDocumental\Create.cshtml"
WriteAttributeValue("", 2773, item.Rev_CodDocItem, 2773, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 2794, "\"", 2822, 1);
#nullable restore
#line 56 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\RevDocumental\Create.cshtml"
WriteAttributeValue("", 2802, item.Rev_CodDocItem, 2802, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("onclick", "\r\n                                                       onclick=\"", 2823, "\"", 2926, 3);
                WriteAttributeValue("", 2889, "hideorshowtxt(\'", 2889, 15, true);
#nullable restore
#line 57 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\RevDocumental\Create.cshtml"
WriteAttributeValue("", 2904, item.Rev_CodDocItem, 2904, 20, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 2924, "\')", 2924, 2, true);
                EndWriteAttribute();
                WriteLiteral(">\r\n                                                <label");
                BeginWriteAttribute("for", " for=\"", 2984, "\"", 3010, 1);
#nullable restore
#line 58 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\RevDocumental\Create.cshtml"
WriteAttributeValue("", 2990, item.Rev_CodDocItem, 2990, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 58 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\RevDocumental\Create.cshtml"
                                                                             Write(item.Rev_DocCheck);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n                                            </div>\r\n                                            <div class=\"col-md-5\">\r\n                                                <input type=\"text\" class=\"form-control\"");
                BeginWriteAttribute("value", " value=\"", 3247, "\"", 3272, 1);
#nullable restore
#line 61 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\RevDocumental\Create.cshtml"
WriteAttributeValue("", 3255, item.Rev_Descrip, 3255, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("id", " id=\"", 3273, "\"", 3302, 2);
                WriteAttributeValue("", 3278, "txt_", 3278, 4, true);
#nullable restore
#line 61 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\RevDocumental\Create.cshtml"
WriteAttributeValue("", 3282, item.Rev_CodDocItem, 3282, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("\r\n                                                       placeholder=\"Especifique razon del no aceptado\" maxlength=\"200\" />\r\n                                            </div>\r\n                                        </div>\r\n");
#nullable restore
#line 65 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\RevDocumental\Create.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <div class=\"col-md-12 mt-3\">\r\n                                            <label>");
#nullable restore
#line 69 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\RevDocumental\Create.cshtml"
                                              Write(item.Rev_DocCheck);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n                                        </div>\r\n");
#nullable restore
#line 71 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\RevDocumental\Create.cshtml"
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 71 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\RevDocumental\Create.cshtml"
                                     
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 76 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\RevDocumental\Create.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </div>\r\n");
#nullable restore
#line 78 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\RevDocumental\Create.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        <div class=\"col-md-12 col-sm-12\">\r\n            <div class=\"row\" style=\"padding-top: 10vh;\">\r\n");
#nullable restore
#line 82 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\RevDocumental\Create.cshtml"
                 if (Model.Ord_Trabajo.FirstOrDefault().Ord_Canvis_Rest > 0)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <input type=\"submit\" class=\"ml-5 col-md-4 btn btn-light TextNegrita border-radius New_OT btn_save_color disable\" value=\"Guardar\" id=\"Btn_SaveOt\" />\r\n");
#nullable restore
#line 85 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\RevDocumental\Create.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                <input type=\"button\" class=\"ml-5 col-md-4 btn btn-light TextNegrita float-right border-radius btn_cancel disable\" onclick=\"location.href =\'/RevDocumental/Show\'\" value=\"Cancelar\" />\r\n            </div>\r\n        </div>\r\n    ");
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
            WriteLiteral("\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6a317f47672a8487a99451c5b3fe781cc4ad1dca18983", async() => {
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
#line 92 "C:\Users\edwin\OneDrive\Documentos\My Web Sites\AsikWeb\AsikWeb\Views\RevDocumental\Create.cshtml"
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
