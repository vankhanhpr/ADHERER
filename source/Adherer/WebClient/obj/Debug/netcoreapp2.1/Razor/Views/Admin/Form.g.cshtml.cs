#pragma checksum "F:\ASP.NET\ADHERER\source\Adherer\WebClient\Views\Admin\Form.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3b2c66d5f40d8fc7529aff520fc5b9380e7aabff"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Form), @"mvc.1.0.view", @"/Views/Admin/Form.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/Form.cshtml", typeof(AspNetCore.Views_Admin_Form))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3b2c66d5f40d8fc7529aff520fc5b9380e7aabff", @"/Views/Admin/Form.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74eabcf7e030352eff2473b217adffa5ad5752fa", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Form : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/admin/adform.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/admin/adform.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "F:\ASP.NET\ADHERER\source\Adherer\WebClient\Views\Admin\Form.cshtml"
  
    ViewData["Title"] = "Form";
    Layout = "~/Views/Shared/LayoutAdmin.cshtml";

#line default
#line hidden
            DefineSection("Css", async() => {
                BeginContext(106, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(112, 69, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8872a70b234944c480e9d889d8be1cac", async() => {
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
                BeginContext(181, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(186, 1793, true);
            WriteLiteral(@"    <div class="" k body-form"">
        <div class=""k form-head"">
            <span class=""k t title"">Quản lý biểu mẫu</span>
        </div>
        <div class=""k form-add-new"">
            <div class=""k item-left-form"">
                <span class=""k left-text"">Tên biểu mẫu:</span>
                <input class=""k right-text"" id=""nameform"" />
            </div>
            <div class=""k item-left-form"">
                <span class=""k left-text"">File:</span>
                <div class=""k form-add-file"">
                    <div class="" k img-brower"" onclick=""getImage()""></div>
                    <input id=""multi-file"" class=""hidden"" accept="".docx,.xlsx,application/msword, application/vnd.ms-excel, application/vnd.ms-powerpoint,text/plain, application/pdf, image/*"" style=""display:none"" type=""file"" multiple="""">
                    <span class=""k t name-file"" id=""name-file"">Nothing</span>
                </div>
            </div>
            <div class=""k item-left-form"">
                <span c");
            WriteLiteral(@"lass=""k left-text"">Ghi chú:</span>
                <textarea class=""k right-text"" id=""noteform""></textarea>
            </div>
            <div class="" k boder-err"">
                <span class=""t err-validate"" id=""err-insert-form"">**Vui lòng điền đầy đủ thông tin</span>
                <span class=""k t bnt-insert-form"" onclick=""validateForm()"">Thêm biểu mẫu</span>
            </div>

        </div>
        <div class="" k main-form-item"" id=""main-form-item"">
            <div class=""k row-table"">
                <span class=""k t tt-table"">STT</span>
                <span class=""k t tt-table"">Tên biểu mẫu</span>
                <span class=""k t tt-table"">Link</span>
                <span class=""k t tt-table"">Cập nhật</span>
            </div>

");
            EndContext();
            BeginContext(2473, 20, true);
            WriteLiteral("\r\n        </div>\r\n\r\n");
            EndContext();
            BeginContext(2518, 1976, true);
            WriteLiteral(@"        <div class=""modal fade"" id=""modalupdateform"" role=""dialog"">
            <div class=""modal-dialog"">
                <!-- Modal content-->
                <div class=""modal-content"">
                    <div class=""modal-header"">
                        <button type=""button"" class=""close"" data-dismiss=""modal"">&times;</button>
                        <h4 class=""modal-title"">Cập nhật biểu mẫu</h4>
                    </div>
                    <div class=""k modal-body"">
                        <div class=""k dl-sm-it"">
                            <span class=""k t left-text"">Tên biểu mẫu: </span>
                            <input class=""k input-text"" id=""name-form-update"" type=""text"" />
                        </div>
                        <div class=""k dl-sm-it"">
                            <span class=""k t left-text"">File biểu mẫu: </span>
                            <div class=""k form-file-update"" type=""text"">
                                <span class=""k t name-file-update"" id=""name-f");
            WriteLiteral(@"ile-update"">abcde.png</span>
                                <span class=""k t bnt-brower-update"" onclick=""getImageUpdate()"">brower</span>
                                <input id=""multi-file-update"" class=""hidden"" accept="".docx,.xlsx,application/msword, application/vnd.ms-excel, application/vnd.ms-powerpoint,text/plain, application/pdf, image/*"" style=""display:none"" type=""file"" multiple="""">
                            </div>
                        </div>
                        <div class=""k dl-sm-it"">
                            <span class=""k t left-text"">Ghi chú: </span>
                            <textarea class=""k input-text"" id=""name-note-update"" type=""text""></textarea>
                        </div>
                        <span class=""k t err-validate-update""id=""err-update-form"">**Vui lòng kiểm tra lại thông tin</span>
                        <span class=""k bnt-update"" id=""bnt-update"" onclick=""validateUpdateForm()"">
");
            EndContext();
            BeginContext(4580, 354, true);
            WriteLiteral(@"                            Cập nhật
                        </span>
                    </div>
                    <div class=""modal-footer"">
                        <button type=""button"" class=""btn btn-default"" data-dismiss=""modal"">Close</button>
                    </div>
                </div>
            </div>
        </div>
    </div>
");
            EndContext();
            DefineSection("Script", async() => {
                BeginContext(4950, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(4956, 44, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3dca43ba8fd34d53a3d54893a9358546", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5000, 2, true);
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
