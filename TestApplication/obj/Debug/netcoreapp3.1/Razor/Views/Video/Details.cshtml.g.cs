#pragma checksum "C:\Users\Owner\Documents\ASP.NET\VideoProject\MovieCatalog\TestApplication\Views\Video\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f9c036833091bcf8665dd08e238436eab27b788b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Video_Details), @"mvc.1.0.view", @"/Views/Video/Details.cshtml")]
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
#line 1 "C:\Users\Owner\Documents\ASP.NET\VideoProject\MovieCatalog\TestApplication\Views\_ViewImports.cshtml"
using TestApplication.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Owner\Documents\ASP.NET\VideoProject\MovieCatalog\TestApplication\Views\_ViewImports.cshtml"
using TestApplication.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f9c036833091bcf8665dd08e238436eab27b788b", @"/Views/Video/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1438c448e9c61cd6af45cebe6c9e5bcf6689eed2", @"/Views/_ViewImports.cshtml")]
    public class Views_Video_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TestApplication.Models.Video>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"col-sm-4 col-lg-4 col-md-4\">\r\n    <div class=\"thumbnail\">\r\n        <h2>\r\n            <a>");
#nullable restore
#line 6 "C:\Users\Owner\Documents\ASP.NET\VideoProject\MovieCatalog\TestApplication\Views\Video\Details.cshtml"
          Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n        </h2>\r\n        <img");
            BeginWriteAttribute("src", " src=\"", 184, "\"", 205, 1);
#nullable restore
#line 8 "C:\Users\Owner\Documents\ASP.NET\VideoProject\MovieCatalog\TestApplication\Views\Video\Details.cshtml"
WriteAttributeValue("", 190, Model.ImageUrl, 190, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 206, "\"", 212, 0);
            EndWriteAttribute();
            WriteLiteral(" width=\"250\" height=\"500\" />\r\n        <div class=\"caption-full\">\r\n            <p>");
#nullable restore
#line 10 "C:\Users\Owner\Documents\ASP.NET\VideoProject\MovieCatalog\TestApplication\Views\Video\Details.cshtml"
          Write(Model.ShortDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p>");
#nullable restore
#line 11 "C:\Users\Owner\Documents\ASP.NET\VideoProject\MovieCatalog\TestApplication\Views\Video\Details.cshtml"
          Write(Model.LongDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <h3 class=\"pull-right\">");
#nullable restore
#line 12 "C:\Users\Owner\Documents\ASP.NET\VideoProject\MovieCatalog\TestApplication\Views\Video\Details.cshtml"
                              Write(Model.Price.ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TestApplication.Models.Video> Html { get; private set; }
    }
}
#pragma warning restore 1591
