#pragma checksum "C:\Users\kenia\OneDrive\Documentos\PUC Minas\Eixo 2\pmv-ads-2022-1-e2-proj-int-t1-servico-transporte-carretos\code\ClickExpress\ClickExpress\Views\Itens\ListarItens.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7192551fe54f8a2d4b9d9f1b4fe7c3db1a0e3e62"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Itens_ListarItens), @"mvc.1.0.view", @"/Views/Itens/ListarItens.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7192551fe54f8a2d4b9d9f1b4fe7c3db1a0e3e62", @"/Views/Itens/ListarItens.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8197a9b78a03eb2e0bb5fc09137c9cbac3fa0c99", @"/Views/_ViewImports.cshtml")]
    public class Views_Itens_ListarItens : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ClickExpress.Models.Item>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
    <div class=""text-white"">

        <div class=""formulario"">
            
            <div class=""form-group"">
                <label class=""control-label col-md-2"">Quantidade</label>
                <div class=""col-md-10"">
                    <input type=""text"" id=""quantidade"" name=""Quantidade"" />
                </div>
            </div>
            <div class=""form-group"">
                <label class=""control-label col-md-2"">Descricao</label>
                <div class=""col-md-10"">
                    <input type=""text"" id=""descricao"" name=""Descrição"" />
                </div>
            </div>
            <div class=""form-group"">
                <div class=""col-md-offset-2 col-md-10"">
                    <a href=""#"" onclick=""SalvarItens();"">Gravar Itens</a>
                </div>
            </div>
        </div>

        <input type=""hidden"" id=""Id_contrato""");
            BeginWriteAttribute("value", " value=\"", 950, "\"", 973, 1);
#nullable restore
#line 26 "C:\Users\kenia\OneDrive\Documentos\PUC Minas\Eixo 2\pmv-ads-2022-1-e2-proj-int-t1-servico-transporte-carretos\code\ClickExpress\ClickExpress\Views\Itens\ListarItens.cshtml"
WriteAttributeValue("", 958, ViewBag.Pedido, 958, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n\r\n        <table class=\"table\">\r\n            <thead>\r\n                <tr>\r\n\r\n                    <th>\r\n                        ");
#nullable restore
#line 33 "C:\Users\kenia\OneDrive\Documentos\PUC Minas\Eixo 2\pmv-ads-2022-1-e2-proj-int-t1-servico-transporte-carretos\code\ClickExpress\ClickExpress\Views\Itens\ListarItens.cshtml"
                   Write(Html.DisplayNameFor(model => model.Quantidade));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 36 "C:\Users\kenia\OneDrive\Documentos\PUC Minas\Eixo 2\pmv-ads-2022-1-e2-proj-int-t1-servico-transporte-carretos\code\ClickExpress\ClickExpress\Views\Itens\ListarItens.cshtml"
                   Write(Html.DisplayNameFor(model => model.Descricao));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th></th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
#nullable restore
#line 42 "C:\Users\kenia\OneDrive\Documentos\PUC Minas\Eixo 2\pmv-ads-2022-1-e2-proj-int-t1-servico-transporte-carretos\code\ClickExpress\ClickExpress\Views\Itens\ListarItens.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n\r\n                    <td>\r\n                        ");
#nullable restore
#line 47 "C:\Users\kenia\OneDrive\Documentos\PUC Minas\Eixo 2\pmv-ads-2022-1-e2-proj-int-t1-servico-transporte-carretos\code\ClickExpress\ClickExpress\Views\Itens\ListarItens.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Quantidade));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 50 "C:\Users\kenia\OneDrive\Documentos\PUC Minas\Eixo 2\pmv-ads-2022-1-e2-proj-int-t1-servico-transporte-carretos\code\ClickExpress\ClickExpress\Views\Itens\ListarItens.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Descricao));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n\r\n                </tr>\r\n");
#nullable restore
#line 54 "C:\Users\kenia\OneDrive\Documentos\PUC Minas\Eixo 2\pmv-ads-2022-1-e2-proj-int-t1-servico-transporte-carretos\code\ClickExpress\ClickExpress\Views\Itens\ListarItens.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ClickExpress.Models.Item>> Html { get; private set; }
    }
}
#pragma warning restore 1591
