#pragma checksum "C:\Users\ecmel\source\repos\LessonForum\LessonForum.PresentationLayer\Views\Log\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f5857d4cb3807c1d80bf669011598527d9da163c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Log_Index), @"mvc.1.0.view", @"/Views/Log/Index.cshtml")]
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
#line 1 "C:\Users\ecmel\source\repos\LessonForum\LessonForum.PresentationLayer\Views\_ViewImports.cshtml"
using LessonForum.PresentationLayer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ecmel\source\repos\LessonForum\LessonForum.PresentationLayer\Views\_ViewImports.cshtml"
using LessonForum.PresentationLayer.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ecmel\source\repos\LessonForum\LessonForum.PresentationLayer\Views\_ViewImports.cshtml"
using LessonForum.EntityLayer.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f5857d4cb3807c1d80bf669011598527d9da163c", @"/Views/Log/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a225bcf6cf79c7b0dc49baccb06472923517307", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Log_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Log>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\ecmel\source\repos\LessonForum\LessonForum.PresentationLayer\Views\Log\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""card"">
    <div class=""card-header clearfix"">

        <h4 class=""card-title float-left""> Rapor Listesi</h4>
        

    </div>
    <div class=""card-body"">
        <table class=""table table-bordered"">


            <tr>
                <th width=""85%"">Rapor</th>
                <th width=""15%"">Tarih</th>
            </tr>
");
#nullable restore
#line 22 "C:\Users\ecmel\source\repos\LessonForum\LessonForum.PresentationLayer\Views\Log\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 25 "C:\Users\ecmel\source\repos\LessonForum\LessonForum.PresentationLayer\Views\Log\Index.cshtml"
                   Write(item.LogDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 26 "C:\Users\ecmel\source\repos\LessonForum\LessonForum.PresentationLayer\Views\Log\Index.cshtml"
                   Write(item.LogDate.ToString("dd-MM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 28 "C:\Users\ecmel\source\repos\LessonForum\LessonForum.PresentationLayer\Views\Log\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </table>\r\n        <br />\r\n    </div>\r\n</div>\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Log>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
