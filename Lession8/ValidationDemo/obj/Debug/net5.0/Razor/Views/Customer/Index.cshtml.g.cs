#pragma checksum "D:\Workspace\Donet nang cao\Lession8\ValidationDemo\Views\Customer\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9d69edcb6452faa1297a08dd42f2d3251b744b38"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_Index), @"mvc.1.0.view", @"/Views/Customer/Index.cshtml")]
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
#line 1 "D:\Workspace\Donet nang cao\Lession8\ValidationDemo\Views\_ViewImports.cshtml"
using ValidationDemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Workspace\Donet nang cao\Lession8\ValidationDemo\Views\_ViewImports.cshtml"
using ValidationDemo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d69edcb6452faa1297a08dd42f2d3251b744b38", @"/Views/Customer/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b500944a255bcd1148806f225ba21ceb0abcc4a0", @"/Views/_ViewImports.cshtml")]
    public class Views_Customer_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ValidationDemo.Models.Customer>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Workspace\Donet nang cao\Lession8\ValidationDemo\Views\Customer\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Index</h1>
<h7>Danh sách khách hàng</h7>
<a href=""/Customer/Create"" class=""btn btn-primary my-3"">Thêm mới</a>
<table class=""table"" >
    <thead>
        <tr>
            <th>Mã khách hàng </th>
            <th>Họ & Tên </th>
            <th>Emai</th>
            <th>Điện thoại</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 19 "D:\Workspace\Donet nang cao\Lession8\ValidationDemo\Views\Customer\Index.cshtml"
         foreach(var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 22 "D:\Workspace\Donet nang cao\Lession8\ValidationDemo\Views\Customer\Index.cshtml"
                   Write(item.CustomerId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 23 "D:\Workspace\Donet nang cao\Lession8\ValidationDemo\Views\Customer\Index.cshtml"
                   Write(item.CustomerName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 24 "D:\Workspace\Donet nang cao\Lession8\ValidationDemo\Views\Customer\Index.cshtml"
                   Write(item.Emai);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 25 "D:\Workspace\Donet nang cao\Lession8\ValidationDemo\Views\Customer\Index.cshtml"
                   Write(item.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 27 "D:\Workspace\Donet nang cao\Lession8\ValidationDemo\Views\Customer\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ValidationDemo.Models.Customer>> Html { get; private set; }
    }
}
#pragma warning restore 1591