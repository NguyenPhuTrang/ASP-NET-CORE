#pragma checksum "D:\Workspace\Donet nang cao\NguyenPhuTrang_Deso2\NguyenPhuTrang_Deso2\Views\Member\add.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a2d7c8df51f4db62d296a3f692d9542b4311b7fc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Member_add), @"mvc.1.0.view", @"/Views/Member/add.cshtml")]
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
#line 1 "D:\Workspace\Donet nang cao\NguyenPhuTrang_Deso2\NguyenPhuTrang_Deso2\Views\_ViewImports.cshtml"
using NguyenPhuTrang_Deso2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Workspace\Donet nang cao\NguyenPhuTrang_Deso2\NguyenPhuTrang_Deso2\Views\_ViewImports.cshtml"
using NguyenPhuTrang_Deso2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a2d7c8df51f4db62d296a3f692d9542b4311b7fc", @"/Views/Member/add.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"de99fef5b944fb688e9064cf1c0ddc1b32781d60", @"/Views/_ViewImports.cshtml")]
    public class Views_Member_add : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<NguyenPhuTrang_Deso2.Models.Member>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("Save"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Workspace\Donet nang cao\NguyenPhuTrang_Deso2\NguyenPhuTrang_Deso2\Views\Member\add.cshtml"
  
    ViewData["Title"] = "add";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>add</h1>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a2d7c8df51f4db62d296a3f692d9542b4311b7fc4178", async() => {
                WriteLiteral(@"
    <h3>Them moi thanh vien</h3>
    <div class=""form-group"">
        <label>Ma Thanh Vien</label>
        <input type=""text"" name=""MemberId"" class=""form-control"" />
    </div>
    <div class=""form-group"">
        <label>Ho & Ten</label>
        <input type=""text"" name=""Username""");
                BeginWriteAttribute("value", " value=\"", 427, "\"", 435, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\" />\r\n    </div>\r\n    <div class=\"form-group\">\r\n        <label>Mat Khau</label>\r\n        <input type=\"password\" name=\"Password\"");
                BeginWriteAttribute("value", " value=\"", 583, "\"", 591, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\" />\r\n    </div>\r\n    <div class=\"form-group\">\r\n        <label>Tuoi</label>\r\n        <input type=\"text\" name=\" Age\"");
                BeginWriteAttribute("value", " value=\"", 727, "\"", 735, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\" />\r\n    </div>\r\n    <div class=\"form-group\">\r\n        <label>Email</label>\r\n        <input type=\"text\" name=\"Email\"");
                BeginWriteAttribute("value", " value=\"", 873, "\"", 881, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\" />\r\n    </div>\r\n    <button type=\"submit\" class=\"btn btn-success\">Them moi</button>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<NguyenPhuTrang_Deso2.Models.Member>> Html { get; private set; }
    }
}
#pragma warning restore 1591