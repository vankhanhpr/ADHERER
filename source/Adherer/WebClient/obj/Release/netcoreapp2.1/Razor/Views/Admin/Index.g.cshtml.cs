#pragma checksum "F:\ASP.NET\ADHERER\source\Adherer\WebClient\Views\Admin\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2dd8e14bfd6d97bf7639f103fbec99022e004026"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Index), @"mvc.1.0.view", @"/Views/Admin/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/Index.cshtml", typeof(AspNetCore.Views_Admin_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2dd8e14bfd6d97bf7639f103fbec99022e004026", @"/Views/Admin/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74eabcf7e030352eff2473b217adffa5ad5752fa", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/admin/adhome.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/chart/highcharts.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/admin/adindex.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "F:\ASP.NET\ADHERER\source\Adherer\WebClient\Views\Admin\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/LayoutAdmin.cshtml";

#line default
#line hidden
            DefineSection("Css", async() => {
                BeginContext(107, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(113, 69, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "7091ea05d1344f7d85141999172cfaa3", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(182, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(187, 5188, true);
            WriteLiteral(@"<div class=""k main-form"">
    <div class=""k form-body"">
        <span class=""k t-name-db"">Nhập thông tin và cập nhật</span>
        <a href=""/admin/dangbo"">
            <div class=""k bd-item-db"">
                <div class=""k item-db"">
                    <span class=""k t t-name-it"">ĐẢNG BỘ</span>
                    <span class=""k t t-tt-it"" id=""totaldangbo"">0</span>
                    <span class=""k t t-bw-it"">update</span>
                    <i class=""fa fa-clock-o ic-time-ud"" aria-hidden=""true""></i>
                    <span class=""k upday"" id=""daydangbo""></span>
                </div>
            </div>
        </a>
        <a href=""/admin/chibo"">
            <div class=""k bd-item-db"">
                <div class=""k item-db2"">
                    <span class=""k t t-name-it"">CHI BỘ</span>
                    <span class=""k t t-tt-it"" id=""totalchibo"">0</span>
                    <span class=""k t t-bw-it"">update</span>
                    <i class=""fa fa-clock-o ic-time-ud"" aria-hidden=");
            WriteLiteral(@"""true""></i>
                    <span class=""k upday"" id=""daychibo""></span>
                </div>
            </div>
        </a>
        <a href=""/admin/donvi"">
            <div class=""k bd-item-db"">
                <div class=""k item-db4"">
                    <span class=""k t t-name-it"">ĐƠN VỊ</span>
                    <span class=""k t t-tt-it"" id=""totalorg"">0</span>
                    <span class=""k t t-bw-it"">update</span>
                    <i class=""fa fa-clock-o ic-time-ud"" aria-hidden=""true""></i>
                    <span class=""k upday"" id=""dayorg""></span>
                </div>
            </div>
        </a>
        <a href=""/admin/dangvien"">
            <div class=""k bd-item-db"">
                <div class=""k item-db3"">
                    <span class=""k t t-name-it"">ĐẢNG VIÊN</span>
                    <span class=""k t t-tt-it"" id=""totaldangvien"">0</span>
                    <span class=""k t t-bw-it"">update</span>
                    <i class=""fa fa-clock-o ic-time-ud"" a");
            WriteLiteral(@"ria-hidden=""true""></i>
                    <span class=""k upday"" id=""daydangvien""></span>
                </div>
            </div>
        </a>

        <span class=""k t-name-db"">Các hoạt động</span>

        <a href=""/admin/form"">
            <div class=""k bd-item-db"">
                <div class=""k item-db5"">
                    <span class=""k t t-name-it note-document"">BIỂU MẪU & VĂN BẢN</span>
                    <span class=""k t t-tt-it total-document"" id=""totalform"">0</span>
                    <span class=""k t t-bw-it"">update</span>
                    <i class=""fa fa-clock-o ic-time-ud"" aria-hidden=""true""></i>
                    <span class=""k upday"" id=""dayform""></span>
                </div>
            </div>
        </a>
        <a href=""/admin/livingadherer"">
            <div class=""k bd-item-db"">
                <div class=""k item-db6"">
                    <span class=""k t t-name-it note-document"">SINH HOẠT ĐẢNG</span>
                    <span class=""k t t-tt-it total-do");
            WriteLiteral(@"cument"">0</span>
                    <span class=""k t t-bw-it"">update</span>
                    <i class=""fa fa-clock-o ic-time-ud"" aria-hidden=""true""></i>
                    <span class=""k upday"">20/12/2012</span>
                </div>
            </div>
        </a>
        <a href=""/admin/finance"">
            <div class=""k bd-item-db"">
                <div class=""k item-db6"">
                    <span class=""k t t-name-it note-document"">TÀI CHÍNH</span>
                    <span class=""k t t-tt-it total-document"">0</span>
                    <span class=""k t t-bw-it"">update</span>
                    <i class=""fa fa-clock-o ic-time-ud"" aria-hidden=""true""></i>
                    <span class=""k upday"">20/12/2012</span>
                </div>
            </div>
        </a>
        <a href=""/admin/manageuser"">
            <div class=""k bd-item-db"">
                <div class=""k item-db6"">
                    <span class=""k t t-name-it note-document"">QUẢN LÝ ĐẢNG VIÊN</span>
        ");
            WriteLiteral(@"            <span class=""k t t-tt-it total-document"">0</span>
                    <span class=""k t t-bw-it"">update</span>
                    <i class=""fa fa-clock-o ic-time-ud"" aria-hidden=""true""></i>
                    <span class=""k upday"">20/12/2012</span>
                </div>
            </div>
        </a>

        <span class=""k t-name-db"">Báo cáo</span>

        <span class=""k t-name-db"">Đảng viên đến theo các tháng trong năm</span>
        <a href=""/admin/report"">
            <div class=""k bd-item-db"">
                <div class=""k item-db6"">
                    <span class=""k t t-name-it"">THỐNG KÊ</span>
                    <span class=""k t t-tt-it"">0</span>
                    <span class=""k t t-bw-it"">update</span>
                    <i class=""fa fa-clock-o ic-time-ud"" aria-hidden=""true""></i>
                    <span class=""k upday"">20/12/2012</span>
                </div>
            </div>
        </a>
        <div id=""container"" style=""min-width: 310px; height: 400px;");
            WriteLiteral(" margin: 0 auto ;margin-bottom:50px;\"></div>\r\n\r\n    </div>\r\n</div>\r\n");
            EndContext();
            DefineSection("Script", async() => {
                BeginContext(5391, 58, true);
                WriteLiteral("\r\n    <script>\r\n        checkToken();\r\n    </script>\r\n    ");
                EndContext();
                BeginContext(5449, 72, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c777bcc9859845ddaa5ba050e9e03eab", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5521, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(5527, 68, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "237d5ab4599643a19df052928563fa7f", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5595, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
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
