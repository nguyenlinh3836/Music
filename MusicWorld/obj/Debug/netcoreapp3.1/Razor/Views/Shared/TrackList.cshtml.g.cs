#pragma checksum "C:\Users\LEGION\source\repos\MusicWorld\MusicWorld\Views\Shared\TrackList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b1d6571d438dd281f47918639ed55b077e490c3d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_TrackList), @"mvc.1.0.view", @"/Views/Shared/TrackList.cshtml")]
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
#line 1 "C:\Users\LEGION\source\repos\MusicWorld\MusicWorld\Views\_ViewImports.cshtml"
using MusicWorld;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\LEGION\source\repos\MusicWorld\MusicWorld\Views\_ViewImports.cshtml"
using MusicWorld.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b1d6571d438dd281f47918639ed55b077e490c3d", @"/Views/Shared/TrackList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7dbb94b8c662fd952bb4f745f7ed7b79253f9f0", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_TrackList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IQueryable<ArtistTrack>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("bvh-item-bg animated fadeInDown"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("position: absolute;z-index: 1; margin-bottom: 10px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/131115648_1548897918629512_5083590689306388122_n.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\Users\LEGION\source\repos\MusicWorld\MusicWorld\Views\Shared\TrackList.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            WriteLiteral(@"<div class=""box-album-hot"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-12"">
                <h2 class=""bvh-h2-title text-center"" style=""margin-bottom: 70px;""><a href=""#"">ALBUM HOT<span></span></a></h2>
            </div>
        </div> 
");
#nullable restore
#line 14 "C:\Users\LEGION\source\repos\MusicWorld\MusicWorld\Views\Shared\TrackList.cshtml"
         foreach(var p in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>\r\n        <div class=\"col-md-5ths \">\r\n            <a href=\"#\">\r\n                <div class=\"bvh-item-lnk d-block position-relative\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "b1d6571d438dd281f47918639ed55b077e490c3d5236", async() => {
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
            WriteLiteral("\r\n                    <img effect=\"opacity\" class=\"bvh-item-img animated fadeInDown2\" style=\"position: relative;z-index: 2\"");
            BeginWriteAttribute("src", " src=\"", 868, "\"", 889, 1);
#nullable restore
#line 21 "C:\Users\LEGION\source\repos\MusicWorld\MusicWorld\Views\Shared\TrackList.cshtml"
WriteAttributeValue("", 874, p.Track.UrlImg, 874, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                </div>\r\n            </a>\r\n            <div class=\"bvh-item\">\r\n                <div class=\"bvh-item-info\">\r\n                    <h6 class=\"bvh-item-h3 text-center\"><a href=\"#\">");
#nullable restore
#line 26 "C:\Users\LEGION\source\repos\MusicWorld\MusicWorld\Views\Shared\TrackList.cshtml"
                                                               Write(p.Track.TrackName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h6>\r\n                    <p class=\"bvh-item-singer author_show text-center text-truncate\">");
#nullable restore
#line 27 "C:\Users\LEGION\source\repos\MusicWorld\MusicWorld\Views\Shared\TrackList.cshtml"
                                                                                Write(p.Artist.ArtistName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 32 "C:\Users\LEGION\source\repos\MusicWorld\MusicWorld\Views\Shared\TrackList.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </div>      
</div>      
         
             
<div class=""baihathot"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-12"">
                <h2 class=""bvh-h2-title text-center"" style=""margin-bottom: 70px;""><a href=""#"">BÀI HÁT HOT<span></span></a></h2>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-md-6 "">
                <div class=""col"" style=""border-width:1px;border-bottom-style:ridge;"">
                    <a href=""#""> <img src=""img/project.jpg"" /></a>
                    <a href=""#""><p class=""p1"">Shawn Mendes</p></a>
                    <p class=""bvh-item-singer "">Lorem ipsum dolor</p>
                </div>
                <div class=""col"" style=""border-width:1px; border-bottom-style:ridge;"">
                    <a href=""#""> <img src=""img/project.jpg"" /></a>
                    <a href=""#""><p class=""p1"">Shawn Mendes</p></a>
                    <p class=""bvh-item-singer "">Lorem ipsum dolor</p>
      ");
            WriteLiteral(@"          </div>
                <div class=""col"" style=""border-width:1px; border-bottom-style:ridge;"">
                    <a href=""#""> <img src=""img/project.jpg"" /></a>
                    <a href=""#""><p class=""p1"">Shawn Mendes</p></a>
                    <p class=""bvh-item-singer "">Lorem ipsum dolor</p>
                </div>
                <div class=""col"" style=""border-width:1px; border-bottom-style:ridge;"">
                    <a href=""#""> <img src=""img/project.jpg"" /></a>
                    <a href=""#""><p class=""p1"">Shawn Mendes</p></a>
                    <p class=""bvh-item-singer "">Lorem ipsum dolor</p>
                </div>
                <div class=""col"" style=""border-width:1px; border-bottom-style:ridge;"">
                    <a href=""#""> <img src=""img/project.jpg"" /></a>
                    <a href=""#""><p class=""p1"">Shawn Mendes</p></a>
                    <p class=""bvh-item-singer "">Lorem ipsum dolor</p>
                </div>
            </div>
            <div class=""col-m");
            WriteLiteral(@"d-6 "">
                <div class=""col"" style=""border-width:1px;border-bottom-style:ridge;"">
                    <a href=""#""> <img src=""img/project.jpg"" /></a>
                    <a href=""#""><p class=""p1"">Shawn Mendes</p></a>
                    <p class=""bvh-item-singer "">Lorem ipsum dolor</p>
                </div>
                <div class=""col"" style=""border-width:1px;border-bottom-style:ridge;"">
                    <a href=""#""> <img src=""img/project.jpg"" /></a>
                    <a href=""#""><p class=""p1"">Shawn Mendes</p></a>
                    <p class=""bvh-item-singer "">Lorem ipsum dolor</p>
                </div>
                <div class=""col"" style=""border-width:1px; border-bottom-style:ridge;"">
                    <a href=""#""> <img src=""img/project.jpg"" /></a>
                    <a href=""#""><p class=""p1"">Shawn Mendes</p></a>
                    <p class=""bvh-item-singer "">Lorem ipsum dolor</p>
                </div>
                <div class=""col"" style=""border-width:1px; bor");
            WriteLiteral(@"der-bottom-style:ridge;"">
                    <a href=""#""> <img src=""img/project.jpg"" /></a>
                    <a href=""#""><p class=""p1"">Shawn Mendes</p></a>
                    <p class=""bvh-item-singer "">Lorem ipsum dolor</p>

                </div>
                <div class=""col"" style=""border-width:1px; border-bottom-style:ridge;"">
                    <a href=""#""> <img src=""img/project.jpg"" /></a>
                    <a href=""#""><p class=""p1"">Shawn Mendes</p></a>
                    <p class=""bvh-item-singer "">Lorem ipsum dolor</p>
                </div>
            </div>
        </div>
    </div>
</div>
<div class=""casihot"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-12"">
                <h2 class=""bvh-h2-title text-center"" style=""margin: 50px 0 70px 0;""><a href=""#""><span>CA SĨ HOT</span></a></h2>
            </div>
        </div>
        <div class=""row"">
            <div class=""colx "">
                <a href=""#""> <img src=""img/proje");
            WriteLiteral(@"ct.jpg"" width=""150px;"" /></a>
                <a href=""#""><h5>Shawn Mendes</h5></a>
            </div>
            <div class=""colx "">
                <a href=""#""> <img src=""img/project.jpg"" width=""150px;"" /></a>
                <a href=""#""><h5>Shawn Mendes</h5></a>
            </div>
            <div class=""colx "">
                <a href=""#""> <img src=""img/project.jpg"" width=""150px;"" /></a>
                <a href=""#""><h5>Shawn Mendes</h5></a>
            </div>
            <div class=""colx "">
                <a href=""#""> <img src=""img/project.jpg"" width=""150px;"" /></a>
                <a href=""#""><h5>Shawn Mendes</h5></a>
            </div>
            <div class=""colx "">
                <a href=""#""> <img src=""img/project.jpg"" width=""150px;"" /></a>
                <a href=""#""><h5>Shawn Mendes</h5></a>
            </div>
            <div class=""colx "">
                <a href=""#""> <img src=""img/project.jpg"" width=""150px;"" /></a>
                <a href=""#""><h5>Shawn Mendes</h5></a>
   ");
            WriteLiteral("         </div>\r\n\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IQueryable<ArtistTrack>> Html { get; private set; }
    }
}
#pragma warning restore 1591
