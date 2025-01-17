#pragma checksum "C:\Users\ecmel\source\repos\LessonForum\LessonForum.PresentationLayer\Views\SubCategory\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8d9e307bdfbbd73cc38aa44e1902f71f1c8efc1b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SubCategory_Index), @"mvc.1.0.view", @"/Views/SubCategory/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d9e307bdfbbd73cc38aa44e1902f71f1c8efc1b", @"/Views/SubCategory/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a225bcf6cf79c7b0dc49baccb06472923517307", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_SubCategory_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<SubCategory>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\ecmel\source\repos\LessonForum\LessonForum.PresentationLayer\Views\SubCategory\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""card"">
    <div class=""container"">
        <br />
        <div class=""card-header clearfix"">

            <h4 class=""card-title float-left""> Alt Kategori Listesi</h4>
            <a href=""/SubCategory/AddSubCategory"" class=""card-title float-right mr-3 p-2""><i class=""now-ui-icons ui-1_simple-add "" style=""width: 20px; height:20px""></i></a>

        </div>
        <div class=""card-body"">
            <table class=""table table-bordered"">

                <tr>
                    <th width=""25%"">Alt Kategori</th>
                    <th width=""25%"">Kategori</th>
                    <th width=""20%"">Durum</th>
                    <th width=""15%"">Sil</th>
                    <th width=""15%"">Düzenle</th>
                </tr>
");
#nullable restore
#line 26 "C:\Users\ecmel\source\repos\LessonForum\LessonForum.PresentationLayer\Views\SubCategory\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 29 "C:\Users\ecmel\source\repos\LessonForum\LessonForum.PresentationLayer\Views\SubCategory\Index.cshtml"
                       Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 30 "C:\Users\ecmel\source\repos\LessonForum\LessonForum.PresentationLayer\Views\SubCategory\Index.cshtml"
                       Write(item.Category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 31 "C:\Users\ecmel\source\repos\LessonForum\LessonForum.PresentationLayer\Views\SubCategory\Index.cshtml"
                         if (item.Status)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td>Açık</td>\r\n");
#nullable restore
#line 34 "C:\Users\ecmel\source\repos\LessonForum\LessonForum.PresentationLayer\Views\SubCategory\Index.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td>Kapalı</td>\r\n");
#nullable restore
#line 38 "C:\Users\ecmel\source\repos\LessonForum\LessonForum.PresentationLayer\Views\SubCategory\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <td><a");
            BeginWriteAttribute("href", " href=\"", 1364, "\"", 1421, 2);
            WriteAttributeValue("", 1371, "/SubCategory/DeleteSubCategory/", 1371, 31, true);
#nullable restore
#line 40 "C:\Users\ecmel\source\repos\LessonForum\LessonForum.PresentationLayer\Views\SubCategory\Index.cshtml"
WriteAttributeValue("", 1402, item.SubCategoryID, 1402, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-danger\">Sil</a></td>\r\n                        <td><a");
            BeginWriteAttribute("href", " href=\"", 1498, "\"", 1553, 2);
            WriteAttributeValue("", 1505, "/SubCategory/EditSubCategory/", 1505, 29, true);
#nullable restore
#line 41 "C:\Users\ecmel\source\repos\LessonForum\LessonForum.PresentationLayer\Views\SubCategory\Index.cshtml"
WriteAttributeValue("", 1534, item.SubCategoryID, 1534, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-success\">Düzenle</a></td>\r\n                    </tr>\r\n");
#nullable restore
#line 43 "C:\Users\ecmel\source\repos\LessonForum\LessonForum.PresentationLayer\Views\SubCategory\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </table>\r\n            <br />\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<SubCategory>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
