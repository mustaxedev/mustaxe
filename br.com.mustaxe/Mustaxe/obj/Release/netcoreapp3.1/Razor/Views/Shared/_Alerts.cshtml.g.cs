#pragma checksum "/Users/marcoswerneck/Projetos/Aspnet Core/Mustaxe/br.com.mustaxe/Mustaxe/Views/Shared/_Alerts.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "52ccda19d501a24948505ecf1040c03a4b16e02e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Alerts), @"mvc.1.0.view", @"/Views/Shared/_Alerts.cshtml")]
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
#line 1 "/Users/marcoswerneck/Projetos/Aspnet Core/Mustaxe/br.com.mustaxe/Mustaxe/Views/_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/marcoswerneck/Projetos/Aspnet Core/Mustaxe/br.com.mustaxe/Mustaxe/Views/_ViewImports.cshtml"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/marcoswerneck/Projetos/Aspnet Core/Mustaxe/br.com.mustaxe/Mustaxe/Views/_ViewImports.cshtml"
using Mustaxe;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/marcoswerneck/Projetos/Aspnet Core/Mustaxe/br.com.mustaxe/Mustaxe/Views/_ViewImports.cshtml"
using Mustaxe.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/marcoswerneck/Projetos/Aspnet Core/Mustaxe/br.com.mustaxe/Mustaxe/Views/_ViewImports.cshtml"
using Mustaxe.Infra;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/marcoswerneck/Projetos/Aspnet Core/Mustaxe/br.com.mustaxe/Mustaxe/Views/_ViewImports.cshtml"
using Mustaxe.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52ccda19d501a24948505ecf1040c03a4b16e02e", @"/Views/Shared/_Alerts.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5576c1e3bff100a2b51c0601b84696504a22a7e3", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Alerts : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/marcoswerneck/Projetos/Aspnet Core/Mustaxe/br.com.mustaxe/Mustaxe/Views/Shared/_Alerts.cshtml"
  
    if (TempData.ContainsKey(Alert.TempDataKey))
    {
        if (TempData[Alert.TempDataKey] != null)
        {
            var alert = TempData[Alert.TempDataKey] as Alert;

            var dismissableClass = alert.Dismissable ? "alert-dismissable" : null;

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div");
            BeginWriteAttribute("class", " class=\"", 279, "\"", 339, 5);
            WriteAttributeValue("", 287, "mt-2", 287, 4, true);
            WriteAttributeValue(" ", 291, "alert", 292, 6, true);
            WriteAttributeValue(" ", 297, "alert-", 298, 7, true);
#nullable restore
#line 9 "/Users/marcoswerneck/Projetos/Aspnet Core/Mustaxe/br.com.mustaxe/Mustaxe/Views/Shared/_Alerts.cshtml"
WriteAttributeValue("", 304, alert.AlertStyle, 304, 17, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/marcoswerneck/Projetos/Aspnet Core/Mustaxe/br.com.mustaxe/Mustaxe/Views/Shared/_Alerts.cshtml"
WriteAttributeValue(" ", 321, dismissableClass, 322, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n");
#nullable restore
#line 10 "/Users/marcoswerneck/Projetos/Aspnet Core/Mustaxe/br.com.mustaxe/Mustaxe/Views/Shared/_Alerts.cshtml"
                 if (alert.Dismissable)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-hidden=\"true\">&times;</button>\n");
#nullable restore
#line 13 "/Users/marcoswerneck/Projetos/Aspnet Core/Mustaxe/br.com.mustaxe/Mustaxe/Views/Shared/_Alerts.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
#nullable restore
#line 14 "/Users/marcoswerneck/Projetos/Aspnet Core/Mustaxe/br.com.mustaxe/Mustaxe/Views/Shared/_Alerts.cshtml"
           Write(Html.Raw(alert.Message));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </div>\n");
#nullable restore
#line 16 "/Users/marcoswerneck/Projetos/Aspnet Core/Mustaxe/br.com.mustaxe/Mustaxe/Views/Shared/_Alerts.cshtml"
        }
    }

#line default
#line hidden
#nullable disable
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