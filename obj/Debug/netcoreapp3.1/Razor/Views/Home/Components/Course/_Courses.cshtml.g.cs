#pragma checksum "F:\Projects\EMPW\Views\Home\Components\Course\_Courses.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3816b9cbb099e5a2d0ddf94e132f869a1d57747a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Components_Course__Courses), @"mvc.1.0.view", @"/Views/Home/Components/Course/_Courses.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3816b9cbb099e5a2d0ddf94e132f869a1d57747a", @"/Views/Home/Components/Course/_Courses.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"977d3c66d905108defbba9c0d2095cbd06a28d16", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Components_Course__Courses : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Emamzadeh.Models.Course>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<section class=""section section-dark section-services"" id=""services"">
    <div class=""container"">
        <div class=""section-head"">
            <span>آموزش ها</span>
            <h2>دوره های آموزشی تدریس شده</h2>
        </div>

        <div class=""section-inner"">
            <div class=""row"">
");
#nullable restore
#line 11 "F:\Projects\EMPW\Views\Home\Components\Course\_Courses.cshtml"
                 foreach (var course in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div class=""col-md-4"">
                <div class=""blog-list d-block mb-5"">
                    <div class=""services-list mt-4 text-center"">
                        <div class=""list-icon list-icon-6 mt-1 "">
                            <i class=""lni-bar-chart""></i>
                        </div>
                        <div class=""blog-list--desc p-4"">
                            <h5 class=""mb-0 text-center"">");
#nullable restore
#line 20 "F:\Projects\EMPW\Views\Home\Components\Course\_Courses.cshtml"
                                                    Write(course.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n                            <p class=\" mt-3\">");
#nullable restore
#line 21 "F:\Projects\EMPW\Views\Home\Components\Course\_Courses.cshtml"
                                        Write(course.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                        </div>\n                    </div>\n                </div>\n                </div>\n");
#nullable restore
#line 26 "F:\Projects\EMPW\Views\Home\Components\Course\_Courses.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </div>\n        </div>\n    </div>\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Emamzadeh.Models.Course>> Html { get; private set; }
    }
}
#pragma warning restore 1591
