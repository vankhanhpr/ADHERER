#pragma checksum "F:\ASP.NET\ADHERER\source\Adherer\WebClient\Views\Admin\ManageUser.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "48f7b624ae96134dbfa2f7e7a4e33d63b678c01e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_ManageUser), @"mvc.1.0.view", @"/Views/Admin/ManageUser.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/ManageUser.cshtml", typeof(AspNetCore.Views_Admin_ManageUser))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"48f7b624ae96134dbfa2f7e7a4e33d63b678c01e", @"/Views/Admin/ManageUser.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74eabcf7e030352eff2473b217adffa5ad5752fa", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_ManageUser : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/admin/admanageuser.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/admin/admanageruser.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/admin/addangviendubi.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "F:\ASP.NET\ADHERER\source\Adherer\WebClient\Views\Admin\ManageUser.cshtml"
  
    ViewData["Title"] = "Quản lý Đảng viên";
    Layout = "~/Views/Shared/LayoutAdmin.cshtml";

#line default
#line hidden
            DefineSection("Css", async() => {
                BeginContext(119, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(125, 75, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a8dd3afa820b4ad38b2280d0f9996c47", async() => {
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
                BeginContext(200, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(205, 496, true);
            WriteLiteral(@"    <div class=""k main-form"">
        <div class=""k body-form"">
            <div class="" k menu"">
                <span class=""k t item-menu"" onclick=""showTab('tab-sinhhoat')"">Chuyển Đảng</span>
                <span class=""k t item-menu"" onclick=""showTab('tab-huyhieu')"">Xét tặng huy hiệu Đảng</span>
                <span class=""k t item-menu"" onclick=""showTab('tab-user-dubi')"">Quản lý Đảng viên dự bị</span>
            </div>

            <select class="" t sl-chibo"" id=""sl-chibo"">
");
            EndContext();
            BeginContext(814, 95, true);
            WriteLiteral("            </select>\r\n\r\n\r\n            <select class=\" t sl-chibo\" id=\"sl-dangbo\"></select>\r\n\r\n");
            EndContext();
            BeginContext(949, 276, true);
            WriteLiteral(@"            <div class=""k body-item"" style=""display:none"" id=""tab-huyhieu"">
                <div class=""k form-user"" id=""form-armorial"">
                    <span class="" k t text-table"">STT </span>
                    <span class="" k t text-table-info"">Thông tin </span>
");
            EndContext();
            BeginContext(1901, 50, true);
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n\r\n");
            EndContext();
            BeginContext(1990, 281, true);
            WriteLiteral(@"            <div class=""k body-item"" style=""display:block"" id=""tab-sinhhoat"">
                <div class=""k tab-head-adhe"">
                    <span class=""t bnt-addnew"" data-toggle=""modal"" data-target=""#modalinsertdangvien"" onclick=""getTitle(bindingTitle)"">+Chuyển đến</span>
");
            EndContext();
            BeginContext(2528, 3685, true);
            WriteLiteral(@"                </div>
                <div class=""k tab-head-adhe"">
                    <span class="" k t t-item-note"">Chọn Đảng viên chuyển sinh hoạt</span>
                    <input class=""select-user"" id=""input-select"" list=""select-dangvien"">
                    <datalist id=""select-dangvien""></datalist>
                </div>
                <div class=""k form-user"">
                    <div class=""k list-user-move"">
                        <div class=""k img-avt""></div>
                        <div class=""k f-name"">
                            <span class=""k t t-if-dv"">
                                <i class=""fa fa-id-card-o font-ic"" aria-hidden=""true""></i>
                                <span id=""madv""></span>
                            </span>
                            <span class=""k t t-if-dv"">
                                <i class=""fa fa-user-circle-o font-ic"" aria-hidden=""true""></i>
                                <span id=""nameuser""></span>
                            </s");
            WriteLiteral(@"pan>
                        </div>
                        <div class=""k f-name"">
                            <div class=""k row-input"">
                                <input class=""k t checkbox"" id=""check-form-move"" type=""checkbox"" name=""giaygioithieu"" value=""0"" />
                                <span class=""k t text-note-checkbox"">Đơn xin chuyển Đảng</span>
                            </div>
                            <div class=""k row-input"">
                                <input class=""k t checkbox"" id=""check-form-review"" type=""checkbox"" name=""hopdanhgia"" value=""1"" />
                                <span class=""k t text-note-checkbox"">Bản tự kiểm điểm</span>
                            </div>
                            <div class=""k row-input"">
                                <input class=""k t checkbox"" type=""checkbox"" name=""danhan"" value=""2"" checked />
                                <span class=""k t text-note-checkbox"">Xác nhận của Chi bộ</span>
                            </div>
  ");
            WriteLiteral(@"                          <div class=""k row-input"">
                                <input class=""k t input-from-to"" id=""address-togo"" placeholder=""Nơi chuyển đi"" type=""text"" />
                            </div>
                        </div>
                        <div class=""k f-name"">
                            <div class=""k row-input"">
                                <span class="" k t "">
                                    <span class=""k t bnt-brower-file"" onclick=""getFileMove()"">Tải lên</span>
                                    <span class=""k t name-file-move""></span>
                                    <input id=""upload-file-move"" class=""hidden"" style=""display:none"" type=""file"" accept=""image/*"" multiple="""">
                                </span>
                            </div>
                            <div class=""k row-input"">
                                <span class="" k t "">
                                    <span class=""k t bnt-brower-file"" onclick=""getFileReview()"">Tải l");
            WriteLiteral(@"ên</span>
                                    <span class=""k t file-review""></span>
                                    <input id=""upload-file-review"" class=""hidden"" style=""display:none"" type=""file"" accept=""image/*"" multiple="""">
                                </span>
                            </div>
                            <div class=""k row-input"">
                                <span class=""k t bnt-move-user"" onclick=""moveDangVien()"">Chuyển đi</span>
                            </div>
                        </div>
                    </div>
                </div>
            </div>

");
            EndContext();
            BeginContext(6254, 330, true);
            WriteLiteral(@"            <div class=""k body-item"" style=""display:none"" id=""tab-user-dubi"">
                <span class="" k t t-item-note"">Danh sách Đảng viên dự bị</span>
                <div class=""k form-user"">
                    <div class=""k form-user"">
                        <div class=""k list-user-move"" id=""list-user-dubi"">


");
            EndContext();
            BeginContext(11052, 126, true);
            WriteLiteral("\r\n\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n");
            EndContext();
            BeginContext(11209, 958, true);
            WriteLiteral(@"        <div class=""modal fade"" id=""modalinsertdangvien"" role=""dialog"">
            <div class=""modal-dialog"">
                <!-- Modal content-->
                <div class=""modal-content"">
                    <div class=""modal-header"">
                        <button type=""button"" class=""close"" data-dismiss=""modal"">&times;</button>
                        <h4 class=""modal-title"">Đảng viên chuyến đến</h4>
                    </div>
                    <div class=""k modal-body"">
                        <div class=""k dl-sm-it"">
                            <span class=""k t dl-name-dv"">Mã Đảng viên: </span>
                            <input class=""k dl-input-dv"" id=""ip-madv"" type=""text"" maxlength=""8"" />
                        </div>
                        <div class=""k dl-sm-it"">
                            <span class=""k t dl-name-dv"">Chức vụ Đảng: </span>
                            <select class=""k dl-sl-dv"" id=""sl-title"">
");
            EndContext();
            BeginContext(12313, 2879, true);
            WriteLiteral(@"                            </select>
                        </div>
                        <div class=""k dl-sm-it"" id=""go-on-business-old"">
                            <span class=""k t dl-name-dv"">Nơi sinh hoạt cũ: </span>
                            <input class=""k dl-input-dv"" id=""adress-on-bussiness"" type=""text"" />
                        </div>
                        <div class=""k dl-sm-it"">
                            <span class=""k t dl-name-dv"" id=""sl-db-active"">Ngày đến Chi bộ: </span>
                            <div class=""form-group"">
                                <div class='input-group date' id='datepicker-daytochibo'>
                                    <input type='text' class=""form-control"" id=""day-to-go"" />
                                    <span class=""input-group-addon"">
                                        <span class=""glyphicon glyphicon-calendar""></span>
                                    </span>
                                </div>
                           ");
            WriteLiteral(@" </div>
                        </div>

                        <div class=""k dl-sm-it"" id=""go-on-business-old"">
                            <span class=""k t dl-name-dv"">Giấy giới thiệu: </span>
                            <span class=""k document-togo"" type=""text"">
                                <span class=""t name-referral"">nothing</span>
                                <span class=""t brower-doc"" onclick=""getImage()"">Brower</span>
                                <input id=""upload-referral"" class=""hidden"" style=""display:none"" type=""file"" accept=""image/*"" multiple="""">
                            </span>
                        </div>

                        <div class=""k dl-sm-it"">
                            <span class=""k t dl-name-dv"">Mật khẩu: </span>
                            <input class=""k dl-input-dv"" id=""ip-pass"" type=""password"" />
                        </div>
                        <div class=""k dl-sm-it"">
                            <span class=""k t dl-name-dv"">Nhập lại mật k");
            WriteLiteral(@"hẩu: </span>
                            <input class=""k dl-input-dv"" id=""ip-cf-pass"" type=""password"" />
                            <span class=""k t err-validate"" id=""err-validate"">**Vui lòng kiểm tra lại thông tin</span>
                        </div>
                    </div>
                    <div class=""modal-footer"">
                        <button type=""button"" class=""k btn btn-default"" data-dismiss=""modal"">
                            Đóng
                        </button>
                        <span class=""k dl-bnt-save"" onclick=""validateForm()"">
                            <i class=""fa fa-paper-plane-o"" aria-hidden=""true""></i>
                            Chuyển tới Chi bộ
                        </span>
                    </div>
                </div>

            </div>
        </div>
");
            EndContext();
            BeginContext(15219, 24, true);
            WriteLiteral("        \r\n    </div>\r\n\r\n");
            EndContext();
            DefineSection("Script", async() => {
                BeginContext(15259, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(15265, 51, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bcd10eb409884b4ba0369267ceaef2ef", async() => {
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
                BeginContext(15316, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(15322, 52, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ea28412af4b94630a5b63f4a5a098c53", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(15374, 2, true);
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
