#pragma checksum "C:\Users\Ripper\Documents\GitHub\Estudos\Contab\Contab\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6ce0fa4f214a940a53e836d865643f69ccfa460b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_Layout.cshtml", typeof(AspNetCore.Views_Shared__Layout))]
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
#line 1 "C:\Users\Ripper\Documents\GitHub\Estudos\Contab\Contab\Views\_ViewImports.cshtml"
using Contab;

#line default
#line hidden
#line 2 "C:\Users\Ripper\Documents\GitHub\Estudos\Contab\Contab\Views\_ViewImports.cshtml"
using Contab.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ce0fa4f214a940a53e836d865643f69ccfa460b", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1305f3b18620149d38bd7938f0c7773728f2debc", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Home/Index"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Employee"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Employee/Create"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_CookieConsentPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Scripts/jquery-3.3.1.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Scripts/bootstrap.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Scripts/vendor/jquery/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 25, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            EndContext();
            BeginContext(25, 123, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4826102929b84cf4a46eba11a4ff6bc8", async() => {
                BeginContext(31, 110, true);
                WriteLiteral("\r\n    <meta charset=\"utf-8\" />\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\" />\r\n");
                EndContext();
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
            EndContext();
            BeginContext(148, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(150, 7813, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ac34170825d2414186839f2e9a459f0d", async() => {
                BeginContext(156, 4560, true);
                WriteLiteral(@"
    <nav class=""navbar navbar-default navbar-static-top"" role=""navigation"" style=""margin-bottom: 0"">
        <div class=""navbar-header"">
            <button type=""button"" class=""navbar-toggle"" data-toggle=""collapse"" data-target="".navbar-collapse"">
                <span class=""sr-only"">Toggle navigation</span>
                <span class=""icon-bar""></span>
                <span class=""icon-bar""></span>
                <span class=""icon-bar""></span>
            </button>
            <a class=""navbar-brand"" href=""#"">VJ - Contab</a>
        </div>
        <!-- /.navbar-header -->
        <ul class=""nav navbar-top-links navbar-right"">
            <li class=""dropdown"">
                <a class=""dropdown-toggle"" data-toggle=""dropdown"" href=""#"">
                    <i class=""fa fa-envelope fa-fw""></i> <i class=""fa fa-caret-down""></i>
                </a>
                <ul class=""dropdown-menu dropdown-messages"">
                    <li>
                        <a href=""#"">

                   ");
                WriteLiteral(@"     </a>
                    </li>
                    <li class=""divider""></li>
                    <li>

                    </li>
                </ul>
                <!-- /.dropdown-messages -->
            </li>
            <!-- /.dropdown -->
            <!-- /.dropdown -->
            <li class=""dropdown"">
                <a class=""dropdown-toggle"" data-toggle=""dropdown"" href=""#"">
                    <i class=""fa fa-bell fa-fw""></i> <i class=""fa fa-caret-down""></i>
                </a>
                <ul class=""dropdown-menu dropdown-alerts"">
                    <li>
                        <a href=""#"">

                        </a>
                    </li>
                    <li class=""divider""></li>
                    <li>
                        <a href=""#"">

                        </a>
                    </li>
                    <li class=""divider""></li>
                    <li>
                        <a href=""#"">

                        </a>
             ");
                WriteLiteral(@"       </li>
                    <li class=""divider""></li>
                    <li>
                        <a href=""#"">

                        </a>
                    </li>
                    <li class=""divider""></li>
                    <li>
                        <a href=""#"">

                        </a>
                    </li>
                    <li class=""divider""></li>
                    <li>
                        <a class=""text-center"" href=""#"">
                            <strong>See All Alerts</strong>
                            <i class=""fa fa-angle-right""></i>
                        </a>
                    </li>
                </ul>
                <!-- /.dropdown-alerts -->
            </li>
            <!-- /.dropdown -->
            <li class=""dropdown"">
                <a class=""dropdown-toggle"" data-toggle=""dropdown"" href=""#"">
                    <i class=""fa fa-user fa-fw""></i> <i class=""fa fa-caret-down""></i>
                </a>
                <u");
                WriteLiteral(@"l class=""dropdown-menu dropdown-user"">
                    <li>
                        <a href=""#""><i class=""fa fa-user fa-fw""></i> User Profile</a>
                    </li>
                    <li>
                        <a href=""#""><i class=""fa fa-gear fa-fw""></i> Settings</a>
                    </li>
                    <li class=""divider""></li>
                    <li>
                        <a href=""Login""><i class=""fa-sign-out""></i> Logout</a>
                    </li>
                </ul>
                <!-- /.dropdown-user -->
            </li>
            <!-- /.dropdown -->
        </ul>
        <!-- /.navbar-top-links -->
        <div class=""navbar-default sidebar"" role=""navigation"">
            <div class=""sidebar-nav navbar-collapse"">
                <ul class=""nav"" id=""side-menu"">
                    <li class=""sidebar-search"">
                        <div class=""input-group custom-search-form"">
                            <input type=""text"" class=""form-control"" plac");
                WriteLiteral(@"eholder=""Search..."">
                            <span class=""input-group-btn"">
                                <button class=""btn btn-default"" type=""button"">
                                    <i class=""fa fa-search""></i>
                                </button>
                            </span>
                        </div>
                        <!-- /input-group -->
                    </li>
                    <li>
                        ");
                EndContext();
                BeginContext(4716, 74, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "69a9a9a4c9f646acbb5d723b5e0beafa", async() => {
                    BeginContext(4739, 47, true);
                    WriteLiteral("<i class=\"fa fa-dashboard fa-fw\"></i> Dashboard");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4790, 79, true);
                WriteLiteral("\r\n                    </li>\r\n                    <li>\r\n                        ");
                EndContext();
                BeginContext(4869, 102, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c22b07d38e0844188f333094ac8910e3", async() => {
                    BeginContext(4890, 77, true);
                    WriteLiteral("<i class=\"fa fa-wrench fa-fw\"></i> Funcionários<span class=\"fa arrow\"></span>");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4971, 127, true);
                WriteLiteral("\r\n                        <ul class=\"nav nav-second-level\">\r\n                            <li>\r\n                                ");
                EndContext();
                BeginContext(5098, 48, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "11a86e07752248aa850887f58e25cf78", async() => {
                    BeginContext(5126, 16, true);
                    WriteLiteral("Novo Funcionário");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5146, 103, true);
                WriteLiteral("\r\n                            </li>\r\n                            <li>\r\n                                ");
                EndContext();
                BeginContext(5249, 43, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "363d5388b5eb4b03ad6500ad9174fca6", async() => {
                    BeginContext(5270, 18, true);
                    WriteLiteral("Todos Funcionários");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5292, 2246, true);
                WriteLiteral(@"
                            </li>
                        </ul>
                    </li>
                    <li>
                        <a href=""Tables""><i class=""fa fa-table fa-fw""></i> Tables</a>
                    </li>
                    <li>
                        <a href=""Forms""><i class=""fa fa-edit fa-fw""></i> Forms</a>
                    </li>
                    <li>
                        <a href=""#""><i class=""fa fa-bar-chart-o fa-fw""></i> UI Elements<span class=""fa arrow""></span></a>
                        <ul class=""nav nav-second-level"">
                            <li>
                                <a href=""Panelswells"">Panels and Wells</a>
                            </li>
                            <li>
                                <a href=""Buttons"">Buttons</a>
                            </li>
                            <li>
                                <a href=""Notifications"">Notifications</a>
                            </li>
                       ");
                WriteLiteral(@"     <li>
                                <a href=""Typography"">Typography</a>
                            </li>
                            <li>
                                <a href=""Icons""> Icons</a>
                            </li>
                            <li>
                                <a href=""Grid"">Grid</a>
                            </li>
                        </ul>
                        <!-- /.nav-second-level -->
                    </li>


                    <li>
                        <a href=""#""><i class=""fa fa-files-o fa-fw""></i> Sample Pages<span class=""fa arrow""></span></a>
                        <ul class=""nav nav-second-level"">
                            <li>
                                <a href=""Blank"">Blank Page</a>
                            </li>
                            <li>
                                <a href=""Login"">Login Page</a>
                            </li>
                        </ul>
                        <!-- /.nav-se");
                WriteLiteral("cond-level -->\r\n                    </li>\r\n                </ul>\r\n            </div>\r\n            <!-- /.sidebar-collapse -->\r\n        </div>\r\n        <!-- /.navbar-static-side -->\r\n    </nav>\r\n    ");
                EndContext();
                BeginContext(7538, 40, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7aa2d1621ecb4fe4bce300f8a685a7e9", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(7578, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(7585, 12, false);
#line 184 "C:\Users\Ripper\Documents\GitHub\Estudos\Contab\Contab\Views\Shared\_Layout.cshtml"
Write(RenderBody());

#line default
#line hidden
                EndContext();
                BeginContext(7597, 2, true);
                WriteLiteral("\r\n");
                EndContext();
                DefineSection("Scripts", async() => {
                    BeginContext(7620, 105, true);
                    WriteLiteral("\r\n        <script src=\"//netdna.bootstrapcdn.com/bootstrap/3.1.1/js/bootstrap.min.js\"></script>\r\n        ");
                    EndContext();
                    BeginContext(7725, 49, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "544f927b293c497490bbe57b39dca38d", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(7774, 10, true);
                    WriteLiteral("\r\n        ");
                    EndContext();
                    BeginContext(7784, 46, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7000b61e5d774de482e5534e4263882b", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(7830, 10, true);
                    WriteLiteral("\r\n        ");
                    EndContext();
                    BeginContext(7840, 57, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0f7b100eadbe4b848c5706a89af24cb0", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(7897, 8, true);
                    WriteLiteral("\r\n\r\n    ");
                    EndContext();
                }
                );
                BeginContext(7908, 4, true);
                WriteLiteral("    ");
                EndContext();
                BeginContext(7913, 41, false);
#line 192 "C:\Users\Ripper\Documents\GitHub\Estudos\Contab\Contab\Views\Shared\_Layout.cshtml"
Write(RenderSection("Scripts", required: false));

#line default
#line hidden
                EndContext();
                BeginContext(7954, 2, true);
                WriteLiteral("\r\n");
                EndContext();
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
            EndContext();
            BeginContext(7963, 11, true);
            WriteLiteral("\r\n</html>\r\n");
            EndContext();
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
