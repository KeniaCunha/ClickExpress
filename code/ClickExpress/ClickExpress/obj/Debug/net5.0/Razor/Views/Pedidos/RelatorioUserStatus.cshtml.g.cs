#pragma checksum "D:\werlon\pmv-ads-2022-1-e2-proj-int-t1-servico-transporte-carretos\code\ClickExpress\ClickExpress\Views\Pedidos\RelatorioUserStatus.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "672c1707e0cc9a772770e14a784e48a556423cec"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pedidos_RelatorioUserStatus), @"mvc.1.0.view", @"/Views/Pedidos/RelatorioUserStatus.cshtml")]
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
#line 1 "D:\werlon\pmv-ads-2022-1-e2-proj-int-t1-servico-transporte-carretos\code\ClickExpress\ClickExpress\Views\_ViewImports.cshtml"
using ClickExpress;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\werlon\pmv-ads-2022-1-e2-proj-int-t1-servico-transporte-carretos\code\ClickExpress\ClickExpress\Views\_ViewImports.cshtml"
using ClickExpress.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"672c1707e0cc9a772770e14a784e48a556423cec", @"/Views/Pedidos/RelatorioUserStatus.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8197a9b78a03eb2e0bb5fc09137c9cbac3fa0c99", @"/Views/_ViewImports.cshtml")]
    public class Views_Pedidos_RelatorioUserStatus : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ClickExpress.Models.Pedido>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\werlon\pmv-ads-2022-1-e2-proj-int-t1-servico-transporte-carretos\code\ClickExpress\ClickExpress\Views\Pedidos\RelatorioUserStatus.cshtml"
  
    ViewData["Title"] = "RelatorioUserStatus";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 8 "D:\werlon\pmv-ads-2022-1-e2-proj-int-t1-servico-transporte-carretos\code\ClickExpress\ClickExpress\Views\Pedidos\RelatorioUserStatus.cshtml"
  var teste = new StatusServico();
    teste = (StatusServico)0;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div style=\"padding: 20px 20px 20px 20px\">\r\n    <h4>.</h4>\r\n    <br />\r\n    <div class=\"table-responsive\">\r\n        <table class=\"table text-white\">\r\n            <thead>\r\n                <tr>\r\n                    <th>\r\n                        ");
