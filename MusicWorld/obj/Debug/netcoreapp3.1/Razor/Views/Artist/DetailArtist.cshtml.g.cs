#pragma checksum "D:\PS\MusicWorld\MusicWorld\Views\Artist\DetailArtist.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b0d23a28c3c4fd6e6fcfc44ee32937c4e83f2bda"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Artist_DetailArtist), @"mvc.1.0.view", @"/Views/Artist/DetailArtist.cshtml")]
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
#line 1 "D:\PS\MusicWorld\MusicWorld\Views\_ViewImports.cshtml"
using MusicWorld;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\PS\MusicWorld\MusicWorld\Views\_ViewImports.cshtml"
using MusicWorld.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\PS\MusicWorld\MusicWorld\Views\_ViewImports.cshtml"
using MusicWorld.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\PS\MusicWorld\MusicWorld\Views\_ViewImports.cshtml"
using MusicWorld.Infrastructure;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0d23a28c3c4fd6e6fcfc44ee32937c4e83f2bda", @"/Views/Artist/DetailArtist.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"259d7e8ef5a32a9507f401aac7a4df10fb7ed49a", @"/Views/_ViewImports.cshtml")]
    public class Views_Artist_DetailArtist : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.EnvironmentTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("environment", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b0d23a28c3c4fd6e6fcfc44ee32937c4e83f2bda3342", async() => {
                WriteLiteral("\r\n    <link rel=\"stylesheet\" href=\"/css/List.css\" />\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.EnvironmentTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

<section>
    <div class=""container"">
        <div class=""img-background"">
        </div>
        <div class=""container"">
            <div class=""kenh"">
                <div class=""avt"">
                    <img src=""https://photo-resize-zmp3.zadn.vn/w240_r1x1_jpeg/avatars/e/e/e/e/eeee188a74736ed2423d4231b6b41424.jpg"">
                </div>
                <div class=""name"">
                    <a href=""#"">K-ICM</a><br />
                    <p>185k người quan tâm</p>
                </div>
            </div>
            <a href=""#"">
                <div class=""folow"">
                    <i class=""fas fa-user-plus""></i>
                    <span>Quan tâm</span>
                </div>
            </a>
        </div>
        <div class=""container"" style=""margin-top: 150px"">
            <a");
            BeginWriteAttribute("href", " href=\"", 906, "\"", 913, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                <div class=""img-song"">
                    <img src=""https://photo-resize-zmp3.zadn.vn/w240_r1x1_jpeg/cover/0/1/5/1/0151bcc5dc64312a9b6d9d2245aab54c.jpg"">
                </div>
                <div class=""song"">
                    <img src=""https://photo-resize-zmp3.zadn.vn/w240_r1x1_jpeg/cover/0/1/5/1/0151bcc5dc64312a9b6d9d2245aab54c.jpg"" style=""width: 70px;height: 70px"">
                    <div class=""name""> Ai Mang Cô Đơn Đi</div>
                    <div class=""cs"">K-ICM,APJ</div>
                </div>
            </a>
        </div>
        <div class=""info"">
            <span>
                Bản hit được dự đoán sẽ phá đảo làng nhạc V-Pop “Ai Mang Cô Đơn Đi” đã <br />chính thức có mặt trên Zing MP3.<br /><br />
                Mở ngay Zing MP3 để không bỏ lỡ ca khúc mới của K-ICM và APJ nhé!
            </span>
        </div>
    </div>
</section>




<section style=""height: 200px;margin-top: 400px"">
    <div class=""container"" style=""position: absolute;z-in");
            WriteLiteral("dex: 1;\">\r\n        <div class=\"album\">\r\n            Bài Hát\r\n        </div>\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 2025, "\"", 2032, 0);
            EndWriteAttribute();
            WriteLiteral(@">
            <div class=""play"">
                <i class=""fas fa-play""></i>
                <span>Nghe tất cả</span>
            </div>
        </a>
        <div class=""list-group"">
            <ul style=""list-style: none;"">
                <li style=""line-height: 53px"">
                    <div class=""stt"" style=""float: left;
                        margin-top: 5px;"">
                        <span>1</span>
                    </div>
                    <a");
            BeginWriteAttribute("href", " href=\"", 2507, "\"", 2514, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        <div class=""song-play"" style=""float: left;"">
                            <img src=""https://photo-resize-zmp3.zadn.vn/w94_r1x1_jpeg/cover/8/3/6/c/836cf31f036fb8f89b78cfd07cd77477.jpg"" style=""width: 40px ;height: 40px;border-radius: 5px"">
                            <span class=""name-song"">Sóng Gió</span>
                            <span class=""cs"">Jack,K-icm</span>
                        </div>
                    </a>
                    <div class=""time"">04:14</div>
                    <a");
            BeginWriteAttribute("href", " href=\"", 3045, "\"", 3052, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        <div class=""icon"" style=""float: right;line-height: 30px;"">
                            <i class=""fas fa-ellipsis-h""></i>
                        </div>
                    </a>
                </li>
                <li style=""line-height: 53px"">
                    <div class=""stt"" style=""float: left;
                        margin-top: 5px;"">
                        <span>2</span>
                    </div>
                    <a");
            BeginWriteAttribute("href", " href=\"", 3524, "\"", 3531, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        <div class=""song-play"" style=""float: left;"">
                            <img src=""https://photo-resize-zmp3.zadn.vn/w94_r1x1_jpeg/cover/8/3/6/c/836cf31f036fb8f89b78cfd07cd77477.jpg"" style=""width: 40px ;height: 40px;border-radius: 5px"">
                            <span class=""name-song"">Sóng Gió</span>
                            <span class=""cs"">Jack,K-icm</span>
                        </div>
                    </a>
                    <div class=""time"">04:14</div>
                    <a");
            BeginWriteAttribute("href", " href=\"", 4062, "\"", 4069, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        <div class=""icon"" style=""float: right;line-height: 30px;"">
                            <i class=""fas fa-ellipsis-h""></i>
                        </div>
                    </a>
                </li>
                <li style=""line-height: 53px"">
                    <div class=""stt"" style=""float: left;
                        margin-top: 5px;"">
                        <span>3</span>
                    </div>
                    <a");
            BeginWriteAttribute("href", " href=\"", 4541, "\"", 4548, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        <div class=""song-play"" style=""float: left;"">
                            <img src=""https://photo-resize-zmp3.zadn.vn/w94_r1x1_jpeg/cover/8/3/6/c/836cf31f036fb8f89b78cfd07cd77477.jpg"" style=""width: 40px ;height: 40px;border-radius: 5px"">
                            <span class=""name-song"">Sóng Gió</span>
                            <span class=""cs"">Jack,K-icm</span>
                        </div>
                    </a>
                    <div class=""time"">04:14</div>
                    <a");
            BeginWriteAttribute("href", " href=\"", 5079, "\"", 5086, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        <div class=""icon"" style=""float: right;line-height: 30px;"">
                            <i class=""fas fa-ellipsis-h""></i>
                        </div>
                    </a>
                </li>
                <li style=""line-height: 53px"">
                    <div class=""stt"" style=""float: left;
                        margin-top: 5px;"">
                        <span>4</span>
                    </div>
                    <a");
            BeginWriteAttribute("href", " href=\"", 5558, "\"", 5565, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        <div class=""song-play"" style=""float: left;"">
                            <img src=""https://photo-resize-zmp3.zadn.vn/w94_r1x1_jpeg/cover/8/3/6/c/836cf31f036fb8f89b78cfd07cd77477.jpg"" style=""width: 40px ;height: 40px;border-radius: 5px"">
                            <span class=""name-song"">Sóng Gió</span>
                            <span class=""cs"">Jack,K-icm</span>
                        </div>
                    </a>
                    <div class=""time"">04:14</div>
                    <a");
            BeginWriteAttribute("href", " href=\"", 6096, "\"", 6103, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        <div class=""icon"" style=""float: right;line-height: 30px;"">
                            <i class=""fas fa-ellipsis-h""></i>
                        </div>
                    </a>
                </li>
                <li style=""line-height: 53px"">
                    <div class=""stt"" style=""float: left;
                        margin-top: 5px;"">
                        <span>5</span>
                    </div>
                    <a");
            BeginWriteAttribute("href", " href=\"", 6575, "\"", 6582, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        <div class=""song-play"" style=""float: left;"">
                            <img src=""https://photo-resize-zmp3.zadn.vn/w94_r1x1_jpeg/cover/8/3/6/c/836cf31f036fb8f89b78cfd07cd77477.jpg"" style=""width: 40px ;height: 40px;border-radius: 5px"">
                            <span class=""name-song"">Sóng Gió</span>
                            <span class=""cs"">Jack,K-icm</span>
                        </div>
                    </a>
                    <div class=""time"">04:14</div>
                    <a");
            BeginWriteAttribute("href", " href=\"", 7113, "\"", 7120, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        <div class=""icon"" style=""float: right;line-height: 30px;"">
                            <i class=""fas fa-ellipsis-h""></i>
                        </div>
                    </a>
                </li>
            </ul>
        </div>
    </div>
</section>


<section style=""margin-top: 200px;"">
    <div class=""container"">
        <div class=""album"" style=""margin-left: 15px;"">
            Playlist
        </div>
        <div class=""row"">
            <div class=""wrapper"">
                <div class=""col-album-circle"">
                    <div class=""img-container"">
                        <a");
            BeginWriteAttribute("href", " href=\"", 7761, "\"", 7768, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            <i class=""far fa-play-circle""></i>
                            <img src=""https://photo-resize-zmp3.zadn.vn/w480_r1x1_jpeg/cover/4/2/5/3/425334e6f252b8c34d74d16177a5eb9d.jpg"">
                        </a>
                    </div>
                </div>
                <div class=""bvh-item"">
                    <div class=""bvh-item-info"">
                        <h6 class=""bvh-item-h3 text-center""><a href=""#"">Bạc Phận (Single)</a></h6>
                        <p class=""bvh-item-singer text-center "">Jack,K-Icm</p>
                    </div>
                </div>
            </div>
            <div class=""wrapper"">
                <div class=""col-album-circle"">
                    <div class=""img-container"">
                        <a");
            BeginWriteAttribute("href", " href=\"", 8558, "\"", 8565, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            <i class=""far fa-play-circle""></i>
                            <img src=""https://photo-resize-zmp3.zadn.vn/w480_r1x1_jpeg/cover/8/3/6/c/836cf31f036fb8f89b78cfd07cd77477.jpg"">
                        </a>
                    </div>
                </div>
                <div class=""bvh-item"">
                    <div class=""bvh-item-info"">
                        <h6 class=""bvh-item-h3 text-center""><a href=""#"">Sóng Gió (Single)</a></h6>
                        <p class=""bvh-item-singer text-center "">Jack,K-Icm</p>
                    </div>
                </div>
            </div>
            <div class=""wrapper"">
                <div class=""col-album-circle"">
                    <div class=""img-container"">
                        <a");
            BeginWriteAttribute("href", " href=\"", 9355, "\"", 9362, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            <i class=""far fa-play-circle""></i>
                            <img src=""https://photo-resize-zmp3.zadn.vn/w480_r1x1_jpeg/cover/8/3/6/c/836cf31f036fb8f89b78cfd07cd77477.jpg"">
                        </a>
                    </div>
                </div>
                <div class=""bvh-item"">
                    <div class=""bvh-item-info"">
                        <h6 class=""bvh-item-h3 text-center""><a href=""#"">Sóng Gió (Single)</a></h6>
                        <p class=""bvh-item-singer text-center "">Jack,K-Icm</p>
                    </div>
                </div>
            </div>
            <div class=""wrapper"">
                <div class=""col-album-circle"">
                    <div class=""img-container"">
                        <a");
            BeginWriteAttribute("href", " href=\"", 10152, "\"", 10159, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            <i class=""far fa-play-circle""></i>
                            <img src=""https://photo-resize-zmp3.zadn.vn/w480_r1x1_jpeg/cover/8/3/6/c/836cf31f036fb8f89b78cfd07cd77477.jpg"">
                        </a>
                    </div>
                </div>
                <div class=""bvh-item"">
                    <div class=""bvh-item-info"">
                        <h6 class=""bvh-item-h3 text-center""><a href=""#"">Sóng Gió (Single)</a></h6>
                        <p class=""bvh-item-singer text-center "">Jack,K-Icm</p>
                    </div>
                </div>
            </div>
            <div class=""wrapper"">
                <div class=""col-album-circle"">
                    <div class=""img-container"">
                        <a");
            BeginWriteAttribute("href", " href=\"", 10949, "\"", 10956, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            <i class=""far fa-play-circle""></i>
                            <img src=""https://photo-resize-zmp3.zadn.vn/w480_r1x1_jpeg/cover/8/3/6/c/836cf31f036fb8f89b78cfd07cd77477.jpg"">
                        </a>
                    </div>
                </div>
                <div class=""bvh-item"">
                    <div class=""bvh-item-info"">
                        <h6 class=""bvh-item-h3 text-center""><a href=""#"">Sóng Gió (Single)</a></h6>
                        <p class=""bvh-item-singer text-center "">Jack,K-Icm</p>
                    </div>
                </div>
            </div>
            <div class=""wrapper"">
                <div class=""col-album-circle"">
                    <div class=""img-container"">
                        <a");
            BeginWriteAttribute("href", " href=\"", 11746, "\"", 11753, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            <i class=""far fa-play-circle""></i>
                            <img src=""https://photo-resize-zmp3.zadn.vn/w480_r1x1_jpeg/cover/3/5/3/f/353f305006cc99e50ef00877e4135d0e.jpg"">
                        </a>
                    </div>
                </div>
                <div class=""bvh-item"">
                    <div class=""bvh-item-info"">
                        <h6 class=""bvh-item-h3 text-center""><a href=""#"">Em Gì Ơi (Single)</a></h6>
                        <p class=""bvh-item-singer text-center "">Jack,K-Icm</p>
                    </div>
                </div>
            </div>
            <div class=""wrapper"">
                <div class=""col-album-circle"">
                    <div class=""img-container"">
                        <a");
            BeginWriteAttribute("href", " href=\"", 12543, "\"", 12550, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            <i class=""far fa-play-circle""></i>
                            <img src=""https://photo-resize-zmp3.zadn.vn/w480_r1x1_jpeg/cover/7/1/b/1/71b166227f44f5a2ea975e1f2dcf4601.jpg"">
                        </a>
                    </div>
                </div>
                <div class=""bvh-item"">
                    <div class=""bvh-item-info"">
                        <h6 class=""bvh-item-h3 text-center""><a href=""#"">Con Trai Cưng (Single)</a></h6>
                        <p class=""bvh-item-singer text-center "">K-Icm,Bray</p>
                    </div>
                </div>
            </div>
            <div class=""wrapper"">
                <div class=""col-album-circle"">
                    <div class=""img-container"">
                        <a");
            BeginWriteAttribute("href", " href=\"", 13345, "\"", 13352, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            <i class=""far fa-play-circle""></i>
                            <img src=""https://photo-resize-zmp3.zadn.vn/w480_r1x1_jpeg/covers/0/c/0c2187d0f119c5c8b291b7222dc5d599_1514265433.jpg"">
                        </a>
                    </div>
                </div>
                <div class=""bvh-item"">
                    <div class=""bvh-item-info"">
                        <h6 class=""bvh-item-h3 text-center""><a href=""#"" style=""color: black"">Buồn Của Anh (Masew Mix)</a></h6>
                        <p class=""bvh-item-singer text-center "">Đạt G,K-Icm,Masew</p>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>
");
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
