#pragma checksum "C:\Users\user\Desktop\ItBrains\ItBrains\Views\Gallery\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eb649793bc79763d30de03e6a71b41bf8ab04aea"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Gallery_Index), @"mvc.1.0.view", @"/Views/Gallery/Index.cshtml")]
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
#line 1 "C:\Users\user\Desktop\ItBrains\ItBrains\Views\_ViewImports.cshtml"
using ItBrains;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\user\Desktop\ItBrains\ItBrains\Views\_ViewImports.cshtml"
using ItBrains.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\user\Desktop\ItBrains\ItBrains\Views\_ViewImports.cshtml"
using ItBrains.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\user\Desktop\ItBrains\ItBrains\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb649793bc79763d30de03e6a71b41bf8ab04aea", @"/Views/Gallery/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"34de1fc2e7b7ee84dec4b7b4e715024e9923e85d", @"/Views/_ViewImports.cshtml")]
    public class Views_Gallery_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Gallery>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("myImg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", "~/src/css/secondary.css", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LinkTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\user\Desktop\ItBrains\ItBrains\Views\Gallery\Index.cshtml"
  
    var culture = System.Globalization.CultureInfo.CurrentCulture.Name;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<!-- *********************     Main  Start     ************************ -->
<main>
    <!-- *********************       Gallery  Start     ************************ -->
    <section class=""gallery"">
        <div class=""container"">
            <div class=""row align-items-center justify-content-center"">
                <div class=""gallery-title"">

");
#nullable restore
#line 14 "C:\Users\user\Desktop\ItBrains\ItBrains\Views\Gallery\Index.cshtml"
                     if (culture == "az")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p>Qalereya</p>\r\n                        <p class=\"gallery-description font-weight-bold\">IT BRAINS A??L??S??</p>\r\n");
#nullable restore
#line 18 "C:\Users\user\Desktop\ItBrains\ItBrains\Views\Gallery\Index.cshtml"
                    }
                    else if (culture == "en")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p>Gallery</p>\r\n                        <p class=\"gallery-description font-weight-bold\">IT BRAINS FAMILY</p>\r\n");
#nullable restore
#line 23 "C:\Users\user\Desktop\ItBrains\ItBrains\Views\Gallery\Index.cshtml"
                    }
                    else if (culture == "ru")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p>Qalareya</p>\r\n                        <p class=\"gallery-description font-weight-bold\">?????????? IT BRAINS </p>\r\n");
#nullable restore
#line 28 "C:\Users\user\Desktop\ItBrains\ItBrains\Views\Gallery\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n            <div class=\"row align-items-center justify-content-center\">\r\n                <div class=\"gallery-name\">\r\n");
#nullable restore
#line 33 "C:\Users\user\Desktop\ItBrains\ItBrains\Views\Gallery\Index.cshtml"
                     if (culture == "az")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <a style=\"cursor:pointer\" id=\"teacher\">M????LL??ML??R</a>\r\n                        <a style=\"cursor:pointer\" id=\"student\">T??L??B??L??R</a>\r\n");
#nullable restore
#line 37 "C:\Users\user\Desktop\ItBrains\ItBrains\Views\Gallery\Index.cshtml"
                    }
                    else if (culture == "en")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <a style=\"cursor:pointer\" id=\"teacher\">TEACHERS</a>\r\n                        <a style=\"cursor:pointer\" id=\"student\">STUDENTS</a>\r\n");
#nullable restore
#line 42 "C:\Users\user\Desktop\ItBrains\ItBrains\Views\Gallery\Index.cshtml"
                    }
                    else if (culture == "ru")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <a style=\"cursor:pointer\"  id=\"teacher\">??????????????</a>\r\n                        <a style=\"cursor:pointer\" id=\"student\">??????????????</a>\r\n");
#nullable restore
#line 47 "C:\Users\user\Desktop\ItBrains\ItBrains\Views\Gallery\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"row align-items-center justify-content-center\" id=\"teacherImages\">\r\n");
#nullable restore
#line 52 "C:\Users\user\Desktop\ItBrains\ItBrains\Views\Gallery\Index.cshtml"
                 foreach (var item in Model.Where(x => x.IsTeacher))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-lg-3 col-md-4 col-sm-6\">\r\n                        <div class=\"gallery-image\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "eb649793bc79763d30de03e6a71b41bf8ab04aea9164", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2432, "~/src/img/gallery/", 2432, 18, true);
#nullable restore
#line 56 "C:\Users\user\Desktop\ItBrains\ItBrains\Views\Gallery\Index.cshtml"
AddHtmlAttributeValue("", 2450, item.Image, 2450, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 59 "C:\Users\user\Desktop\ItBrains\ItBrains\Views\Gallery\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            </div>\r\n            <div class=\"row align-items-center justify-content-center\" id=\"studentImages\">\r\n");
#nullable restore
#line 64 "C:\Users\user\Desktop\ItBrains\ItBrains\Views\Gallery\Index.cshtml"
                 foreach (var item in Model.Where(x => !x.IsTeacher))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-lg-3 col-md-4 col-sm-6\">\r\n                        <div class=\"gallery-image\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "eb649793bc79763d30de03e6a71b41bf8ab04aea11616", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2926, "~/src/img/gallery/", 2926, 18, true);
