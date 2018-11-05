#pragma checksum "C:\Users\Familj\git\Smastad\Smastad\Smastad\Views\Coordinator\CrimeCoordinator.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "98f19c623c9a0d4b1ed5bb66fcaeb989cf6faa79"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Coordinator_CrimeCoordinator), @"mvc.1.0.view", @"/Views/Coordinator/CrimeCoordinator.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Coordinator/CrimeCoordinator.cshtml", typeof(AspNetCore.Views_Coordinator_CrimeCoordinator))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"98f19c623c9a0d4b1ed5bb66fcaeb989cf6faa79", @"/Views/Coordinator/CrimeCoordinator.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"156e577ba099e7aa4c85abd1525c8d45f2e0c5c8", @"/Views/_ViewImports.cshtml")]
    public class Views_Coordinator_CrimeCoordinator : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(7, 2860, true);
            WriteLiteral(@"
<div id=""content"">
    <h2>Detaljer för ärendet</h2>
    <p class=""info"">Du är inloggad som samordnare</p>
    <h3>Ärende: 2014-45-0201</h3>
    <section id=""leftColumn"">
        <h3>Anmälan</h3>
        <p>
            <span class=""label"">Typ av brott: </span><br />
            Nedskräpning
        </p>
        <p>
            <span class=""label"">Brottsplats: </span><br />
            Skogslunden vid Jensens gård
        </p>
        <p>
            <span class=""label"">Brottsdatum: </span><br />
            2014-04-24
        </p>
        <p>
            <span class=""label"">Anmälare: </span><br />
            Maja Färjedal
        </p>
        <p>
            <span class=""label"">Telefon: </span><br />
            432-554 55 22
        </p>
        <p>
            <span class=""label"">Observationer:</span><br />
            Jag upptäckte soporna på en promenad den 24 april
        </p>
    </section>

    <section id=""rightColumn"">
        <h3>Utredning</h3>
        <p>
   ");
            WriteLiteral(@"         <span class=""label"">Status:</span><br />
            Pågående
        </p>
        <p>
            <span class=""label"">Ansvarig avdelning: </span><br />
            Tekniska avloppshanteringen
        </p>
        <p>
            <span class=""label"">Handläggare: </span><br />
            Ada Bengtsson
        </p>
        <p>
            <span class=""label"">Provtagning: </span><br />
            Provtagning.pdf
        </p>
        <p>
            <span class=""label"">Ytterligare information: </span><br />
            Bland soporna hittades ett brev adresserat till Gösta Olsson
        </p>
        <p>
            <span class=""label"">Händelser: </span><br />
            Brev skickat till Gösta Olsson om soporna och anmälan som är gjord till polisen 2014-05-20
        </p>
        <p>
            <span class=""label"">Bilder: </span><br />
            <img src=""../images/imagetest.jpg"" alt=""klicka på bilden"" />
        </p>
    </section>

    <section id=""bottomColumn"">
   ");
            WriteLiteral(@"     <h3>Redigera ärende</h3>
        <p>
            Ange enhet:
            <select name=""department"">
                <option selected=""selected"">Välj</option>
                <option value=""unit0"">Småstads Kommun</option>
                <option value=""unit1"">Tekniska Avloppshantering</option>
                <option value=""unit2"">Klimat och Energi</option>
                <option value=""unit3"">Miljö och Hälsoskydd</option>
                <option value=""unit4"">Natur och Skogsvård</option>
                <option value=""unit5"">Renhållning och Avfall</option>
            </select>
        </p>
        <p><input class=""button"" type=""submit"" value=""Spara"" /></p>
    </section>

    <footer>
        &copy; Småstads Kommun All rights reserved.
    </footer>
</div><!-- End Content -->");
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
