#pragma checksum "C:\Users\Familj\git\Smastad\Smastad\Smastad\Views\Citizen\Validate.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c3607db5651b307b75aa5b4bcd2b61f08718c45c"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3607db5651b307b75aa5b4bcd2b61f08718c45c", @"/Views/Citizen/Validate.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"156e577ba099e7aa4c85abd1525c8d45f2e0c5c8", @"/Views/_ViewImports.cshtml")]
    public class Views_Citizen_Validate : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(7, 919, true);
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
            BeginWriteAttribute("onclick", " onclick=\"", 926, "\"", 980, 3);
            WriteAttributeValue("", 936, "location.href=\'", 936, 15, true);
#line 18 "C:\Users\Familj\git\Smastad\Smastad\Smastad\Views\Citizen\Validate.cshtml"
WriteAttributeValue("", 951, Url.Action("Index", "Home"), 951, 28, false);

#line default
#line hidden
            WriteAttributeValue("", 979, "\'", 979, 1, true);
            EndWriteAttribute();
            BeginContext(981, 55, true);
            WriteLiteral(" />\r\n            <input class=\"button\" value=\"Bekräfta\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1036, "\"", 1094, 3);
            WriteAttributeValue("", 1046, "location.href=\'", 1046, 15, true);
#line 19 "C:\Users\Familj\git\Smastad\Smastad\Smastad\Views\Citizen\Validate.cshtml"
WriteAttributeValue("", 1061, Url.Action("thanks", "Citizen"), 1061, 32, false);

#line default
#line hidden
            WriteAttributeValue("", 1093, "\'", 1093, 1, true);
            EndWriteAttribute();
            BeginContext(1095, 162, true);
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
