#pragma checksum "C:\Users\kenia\OneDrive\Documentos\PUC Minas\Eixo 2\pmv-ads-2022-1-e2-proj-int-t1-servico-transporte-carretos\code\ClickExpress\ClickExpress\Views\Usuarios\RelatoriosUserRespondido.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4b370b050073a1b039c3597d28229e371f65d176"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuarios_RelatoriosUserRespondido), @"mvc.1.0.view", @"/Views/Usuarios/RelatoriosUserRespondido.cshtml")]
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
#line 1 "C:\Users\kenia\OneDrive\Documentos\PUC Minas\Eixo 2\pmv-ads-2022-1-e2-proj-int-t1-servico-transporte-carretos\code\ClickExpress\ClickExpress\Views\_ViewImports.cshtml"
using ClickExpress;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\kenia\OneDrive\Documentos\PUC Minas\Eixo 2\pmv-ads-2022-1-e2-proj-int-t1-servico-transporte-carretos\code\ClickExpress\ClickExpress\Views\_ViewImports.cshtml"
using ClickExpress.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b370b050073a1b039c3597d28229e371f65d176", @"/Views/Usuarios/RelatoriosUserRespondido.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8197a9b78a03eb2e0bb5fc09137c9cbac3fa0c99", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuarios_RelatoriosUserRespondido : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ClickExpress.Models.Usuario>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RelatoriosUser", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\kenia\OneDrive\Documentos\PUC Minas\Eixo 2\pmv-ads-2022-1-e2-proj-int-t1-servico-transporte-carretos\code\ClickExpress\ClickExpress\Views\Usuarios\RelatoriosUserRespondido.cshtml"
  
    ViewData["Title"] = "RelatoriosUserRespondido";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""container m-0 p-0 mw-100"" style=""font-size: 0.7vw"">
    <div>
        <h4 class=""table text-white"">Pedidos Respondidos</h4>
        <hr />
        <table class=""table text-white"">
            <thead>
                <tr>
                    <th>
                        Status
                    </th>
                    <th>
                        Id_contrato
                    </th>
                    <th>
                        Tipo
                    </th>
                    <th>
                        Dt_agendamento
                    </th>
                    <th>
                        Cidade_origem
                    </th>
                    <th>
                        UF_origem
                    </th>
                    <th>
                        Cidade_destino
                    </th>
                    <th>
                        UF_destino
                    </th>
                    <th>
                        Serv_descarrega
");
            WriteLiteral(@"                    </th>
                    <th>
                        Serv_montagem
                    </th>
                    <th>
                        Preco
                    </th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 51 "C:\Users\kenia\OneDrive\Documentos\PUC Minas\Eixo 2\pmv-ads-2022-1-e2-proj-int-t1-servico-transporte-carretos\code\ClickExpress\ClickExpress\Views\Usuarios\RelatoriosUserRespondido.cshtml"
                 foreach (var item in Model.Pedidos)
                {

                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 54 "C:\Users\kenia\OneDrive\Documentos\PUC Minas\Eixo 2\pmv-ads-2022-1-e2-proj-int-t1-servico-transporte-carretos\code\ClickExpress\ClickExpress\Views\Usuarios\RelatoriosUserRespondido.cshtml"
                     if (Convert.ToInt32(item.Status) == 1)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        <div class=\"text-dark bg-warning rounded\">Respondido</div>\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 61 "C:\Users\kenia\OneDrive\Documentos\PUC Minas\Eixo 2\pmv-ads-2022-1-e2-proj-int-t1-servico-transporte-carretos\code\ClickExpress\ClickExpress\Views\Usuarios\RelatoriosUserRespondido.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Id_contrato));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 64 "C:\Users\kenia\OneDrive\Documentos\PUC Minas\Eixo 2\pmv-ads-2022-1-e2-proj-int-t1-servico-transporte-carretos\code\ClickExpress\ClickExpress\Views\Usuarios\RelatoriosUserRespondido.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Tipo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 67 "C:\Users\kenia\OneDrive\Documentos\PUC Minas\Eixo 2\pmv-ads-2022-1-e2-proj-int-t1-servico-transporte-carretos\code\ClickExpress\ClickExpress\Views\Usuarios\RelatoriosUserRespondido.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Dt_agendamento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 70 "C:\Users\kenia\OneDrive\Documentos\PUC Minas\Eixo 2\pmv-ads-2022-1-e2-proj-int-t1-servico-transporte-carretos\code\ClickExpress\ClickExpress\Views\Usuarios\RelatoriosUserRespondido.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Cidade_origem));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 73 "C:\Users\kenia\OneDrive\Documentos\PUC Minas\Eixo 2\pmv-ads-2022-1-e2-proj-int-t1-servico-transporte-carretos\code\ClickExpress\ClickExpress\Views\Usuarios\RelatoriosUserRespondido.cshtml"
                   Write(Html.DisplayFor(modelItem => item.UF_origem));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 76 "C:\Users\kenia\OneDrive\Documentos\PUC Minas\Eixo 2\pmv-ads-2022-1-e2-proj-int-t1-servico-transporte-carretos\code\ClickExpress\ClickExpress\Views\Usuarios\RelatoriosUserRespondido.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Cidade_destino));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 79 "C:\Users\kenia\OneDrive\Documentos\PUC Minas\Eixo 2\pmv-ads-2022-1-e2-proj-int-t1-servico-transporte-carretos\code\ClickExpress\ClickExpress\Views\Usuarios\RelatoriosUserRespondido.cshtml"
                   Write(Html.DisplayFor(modelItem => item.UF_destino));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 82 "C:\Users\kenia\OneDrive\Documentos\PUC Minas\Eixo 2\pmv-ads-2022-1-e2-proj-int-t1-servico-transporte-carretos\code\ClickExpress\ClickExpress\Views\Usuarios\RelatoriosUserRespondido.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Serv_descarrega));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 85 "C:\Users\kenia\OneDrive\Documentos\PUC Minas\Eixo 2\pmv-ads-2022-1-e2-proj-int-t1-servico-transporte-carretos\code\ClickExpress\ClickExpress\Views\Usuarios\RelatoriosUserRespondido.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Serv_montagem));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 88 "C:\Users\kenia\OneDrive\Documentos\PUC Minas\Eixo 2\pmv-ads-2022-1-e2-proj-int-t1-servico-transporte-carretos\code\ClickExpress\ClickExpress\Views\Usuarios\RelatoriosUserRespondido.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Preco));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 91 "C:\Users\kenia\OneDrive\Documentos\PUC Minas\Eixo 2\pmv-ads-2022-1-e2-proj-int-t1-servico-transporte-carretos\code\ClickExpress\ClickExpress\Views\Usuarios\RelatoriosUserRespondido.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 91 "C:\Users\kenia\OneDrive\Documentos\PUC Minas\Eixo 2\pmv-ads-2022-1-e2-proj-int-t1-servico-transporte-carretos\code\ClickExpress\ClickExpress\Views\Usuarios\RelatoriosUserRespondido.cshtml"
                     
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n<div>    \r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4b370b050073a1b039c3597d28229e371f65d17612076", async() => {
                WriteLiteral("Voltar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ClickExpress.Models.Usuario> Html { get; private set; }
    }
}
#pragma warning restore 1591
