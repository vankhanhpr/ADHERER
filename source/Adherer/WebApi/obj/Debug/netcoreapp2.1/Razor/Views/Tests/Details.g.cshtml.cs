#pragma checksum "F:\ASP.NET\ADHERER\source\Adherer\WebApi\Views\Tests\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1b6793ac9fa525f431c011c5dce293600f472122"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tests_Details), @"mvc.1.0.view", @"/Views/Tests/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Tests/Details.cshtml", typeof(AspNetCore.Views_Tests_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b6793ac9fa525f431c011c5dce293600f472122", @"/Views/Tests/Details.cshtml")]
    public class Views_Tests_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApi.controllers.values.Test>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(39, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "F:\ASP.NET\ADHERER\source\Adherer\WebApi\Views\Tests\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(84, 118, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>Test</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(203, 44, false);
#line 14 "F:\ASP.NET\ADHERER\source\Adherer\WebApi\Views\Tests\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.testname));

#line default
#line hidden
            EndContext();
            BeginContext(247, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(291, 40, false);
#line 17 "F:\ASP.NET\ADHERER\source\Adherer\WebApi\Views\Tests\Details.cshtml"
       Write(Html.DisplayFor(model => model.testname));

#line default
#line hidden
            EndContext();
            BeginContext(331, 67, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    <a asp-action=\"Edit\"");
            EndContext();
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 398, "\"", 426, 1);
#line 22 "F:\ASP.NET\ADHERER\source\Adherer\WebApi\Views\Tests\Details.cshtml"
WriteAttributeValue("", 413, Model.testId, 413, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(427, 65, true);
            WriteLiteral(">Edit</a> |\r\n    <a asp-action=\"Index\">Back to List</a>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApi.controllers.values.Test> Html { get; private set; }
    }
}
#pragma warning restore 1591
