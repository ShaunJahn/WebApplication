#pragma checksum "C:\Users\mrjsh\Desktop\API Creating Learn\Web Applicaion\CakesWebApplication\CakesWebApplication\Views\Order\CheckoutCompleted.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cd8bd38069606152113da3c6e310d0e47929208e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_CheckoutCompleted), @"mvc.1.0.view", @"/Views/Order/CheckoutCompleted.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Order/CheckoutCompleted.cshtml", typeof(AspNetCore.Views_Order_CheckoutCompleted))]
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
#line 1 "C:\Users\mrjsh\Desktop\API Creating Learn\Web Applicaion\CakesWebApplication\CakesWebApplication\Views\_ViewImports.cshtml"
using CakesWebApplication.ViewModels;

#line default
#line hidden
#line 2 "C:\Users\mrjsh\Desktop\API Creating Learn\Web Applicaion\CakesWebApplication\CakesWebApplication\Views\_ViewImports.cshtml"
using CakesWebApplication.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd8bd38069606152113da3c6e310d0e47929208e", @"/Views/Order/CheckoutCompleted.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f5b0973f4b5307cff68c28f9f17ae3ba71b7b105", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_CheckoutCompleted : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 4, true);
            WriteLiteral("<h1>");
            EndContext();
            BeginContext(5, 31, false);
#line 1 "C:\Users\mrjsh\Desktop\API Creating Learn\Web Applicaion\CakesWebApplication\CakesWebApplication\Views\Order\CheckoutCompleted.cshtml"
Write(ViewBag.CheckoutCompleteMessage);

#line default
#line hidden
            EndContext();
            BeginContext(36, 8, true);
            WriteLiteral(" </h1>\r\n");
            EndContext();
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
