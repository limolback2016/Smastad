#pragma checksum "C:\Users\Familj\git\Smastad\Smastad\Smastad\Views\Citizen\Thanks.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8f45310e6883cb5c2d891a8455d45d2e087041a3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Citizen_Thanks), @"mvc.1.0.view", @"/Views/Citizen/Thanks.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Citizen/Thanks.cshtml", typeof(AspNetCore.Views_Citizen_Thanks))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f45310e6883cb5c2d891a8455d45d2e087041a3", @"/Views/Citizen/Thanks.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"45aed50c2668a6a31a60890e1ef610186006a5c9", @"/Views/_ViewImports.cshtml")]
    public class Views_Citizen_Thanks : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(7, 462, true);
            WriteLiteral(@"
<div id=""content"">
    <section id=""mainColumn"">
        <h2>Tack för din Anmälan</h2>
        <p class=""info"">I Småstad är inga brott för små för att anmälas</p>

        <p>
            Anmälan har nu skickats in till kommunen och kommer att utredas. <br />
            Vill du komplettera din anmälan kontakta oss via mail eller telefon. <br />
            Ange då nummer: 2014-45-0201
        </p>
        <p><input class=""button"" value=""Avsluta""");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 469, "\"", 523, 3);
            WriteAttributeValue("", 479, "location.href=\'", 479, 15, true);
#line 14 "C:\Users\Familj\git\Smastad\Smastad\Smastad\Views\Citizen\Thanks.cshtml"
WriteAttributeValue("", 494, Url.Action("Index", "Home"), 494, 28, false);

#line default
#line hidden
            WriteAttributeValue("", 522, "\'", 522, 1, true);
            EndWriteAttribute();
            BeginContext(524, 152, true);
            WriteLiteral(" /></p>\r\n    </section><!-- End Left -->\r\n\r\n    <footer>\r\n        &copy; Småstads Kommun All rights reserved.\r\n    </footer>\r\n</div><!-- End Content -->");
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
