#pragma checksum "C:\Users\rmadureira\source\repos\PeTinder\PeTinder\Petinder_PWA\Server\Views\Animals\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cf7f39e356a7ac24b63aa09fb680679ef5ff279c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Animals_Create), @"mvc.1.0.view", @"/Views/Animals/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf7f39e356a7ac24b63aa09fb680679ef5ff279c", @"/Views/Animals/Create.cshtml")]
    public class Views_Animals_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Petinder_PWA.Server.Models.Animal>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\rmadureira\source\repos\PeTinder\PeTinder\Petinder_PWA\Server\Views\Animals\Create.cshtml"
  
    ViewData["Title"] = "Create";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Create</h1>

<h4>Animal</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Create"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <div class=""form-group"">
                <label asp-for=""Nome"" class=""control-label""></label>
                <input asp-for=""Nome"" class=""form-control"" />
                <span asp-validation-for=""Nome"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Sexo"" class=""control-label""></label>
                <select asp-for=""Sexo"" class=""form-control""></select>
                <span asp-validation-for=""Sexo"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Porte"" class=""control-label""></label>
                <select asp-for=""Porte"" class=""form-control""></select>
                <span asp-validation-for=""Porte"" class=""text-danger""></span>
            ");
            WriteLiteral(@"</div>
            <div class=""form-group"">
                <label asp-for=""Idade"" class=""control-label""></label>
                <input asp-for=""Idade"" class=""form-control"" />
                <span asp-validation-for=""Idade"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Create"" class=""btn btn-primary"" />
            </div>
        </form>
    </div>
</div>

<div>
    <a asp-action=""Index"">Back to List</a>
</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 47 "C:\Users\rmadureira\source\repos\PeTinder\PeTinder\Petinder_PWA\Server\Views\Animals\Create.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Petinder_PWA.Server.Models.Animal> Html { get; private set; }
    }
}
#pragma warning restore 1591
