#pragma checksum "D:\Workspace\Donet nang cao\Lession06\DataSharing\Views\User\Profile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3e3a19ee0a2dd44a1341a1e91f6ea0637bb3d39e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Profile), @"mvc.1.0.view", @"/Views/User/Profile.cshtml")]
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
#line 1 "D:\Workspace\Donet nang cao\Lession06\DataSharing\Views\_ViewImports.cshtml"
using DataSharing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Workspace\Donet nang cao\Lession06\DataSharing\Views\_ViewImports.cshtml"
using DataSharing.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\Workspace\Donet nang cao\Lession06\DataSharing\Views\User\Profile.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e3a19ee0a2dd44a1341a1e91f6ea0637bb3d39e", @"/Views/User/Profile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"05995d7e58030e34a49f9a6612ef71a9196db645", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Profile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Workspace\Donet nang cao\Lession06\DataSharing\Views\User\Profile.cshtml"
  
    ViewData["Title"] = "Profile";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Profile</h1>\r\n<p>Ten tai khoan : ");
#nullable restore
#line 7 "D:\Workspace\Donet nang cao\Lession06\DataSharing\Views\User\Profile.cshtml"
              Write(Context.Session.GetString("UserName"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>Ho & ten : ");
#nullable restore
#line 8 "D:\Workspace\Donet nang cao\Lession06\DataSharing\Views\User\Profile.cshtml"
         Write(Context.Session.GetString("FullName"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>Email : ");
#nullable restore
#line 9 "D:\Workspace\Donet nang cao\Lession06\DataSharing\Views\User\Profile.cshtml"
      Write(Context.Session.GetString("Email"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n\r\n\r\n");
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
