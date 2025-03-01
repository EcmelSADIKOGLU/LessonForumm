#pragma checksum "C:\Users\ecmel\source\repos\LessonForum\LessonForum.PresentationLayer\Views\User\BannedUserList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9dd7940915e63442f83d3803473a47f3a67425fa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_BannedUserList), @"mvc.1.0.view", @"/Views/User/BannedUserList.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9dd7940915e63442f83d3803473a47f3a67425fa", @"/Views/User/BannedUserList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a225bcf6cf79c7b0dc49baccb06472923517307", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_User_BannedUserList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<AppUser>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\ecmel\source\repos\LessonForum\LessonForum.PresentationLayer\Views\User\BannedUserList.cshtml"
  
    ViewData["Title"] = "BannedUserList";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""card"">
    <div class=""container"">
        <br />
        <div class=""card-header clearfix"">

            <h4 class=""card-title float-left""> Üye Listesi</h4>
            <a href=""/User/Index/"" class=""btn btn-outline-success card-title float-right mr-3 p-2""> Kullancılar </a>


        </div>
        <div class=""card-body"">
            <table class=""table table-bordered"">


                <tr>
                    <th width=""55%"">İsim</th>
                    <th width=""20%"">Durum</th>
                    <th width=""25%"">Ban Kaldır</th>
                </tr>
");
#nullable restore
#line 26 "C:\Users\ecmel\source\repos\LessonForum\LessonForum.PresentationLayer\Views\User\BannedUserList.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 29 "C:\Users\ecmel\source\repos\LessonForum\LessonForum.PresentationLayer\Views\User\BannedUserList.cshtml"
                       Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 29 "C:\Users\ecmel\source\repos\LessonForum\LessonForum.PresentationLayer\Views\User\BannedUserList.cshtml"
                                  Write(item.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 30 "C:\Users\ecmel\source\repos\LessonForum\LessonForum.PresentationLayer\Views\User\BannedUserList.cshtml"
                         if (item.Status)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td>Açık</td>\r\n");
#nullable restore
#line 33 "C:\Users\ecmel\source\repos\LessonForum\LessonForum.PresentationLayer\Views\User\BannedUserList.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td>Kapalı</td>\r\n");
#nullable restore
#line 37 "C:\Users\ecmel\source\repos\LessonForum\LessonForum.PresentationLayer\Views\User\BannedUserList.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                        <td><a");
            BeginWriteAttribute("href", " href=\"", 1168, "\"", 1199, 2);
            WriteAttributeValue("", 1175, "/User/UnbanUser/", 1175, 16, true);
#nullable restore
#line 40 "C:\Users\ecmel\source\repos\LessonForum\LessonForum.PresentationLayer\Views\User\BannedUserList.cshtml"
WriteAttributeValue("", 1191, item.Id, 1191, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-success\">Ban Kaldır</a></td>\r\n                    </tr>\r\n");
#nullable restore
#line 42 "C:\Users\ecmel\source\repos\LessonForum\LessonForum.PresentationLayer\Views\User\BannedUserList.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </table>\r\n            <br />\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<AppUser>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
