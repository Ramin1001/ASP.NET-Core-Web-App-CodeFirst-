#pragma checksum "C:\Users\RAMO1378\Desktop\GitPush ASP.NET_CORE_HTML5_WebSite\ASP.NET_CORE_HTML5_WebSite\Views\Shared\SidebarPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c8c359492fad9d8bd408105f01240bfd832b43ce"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_SidebarPartial), @"mvc.1.0.view", @"/Views/Shared/SidebarPartial.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c8c359492fad9d8bd408105f01240bfd832b43ce", @"/Views/Shared/SidebarPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57b1e7cec94e112deb472c828a582481c920c966", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_SidebarPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.CacheTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_CacheTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"col-4 col-12-medium\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("cache", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c8c359492fad9d8bd408105f01240bfd832b43ce3789", async() => {
                WriteLiteral("\r\n        ");
#nullable restore
#line 3 "C:\Users\RAMO1378\Desktop\GitPush ASP.NET_CORE_HTML5_WebSite\ASP.NET_CORE_HTML5_WebSite\Views\Shared\SidebarPartial.cshtml"
    Write(await Component.InvokeAsync<SideBarViewComponent>());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_CacheTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.CacheTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_CacheTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>");
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
