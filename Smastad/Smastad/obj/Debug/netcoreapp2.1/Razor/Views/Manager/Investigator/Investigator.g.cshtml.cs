#pragma checksum "C:\Users\Familj\git\Smastad\Smastad\Smastad\Views\Manager\Investigator\Investigator.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "775e35fa732d8c3d189b211f685bacd5afc81ecd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Manager_Investigator_Investigator), @"mvc.1.0.view", @"/Views/Manager/Investigator/Investigator.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Manager/Investigator/Investigator.cshtml", typeof(AspNetCore.Views_Manager_Investigator_Investigator))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"775e35fa732d8c3d189b211f685bacd5afc81ecd", @"/Views/Manager/Investigator/Investigator.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"156e577ba099e7aa4c85abd1525c8d45f2e0c5c8", @"/Views/_ViewImports.cshtml")]
    public class Views_Manager_Investigator_Investigator : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(7, 3658, true);
            WriteLiteral(@"
<div id=""content"">
    <h2>Ärenden</h2>
    <p class=""info"">Du är inloggad som handläggare</p>

    <table id=""managerForm"">
        <tr>
            <td class=""label"">Välj status:</td>
            <td>&nbsp;</td>
            <td class=""label"">Ärendenummer:</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <select name=""status"">
                    <option selected=""selected"">Välj alla</option>
                    <option value=""stat0"">Inrapporterad</option>
                    <option value=""stat1"">Ingen åtgärd</option>
                    <option value=""stat2"">Påbörjad</option>
                    <option value=""stat3"">Klar</option>
                </select>
            </td>
            <td><input class=""button"" type=""submit"" value=""Hämta lista"" /></td>
            <td><input name=""casenumber"" /></td>
            <td><input class=""button"" type=""submit"" value=""Sök"" /></td>
        </tr>
    </table>

    <!--Nedan ser man en lista på är");
            WriteLiteral(@"enden-->
    <table>
        <tr>
            <th>Ärende anmält</th>
            <th>Ärendenummer</th>
            <th>Miljöbrott</th>
            <th>Status</th>
            <th>Avdelning</th>
            <th>Handläggare</th>
        </tr>
        <tr>
            <td>2014-05-01</td>
            <td><a asp-controller=""Investigator"" asp-action=""crimeInvestigator"">2014-45-0201</a></td>
            <td>Oljeutsläpp</td>
            <td>Ej startad</td>
            <td>Tekniska avloppshanteringen</td>
            <td>Ingen utredare satt</td>
        </tr>
        <tr>
            <td>2014-05-01</td>
            <td><a asp-controller=""Investigator"" asp-action=""crimeInvestigator"">2014-45-0202</a></td>
            <td>Oljeutsläpp</td>
            <td>Pågående</td>
            <td>Tekniska avloppshanteringen</td>
            <td>Ada Bengtsson</td>
        </tr>
        <tr>
            <td>2014-05-01</td>
            <td><a asp-controller=""Investigator"" asp-action=""crimeInvestigator"">2014-4");
            WriteLiteral(@"5-0203</a></td>
            <td>Oljeutsläpp</td>
            <td>Ej startad</td>
            <td>Tekniska avloppshanteringen</td>
            <td>Ingen utredare satt</td>
        </tr>
        <tr>
            <td>2014-05-01</td>
            <td><a asp-controller=""Investigator"" asp-action=""crimeInvestigator"">2014-45-0204</a></td>
            <td>Oljeutsläpp</td>
            <td>Ej startad</td>
            <td>Tekniska avloppshanteringen</td>
            <td>Ingen utredare satt</td>
        </tr>
        <tr>
            <td>2014-05-01</td>
            <td><a asp-controller=""Investigator"" asp-action=""crimeInvestigator"">2014-45-0205</a></td>
            <td>Oljeutsläpp</td>
            <td>Pågående</td>
            <td>Tekniska avloppshanteringen</td>
            <td>Bengt Cederström</td>
        </tr>
        <tr>
            <td>2014-05-01</td>
            <td><a asp-controller=""Investigator"" asp-action=""crimeInvestigator"">2014-45-0206</a></td>
            <td>Oljeutsläpp</td>
      ");
            WriteLiteral(@"      <td>Ej startad</td>
            <td>Tekniska avloppshanteringen</td>
            <td>Ingen utredare satt</td>
        </tr>
        <tr>
            <td>2014-05-01</td>
            <td><a asp-controller=""Investigator"" asp-action=""crimeInvestigator"">2014-45-0206</a></td>
            <td>Oljeutsläpp</td>
            <td>Ej startad</td>
            <td>Tekniska avloppshanteringen</td>
            <td>Ingen utredare satt</td>
        </tr>
    </table>


    <footer>
        &copy; Småstads Kommun All rights reserved.
    </footer>
</div><!-- End Content -->
");
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
