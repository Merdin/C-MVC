#pragma checksum "C:\Users\merdin\Documents\Tentamen\Client\MVC\MuzikantMVC\Views\Muzikant\ActieveMuzikanten.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4109cfc12824d039c9fb0436b71df7871a3f7df7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Muzikant_ActieveMuzikanten), @"mvc.1.0.view", @"/Views/Muzikant/ActieveMuzikanten.cshtml")]
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
#line 1 "C:\Users\merdin\Documents\Tentamen\Client\MVC\MuzikantMVC\Views\_ViewImports.cshtml"
using MuzikantMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\merdin\Documents\Tentamen\Client\MVC\MuzikantMVC\Views\_ViewImports.cshtml"
using MuzikantMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4109cfc12824d039c9fb0436b71df7871a3f7df7", @"/Views/Muzikant/ActieveMuzikanten.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad87b724305b2d279e338b5834e20f36583a9dd6", @"/Views/_ViewImports.cshtml")]
    public class Views_Muzikant_ActieveMuzikanten : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MuzikantenApi.Models.Muzikant>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\merdin\Documents\Tentamen\Client\MVC\MuzikantMVC\Views\Muzikant\ActieveMuzikanten.cshtml"
  
    ViewData["Title"] = "ActieveMuzikanten";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>ActieveMuzikanten</h1>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 12 "C:\Users\merdin\Documents\Tentamen\Client\MVC\MuzikantMVC\Views\Muzikant\ActieveMuzikanten.cshtml"
           Write(Html.DisplayNameFor(model => model.MuzikantId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 15 "C:\Users\merdin\Documents\Tentamen\Client\MVC\MuzikantMVC\Views\Muzikant\ActieveMuzikanten.cshtml"
           Write(Html.DisplayNameFor(model => model.Voornaam));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 18 "C:\Users\merdin\Documents\Tentamen\Client\MVC\MuzikantMVC\Views\Muzikant\ActieveMuzikanten.cshtml"
           Write(Html.DisplayNameFor(model => model.Achternaam));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 21 "C:\Users\merdin\Documents\Tentamen\Client\MVC\MuzikantMVC\Views\Muzikant\ActieveMuzikanten.cshtml"
           Write(Html.DisplayNameFor(model => model.StartJaar));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 24 "C:\Users\merdin\Documents\Tentamen\Client\MVC\MuzikantMVC\Views\Muzikant\ActieveMuzikanten.cshtml"
           Write(Html.DisplayNameFor(model => model.StopJaar));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 29 "C:\Users\merdin\Documents\Tentamen\Client\MVC\MuzikantMVC\Views\Muzikant\ActieveMuzikanten.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 32 "C:\Users\merdin\Documents\Tentamen\Client\MVC\MuzikantMVC\Views\Muzikant\ActieveMuzikanten.cshtml"
           Write(Html.DisplayFor(modelItem => item.MuzikantId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 35 "C:\Users\merdin\Documents\Tentamen\Client\MVC\MuzikantMVC\Views\Muzikant\ActieveMuzikanten.cshtml"
           Write(Html.DisplayFor(modelItem => item.Voornaam));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 38 "C:\Users\merdin\Documents\Tentamen\Client\MVC\MuzikantMVC\Views\Muzikant\ActieveMuzikanten.cshtml"
           Write(Html.DisplayFor(modelItem => item.Achternaam));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 41 "C:\Users\merdin\Documents\Tentamen\Client\MVC\MuzikantMVC\Views\Muzikant\ActieveMuzikanten.cshtml"
           Write(Html.DisplayFor(modelItem => item.StartJaar));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 44 "C:\Users\merdin\Documents\Tentamen\Client\MVC\MuzikantMVC\Views\Muzikant\ActieveMuzikanten.cshtml"
           Write(Html.DisplayFor(modelItem => item.StopJaar));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 47 "C:\Users\merdin\Documents\Tentamen\Client\MVC\MuzikantMVC\Views\Muzikant\ActieveMuzikanten.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MuzikantenApi.Models.Muzikant>> Html { get; private set; }
    }
}
#pragma warning restore 1591
