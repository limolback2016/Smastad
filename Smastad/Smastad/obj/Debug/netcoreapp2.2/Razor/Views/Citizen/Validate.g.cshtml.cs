#pragma checksum "C:\Users\Familj\git\Smastad\Smastad\Smastad\Views\Citizen\Validate.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2dfcdda7a0f928abcf2e6919fd99499ed9644744"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Citizen_Validate), @"mvc.1.0.view", @"/Views/Citizen/Validate.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Citizen/Validate.cshtml", typeof(AspNetCore.Views_Citizen_Validate))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2dfcdda7a0f928abcf2e6919fd99499ed9644744", @"/Views/Citizen/Validate.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"45aed50c2668a6a31a60890e1ef610186006a5c9", @"/Views/_ViewImports.cshtml")]
    public class Views_Citizen_Validate : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Familj\git\Smastad\Smastad\Smastad\Views\Citizen\Validate.cshtml"
  
    Layout = "~/Views/Shared/_CitizenLayout.cshtml";

#line default
#line hidden
            BeginContext(61, 919, true);
            WriteLiteral(@"
<div id=""content"">
    <section id=""mainColumn"">
        <h2>Din anmälan av miljöbrott</h2>
        <p class=""label"">
            Vänligen läs igenom din anmälan och se att allt är okej.<br />
            Om något är fel, gå tillbaka och ändra. Annars välj Bekräfta.
        </p>
        <p><span class=""label"">Var har brottet skett någonstans?</span><br />Skogslunden vid Jensens gård</p>
        <p><span class=""label"">Vilken typ av brott?</span><br />Sopor i massor ligger där</p>
        <p><span class=""label"">När skedde brottet?</span><br />Vet inte</p>
        <p><span class=""label"">Ditt namn (för- och efternamn):</span><br />Maja Färjedal</p>
        <p><span class=""label"">Din telefon:</span><br />432-554 55 22</p>
        <p><span class=""label"">Mer information:</span><br />Jag upptäckte soporna på en promenad den 24 april</p>
        <p>
            <input class=""button"" value=""Tillbaka""");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 980, "\"", 1034, 3);
            WriteAttributeValue("", 990, "location.href=\'", 990, 15, true);
#line 19 "C:\Users\Familj\git\Smastad\Smastad\Smastad\Views\Citizen\Validate.cshtml"
WriteAttributeValue("", 1005, Url.Action("Index", "Home"), 1005, 28, false);

#line default
#line hidden
            WriteAttributeValue("", 1033, "\'", 1033, 1, true);
            EndWriteAttribute();
            BeginContext(1035, 55, true);
            WriteLiteral(" />\r\n            <input class=\"button\" value=\"Bekräfta\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1090, "\"", 1148, 3);
            WriteAttributeValue("", 1100, "location.href=\'", 1100, 15, true);
#line 20 "C:\Users\Familj\git\Smastad\Smastad\Smastad\Views\Citizen\Validate.cshtml"
WriteAttributeValue("", 1115, Url.Action("thanks", "Citizen"), 1115, 32, false);

#line default
#line hidden
            WriteAttributeValue("", 1147, "\'", 1147, 1, true);
            EndWriteAttribute();
            BeginContext(1149, 162, true);
            WriteLiteral(" />\r\n        </p>\r\n    </section><!-- End Left -->\r\n\r\n    <footer>\r\n        &copy; Småstads Kommun All rights reserved.\r\n    </footer>\r\n</div><!-- End Content -->");
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