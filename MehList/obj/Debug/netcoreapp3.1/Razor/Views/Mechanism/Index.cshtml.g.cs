#pragma checksum "D:\VS\MehList\Views\Mechanism\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "04ec06cb9ac08dd905993be3730ec3242a614010"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Mechanism_Index), @"mvc.1.0.view", @"/Views/Mechanism/Index.cshtml")]
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
#line 1 "D:\VS\MehList\Views\_ViewImports.cshtml"
using MehList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\VS\MehList\Views\_ViewImports.cshtml"
using MehList.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\VS\MehList\Views\Mechanism\Index.cshtml"
using DAL.EF.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"04ec06cb9ac08dd905993be3730ec3242a614010", @"/Views/Mechanism/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf558a16e55c520d991833dab92408b0b5b1a775", @"/Views/_ViewImports.cshtml")]
    public class Views_Mechanism_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Mechanism>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\VS\MehList\Views\Mechanism\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container container-fluid\">\r\n    <div class=\"row\">\r\n        <div class=\"col-md-6\">\r\n\r\n            ");
#nullable restore
#line 12 "D:\VS\MehList\Views\Mechanism\Index.cshtml"
       Write(Html.ActionLink("Add mechanism", "AddMechanism", "Mechanism", null, new { @class = "btn btn-success " }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"col-md-6\">\r\n            ");
#nullable restore
#line 15 "D:\VS\MehList\Views\Mechanism\Index.cshtml"
       Write(Html.ActionLink("Add construction object", "AddConstructionObject", "Mechanism", null, new { @class = "btn btn-success" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </div>
    </div>
    <table class=""table"">
        <thead>
            <tr>
                <th scope=""col"">#</th>
                <th scope=""col"">Name</th>
                <th scope=""col"">FuelСonsumption</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 27 "D:\VS\MehList\Views\Mechanism\Index.cshtml"
             foreach (var m in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <th scope=\"row\">");
#nullable restore
#line 30 "D:\VS\MehList\Views\Mechanism\Index.cshtml"
                               Write(m.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <td>");
#nullable restore
#line 31 "D:\VS\MehList\Views\Mechanism\Index.cshtml"
                   Write(m.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 32 "D:\VS\MehList\Views\Mechanism\Index.cshtml"
                   Write(m.FuelConsumption);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 34 "D:\VS\MehList\Views\Mechanism\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Mechanism>> Html { get; private set; }
    }
}
#pragma warning restore 1591
