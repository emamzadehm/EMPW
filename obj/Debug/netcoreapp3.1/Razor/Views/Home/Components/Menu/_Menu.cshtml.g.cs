#pragma checksum "F:\Projects\EMPW\Views\Home\Components\Menu\_Menu.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9cc5f8faf4de8819d14e053aa34ad34cbe563ddc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Components_Menu__Menu), @"mvc.1.0.view", @"/Views/Home/Components/Menu/_Menu.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9cc5f8faf4de8819d14e053aa34ad34cbe563ddc", @"/Views/Home/Components/Menu/_Menu.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"669539bda9ef8379804d997fe69a220d801a7ce1", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Components_Menu__Menu : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Emamzadeh.Models.Professor>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-block img-fluid mx-auto rounded-pill shadow-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<aside class=""aside"">
    <!-- START: NAVBAR -->

    <div class=""nav-wrapper"">

        <div class=""navbar-toggler"">
            <svg class=""ham hamRotate ham1"" viewBox=""0 0 100 100"" width=""60"">
                <path class=""line top"" d=""m 30,33 h 40 c 0,0 9.044436,-0.654587 9.044436,-8.508902 0,-7.854315 -8.024349,-11.958003 -14.89975,-10.85914 -6.875401,1.098863 -13.637059,4.171617 -13.637059,16.368042 v 40"" />
                <path class=""line middle"" d=""m 30,50 h 40"" />
                <path class=""line bottom"" d=""m 30,67 h 40 c 12.796276,0 15.357889,-11.717785 15.357889,-26.851538 0,-15.133752 -4.786586,-27.274118 -16.667516,-27.274118 -11.88093,0 -18.499247,6.994427 -18.435284,17.125656 l 0.252538,40"" />
            </svg>
        </div>

        <nav class=""navbar text-center align-items-center justify-content-center"">



            <div class=""collapse navbar-collapse show"" id=""navbarCollapse"">
");
            WriteLiteral("                <div class=\"about-avatar mb-5\">\n\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "9cc5f8faf4de8819d14e053aa34ad34cbe563ddc4847", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1097, "~/assets/images/", 1097, 16, true);
#nullable restore
#line 23 "F:\Projects\EMPW\Views\Home\Components\Menu\_Menu.cshtml"
AddHtmlAttributeValue("", 1113, Model.ImgAddress, 1113, 17, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"


                    <div class=""about-avatar-details mt-3"">
                        <p class=""badge"">خوش آمدید...</p>
                    </div>
                </div>

                <ul class=""navbar-nav mx-auto"">
                    <li class=""nav-item"">
                        <a class=""nav-link ripple active"" href=""#home"">

                            <span>خانه</span>	<i class=""lni-home""></i>
                        </a>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link ripple"" href=""#services"">

                            <span>دوره های آموزشی</span>	<i class=""lni-offer""></i>
                        </a>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link ripple"" href=""#testimony"">

                            <span>خاطرات دانشجویان</span>	<i class=""lni-graduation""></i>
                        </a>
                    </li>
                    <li class=""nav-item"">
              ");
            WriteLiteral(@"          <a class=""nav-link ripple"" href=""#resume"">

                            <span>رزومه</span>	<i class=""lni-briefcase""></i>
                        </a>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link ripple"" href=""#blog"">

                            <span>فایل ها و محتوای آموزشی</span><i class=""lni-pencil""></i>
                        </a>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link ripple"" href=""#contact"">

                            <span>ارتباط با من</span>	<i class=""lni-phone-handset""></i>
                        </a>
                    </li>
                </ul>
            </div>

            <div class=""aside-footer"">
                <ul class=""list-unstyled list-inline"">
");
#nullable restore
#line 76 "F:\Projects\EMPW\Views\Home\Components\Menu\_Menu.cshtml"
                     if (!string.IsNullOrWhiteSpace(Model.LinkedInURL))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li class=\"list-inline-item\"><a");
            BeginWriteAttribute("href", " href=\"", 3495, "\"", 3520, 1);
#nullable restore
#line 78 "F:\Projects\EMPW\Views\Home\Components\Menu\_Menu.cshtml"
WriteAttributeValue("", 3502, Model.LinkedInURL, 3502, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"lni-linkedin-original\"></i></a></li>");
#nullable restore
#line 78 "F:\Projects\EMPW\Views\Home\Components\Menu\_Menu.cshtml"
                                                                                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </ul>\n            </div>\n        </nav>\n    </div>\n    <!-- END: NAVBAR -->\n</aside>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Emamzadeh.Models.Professor> Html { get; private set; }
    }
}
#pragma warning restore 1591