#pragma checksum "C:\Users\Familj\git\Smastad\Smastad\Smastad\Views\Home\ReadCookies.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c49e15af52a03455772a44f3ec550fce75708f80"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ReadCookies), @"mvc.1.0.view", @"/Views/Home/ReadCookies.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/ReadCookies.cshtml", typeof(AspNetCore.Views_Home_ReadCookies))]
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
#line 2 "C:\Users\Familj\git\Smastad\Smastad\Smastad\Views\_ViewImports.cshtml"
using Smastad.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c49e15af52a03455772a44f3ec550fce75708f80", @"/Views/Home/ReadCookies.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"45aed50c2668a6a31a60890e1ef610186006a5c9", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ReadCookies : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 4, true);
            WriteLiteral("<div");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 4, "\"", 106, 8);
            WriteAttributeValue("", 12, "font-family:\'", 12, 13, true);
#line 1 "C:\Users\Familj\git\Smastad\Smastad\Smastad\Views\Home\ReadCookies.cshtml"
WriteAttributeValue("", 25, ViewBag.FontName, 25, 17, false);

#line default
#line hidden
            WriteAttributeValue("", 42, "\';", 42, 2, true);
            WriteAttributeValue("\r\n     ", 44, "font-size:", 51, 17, true);
#line 2 "C:\Users\Familj\git\Smastad\Smastad\Smastad\Views\Home\ReadCookies.cshtml"
WriteAttributeValue("", 61, ViewBag.FontSize, 61, 17, false);

#line default
#line hidden
            WriteAttributeValue("", 78, ";", 78, 1, true);
            WriteAttributeValue("\r\n     ", 79, "color:", 86, 13, true);
#line 3 "C:\Users\Familj\git\Smastad\Smastad\Smastad\Views\Home\ReadCookies.cshtml"
WriteAttributeValue("", 92, ViewBag.Color, 92, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(107, 39, true);
            WriteLiteral(">\r\n\r\n    <p>Hello World!</p>\r\n\r\n    <p>");
            EndContext();
            BeginContext(147, 16, false);
#line 7 "C:\Users\Familj\git\Smastad\Smastad\Smastad\Views\Home\ReadCookies.cshtml"
  Write(ViewBag.FontName);

#line default
#line hidden
            EndContext();
            BeginContext(163, 14, true);
            WriteLiteral("</p>\r\n</div>\r\n");
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