#pragma checksum "C:\Users\Gustavo\Desktop\sistema de login\Views\Home\AcessoNegado.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cf6c2a4fb149d66d18bdcb0d6d9c986e9b1bda8a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_AcessoNegado), @"mvc.1.0.view", @"/Views/Home/AcessoNegado.cshtml")]
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
#line 1 "C:\Users\Gustavo\Desktop\sistema de login\Views\_ViewImports.cshtml"
using sistema_de_login;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Gustavo\Desktop\sistema de login\Views\_ViewImports.cshtml"
using sistema_de_login.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf6c2a4fb149d66d18bdcb0d6d9c986e9b1bda8a", @"/Views/Home/AcessoNegado.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"305528339fb203cd9148ff4e86d6ff2391d48b8f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_AcessoNegado : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Gustavo\Desktop\sistema de login\Views\Home\AcessoNegado.cshtml"
  
    ViewData["Title"] = "Acesso Negado";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1 class=\"text-center\">");
#nullable restore
#line 5 "C:\Users\Gustavo\Desktop\sistema de login\Views\Home\AcessoNegado.cshtml"
                   Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<div class=\"shadow-lg p-3 mb-5 bg-white rounded\">VOCÊ NÃO TEM PERMISSÃO PARA ACESSAR ESSA PÁGINA!</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
