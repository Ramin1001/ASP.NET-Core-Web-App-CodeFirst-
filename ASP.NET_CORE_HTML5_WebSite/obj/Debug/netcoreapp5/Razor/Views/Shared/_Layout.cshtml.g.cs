#pragma checksum "C:\Users\RAMO1378\Desktop\GitPush ASP.NET_CORE_HTML5_WebSite\ASP.NET_CORE_HTML5_WebSite\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b99d6382bf6591dd10118543d479192f333da618"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
#line 2 "C:\Users\RAMO1378\Desktop\GitPush ASP.NET_CORE_HTML5_WebSite\ASP.NET_CORE_HTML5_WebSite\Views\_ViewImports.cshtml"
using ASP.NET_CORE_HTML5_WebSite.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\RAMO1378\Desktop\GitPush ASP.NET_CORE_HTML5_WebSite\ASP.NET_CORE_HTML5_WebSite\Views\_ViewImports.cshtml"
using ASP.NET_CORE_HTML5_WebSite.Service;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\RAMO1378\Desktop\GitPush ASP.NET_CORE_HTML5_WebSite\ASP.NET_CORE_HTML5_WebSite\Views\_ViewImports.cshtml"
using ASP.NET_CORE_HTML5_WebSite.Domain.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\RAMO1378\Desktop\GitPush ASP.NET_CORE_HTML5_WebSite\ASP.NET_CORE_HTML5_WebSite\Views\_ViewImports.cshtml"
using ASP.NET_CORE_HTML5_WebSite.Model.ViewComponents;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b99d6382bf6591dd10118543d479192f333da618", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57b1e7cec94e112deb472c828a582481c920c966", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE HTML>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b99d6382bf6591dd10118543d479192f333da6183894", async() => {
                WriteLiteral("\r\n    ");
#nullable restore
#line 5 "C:\Users\RAMO1378\Desktop\GitPush ASP.NET_CORE_HTML5_WebSite\ASP.NET_CORE_HTML5_WebSite\Views\Shared\_Layout.cshtml"
Write(await Html.PartialAsync("MetatagsPartial"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    ");
#nullable restore
#line 6 "C:\Users\RAMO1378\Desktop\GitPush ASP.NET_CORE_HTML5_WebSite\ASP.NET_CORE_HTML5_WebSite\Views\Shared\_Layout.cshtml"
Write(await Html.PartialAsync("CssPartial"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    \r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b99d6382bf6591dd10118543d479192f333da6185445", async() => {
                WriteLiteral("\r\n    <div id=\"page-wrapper\">\r\n\r\n        <!-- Header -->\r\n        ");
#nullable restore
#line 13 "C:\Users\RAMO1378\Desktop\GitPush ASP.NET_CORE_HTML5_WebSite\ASP.NET_CORE_HTML5_WebSite\Views\Shared\_Layout.cshtml"
   Write(await Html.PartialAsync("HeaderPartial"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n\r\n\r\n        <!-- Main -->\r\n        <div id=\"main\">\r\n            <div class=\"container\">\r\n                <div class=\"row main-row\">\r\n\r\n                    <div class=\"col-8 col-12-medium\">\r\n\r\n                        ");
#nullable restore
#line 24 "C:\Users\RAMO1378\Desktop\GitPush ASP.NET_CORE_HTML5_WebSite\ASP.NET_CORE_HTML5_WebSite\Views\Shared\_Layout.cshtml"
                   Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                    </div>\r\n\r\n                    ");
#nullable restore
#line 28 "C:\Users\RAMO1378\Desktop\GitPush ASP.NET_CORE_HTML5_WebSite\ASP.NET_CORE_HTML5_WebSite\Views\Shared\_Layout.cshtml"
               Write(await Html.PartialAsync("SidebarPartial"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n\r\n                \r\n            </div>\r\n        </div>\r\n\r\n        <!-- Footer -->\r\n\r\n        ");
#nullable restore
#line 37 "C:\Users\RAMO1378\Desktop\GitPush ASP.NET_CORE_HTML5_WebSite\ASP.NET_CORE_HTML5_WebSite\Views\Shared\_Layout.cshtml"
   Write(await Html.PartialAsync("FooterPartial"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </div>\r\n\r\n    <!-- Scripts -->\r\n    ");
#nullable restore
#line 41 "C:\Users\RAMO1378\Desktop\GitPush ASP.NET_CORE_HTML5_WebSite\ASP.NET_CORE_HTML5_WebSite\Views\Shared\_Layout.cshtml"
Write(await Html.PartialAsync("ScriptsPartial"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n   \r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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
