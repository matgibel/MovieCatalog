#pragma checksum "C:\Users\matgi\source\repos\TestApplication\TestApplication\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5d9ef38b77bb91e06f1b0541bb89d17611f371d2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\matgi\source\repos\TestApplication\TestApplication\Views\_ViewImports.cshtml"
using TestApplication.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d9ef38b77bb91e06f1b0541bb89d17611f371d2", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b6e47e647d5326614cd8a34dfab6aa8cb3a06570", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VideoListViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"row\">\r\n");
#nullable restore
#line 3 "C:\Users\matgi\source\repos\TestApplication\TestApplication\Views\Home\Index.cshtml"
     foreach(var video in Model.Videos)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-sm-4 col-lg-4 col-md-4\">\r\n            <div class=\"thumbnail\">\r\n                <h2>\r\n                    <a>");
#nullable restore
#line 8 "C:\Users\matgi\source\repos\TestApplication\TestApplication\Views\Home\Index.cshtml"
                  Write(video.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                </h2>\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 287, "\"", 308, 1);
#nullable restore
#line 10 "C:\Users\matgi\source\repos\TestApplication\TestApplication\Views\Home\Index.cshtml"
WriteAttributeValue("", 293, video.ImageUrl, 293, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 309, "\"", 315, 0);
            EndWriteAttribute();
            WriteLiteral(" width=\"150\" height=\"400\"/>\r\n                <div class=\"caption\">\r\n                    <p>");
#nullable restore
#line 12 "C:\Users\matgi\source\repos\TestApplication\TestApplication\Views\Home\Index.cshtml"
                  Write(video.ShortDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <h3 class=\"pull-right\">");
#nullable restore
#line 13 "C:\Users\matgi\source\repos\TestApplication\TestApplication\Views\Home\Index.cshtml"
                                      Write(video.Price.ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 17 "C:\Users\matgi\source\repos\TestApplication\TestApplication\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VideoListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
