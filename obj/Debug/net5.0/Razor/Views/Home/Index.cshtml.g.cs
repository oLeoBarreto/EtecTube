#pragma checksum "C:\Users\etec\Desktop\EtecTube\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ac7d2bd1f806e9f26e3abe451c28779492b50421"
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
#line 1 "C:\Users\etec\Desktop\EtecTube\Views\_ViewImports.cshtml"
using EtecTube;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\etec\Desktop\EtecTube\Views\_ViewImports.cshtml"
using EtecTube.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac7d2bd1f806e9f26e3abe451c28779492b50421", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac2e2f85bdd336411d8c380468e501f35135f790", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EtecTube.Models.Video>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/index.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\etec\Desktop\EtecTube\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Styles", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ac7d2bd1f806e9f26e3abe451c28779492b504214017", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral("\r\n<div class=\"videos\">\r\n");
#nullable restore
#line 11 "C:\Users\etec\Desktop\EtecTube\Views\Home\Index.cshtml"
     foreach (var video in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <!-- V??deo -->\r\n        <div class=\"video\">\r\n            <div class=\"thumbnail\">\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 342, "\"", 377, 1);
#nullable restore
#line 16 "C:\Users\etec\Desktop\EtecTube\Views\Home\Index.cshtml"
WriteAttributeValue("", 348, Url.Content(video.Thumbnail), 348, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 378, "\"", 395, 1);
#nullable restore
#line 16 "C:\Users\etec\Desktop\EtecTube\Views\Home\Index.cshtml"
WriteAttributeValue("", 384, video.Name, 384, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n            </div>\r\n            <div class=\"details\">\r\n                <div class=\"author\">\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 518, "\"", 566, 1);
#nullable restore
#line 20 "C:\Users\etec\Desktop\EtecTube\Views\Home\Index.cshtml"
WriteAttributeValue("", 524, Url.Content(video.Channel.ChannelPicture), 524, 42, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 567, "\"", 592, 1);
#nullable restore
#line 20 "C:\Users\etec\Desktop\EtecTube\Views\Home\Index.cshtml"
WriteAttributeValue("", 573, video.Channel.Name, 573, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                </div>\r\n                <div class=\"title\">\r\n                    <h3>");
#nullable restore
#line 23 "C:\Users\etec\Desktop\EtecTube\Views\Home\Index.cshtml"
                   Write(video.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 723, "\"", 730, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 24 "C:\Users\etec\Desktop\EtecTube\Views\Home\Index.cshtml"
                          Write(video.Channel.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                    <span>3M Visualiza????es ??? ");
#nullable restore
#line 25 "C:\Users\etec\Desktop\EtecTube\Views\Home\Index.cshtml"
                                        Write(video.PassedTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 29 "C:\Users\etec\Desktop\EtecTube\Views\Home\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EtecTube.Models.Video>> Html { get; private set; }
    }
}
#pragma warning restore 1591
