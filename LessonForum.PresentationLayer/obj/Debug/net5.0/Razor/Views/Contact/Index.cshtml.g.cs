#pragma checksum "C:\Users\ecmel\source\repos\LessonForum\LessonForum.PresentationLayer\Views\Contact\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1944dc96d8fb8e1a8990f234cc714f8d04bee393"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contact_Index), @"mvc.1.0.view", @"/Views/Contact/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1944dc96d8fb8e1a8990f234cc714f8d04bee393", @"/Views/Contact/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a225bcf6cf79c7b0dc49baccb06472923517307", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Contact_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Contact>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\ecmel\source\repos\LessonForum\LessonForum.PresentationLayer\Views\Contact\Index.cshtml"
  
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
            <h4 class=""card-title float-left""> Mesajlar </h4>
        </div>

        <div class=""card-body"">
            <table class=""table table-bordered"">
                <tr>
                    <th width=""20%"">Gönderen</th>
                    <th width=""50%"">Konu</th>
                    <th width=""20%"">Tarih</th>
                    <th width=""10%"">Sil</th>
                    <th width=""15%"">Detaylar</th>
                </tr>
");
#nullable restore
#line 23 "C:\Users\ecmel\source\repos\LessonForum\LessonForum.PresentationLayer\Views\Contact\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 26 "C:\Users\ecmel\source\repos\LessonForum\LessonForum.PresentationLayer\Views\Contact\Index.cshtml"
                       Write(item.SenderMail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 27 "C:\Users\ecmel\source\repos\LessonForum\LessonForum.PresentationLayer\Views\Contact\Index.cshtml"
                       Write(item.Subject);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 28 "C:\Users\ecmel\source\repos\LessonForum\LessonForum.PresentationLayer\Views\Contact\Index.cshtml"
                       Write(item.Date.ToString("dd-MM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                        <td><a");
            BeginWriteAttribute("href", " href=\"", 963, "\"", 1008, 2);
            WriteAttributeValue("", 970, "/Contact/DeleteContact/", 970, 23, true);
#nullable restore
#line 30 "C:\Users\ecmel\source\repos\LessonForum\LessonForum.PresentationLayer\Views\Contact\Index.cshtml"
WriteAttributeValue("", 993, item.ContactID, 993, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-danger\">Sil</a></td>\r\n                        <td><a");
            BeginWriteAttribute("href", " href=\"", 1085, "\"", 1131, 2);
            WriteAttributeValue("", 1092, "/Contact/ContactDetails/", 1092, 24, true);
#nullable restore
#line 31 "C:\Users\ecmel\source\repos\LessonForum\LessonForum.PresentationLayer\Views\Contact\Index.cshtml"
WriteAttributeValue("", 1116, item.ContactID, 1116, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-success\">Detaylar</a></td>\r\n                    </tr>\r\n");
#nullable restore
#line 33 "C:\Users\ecmel\source\repos\LessonForum\LessonForum.PresentationLayer\Views\Contact\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Contact>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