#nullable restore
#line 19 "D:\werlon\pmv-ads-2022-1-e2-proj-int-t1-servico-transporte-carretos\code\ClickExpress\ClickExpress\Views\Pedidos\RelatorioUserStatus.cshtml"
                   Write(Html.DisplayNameFor(model => model.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 22 "D:\werlon\pmv-ads-2022-1-e2-proj-int-t1-servico-transporte-carretos\code\ClickExpress\ClickExpress\Views\Pedidos\RelatorioUserStatus.cshtml"
                   Write(Html.DisplayNameFor(model => model.Id_contrato));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 25 "D:\werlon\pmv-ads-2022-1-e2-proj-int-t1-servico-transporte-carretos\code\ClickExpress\ClickExpress\Views\Pedidos\RelatorioUserStatus.cshtml"
                   Write(Html.DisplayNameFor(model => model.Tipo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 28 "D:\werlon\pmv-ads-2022-1-e2-proj-int-t1-servico-transporte-carretos\code\ClickExpress\ClickExpress\Views\Pedidos\RelatorioUserStatus.cshtml"
                   Write(Html.DisplayNameFor(model => model.Dt_agendamento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 31 "D:\werlon\pmv-ads-2022-1-e2-proj-int-t1-servico-transporte-carretos\code\ClickExpress\ClickExpress\Views\Pedidos\RelatorioUserStatus.cshtml"
                   Write(Html.DisplayNameFor(model => model.Cidade_origem));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 34 "D:\werlon\pmv-ads-2022-1-e2-proj-int-t1-servico-transporte-carretos\code\ClickExpress\ClickExpress\Views\Pedidos\RelatorioUserStatus.cshtml"
                   Write(Html.DisplayNameFor(model => model.UF_origem));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 37 "D:\werlon\pmv-ads-2022-1-e2-proj-int-t1-servico-transporte-carretos\code\ClickExpress\ClickExpress\Views\Pedidos\RelatorioUserStatus.cshtml"
                   Write(Html.DisplayNameFor(model => model.Cidade_destino));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 40 "D:\werlon\pmv-ads-2022-1-e2-proj-int-t1-servico-transporte-carretos\code\ClickExpress\ClickExpress\Views\Pedidos\RelatorioUserStatus.cshtml"
                   Write(Html.DisplayNameFor(model => model.UF_destino));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 43 "D:\werlon\pmv-ads-2022-1-e2-proj-int-t1-servico-transporte-carretos\code\ClickExpress\ClickExpress\Views\Pedidos\RelatorioUserStatus.cshtml"
                   Write(Html.DisplayNameFor(model => model.Serv_descarrega));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 46 "D:\werlon\pmv-ads-2022-1-e2-proj-int-t1-servico-transporte-carretos\code\ClickExpress\ClickExpress\Views\Pedidos\RelatorioUserStatus.cshtml"
                   Write(Html.DisplayNameFor(model => model.Serv_montagem));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n\r\n                    <th></th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
#nullable restore
#line 53 "D:\werlon\pmv-ads-2022-1-e2-proj-int-t1-servico-transporte-carretos\code\ClickExpress\ClickExpress\Views\Pedidos\RelatorioUserStatus.cshtml"
                 foreach (var item in Model)
                {
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 55 "D:\werlon\pmv-ads-2022-1-e2-proj-int-t1-servico-transporte-carretos\code\ClickExpress\ClickExpress\Views\Pedidos\RelatorioUserStatus.cshtml"
     if (item.Status == teste)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\r\n        <td>\r\n            <div class=\"text-white bg-danger\">Pendente</div>\r\n        </td>\r\n        <td>\r\n            ");
#nullable restore
#line 62 "D:\werlon\pmv-ads-2022-1-e2-proj-int-t1-servico-transporte-carretos\code\ClickExpress\ClickExpress\Views\Pedidos\RelatorioUserStatus.cshtml"
       Write(Html.DisplayFor(modelItem => item.Id_contrato));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");
#nullable restore
#line 65 "D:\werlon\pmv-ads-2022-1-e2-proj-int-t1-servico-transporte-carretos\code\ClickExpress\ClickExpress\Views\Pedidos\RelatorioUserStatus.cshtml"
       Write(Html.DisplayFor(modelItem => item.Tipo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");
#nullable restore
#line 68 "D:\werlon\pmv-ads-2022-1-e2-proj-int-t1-servico-transporte-carretos\code\ClickExpress\ClickExpress\Views\Pedidos\RelatorioUserStatus.cshtml"
       Write(Html.DisplayFor(modelItem => item.Dt_agendamento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");
#nullable restore
#line 71 "D:\werlon\pmv-ads-2022-1-e2-proj-int-t1-servico-transporte-carretos\code\ClickExpress\ClickExpress\Views\Pedidos\RelatorioUserStatus.cshtml"
       Write(Html.DisplayFor(modelItem => item.Cidade_origem));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");
#nullable restore
#line 74 "D:\werlon\pmv-ads-2022-1-e2-proj-int-t1-servico-transporte-carretos\code\ClickExpress\ClickExpress\Views\Pedidos\RelatorioUserStatus.cshtml"
       Write(Html.DisplayFor(modelItem => item.UF_origem));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");
#nullable restore
#line 77 "D:\werlon\pmv-ads-2022-1-e2-proj-int-t1-servico-transporte-carretos\code\ClickExpress\ClickExpress\Views\Pedidos\RelatorioUserStatus.cshtml"
       Write(Html.DisplayFor(modelItem => item.Cidade_destino));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");
#nullable restore
#line 80 "D:\werlon\pmv-ads-2022-1-e2-proj-int-t1-servico-transporte-carretos\code\ClickExpress\ClickExpress\Views\Pedidos\RelatorioUserStatus.cshtml"
       Write(Html.DisplayFor(modelItem => item.UF_destino));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");
#nullable restore
#line 83 "D:\werlon\pmv-ads-2022-1-e2-proj-int-t1-servico-transporte-carretos\code\ClickExpress\ClickExpress\Views\Pedidos\RelatorioUserStatus.cshtml"
       Write(Html.DisplayFor(modelItem => item.Serv_descarrega));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");
#nullable restore
#line 86 "D:\werlon\pmv-ads-2022-1-e2-proj-int-t1-servico-transporte-carretos\code\ClickExpress\ClickExpress\Views\Pedidos\RelatorioUserStatus.cshtml"
       Write(Html.DisplayFor(modelItem => item.Serv_montagem));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n    </tr>                ");
#nullable restore
#line 88 "D:\werlon\pmv-ads-2022-1-e2-proj-int-t1-servico-transporte-carretos\code\ClickExpress\ClickExpress\Views\Pedidos\RelatorioUserStatus.cshtml"
                         }

#line default
#line hidden
#nullable disable
#nullable restore
#line 88 "D:\werlon\pmv-ads-2022-1-e2-proj-int-t1-servico-transporte-carretos\code\ClickExpress\ClickExpress\Views\Pedidos\RelatorioUserStatus.cshtml"
                                      }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n    <br />\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ClickExpress.Models.Pedido>> Html { get; private set; }
    }
}
#pragma warning restore 1591
