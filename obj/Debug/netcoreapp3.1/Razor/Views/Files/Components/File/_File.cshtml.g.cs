#pragma checksum "F:\Projects\EMPW\Views\Files\Components\File\_File.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "34b2e05825849df7007404e943439e64e3aa4950"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Files_Components_File__File), @"mvc.1.0.view", @"/Views/Files/Components/File/_File.cshtml")]
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
#line 1 "F:\Projects\EMPW\Views\_ViewImports.cshtml"
using Emamzadeh;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Projects\EMPW\Views\_ViewImports.cshtml"
using Emamzadeh.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"34b2e05825849df7007404e943439e64e3aa4950", @"/Views/Files/Components/File/_File.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"977d3c66d905108defbba9c0d2095cbd06a28d16", @"/Views/_ViewImports.cshtml")]
    public class Views_Files_Components_File__File : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Emamzadeh.Models.File>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Download", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Files", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<section class=""section"" id=""blog"">
    <div class=""container"">
        <div class=""section-head"">
            <span>فایل ها و محتوای آموزشی</span>
            <h2>فایلها، نمونه سوالات و محتوای آموزشی</h2>
        </div>

        <div class=""section-inner"">
            <div class=""row"">
");
#nullable restore
#line 11 "F:\Projects\EMPW\Views\Files\Components\File\_File.cshtml"
                 foreach (var fi in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-md-4\">\n                <div class=\"blog-list d-block mb-5 \">\n                    <div class=\"blog-list--img\">\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "34b2e05825849df7007404e943439e64e3aa49505574", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 568, "~/assets/images/ext/", 568, 20, true);
            AddHtmlAttributeValue("", 588, new Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_attribute_value_writer) => {
                PushWriter(__razor_attribute_value_writer);
                                                                            
#nullable restore
#line 16 "F:\Projects\EMPW\Views\Files\Components\File\_File.cshtml"
                                                       Write(fi.FileExtention);

#line default
#line hidden
#nullable disable
                                                                                             
                PopWriter();
            }
            ), 588, 20, false);
            AddHtmlAttributeValue("", 608, ".png", 608, 4, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 16 "F:\Projects\EMPW\Views\Files\Components\File\_File.cshtml"
AddHtmlAttributeValue("", 619, fi.Title, 619, 9, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "title", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 16 "F:\Projects\EMPW\Views\Files\Components\File\_File.cshtml"
AddHtmlAttributeValue("", 637, fi.Description, 637, 15, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                            <div class=\"blog-list--details d-flex justify-content-center align-items-center\">\n                                <div class=\"blog-list--details-in\">\n                                    <p class=\"blog-date text-white\">");
#nullable restore
#line 19 "F:\Projects\EMPW\Views\Files\Components\File\_File.cshtml"
                                                               Write(fi.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                                    <span class=\"blog-by\">");
#nullable restore
#line 20 "F:\Projects\EMPW\Views\Files\Components\File\_File.cshtml"
                                                     Write(fi.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n                                </div>\n                            </div>\n                        </div>\n                        <div class=\"blog-list--desc p-4\">\n                            <span class=\"blog-cat badge badge-primary\">");
#nullable restore
#line 25 "F:\Projects\EMPW\Views\Files\Components\File\_File.cshtml"
                                                                  Write(fi.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n\n                            <h3>نوع فایل: ");
#nullable restore
#line 27 "F:\Projects\EMPW\Views\Files\Components\File\_File.cshtml"
                                     Write(fi.FileExtention);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n                            <h3>حجم فایل: ");
#nullable restore
#line 28 "F:\Projects\EMPW\Views\Files\Components\File\_File.cshtml"
                                     Write(fi.FileLenght);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n                            <h3>تاریخ بارگزاری: ");
#nullable restore
#line 29 "F:\Projects\EMPW\Views\Files\Components\File\_File.cshtml"
                                           Write(fi.UploadDate.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n                            <div class=\"col-lg-12 text-center mt-4\">\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "34b2e05825849df7007404e943439e64e3aa495010836", async() => {
                WriteLiteral("دریافت فایل");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 31 "F:\Projects\EMPW\Views\Files\Components\File\_File.cshtml"
                                                                                                     WriteLiteral(fi.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                            </div>\n\n                        </div>\n                    </div>\n            </div>\n");
#nullable restore
#line 37 "F:\Projects\EMPW\Views\Files\Components\File\_File.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </div>\n\n        </div>\n    </div>\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Emamzadeh.Models.File>> Html { get; private set; }
    }
}
#pragma warning restore 1591
