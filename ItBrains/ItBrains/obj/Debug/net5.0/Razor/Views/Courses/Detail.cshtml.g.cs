#pragma checksum "C:\Users\user\Desktop\HomeTask\ItBrains\ItBrains\Views\Courses\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a1d21e874c6f916e27d63cd6da850e0de86bcb6b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Courses_Detail), @"mvc.1.0.view", @"/Views/Courses/Detail.cshtml")]
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
#line 1 "C:\Users\user\Desktop\HomeTask\ItBrains\ItBrains\Views\_ViewImports.cshtml"
using ItBrains;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\user\Desktop\HomeTask\ItBrains\ItBrains\Views\_ViewImports.cshtml"
using ItBrains.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\user\Desktop\HomeTask\ItBrains\ItBrains\Views\_ViewImports.cshtml"
using ItBrains.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\user\Desktop\HomeTask\ItBrains\ItBrains\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1d21e874c6f916e27d63cd6da850e0de86bcb6b", @"/Views/Courses/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"34de1fc2e7b7ee84dec4b7b4e715024e9923e85d", @"/Views/_ViewImports.cshtml")]
    public class Views_Courses_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Service>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Courses", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Registration", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("itBtn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", "~/src/css/secondary.css", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LinkTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\user\Desktop\HomeTask\ItBrains\ItBrains\Views\Courses\Detail.cshtml"
  
    var culture = System.Globalization.CultureInfo.CurrentCulture.Name;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<!-- *********************     Main  Start     ************************ -->
<main>
    <section id=""service-detail"" class=""service-detail"">
        <div class=""container"">
            <div class=""row align-items-center justify-content-center"">
                <div class=""col-lg-7 col-md-10 ser-images"">
                    <div class=""row"">
");
#nullable restore
#line 12 "C:\Users\user\Desktop\HomeTask\ItBrains\ItBrains\Views\Courses\Detail.cshtml"
                         foreach (ServiceImage item in Model.ServiceImages)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"col-6 mt-3\">\r\n                                <div class=\"ser-image\">\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a1d21e874c6f916e27d63cd6da850e0de86bcb6b6728", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 706, "~/src/img/courses/", 706, 18, true);
#nullable restore
#line 16 "C:\Users\user\Desktop\HomeTask\ItBrains\ItBrains\Views\Courses\Detail.cshtml"
AddHtmlAttributeValue("", 724, item.Image, 724, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 19 "C:\Users\user\Desktop\HomeTask\ItBrains\ItBrains\Views\Courses\Detail.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-lg-5 col-md-10 ser-details\">\r\n                    <div class=\"ser-detail\">\r\n");
#nullable restore
#line 25 "C:\Users\user\Desktop\HomeTask\ItBrains\ItBrains\Views\Courses\Detail.cshtml"
                         if (culture == "az")
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <h1 class=\"ser-head\">");
#nullable restore
#line 27 "C:\Users\user\Desktop\HomeTask\ItBrains\ItBrains\Views\Courses\Detail.cshtml"
                                            Write(Model.AzServiceName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                            <div class=\"ser-description\">\r\n                                ");
#nullable restore
#line 29 "C:\Users\user\Desktop\HomeTask\ItBrains\ItBrains\Views\Courses\Detail.cshtml"
                           Write(Html.Raw(Model.ServiceDetail.AzDescription));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n                            <div class=\"service-details\">\r\n                                <div class=\"detail d-flex align-items-center\">\r\n                                    ");
#nullable restore
#line 33 "C:\Users\user\Desktop\HomeTask\ItBrains\ItBrains\Views\Courses\Detail.cshtml"
                               Write(Html.Raw(Model.ServiceDetail.TagIcon));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    <div class=\"det-text\">");
#nullable restore
#line 34 "C:\Users\user\Desktop\HomeTask\ItBrains\ItBrains\Views\Courses\Detail.cshtml"
                                                     Write(Model.ServiceDetail.AzTagDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                                </div>\r\n                                <div class=\"detail d-flex\">\r\n                                    <i class=\"fas fa-calendar-alt det-icon\"></i>\r\n                                    <div class=\"det-text\">");
