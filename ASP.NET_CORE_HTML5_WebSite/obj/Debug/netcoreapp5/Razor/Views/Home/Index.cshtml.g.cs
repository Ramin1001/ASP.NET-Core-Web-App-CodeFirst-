#pragma checksum "C:\Users\RAMO1378\Desktop\GitPush ASP.NET_CORE_HTML5_WebSite\ASP.NET_CORE_HTML5_WebSite\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c34a3540c7dddbf927d5d7f40bb85aa7e6f1eb68"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c34a3540c7dddbf927d5d7f40bb85aa7e6f1eb68", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1cabb1a0ff0df00df53d77dfad24e0f28fb85851", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TextField>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 5 "C:\Users\RAMO1378\Desktop\GitPush ASP.NET_CORE_HTML5_WebSite\ASP.NET_CORE_HTML5_WebSite\Views\Home\Index.cshtml"
   
    ViewBag.Title = Model.MetaTitle;
    ViewBag.Description = Model.MetaDescription;
    ViewBag.Keyword = Model.MetaKeywords;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n<div>\r\n    ");
#nullable restore
#line 15 "C:\Users\RAMO1378\Desktop\GitPush ASP.NET_CORE_HTML5_WebSite\ASP.NET_CORE_HTML5_WebSite\Views\Home\Index.cshtml"
Write(Html.Raw(Model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("  ");
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TextField> Html { get; private set; }
    }
}
#pragma warning restore 1591
