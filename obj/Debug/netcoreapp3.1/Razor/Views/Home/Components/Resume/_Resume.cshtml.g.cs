#pragma checksum "F:\Projects\EMPW\Views\Home\Components\Resume\_Resume.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "28876905e0187cc97e0262367d13a4de2b1ac8d8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Components_Resume__Resume), @"mvc.1.0.view", @"/Views/Home/Components/Resume/_Resume.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"28876905e0187cc97e0262367d13a4de2b1ac8d8", @"/Views/Home/Components/Resume/_Resume.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"977d3c66d905108defbba9c0d2095cbd06a28d16", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Components_Resume__Resume : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Emamzadeh.Models.Resume>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<section class=""section section-resume"" id=""resume"">
    <div class=""container"">

        <div class=""section-head"">
            <span>رزومه من</span>
            <h2>تجربیات من</h2>
        </div>

        <div class=""section-inner"">
            <div class=""section-resume-wrap"">

                <div class=""section-experience mb-5"">
                    <div class=""row"">
                        <div class=""col-lg-3"">
                            <h5 class=""section-subHead mb-4 "">بیوگرافی</h5>
                        </div>
                        <div class=""col-lg-9"">
                            <div class=""ExperienceList pb-3"">

");
#nullable restore
#line 21 "F:\Projects\EMPW\Views\Home\Components\Resume\_Resume.cshtml"
                                 foreach (var res in Model)
                                {
                                    if (!string.IsNullOrWhiteSpace(res.Id.ToString()))
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <div class=\"resume-list b-box p-4 \">\r\n                                            <div class=\"row align-items-center\">\r\n");
#nullable restore
#line 27 "F:\Projects\EMPW\Views\Home\Components\Resume\_Resume.cshtml"
                                                 if (!(string.IsNullOrWhiteSpace(res.FromYear)) && !(string.IsNullOrWhiteSpace(res.ToYear)))
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <div class=\"col-md-4 text-md-left\"><h6 class=\"badge badge-primary\">");
#nullable restore
#line 29 "F:\Projects\EMPW\Views\Home\Components\Resume\_Resume.cshtml"
                                                                                                                  Write(res.FromYear);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 29 "F:\Projects\EMPW\Views\Home\Components\Resume\_Resume.cshtml"
                                                                                                                                  Write(res.ToYear);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6></div>\r\n");
#nullable restore
#line 30 "F:\Projects\EMPW\Views\Home\Components\Resume\_Resume.cshtml"
                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <div class=\"col-12 col-md-12 pb-2 pb-md-0\">\r\n                                                    <h5 class=\"mb-3\">");
#nullable restore
#line 32 "F:\Projects\EMPW\Views\Home\Components\Resume\_Resume.cshtml"
                                                                Write(res.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                                    <p>");
#nullable restore
#line 33 "F:\Projects\EMPW\Views\Home\Components\Resume\_Resume.cshtml"
                                                  Write(res.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                                </div>\r\n                                            </div>\r\n                                        </div>\r\n");
#nullable restore
#line 37 "F:\Projects\EMPW\Views\Home\Components\Resume\_Resume.cshtml"
                                    }
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                            </div>\r\n                        </div>\r\n\r\n\r\n\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n    </div>\r\n</section>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Emamzadeh.Models.Resume>> Html { get; private set; }
    }
}
#pragma warning restore 1591