#nullable restore
#line 38 "C:\Users\user\Desktop\HomeTask\ItBrains\ItBrains\Views\Courses\Detail.cshtml"
                                                     Write(Model.ServiceDetail.AzDateDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                                </div>\r\n                                <div class=\"detail d-flex\">\r\n                                    <i class=\"fas fa-clock det-icon\"></i>\r\n                                    <div class=\"det-text\">");
#nullable restore
#line 42 "C:\Users\user\Desktop\HomeTask\ItBrains\ItBrains\Views\Courses\Detail.cshtml"
                                                     Write(Model.ServiceDetail.AzTimeDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                                </div>
                                <div class=""detail d-flex"">
                                    <i class=""fas fa-file-alt det-icon my-pt-5 my-pl-3""></i>
                                    <div class=""det-text"">");
#nullable restore
#line 46 "C:\Users\user\Desktop\HomeTask\ItBrains\ItBrains\Views\Courses\Detail.cshtml"
                                                     Write(Model.ServiceDetail.AzCertfDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                                </div>\r\n                                <div class=\"detail d-flex\">\r\n                                    <i class=\"fas fa-book-open det-icon my-pt-5\"></i>\r\n                                    <div class=\"det-text\">");
#nullable restore
#line 50 "C:\Users\user\Desktop\HomeTask\ItBrains\ItBrains\Views\Courses\Detail.cshtml"
                                                     Write(Model.ServiceDetail.AzLessDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                                </div>\r\n                            </div>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a1d21e874c6f916e27d63cd6da850e0de86bcb6b12888", async() => {
                WriteLiteral("Qeydİyyatdan keç");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 53 "C:\Users\user\Desktop\HomeTask\ItBrains\ItBrains\Views\Courses\Detail.cshtml"
                                                                                    WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 54 "C:\Users\user\Desktop\HomeTask\ItBrains\ItBrains\Views\Courses\Detail.cshtml"
                        }
                        else if (culture == "en")
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <h1 class=\"ser-head\">");
#nullable restore
#line 57 "C:\Users\user\Desktop\HomeTask\ItBrains\ItBrains\Views\Courses\Detail.cshtml"
                                            Write(Model.EnServiceName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                            <div class=\"ser-description\">\r\n                                ");
#nullable restore
#line 59 "C:\Users\user\Desktop\HomeTask\ItBrains\ItBrains\Views\Courses\Detail.cshtml"
                           Write(Html.Raw(Model.ServiceDetail.EnDescription));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n                            <div class=\"service-details\">\r\n                                <div class=\"detail d-flex align-items-center\">\r\n                                    ");
#nullable restore
#line 63 "C:\Users\user\Desktop\HomeTask\ItBrains\ItBrains\Views\Courses\Detail.cshtml"
                               Write(Html.Raw(Model.ServiceDetail.TagIcon));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    <div class=\"det-text\">");
#nullable restore
#line 64 "C:\Users\user\Desktop\HomeTask\ItBrains\ItBrains\Views\Courses\Detail.cshtml"
                                                     Write(Model.ServiceDetail.EnTagDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                                </div>\r\n                                <div class=\"detail d-flex\">\r\n                                    <i class=\"fas fa-calendar-alt det-icon\"></i>\r\n                                    <div class=\"det-text\">");
#nullable restore
#line 68 "C:\Users\user\Desktop\HomeTask\ItBrains\ItBrains\Views\Courses\Detail.cshtml"
                                                     Write(Model.ServiceDetail.EnDateDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                                </div>\r\n                                <div class=\"detail d-flex\">\r\n                                    <i class=\"fas fa-clock det-icon\"></i>\r\n                                    <div class=\"det-text\">");
