#pragma checksum "C:\ProjetosWeb\Pokedex\Pokedex\Pages\Pokemon.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "09a608bd3e83eec51d9b9a00efb3678eb1f030f7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Pokedex.Pages.Pages_Pokemon), @"mvc.1.0.razor-page", @"/Pages/Pokemon.cshtml")]
namespace Pokedex.Pages
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
#line 1 "C:\ProjetosWeb\Pokedex\Pokedex\Pages\_ViewImports.cshtml"
using Pokedex;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"09a608bd3e83eec51d9b9a00efb3678eb1f030f7", @"/Pages/Pokemon.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c854cf51b4c88281b46a1c2796ed99b0ee737d4", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Pokemon : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-lg btn-outline-dark float-left"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Pokemon", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-lg btn-outline-dark float-right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\ProjetosWeb\Pokedex\Pokedex\Pages\Pokemon.cshtml"
  
    Layout = "~/Pages/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container pb-5\">\r\n    <div class=\"row\">\r\n        <div class=\"col text-center\">\r\n            <h1 class=\"fw-light mt-5 mb-5\">\r\n");
#nullable restore
#line 11 "C:\ProjetosWeb\Pokedex\Pokedex\Pages\Pokemon.cshtml"
                 if (Model.Anterior !=null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "09a608bd3e83eec51d9b9a00efb3678eb1f030f74755", async() => {
                WriteLiteral("\r\n                        Nº ");
#nullable restore
#line 14 "C:\ProjetosWeb\Pokedex\Pokedex\Pages\Pokemon.cshtml"
                      Write(Model.Anterior.Numero.ToString("000"));

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 14 "C:\ProjetosWeb\Pokedex\Pokedex\Pages\Pokemon.cshtml"
                                                             Write(Model.Anterior.Nome);

#line default
#line hidden
#nullable disable
                WriteLiteral(" \r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-numero", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 13 "C:\ProjetosWeb\Pokedex\Pokedex\Pages\Pokemon.cshtml"
                                                                                                WriteLiteral(Model.Anterior.Numero);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["numero"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-numero", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["numero"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 16 "C:\ProjetosWeb\Pokedex\Pokedex\Pages\Pokemon.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <strong>");
#nullable restore
#line 17 "C:\ProjetosWeb\Pokedex\Pokedex\Pages\Pokemon.cshtml"
                   Write(Model.Pokemon.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - Nº ");
#nullable restore
#line 17 "C:\ProjetosWeb\Pokedex\Pokedex\Pages\Pokemon.cshtml"
                                            Write(Model.Pokemon.Numero);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </strong>\r\n");
#nullable restore
#line 18 "C:\ProjetosWeb\Pokedex\Pokedex\Pages\Pokemon.cshtml"
                 if (Model.Proximo !=null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "09a608bd3e83eec51d9b9a00efb3678eb1f030f78513", async() => {
                WriteLiteral("\r\n                        Nº ");
#nullable restore
#line 21 "C:\ProjetosWeb\Pokedex\Pokedex\Pages\Pokemon.cshtml"
                      Write(Model.Proximo.Numero.ToString("000"));

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 21 "C:\ProjetosWeb\Pokedex\Pokedex\Pages\Pokemon.cshtml"
                                                            Write(Model.Proximo.Nome);

#line default
#line hidden
#nullable disable
                WriteLiteral(" \r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-numero", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 20 "C:\ProjetosWeb\Pokedex\Pokedex\Pages\Pokemon.cshtml"
                                                                                                 WriteLiteral(Model.Proximo.Numero);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["numero"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-numero", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["numero"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("   \r\n");
#nullable restore
#line 23 "C:\ProjetosWeb\Pokedex\Pokedex\Pages\Pokemon.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </h1>\r\n        </div>\r\n    </div>\r\n    <div class=\"row\">\r\n        <div class=\"col-lg-6\">\r\n            <img class=\"img-fluid\"");
            BeginWriteAttribute("src", " src=\"", 1117, "\"", 1157, 1);
#nullable restore
#line 29 "C:\ProjetosWeb\Pokedex\Pokedex\Pages\Pokemon.cshtml"
WriteAttributeValue("", 1123, Url.Content(Model.Pokemon.Imagem), 1123, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1158, "\"", 1183, 1);
#nullable restore
#line 29 "C:\ProjetosWeb\Pokedex\Pokedex\Pages\Pokemon.cshtml"
WriteAttributeValue("", 1164, Model.Pokemon.Nome, 1164, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n        </div>\r\n        <div class=\"col-lg-6\">\r\n            <label class=\"mt-5 text-justify\">");
#nullable restore
#line 32 "C:\ProjetosWeb\Pokedex\Pokedex\Pages\Pokemon.cshtml"
                                        Write(Model.Pokemon.Descricao);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </label>\r\n            <hr>\r\n            <label class=\"titulo w-25\">Categoria</label><label>");
#nullable restore
#line 34 "C:\ProjetosWeb\Pokedex\Pokedex\Pages\Pokemon.cshtml"
                                                          Write(Model.Pokemon.Especie);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n            <hr>\r\n            <label class=\"titulo w-25\">Altura</label><label>");
#nullable restore
#line 36 "C:\ProjetosWeb\Pokedex\Pokedex\Pages\Pokemon.cshtml"
                                                       Write(Model.Pokemon.Altura);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n            <hr>\r\n            <label class=\"titulo w-25\">Peso</label><label>");
#nullable restore
#line 38 "C:\ProjetosWeb\Pokedex\Pokedex\Pages\Pokemon.cshtml"
                                                     Write(Model.Pokemon.Peso);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n            <hr>\r\n\r\n            <div class=\"tipo mt-2\">\r\n                <label class=\"titulo w-25\">Tipo</label>\r\n");
#nullable restore
#line 43 "C:\ProjetosWeb\Pokedex\Pokedex\Pages\Pokemon.cshtml"
                 foreach (var tipo in Model.Pokemon.Tipo)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                     ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "09a608bd3e83eec51d9b9a00efb3678eb1f030f714122", async() => {
#nullable restore
#line 45 "C:\ProjetosWeb\Pokedex\Pokedex\Pages\Pokemon.cshtml"
                                                                                          Write(tipo);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Tipo", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 45 "C:\ProjetosWeb\Pokedex\Pokedex\Pages\Pokemon.cshtml"
                                              WriteLiteral(tipo);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Tipo"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Tipo", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Tipo"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 4, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1906, "btn", 1906, 3, true);
            AddHtmlAttributeValue(" ", 1909, "btn-sm", 1910, 7, true);
            AddHtmlAttributeValue(" ", 1916, "tipo-", 1917, 6, true);
#nullable restore
#line 45 "C:\ProjetosWeb\Pokedex\Pokedex\Pages\Pokemon.cshtml"
AddHtmlAttributeValue("", 1922, tipo, 1922, 5, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 46 "C:\ProjetosWeb\Pokedex\Pokedex\Pages\Pokemon.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Pokedex.Pages.PokemonModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pokedex.Pages.PokemonModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pokedex.Pages.PokemonModel>)PageContext?.ViewData;
        public Pokedex.Pages.PokemonModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
