#pragma checksum "C:\Users\Code\source\repos\FinalProject\FromAeMVC\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "029b96d39323b8f0145badf482c3137b0967555d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
#line 1 "C:\Users\Code\source\repos\FinalProject\FromAeMVC\Views\_ViewImports.cshtml"
using FromAeMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Code\source\repos\FinalProject\FromAeMVC\Views\_ViewImports.cshtml"
using FromAeMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"029b96d39323b8f0145badf482c3137b0967555d", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b6e2554ba44838b781cfd069029ea11303caf672", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "029b96d39323b8f0145badf482c3137b0967555d3388", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <meta http-equiv=""X-UA-Compatible"" content=""ie=edge"">
    <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/animate.css/3.7.2/animate.min.css"">
    <link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css""
          integrity=""sha384-Vkoo8x4CGsO3+Hhxv8T/Q5PaXtkKtu6ug5TOeNV6gBiFeWPGFN9MuhOf23Q9Ifjh"" crossorigin=""anonymous"">
    <link rel=""stylesheet"" href=""./OwlCarousel2-2.3.4/dist/assets/owl.carousel.css"">
    <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css"">
    <script src=""https://kit.fontawesome.com/c2953f0e86.js"" crossorigin=""anonymous""></script>
    <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css"">
    <link rel=""stylesheet"" href=""/css/style.css"">

    <title>Document</title>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "029b96d39323b8f0145badf482c3137b0967555d5400", async() => {
                WriteLiteral(@"
    <!-- scroll-top -->
    <a id=""button""></a>
    <!-- scroll-top -->
    <!--Navbar-->
    <nav class=""navbar navbar-light purple lighten-4"">

        <!-- Navbar brand -->
        <a class=""navbar-brand"" href=""#"">Categories</a>

        <!-- Collapse button -->
        <button class=""navbar-toggler toggler-example purple darken-3"" type=""button"" data-toggle=""collapse""
                data-target=""#navbarSupportedContent41"" aria-controls=""navbarSupportedContent41"" aria-expanded=""false""
                aria-label=""Toggle navigation"">
            <span class=""white-text""><i class=""fas fa-bars fa-1x""></i></span>
        </button>

        <!-- Collapsible content -->
        <div class=""collapse navbar-collapse"" id=""navbarSupportedContent41"">

            <!-- Links -->
            <ul class=""navbar-nav mr-auto"">
                <li class=""nav-item active"">
                    <a class=""nav-link"" href=""#"">ELEKTRONİKA<span class=""sr-only"">(current)</span></a>
                </li>
    ");
                WriteLiteral(@"            <li class=""nav-item"">
                    <a class=""nav-link"" href=""#"">KOMPÜTERLƏR</a>
                </li>
                <li class=""nav-item"">
                    <a class=""nav-link"" href=""#"">FOTO VƏ VİDEO</a>
                </li>
                <li class=""nav-item"">
                    <a class=""nav-link"" href=""#"">MƏİŞƏT AVADANLIQLARI</a>
                </li>
                <li class=""nav-item"">
                    <a class=""nav-link"" href=""#"">PARFÜM VƏ KOSMETİKA</a>
                </li>
                <li class=""nav-item"">
                    <a class=""nav-link"" href=""#"">EV ƏŞYALARI</a>
                </li>
                <li class=""nav-item"">
                    <a class=""nav-link"" href=""#"">MODA</a>
                </li>
            </ul>
            <!-- Links -->

        </div>
        <!-- Collapsible content -->

    </nav>
    <!--/.Navbar-->


    <header class=""container-fluid"">
        <div class=""contaiener-fluid for-background"">
            <");
                WriteLiteral(@"div class=""container"">
                <div class=""head-top row"">
                    <div class=""col-md-12 col-lg-6 left col-sm-12 col-12"">
                        <ul>
                            <li><i class=""fas fa-phone""></i><a href=""/"">+994 51 488 04 42</a></li>
                            <li><i class=""fab fa-hire-a-helper""></i><a href=""/"">Yardim Merkezi</a></li>
                            <li><i class=""fas fa-clipboard-list""></i><a href=""/"">Sifarishi izlemek</a></li>
                            <li><i class=""fas fa-bell""></i><a href=""/"">Blog</a></li>
                        </ul>
                    </div>
                    <div class=""col-md-12 right right-media col-lg-6 col-sm-12 col-12"">
                        <img src=""/img/az_payment_methods.png"">
                        <select class=""selectpicker"">
                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "029b96d39323b8f0145badf482c3137b0967555d8753", async() => {
                    WriteLiteral("Azerbaijan");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "029b96d39323b8f0145badf482c3137b0967555d9799", async() => {
                    WriteLiteral("Русский");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                            </optgroup>
                        </select>

                    </div>
                </div>
            </div>
        </div>


        <div class=""container"">
            <div class=""head-middle row"">
                <div class=""col-md-4 col-sm-4 col-4 col-lg-2"">
                    <img src=""/img/logo-head.png"">
                </div>
                <div class=""col-md-4 col-sm-4 col-4 col-lg-8"">
                    <input class=""form-control form-control-sm"" type=""search""
                           placeholder=""Search for products, categories"">
                </div>
                <div class=""col-md-4 col-sm-4 col-4 col-lg-2"">
                    <a href=""/""><i class=""fas fa-user""></i></a>
                    <a href=""/""><i class=""fas fa-drum""></i></a>
                    <a href=""/""><i class=""fas fa-comments""></i></i></a>
                </div>
            </div>
        </div>
        <div class=""row categories"">
            <div class=""conta");
                WriteLiteral(@"iner-fluid head-b-fluid"">
                <div class=""container"">
                    <div class=""head-bottom row"">
                        <div class=""col-md-12"">
                            <ul class=""new-block"">
                                <li>
                                    <a");
                BeginWriteAttribute("href", " href=\"", 5382, "\"", 5389, 0);
                EndWriteAttribute();
                WriteLiteral(@">Elektronika</a>
                                    <div class=""container test"">
                                        <div class=""row"">
                                            <div class=""plus"">
                                                <div class=""container"">
                                                    <div class=""row"">
                                                        <div class=""col-md-3 left-side"">
                                                            <ul>
                                                                <li><a");
                BeginWriteAttribute("href", " href=\"", 5967, "\"", 5974, 0);
                EndWriteAttribute();
                WriteLiteral(">Telefonlar</a></li>\r\n                                                                <li><a");
                BeginWriteAttribute("href", " href=\"", 6067, "\"", 6074, 0);
                EndWriteAttribute();
                WriteLiteral(">Mobil Aksesuar</a></li>\r\n                                                                <li><a");
                BeginWriteAttribute("href", " href=\"", 6171, "\"", 6178, 0);
                EndWriteAttribute();
                WriteLiteral(@">Video Audio</a></li>

                                                            </ul>
                                                        </div>
                                                        <div class=""col-md-9 right-side position"">
                                                            <div class=""container"">
                                                                <div class=""row"">
                                                                    <div class=""col-md-3"">
                                                                        <div class=""card"" style=""width: 100%;"">
                                                                            <div class=""card-body"">
                                                                                <p class=""card-text"">Samsung</p>
                                                                            </div>
                                                                            <img class=""card-img");
                WriteLiteral(@"-top"" src=""/img/551.jpg""
                                                                                 alt=""Card image cap"">
                                                                        </div>
                                                                    </div>
                                                                    <div class=""col-md-3"">
                                                                        <div class=""card"" style=""width: 100%;"">
                                                                            <div class=""card-body"">
                                                                                <p class=""card-text"">Samsung</p>
                                                                            </div>
                                                                            <img class=""card-img-top"" src=""/img/551.jpg""
                                                                                 alt=""Card image cap"">
        ");
                WriteLiteral(@"                                                                </div>
                                                                    </div>
                                                                    <div class=""col-md-3"">
                                                                        <div class=""card"" style=""width: 100%;"">
                                                                            <div class=""card-body"">
                                                                                <p class=""card-text"">Samsung</p>
                                                                            </div>
                                                                            <img class=""card-img-top"" src=""/img/551.jpg""
                                                                                 alt=""Card image cap"">
                                                                        </div>
                                                                  ");
                WriteLiteral(@"  </div>
                                                                    <div class=""col-md-3"">
                                                                        <div class=""card"" style=""width: 100%;"">
                                                                            <div class=""card-body"">
                                                                                <p class=""card-text"">Samsung</p>
                                                                            </div>
                                                                            <img class=""card-img-top"" src=""/img/551.jpg""
                                                                                 alt=""Card image cap"">
                                                                        </div>
                                                                    </div>
                                                                    <div class=""col-md-3"">
                                    ");
                WriteLiteral(@"                                    <div class=""card"" style=""width: 100%;"">
                                                                            <div class=""card-body"">
                                                                                <p class=""card-text"">Samsung</p>
                                                                            </div>
                                                                            <img class=""card-img-top"" src=""/img/551.jpg""
                                                                                 alt=""Card image cap"">
                                                                        </div>
                                                                    </div>



                                                                </div>
                                                            </div>
                                                        </div>
                                                    </di");
                WriteLiteral(@"v>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </li>
                                ");
#nullable restore
#line 196 "C:\Users\Code\source\repos\FinalProject\FromAeMVC\Views\Shared\_Layout.cshtml"
                           Write(await Component.InvokeAsync("Menu"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                <li><a");
                BeginWriteAttribute("href", " href=\"", 11650, "\"", 11657, 0);
                EndWriteAttribute();
                WriteLiteral(">Komputerler</a></li>\r\n                                <li><a");
                BeginWriteAttribute("href", " href=\"", 11719, "\"", 11726, 0);
                EndWriteAttribute();
                WriteLiteral(">Oyunlar</a></li>\r\n                                <li><a");
                BeginWriteAttribute("href", " href=\"", 11784, "\"", 11791, 0);
                EndWriteAttribute();
                WriteLiteral(">Foto Ve Video</a></li>\r\n                                <li><a");
                BeginWriteAttribute("href", " href=\"", 11855, "\"", 11862, 0);
                EndWriteAttribute();
                WriteLiteral(">Meishet Avadanliqlari</a></li>\r\n                                <li><a");
                BeginWriteAttribute("href", " href=\"", 11934, "\"", 11941, 0);
                EndWriteAttribute();
                WriteLiteral(">Parfum ve Kosmetika</a></li>\r\n                                <li><a");
                BeginWriteAttribute("href", " href=\"", 12011, "\"", 12018, 0);
                EndWriteAttribute();
                WriteLiteral(">Ev Eshyalari</a></li>\r\n                                <li><a");
                BeginWriteAttribute("href", " href=\"", 12081, "\"", 12088, 0);
                EndWriteAttribute();
                WriteLiteral(">Moda</a></li>\r\n                            </ul>\r\n\r\n                        </div>\r\n\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </header>\r\n\r\n    ");
#nullable restore
#line 214 "C:\Users\Code\source\repos\FinalProject\FromAeMVC\Views\Shared\_Layout.cshtml"
Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n    <footer>\r\n        <div class=\"container-fluid\">\r\n            <div class=\"row border-footer\">\r\n                <div class=\"col-md-3\">\r\n                    <h4>Istifadecilere</h4>\r\n                    <ul>\r\n                        <li><a");
                BeginWriteAttribute("href", " href=\"", 12541, "\"", 12548, 0);
                EndWriteAttribute();
                WriteLiteral(">Sifarişlərim</a></li>\r\n                        <li><a");
                BeginWriteAttribute("href", " href=\"", 12603, "\"", 12610, 0);
                EndWriteAttribute();
                WriteLiteral(">Hesabım</a></li>\r\n                        <li><a");
                BeginWriteAttribute("href", " href=\"", 12660, "\"", 12667, 0);
                EndWriteAttribute();
                WriteLiteral(">Xəbərlərim</a></li>\r\n                        <li><a");
                BeginWriteAttribute("href", " href=\"", 12720, "\"", 12727, 0);
                EndWriteAttribute();
                WriteLiteral(">Zəmanət</a></li>\r\n                    </ul>\r\n                </div>\r\n                <div class=\"col-md-3\">\r\n                    <h4>Informasiya</h4>\r\n                    <ul>\r\n                        <li><a");
                BeginWriteAttribute("href", " href=\"", 12936, "\"", 12943, 0);
                EndWriteAttribute();
                WriteLiteral(">Haqqımızda</a></li>\r\n                        <li><a");
                BeginWriteAttribute("href", " href=\"", 12996, "\"", 13003, 0);
                EndWriteAttribute();
                WriteLiteral(">Bizimlə əlaqə</a></li>\r\n                        <li><a");
                BeginWriteAttribute("href", " href=\"", 13059, "\"", 13066, 0);
                EndWriteAttribute();
                WriteLiteral(">Çatdırılma</a></li>\r\n                        <li><a");
                BeginWriteAttribute("href", " href=\"", 13119, "\"", 13126, 0);
                EndWriteAttribute();
                WriteLiteral(">Ödənişlər</a></li>\r\n                        <li><a");
                BeginWriteAttribute("href", " href=\"", 13178, "\"", 13185, 0);
                EndWriteAttribute();
                WriteLiteral(">Göndərmə qaydaları</a></li>\r\n                        <li><a");
                BeginWriteAttribute("href", " href=\"", 13246, "\"", 13253, 0);
                EndWriteAttribute();
                WriteLiteral(">Xidmət şərtələri</a></li>\r\n                        <li><a");
                BeginWriteAttribute("href", " href=\"", 13312, "\"", 13319, 0);
                EndWriteAttribute();
                WriteLiteral(">Sifarış və geri qaytarma</a></li>\r\n                        <li><a");
                BeginWriteAttribute("href", " href=\"", 13386, "\"", 13393, 0);
                EndWriteAttribute();
                WriteLiteral(">Sual Cavab?</a></li>\r\n                        <li><a");
                BeginWriteAttribute("href", " href=\"", 13447, "\"", 13454, 0);
                EndWriteAttribute();
                WriteLiteral(">Axtarış</a></li>\r\n                    </ul>\r\n                </div>\r\n                <div class=\"col-md-3\">\r\n                    <h4>Əlaqə məlumatı</h4>\r\n                    <ul>\r\n                        <li><a");
                BeginWriteAttribute("href", " href=\"", 13666, "\"", 13673, 0);
                EndWriteAttribute();
                WriteLiteral(">Email:support@from.ae</a></li>\r\n                        <li><a");
                BeginWriteAttribute("href", " href=\"", 13737, "\"", 13744, 0);
                EndWriteAttribute();
                WriteLiteral(@">Mobil:+99470 311 00 00</a></li>
                    </ul>
                </div>
                <div class=""col-md-3"">
                    <h4>Yenilikler</h4>
                    <p>Yeniliklərə Abunə Ol:</p>
                    <div class=""form-group"">
                        <input type=""email"" class=""form-control"" id=""exampleInputEmail1"" aria-describedby=""emailHelp""
                               placeholder=""Enter email"">
                    </div>
                    <button class=""btn btn-dark"">Abune ol</button>
                </div>
            </div>
            <div class=""row social"">
                <ul class=""socials"">
                    <li><a href=""/""><img src=""/img/social/google.png""></a></li>
                    <li><a href=""/""><img src=""/img/social/facebook.png""></a></li>
                    <li><a href=""/""><img src=""/img/social/twitter.png""></a></li>
                    <li><a href=""/""><img src=""/img/social/watsup.png""></a></li>
                    <li><a href=""/""><img ");
                WriteLiteral(@"src=""/img/social/vk.png""></a></li>
                    <li><a href=""/""><img src=""/img/social/instagram.png""></a></li>
                </ul>
            </div>
            <div class=""row fooot"">
                <div class=""foot-end"">
                    <ul>
                        <li><a href=""/"">Axtarış sorğuları</a></li>
                        <li><a href=""/"">Etrafli Axtarish</a></li>
                        <li><a href=""/"">Sifarış və geri qaytarma</a></li>
                        <li><a href=""/"">Bizimlə əlaqə</a></li>
                    </ul>
                </div>
            </div>
        </div>

    </footer>



    <script src=""https://cdnjs.cloudflare.com/ajax/libs/jquery/3.4.1/jquery.min.js""></script>
    <script src=""https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.min.js""
            integrity=""sha384-wfSDF2E50Y2D1uUdj0O3uMBJnjuUD4Ih7YwaYd1iqfktj0Uod8GCExl3Og8ifwB6""
            crossorigin=""anonymous""></script>
    <script src=""/OwlCarousel2-2.3.4/dist/owl");
                WriteLiteral(".carousel.js\"></script>\r\n    <script src=\"/OwlCarousel2-2.3.4/dist/owl.carousel.min.js\"></script>\r\n    <script src=\"/js/script.js\"></script>\r\n    <script>\r\n    </script>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</html>");
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