#nullable restore
#line 72 "C:\Users\user\Desktop\HomeTask\ItBrains\ItBrains\Views\Courses\Detail.cshtml"
                                                     Write(Model.ServiceDetail.EnTimeDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                                </div>
                                <div class=""detail d-flex"">
                                    <i class=""fas fa-file-alt det-icon my-pt-5 my-pl-3""></i>
                                    <div class=""det-text"">");
#nullable restore
#line 76 "C:\Users\user\Desktop\HomeTask\ItBrains\ItBrains\Views\Courses\Detail.cshtml"
                                                     Write(Model.ServiceDetail.EnCertfDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                                </div>\r\n                                <div class=\"detail d-flex\">\r\n                                    <i class=\"fas fa-book-open det-icon my-pt-5\"></i>\r\n                                    <div class=\"det-text\">");
#nullable restore
#line 80 "C:\Users\user\Desktop\HomeTask\ItBrains\ItBrains\Views\Courses\Detail.cshtml"
                                                     Write(Model.ServiceDetail.EnLessDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                                </div>\r\n                            </div>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a1d21e874c6f916e27d63cd6da850e0de86bcb6b19534", async() => {
                WriteLiteral("Register");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 83 "C:\Users\user\Desktop\HomeTask\ItBrains\ItBrains\Views\Courses\Detail.cshtml"
                                                                                    WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 84 "C:\Users\user\Desktop\HomeTask\ItBrains\ItBrains\Views\Courses\Detail.cshtml"
                        }
                        else if (culture == "ru")
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <h1 class=\"ser-head\">");
#nullable restore
#line 87 "C:\Users\user\Desktop\HomeTask\ItBrains\ItBrains\Views\Courses\Detail.cshtml"
                                            Write(Model.RuServiceName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                            <div class=\"ser-description\">\r\n                                ");
#nullable restore
#line 89 "C:\Users\user\Desktop\HomeTask\ItBrains\ItBrains\Views\Courses\Detail.cshtml"
                           Write(Html.Raw(Model.ServiceDetail.RuDescription));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n                            <div class=\"service-details\">\r\n                                <div class=\"detail d-flex align-items-center\">\r\n                                    ");
#nullable restore
#line 93 "C:\Users\user\Desktop\HomeTask\ItBrains\ItBrains\Views\Courses\Detail.cshtml"
                               Write(Html.Raw(Model.ServiceDetail.TagIcon));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    <div class=\"det-text\">");
#nullable restore
#line 94 "C:\Users\user\Desktop\HomeTask\ItBrains\ItBrains\Views\Courses\Detail.cshtml"
                                                     Write(Model.ServiceDetail.RuTagDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                                </div>\r\n                                <div class=\"detail d-flex\">\r\n                                    <i class=\"fas fa-calendar-alt det-icon\"></i>\r\n                                    <div class=\"det-text\">");
#nullable restore
#line 98 "C:\Users\user\Desktop\HomeTask\ItBrains\ItBrains\Views\Courses\Detail.cshtml"
                                                     Write(Model.ServiceDetail.RuDateDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                                </div>\r\n                                <div class=\"detail d-flex\">\r\n                                    <i class=\"fas fa-clock det-icon\"></i>\r\n                                    <div class=\"det-text\">");
#nullable restore
#line 102 "C:\Users\user\Desktop\HomeTask\ItBrains\ItBrains\Views\Courses\Detail.cshtml"
                                                     Write(Model.ServiceDetail.RuTimeDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                                </div>
                                <div class=""detail d-flex"">
                                    <i class=""fas fa-file-alt det-icon my-pt-5 my-pl-3""></i>
                                    <div class=""det-text"">");
#nullable restore
#line 106 "C:\Users\user\Desktop\HomeTask\ItBrains\ItBrains\Views\Courses\Detail.cshtml"
                                                     Write(Model.ServiceDetail.RuCertfDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                                </div>\r\n                                <div class=\"detail d-flex\">\r\n                                    <i class=\"fas fa-book-open det-icon my-pt-5\"></i>\r\n                                    <div class=\"det-text\">");
#nullable restore
#line 110 "C:\Users\user\Desktop\HomeTask\ItBrains\ItBrains\Views\Courses\Detail.cshtml"
                                                     Write(Model.ServiceDetail.RuLessDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                                </div>\r\n                            </div>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a1d21e874c6f916e27d63cd6da850e0de86bcb6b26175", async() => {
                WriteLiteral("регистр");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 113 "C:\Users\user\Desktop\HomeTask\ItBrains\ItBrains\Views\Courses\Detail.cshtml"
                                                                                    WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 114 "C:\Users\user\Desktop\HomeTask\ItBrains\ItBrains\Views\Courses\Detail.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </section>\r\n</main>\r\n<!-- *********************      Main  End     ************************ -->\r\n");
            DefineSection("Css", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a1d21e874c6f916e27d63cd6da850e0de86bcb6b29177", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LinkTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
#nullable restore
#line 124 "C:\Users\user\Desktop\HomeTask\ItBrains\ItBrains\Views\Courses\Detail.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper.Href = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Service> Html { get; private set; }
    }
}
#pragma warning restore 1591
