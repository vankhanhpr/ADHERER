#pragma checksum "F:\ASP.NET\ADHERER\source\Adherer\WebClient\Views\Home\Form.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8dd98aa2cf7744dfb9d8d42c1cd6190e356551eb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Form), @"mvc.1.0.view", @"/Views/Home/Form.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Form.cshtml", typeof(AspNetCore.Views_Home_Form))]
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
#line 1 "F:\ASP.NET\ADHERER\source\Adherer\WebClient\Views\_ViewImports.cshtml"
using WebClient;

#line default
#line hidden
#line 2 "F:\ASP.NET\ADHERER\source\Adherer\WebClient\Views\_ViewImports.cshtml"
using WebClient.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8dd98aa2cf7744dfb9d8d42c1cd6190e356551eb", @"/Views/Home/Form.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74eabcf7e030352eff2473b217adffa5ad5752fa", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Form : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "F:\ASP.NET\ADHERER\source\Adherer\WebClient\Views\Home\Form.cshtml"
  
    ViewData["Title"] = "Form1";
    Layout = "~/Views/Shared/LayoutUser.cshtml";

#line default
#line hidden
            BeginContext(93, 2817, true);
            WriteLiteral(@"
<div class=""modal fade"" id=""myModal"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">

            <!-- Modal Header -->
            <div class=""modal-header"">
                <h4 class=""modal-title"">Chọn hình đại diện</h4>
                <button type=""button"" id=""btnclose"" class=""close"" data-dismiss=""modal"">&times;</button>
            </div>

            <!-- Modal body -->
            <div class=""custom-file mb-3"">
                <input type=""file"" class=""custom-file-input"" id=""customFile"" name=""filename"" accept=""image/*"">
                <label class=""custom-file-label"" for=""customFile"">Chọn ảnh đại diện</label>
            </div>
        </div>
    </div>
</div>

<div class=""pcoded-content"">
<div class=""pcoded-inner-content"">

    <!-- Main-body start -->
    <div class=""main-body"">
        <div class=""page-wrapper"">
            <!-- Page body start -->
            <div class=""page-body"">
                <div class=""row"">
                    <div class=""");
            WriteLiteral(@"col-sm-12"">
                        <!-- Basic Form Inputs card start -->
                        <div class=""card"">
                            <div class=""card-header"">
                                <h1>Biểu mẫu</h1>
                                <div class=""container"">
                                    <table class=""table table-hover"">
                                        <thead>
                                            <tr>
                                                <th>số thứ tự</th>
                                                <th>Tên biểu mẫu</th>
                                                <th>Mục đính kèm</th>
                                            </tr>
                                        </thead>
                                        <tbody>
                                            <tr>
                                                <td>1</td>
                                                <td>Mẫu bản tự kiểm điểm </td>
                     ");
            WriteLiteral(@"                           <td><input type=""file""></td>
                                            </tr>
                                        </tbody>
                                    </table>
                                </div>
                                <!-- Basic Form Inputs card end -->
                                <!-- Input Grid card start -->
                                <!-- Page body end -->
                            </div>
                        </div>
                        <!-- Main-body end -->
                        <div id=""styleSelector"">

                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
                    </div>
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
