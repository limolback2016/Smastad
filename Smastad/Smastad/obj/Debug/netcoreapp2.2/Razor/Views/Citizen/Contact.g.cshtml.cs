#pragma checksum "C:\Users\Familj\git\Smastad\Smastad\Smastad\Views\Citizen\Contact.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c66b6393408aecbb5f330a4bcebee1da7dacabcc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Citizen_Contact), @"mvc.1.0.view", @"/Views/Citizen/Contact.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Citizen/Contact.cshtml", typeof(AspNetCore.Views_Citizen_Contact))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c66b6393408aecbb5f330a4bcebee1da7dacabcc", @"/Views/Citizen/Contact.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"45aed50c2668a6a31a60890e1ef610186006a5c9", @"/Views/_ViewImports.cshtml")]
    public class Views_Citizen_Contact : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Familj\git\Smastad\Smastad\Smastad\Views\Citizen\Contact.cshtml"
  
    Layout = "~/Views/Shared/_CitizenLayout.cshtml";

#line default
#line hidden
            BeginContext(61, 518, true);
            WriteLiteral(@"
<div id=""content"">
    <section id=""mainColumn"">
        <h2>Kontaktuppgifter</h2>
        <p><span class=""label"">Besöksadress:</span> Storgatan 42</p>
        <p><span class=""label"">Postadress:</span> Box 10, 909 00 Småstad</p>
        <p><span class=""label"">Mail:</span> miljoboven@smastad.nu</p>
        <p><span class=""label"">Telefon:</span> 432-500 10 00</p>
    </section><!-- End Left -->

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
