#pragma checksum "C:\Users\Gustavo\Desktop\sistema de login\Views\Pacotes\PacotesL.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9558db10762554abc4f8c2ea0c325d673f8bbada"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pacotes_PacotesL), @"mvc.1.0.view", @"/Views/Pacotes/PacotesL.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9558db10762554abc4f8c2ea0c325d673f8bbada", @"/Views/Pacotes/PacotesL.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"305528339fb203cd9148ff4e86d6ff2391d48b8f", @"/Views/_ViewImports.cshtml")]
    public class Views_Pacotes_PacotesL : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<PacoteM>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"text-center\">\r\n<h1>");
#nullable restore
#line 3 "C:\Users\Gustavo\Desktop\sistema de login\Views\Pacotes\PacotesL.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>

<br>
<table class=""table"">
  <thead>
    <tr>
      <th scope=""col"">ORIGEM</th>
      <th scope=""col"">DESTINO</th>
      <th scope=""col"">MÊS</th>
      <th scope=""col"">IDA</th>
      <th scope=""col"">VOLTA</th>
      <th scope=""col"">PREÇO</th>
      <th scope=""col"">AÇÕES</th>
    </tr>
  </thead>
");
#nullable restore
#line 18 "C:\Users\Gustavo\Desktop\sistema de login\Views\Pacotes\PacotesL.cshtml"
   foreach (PacoteM pacoteAtual in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("  <tbody>\r\n    <tr>\r\n      <th >");
#nullable restore
#line 22 "C:\Users\Gustavo\Desktop\sistema de login\Views\Pacotes\PacotesL.cshtml"
      Write(pacoteAtual.origem);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n      <td>");
#nullable restore
#line 23 "C:\Users\Gustavo\Desktop\sistema de login\Views\Pacotes\PacotesL.cshtml"
     Write(pacoteAtual.destino);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n      <td>");
#nullable restore
#line 24 "C:\Users\Gustavo\Desktop\sistema de login\Views\Pacotes\PacotesL.cshtml"
     Write(pacoteAtual.mes);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n      <td>");
#nullable restore
#line 25 "C:\Users\Gustavo\Desktop\sistema de login\Views\Pacotes\PacotesL.cshtml"
     Write(pacoteAtual.ida);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n      <td>");
#nullable restore
#line 26 "C:\Users\Gustavo\Desktop\sistema de login\Views\Pacotes\PacotesL.cshtml"
     Write(pacoteAtual.volta);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n      <td>");
#nullable restore
#line 27 "C:\Users\Gustavo\Desktop\sistema de login\Views\Pacotes\PacotesL.cshtml"
     Write(pacoteAtual.preco);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n      <td><a");
            BeginWriteAttribute("href", " href=\"", 679, "\"", 720, 2);
            WriteAttributeValue("", 686, "/Pacotes/Editar?id=", 686, 19, true);
#nullable restore
#line 28 "C:\Users\Gustavo\Desktop\sistema de login\Views\Pacotes\PacotesL.cshtml"
WriteAttributeValue("", 705, pacoteAtual.id, 705, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\"button\" class=\"btn btn-warning\">Editar</a><a");
            BeginWriteAttribute("href", " href=\"", 772, "\"", 814, 2);
            WriteAttributeValue("", 779, "/Pacotes/Remover?id=", 779, 20, true);
#nullable restore
#line 28 "C:\Users\Gustavo\Desktop\sistema de login\Views\Pacotes\PacotesL.cshtml"
WriteAttributeValue("", 799, pacoteAtual.id, 799, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Apagar</a>\r\n       </td>\r\n    </tr>\r\n  </tbody>\r\n");
#nullable restore
#line 32 "C:\Users\Gustavo\Desktop\sistema de login\Views\Pacotes\PacotesL.cshtml"
  }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<PacoteM>> Html { get; private set; }
    }
}
#pragma warning restore 1591