#nullable restore
#line 68 "C:\Users\user\Desktop\ItBrains\ItBrains\Views\Gallery\Index.cshtml"
AddHtmlAttributeValue("", 2944, item.Image, 2944, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 71 "C:\Users\user\Desktop\ItBrains\ItBrains\Views\Gallery\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </div>
        </div>
    </section>
    <!-- *********************     Gallery  end     ************************ -->
    <!-- ******************************************************************** -->
</main>
<!-- *********************      Main  End     ************************ -->
");
            DefineSection("Css", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "eb649793bc79763d30de03e6a71b41bf8ab04aea13920", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LinkTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
#nullable restore
#line 81 "C:\Users\user\Desktop\ItBrains\ItBrains\Views\Gallery\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper.Href = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
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
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
 <script>
    let imgs = document.querySelectorAll("".gallery-image img"");



    let modalCarousel = document.getElementById(""modal-product-images"");

    //**************      change main img    ***************





    //***************    Media 700px function    ***************/
    function myFunction(x) {
        if (x.matches) {
            modalCarousel.remove()
        }
        else {
            let closeModalCarousel = document.getElementById(""close-modal-product-images"");
            let carouselImgs = document.querySelectorAll("".bg-img"");
            let carouselItems = document.querySelectorAll("".carousel-item"");
            $('.carousel.myModal').carousel({
                interval: false,
                touch: false
            })


            imgs.forEach((element) => {
                element.addEventListener(""click"", function () {
                    console.log(""ds"")
                    modalCarousel.style.opacity = 1
                    modalCarousel.st");
                WriteLiteral(@"yle.display = ""block""
                    carouselItems.forEach((e) => {
                        if (e.classList.contains(""active"")) {
                            e.classList.remove(""active"")
                        }
                        if (element.src === e.children[0].children[0].src) {
                            e.classList.add(""active"")
                        }
                    });
                })
            });



            //****************    close Modal    ******************
            closeModalCarousel.addEventListener(""click"", function () {
                modalCarousel.style.opacity = 0
                modalCarousel.style.display = ""none""
            })


            // ****************    Helper Function    *****************


        }
    }

    var x = window.matchMedia(""(max-width: 340px)"")
    myFunction(x) // Call listener function at run time
    x.addListener(myFunction)






</script>
");
            }
            );
            DefineSection("Components", async() => {
                WriteLiteral(@"
    <div id=""modal-product-images"">
        <div class=""container-fluid"">
            <div class=""row"">
                <div class=""col-12"">
                    <div class=""myModal row justify-content-center"">
                        <div class=""col-lg-6 col-md-8 col-sm-10 col-12"">
                            <div id=""carouselExampleFade""
                                 class=""carousel slide carousel-fade myModal""
                                 data-ride=""carousel""
                                 data-interval=""false"">
                                <div class=""carousel-inner"" id=""carousel-inner"">
");
#nullable restore
#line 166 "C:\Users\user\Desktop\ItBrains\ItBrains\Views\Gallery\Index.cshtml"
                                     foreach (Gallery item in Model.Where(x => x.IsTeacher))
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <div class=\"carousel-item \">\r\n                                            <div class=\"bg-img\">\r\n                                                <img");
                BeginWriteAttribute("src", " src=\"", 6441, "\"", 6474, 2);
                WriteAttributeValue("", 6447, "src/img/gallery/", 6447, 16, true);
#nullable restore
#line 170 "C:\Users\user\Desktop\ItBrains\ItBrains\Views\Gallery\Index.cshtml"
WriteAttributeValue("", 6463, item.Image, 6463, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("\r\n                                                     class=\"zoom-images\"");
                BeginWriteAttribute("alt", "\r\n                                                     alt=\"", 6549, "\"", 6609, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                            </div>\r\n\r\n                                        </div>\r\n");
#nullable restore
#line 176 "C:\Users\user\Desktop\ItBrains\ItBrains\Views\Gallery\Index.cshtml"

                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 178 "C:\Users\user\Desktop\ItBrains\ItBrains\Views\Gallery\Index.cshtml"
                                     foreach (Gallery item in Model.Where(x => !x.IsTeacher))
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <div class=\"carousel-item \">\r\n                                            <div class=\"bg-img\">\r\n                                                <img");
                BeginWriteAttribute("src", " src=\"", 7080, "\"", 7113, 2);
                WriteAttributeValue("", 7086, "src/img/gallery/", 7086, 16, true);
#nullable restore
#line 182 "C:\Users\user\Desktop\ItBrains\ItBrains\Views\Gallery\Index.cshtml"
WriteAttributeValue("", 7102, item.Image, 7102, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("\r\n                                                     class=\"zoom-images\"");
                BeginWriteAttribute("alt", "\r\n                                                     alt=\"", 7188, "\"", 7248, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                            </div>\r\n\r\n                                        </div>\r\n");
#nullable restore
#line 188 "C:\Users\user\Desktop\ItBrains\ItBrains\Views\Gallery\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                </div>
                            </div>
                        </div>
                        <a class=""carousel-control-prev""
                           href=""#carouselExampleFade""
                           role=""button""
                           data-slide=""prev"">
                            <span class=""carousel-control-prev-icon""
                                  aria-hidden=""true""></span>
                            <span class=""sr-only"">Previous</span>
                        </a>
                        <a class=""carousel-control-next""
                           href=""#carouselExampleFade""
                           role=""button""
                           data-slide=""next"">
                            <span class=""carousel-control-next-icon""
                                  aria-hidden=""true""></span>
                            <span class=""sr-only"">Next</span>
                        </a>
                        <div class=""close-btn"" id=""clo");
                WriteLiteral("se-modal-product-images\">\r\n                            <i class=\"fas fa-times\" style=\"color: white\"></i>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Gallery>> Html { get; private set; }
    }
}
#pragma warning restore 1591
