#pragma checksum "C:\Users\matgi\source\repos\TestApplication\TestApplication\Views\Video\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f7170d25df74d93e6eb55fcf617fa6e9d74bac7f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Video_List), @"mvc.1.0.view", @"/Views/Video/List.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f7170d25df74d93e6eb55fcf617fa6e9d74bac7f", @"/Views/Video/List.cshtml")]
    public class Views_Video_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TestApplication.ViewModels.VideoListViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n");
#nullable restore
#line 7 "C:\Users\matgi\source\repos\TestApplication\TestApplication\Views\Video\List.cshtml"
 foreach (var video in Model.Videos)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1>");
#nullable restore
#line 9 "C:\Users\matgi\source\repos\TestApplication\TestApplication\Views\Video\List.cshtml"
   Write(video.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n    <h2>");
#nullable restore
#line 10 "C:\Users\matgi\source\repos\TestApplication\TestApplication\Views\Video\List.cshtml"
   Write(video.ShortDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n    <h2>");
#nullable restore
#line 11 "C:\Users\matgi\source\repos\TestApplication\TestApplication\Views\Video\List.cshtml"
   Write(video.Price.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n");
#nullable restore
#line 12 "C:\Users\matgi\source\repos\TestApplication\TestApplication\Views\Video\List.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TestApplication.ViewModels.VideoListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591