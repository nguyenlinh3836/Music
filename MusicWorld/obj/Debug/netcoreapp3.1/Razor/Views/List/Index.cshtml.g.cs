#pragma checksum "C:\Users\LEGION\source\repos\MusicWorld\MusicWorld\Views\List\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "013761a74a545bbf509dd83d9add92bea2d04f2e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_List_Index), @"mvc.1.0.view", @"/Views/List/Index.cshtml")]
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
#nullable restore
#line 3 "C:\Users\LEGION\source\repos\MusicWorld\MusicWorld\Views\_ViewImports.cshtml"
using MusicWorld.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\LEGION\source\repos\MusicWorld\MusicWorld\Views\_ViewImports.cshtml"
using MusicWorld.Infrastructure;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"013761a74a545bbf509dd83d9add92bea2d04f2e", @"/Views/List/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"259d7e8ef5a32a9507f401aac7a4df10fb7ed49a", @"/Views/_ViewImports.cshtml")]
    public class Views_List_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("environment", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "013761a74a545bbf509dd83d9add92bea2d04f2e3412", async() => {
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
            BeginWriteAttribute("href", " href=\"", 904, "\"", 911, 0);
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
            BeginWriteAttribute("href", " href=\"", 2023, "\"", 2030, 0);
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
            BeginWriteAttribute("href", " href=\"", 2505, "\"", 2512, 0);
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
            BeginWriteAttribute("href", " href=\"", 3043, "\"", 3050, 0);
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
            BeginWriteAttribute("href", " href=\"", 3522, "\"", 3529, 0);
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
            BeginWriteAttribute("href", " href=\"", 4060, "\"", 4067, 0);
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
            BeginWriteAttribute("href", " href=\"", 4539, "\"", 4546, 0);
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
            BeginWriteAttribute("href", " href=\"", 5077, "\"", 5084, 0);
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
            BeginWriteAttribute("href", " href=\"", 5556, "\"", 5563, 0);
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
            BeginWriteAttribute("href", " href=\"", 6094, "\"", 6101, 0);
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
            BeginWriteAttribute("href", " href=\"", 6573, "\"", 6580, 0);
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
            BeginWriteAttribute("href", " href=\"", 7111, "\"", 7118, 0);
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
            BeginWriteAttribute("href", " href=\"", 7759, "\"", 7766, 0);
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
            BeginWriteAttribute("href", " href=\"", 8556, "\"", 8563, 0);
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
            BeginWriteAttribute("href", " href=\"", 9353, "\"", 9360, 0);
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
            BeginWriteAttribute("href", " href=\"", 10150, "\"", 10157, 0);
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
            BeginWriteAttribute("href", " href=\"", 10947, "\"", 10954, 0);
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
            BeginWriteAttribute("href", " href=\"", 11744, "\"", 11751, 0);
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
            BeginWriteAttribute("href", " href=\"", 12541, "\"", 12548, 0);
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
            BeginWriteAttribute("href", " href=\"", 13343, "\"", 13350, 0);
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




<section class=""section2"" style=""margin-top: 70px;"">
    <div class=""container"">
        <div class=""album"" style=""margin-left: 15px;"">
            Mv
        </div>
        <div class=""row"">
            <div class=""wrapper"">
                <div class=""col-album-circle"">
                    <");
            WriteLiteral("div class=\"img-container\">\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 14429, "\"", 14436, 0);
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
            BeginWriteAttribute("href", " href=\"", 15226, "\"", 15233, 0);
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
            BeginWriteAttribute("href", " href=\"", 16023, "\"", 16030, 0);
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
            BeginWriteAttribute("href", " href=\"", 16820, "\"", 16827, 0);
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
            BeginWriteAttribute("href", " href=\"", 17617, "\"", 17624, 0);
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
            BeginWriteAttribute("href", " href=\"", 18414, "\"", 18421, 0);
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
            BeginWriteAttribute("href", " href=\"", 19211, "\"", 19218, 0);
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
            BeginWriteAttribute("href", " href=\"", 20013, "\"", 20020, 0);
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


<section class=""section2"" style=""margin-top: 70px;"">
    <div class=""container"">
        <div class=""album"" style=""margin-left: 15px;"">
            Đề Xuất Bởi Nghệ Sĩ
        </div>
        <div class=""row"">
            <div class=""wrapper"">
                <div class=""col-album-circle"">
        ");
            WriteLiteral("            <div class=\"img-container\">\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 21112, "\"", 21119, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            <i class=""far fa-play-circle""></i>
                            <img src=""https://photo-resize-zmp3.zadn.vn/w480_r1x1_jpeg/cover/f/c/3/a/fc3aa71eeea30d23eb7c36bca91cd891.jpg"">
                        </a>
                    </div>
                </div>
                <div class=""bvh-item"">
                    <div class=""bvh-item-info"">
                        <h6 class=""bvh-item-h3 text-center""><a href=""#"">Những Bài Hát Hay Nhất Của K-ICM</a></h6>
                        <p class=""bvh-item-singer text-center ""></p>
                    </div>
                </div>
            </div>
            <div class=""wrapper"">
                <div class=""col-album-circle"">
                    <div class=""img-container"">
                        <a");
            BeginWriteAttribute("href", " href=\"", 21914, "\"", 21921, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            <i class=""far fa-play-circle""></i>
                            <img src=""https://photo-resize-zmp3.zadn.vn/w480_r1x1_jpeg/cover/7/5/4/0/7540fbc87a23ac44fb5b00b08db6a4b0.jpg"">
                        </a>
                    </div>
                </div>
                <div class=""bvh-item"">
                    <div class=""bvh-item-info"">
                        <h6 class=""bvh-item-h3 text-center""><a href=""#"">Những bài hát gây nghiện</a></h6>
                        <p class=""bvh-item-singer text-center ""></p>
                    </div>
                </div>
            </div>
            <div class=""wrapper"">
                <div class=""col-album-circle"">
                    <div class=""img-container"">
                        <a");
            BeginWriteAttribute("href", " href=\"", 22708, "\"", 22715, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            <i class=""far fa-play-circle""></i>
                            <img src=""https://photo-resize-zmp3.zadn.vn/w480_r1x1_jpeg/cover/3/c/9/2/3c922992b7b64f40cc1a9f176c685f04.jpg"">
                        </a>
                    </div>
                </div>
                <div class=""bvh-item"">
                    <div class=""bvh-item-info"">
                        <h6 class=""bvh-item-h3 text-center""><a href=""#"">V-Pop Nhạc Mới nổi bật</a></h6>
                        <p class=""bvh-item-singer text-center ""></p>
                    </div>
                </div>
            </div>
            <div class=""wrapper"">
                <div class=""col-album-circle"">
                    <div class=""img-container"">
                        <a");
            BeginWriteAttribute("href", " href=\"", 23500, "\"", 23507, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            <i class=""far fa-play-circle""></i>
                            <img src=""https://photo-resize-zmp3.zadn.vn/w480_r1x1_jpeg/cover/0/1/4/7/01477521b69e1921bafe110a878aafdc.jpg"">
                        </a>
                    </div>
                </div>
                <div class=""bvh-item"">
                    <div class=""bvh-item-info"">
                        <h6 class=""bvh-item-h3 text-center""><a href=""#"">Nhạc Việt Nghe Nhiều 2020</a></h6>
                        <p class=""bvh-item-singer text-center ""></p>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>






<section>
    <div class=""container"" style=""margin:100px 0px"">
        <div class=""album"" style=""margin-left: 15px;"">
            Nghệ sĩ liên quan
        </div>
        <div class=""row"">
            <div class=""wrapper2"">
                <div class=""col-album-circle"">
                    <div class=""img-container2"">
              ");
            WriteLiteral("          <a");
            BeginWriteAttribute("href", " href=\"", 24544, "\"", 24551, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            <img src=""https://photo-resize-zmp3.zadn.vn/w240_r1x1_jpeg/avatars/e/9/e/9/e9e9cef9599f670e6df227c87debc2fd.jpg"">
                        </a>
                    </div>
                </div>
                <div class=""bvh-item"">
                    <div class=""bvh-item-info"">
                        <h6 class=""bvh-item-h3 text-center""><a href=""#"">Wonder</a></h6>
                        <p class=""bvh-item-singer text-center "">72K quan tâm</p>
                    </div>
                </div>
            </div>
            <div class=""wrapper2"">
                <div class=""col-album-circle"">
                    <div class=""img-container2"">
                        <a");
            BeginWriteAttribute("href", " href=\"", 25272, "\"", 25279, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            <img src=""https://photo-resize-zmp3.zadn.vn/w240_r1x1_jpeg/avatars/5/4/5/f/545f634d91105696439b1bf7cee5341b.jpg"">
                        </a>
                    </div>
                </div>
                <div class=""bvh-item"">
                    <div class=""bvh-item-info"">
                        <h6 class=""bvh-item-h3 text-center""><a href=""#"">Wonder</a></h6>
                        <p class=""bvh-item-singer text-center "">72K quan tâm</p>
                    </div>
                </div>
            </div>
            <div class=""wrapper2"">
                <div class=""col-album-circle"">
                    <div class=""img-container2"">
                        <a");
            BeginWriteAttribute("href", " href=\"", 26000, "\"", 26007, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            <img src=""https://photo-resize-zmp3.zadn.vn/w240_r1x1_jpeg/avatars/c/1/4/0/c140ebb6799391799b29a8eabae217f5.jpg"">
                        </a>
                    </div>
                </div>
                <div class=""bvh-item"">
                    <div class=""bvh-item-info"">
                        <h6 class=""bvh-item-h3 text-center""><a href=""#"">Wonder</a></h6>
                        <p class=""bvh-item-singer text-center "">72K quan tâm</p>
                    </div>
                </div>
            </div>
            <div class=""wrapper2"">
                <div class=""col-album-circle"">
                    <div class=""img-container2"">
                        <a");
            BeginWriteAttribute("href", " href=\"", 26728, "\"", 26735, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            <img src=""https://photo-resize-zmp3.zadn.vn/w240_r1x1_jpeg/avatars/5/1/5/c/515c86b8f10cd8e44fa77f195d0c286f.jpg"">
                        </a>
                    </div>
                </div>
                <div class=""bvh-item"">
                    <div class=""bvh-item-info"">
                        <h6 class=""bvh-item-h3 text-center""><a href=""#"">Wonder</a></h6>
                        <p class=""bvh-item-singer text-center "">72K quan tâm</p>
                    </div>
                </div>
            </div>
            <div class=""wrapper2"">
                <div class=""col-album-circle"">
                    <div class=""img-container2"">
                        <a");
            BeginWriteAttribute("href", " href=\"", 27456, "\"", 27463, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            <img src=""https://photo-resize-zmp3.zadn.vn/w240_r1x1_jpeg/avatars/8/9/89338ce53557eaefbd61fcee4f9b901b_1512444828.jpg"" style=""border-radius: 100%;"">
                        </a>
                    </div>
                </div>
                <div class=""bvh-item"">
                    <div class=""bvh-item-info"">
                        <h6 class=""bvh-item-h3 text-center""><a href=""#"">Wonder</a></h6>
                        <p class=""bvh-item-singer text-center "">72K quan tâm</p>
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
