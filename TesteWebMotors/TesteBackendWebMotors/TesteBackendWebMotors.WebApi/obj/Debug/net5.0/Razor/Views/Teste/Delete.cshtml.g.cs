#pragma checksum "W:\Projetos-Pessoais\Desafios-Empregos\TesteWebMotors\TesteBackendWebMotors\TesteBackendWebMotors.WebApi\Views\Teste\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dfd4f172055ffb47eacf247d6aa4a8796e5f07a1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Teste_Delete), @"mvc.1.0.view", @"/Views/Teste/Delete.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dfd4f172055ffb47eacf247d6aa4a8796e5f07a1", @"/Views/Teste/Delete.cshtml")]
    public class Views_Teste_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TesteBackendWebMotors.Data.Entities.Anuncio>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "W:\Projetos-Pessoais\Desafios-Empregos\TesteWebMotors\TesteBackendWebMotors\TesteBackendWebMotors.WebApi\Views\Teste\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Delete</h1>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Anuncio</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 15 "W:\Projetos-Pessoais\Desafios-Empregos\TesteWebMotors\TesteBackendWebMotors\TesteBackendWebMotors.WebApi\Views\Teste\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Marca));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 18 "W:\Projetos-Pessoais\Desafios-Empregos\TesteWebMotors\TesteBackendWebMotors\TesteBackendWebMotors.WebApi\Views\Teste\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Marca));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 21 "W:\Projetos-Pessoais\Desafios-Empregos\TesteWebMotors\TesteBackendWebMotors\TesteBackendWebMotors.WebApi\Views\Teste\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Modelo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 24 "W:\Projetos-Pessoais\Desafios-Empregos\TesteWebMotors\TesteBackendWebMotors\TesteBackendWebMotors.WebApi\Views\Teste\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Modelo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 27 "W:\Projetos-Pessoais\Desafios-Empregos\TesteWebMotors\TesteBackendWebMotors\TesteBackendWebMotors.WebApi\Views\Teste\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Versao));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 30 "W:\Projetos-Pessoais\Desafios-Empregos\TesteWebMotors\TesteBackendWebMotors\TesteBackendWebMotors.WebApi\Views\Teste\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Versao));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 33 "W:\Projetos-Pessoais\Desafios-Empregos\TesteWebMotors\TesteBackendWebMotors\TesteBackendWebMotors.WebApi\Views\Teste\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Ano));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 36 "W:\Projetos-Pessoais\Desafios-Empregos\TesteWebMotors\TesteBackendWebMotors\TesteBackendWebMotors.WebApi\Views\Teste\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Ano));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 39 "W:\Projetos-Pessoais\Desafios-Empregos\TesteWebMotors\TesteBackendWebMotors\TesteBackendWebMotors.WebApi\Views\Teste\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Quilometragem));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 42 "W:\Projetos-Pessoais\Desafios-Empregos\TesteWebMotors\TesteBackendWebMotors\TesteBackendWebMotors.WebApi\Views\Teste\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Quilometragem));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 45 "W:\Projetos-Pessoais\Desafios-Empregos\TesteWebMotors\TesteBackendWebMotors\TesteBackendWebMotors.WebApi\Views\Teste\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Observacao));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 48 "W:\Projetos-Pessoais\Desafios-Empregos\TesteWebMotors\TesteBackendWebMotors\TesteBackendWebMotors.WebApi\Views\Teste\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Observacao));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    <form asp-action=\"Delete\">\r\n        <input type=\"hidden\" asp-for=\"Id\" />\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\r\n        <a asp-action=\"Index\">Back to List</a>\r\n    </form>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TesteBackendWebMotors.Data.Entities.Anuncio> Html { get; private set; }
    }
}
#pragma warning restore 1591
