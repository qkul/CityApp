#pragma checksum "C:\Users\Andrei_Kulbeda\source\repos\CitiesApp\CitiesApp\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5a67bed5f9e0133f24c42b2b73281572b31b136a"
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
#line 1 "C:\Users\Andrei_Kulbeda\source\repos\CitiesApp\CitiesApp\Views\_ViewImports.cshtml"
using CitiesApp;

#line default
#line hidden
#line 2 "C:\Users\Andrei_Kulbeda\source\repos\CitiesApp\CitiesApp\Views\_ViewImports.cshtml"
using CitiesApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a67bed5f9e0133f24c42b2b73281572b31b136a", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4de11caaa219ba123f530794408d48d009645a1e", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("bg-image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 35, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            EndContext();
            BeginContext(35, 662, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5bc82e49c5894f00a1552e6c5e388b3a", async() => {
                BeginContext(41, 363, true);
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1, shrink-to-fit=no"">
    <meta http-equiv=""x-ua-compatible"" content=""ie=edge"">
    <title></title>
    <!-- Font Awesome -->
    <link rel=""stylesheet"" href=""https://use.fontawesome.com/releases/v5.6.3/css/all.css"">
    <!-- Bootstrap core CSS -->
    <link");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 404, "\"", 450, 1);
#line 11 "C:\Users\Andrei_Kulbeda\source\repos\CitiesApp\CitiesApp\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 411, Url.Content("~/css/bootstrap.min.css"), 411, 39, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(451, 69, true);
                WriteLiteral(" rel=\"stylesheet\">\r\n    <!-- Material Design Bootstrap -->\r\n    <link");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 520, "\"", 560, 1);
#line 13 "C:\Users\Andrei_Kulbeda\source\repos\CitiesApp\CitiesApp\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 527, Url.Content("~/css/mdb.min.css"), 527, 33, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(561, 68, true);
                WriteLiteral(" rel=\"stylesheet\">\r\n    <!-- Custom styles (optional) -->\r\n    <link");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 629, "\"", 667, 1);
#line 15 "C:\Users\Andrei_Kulbeda\source\repos\CitiesApp\CitiesApp\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 636, Url.Content("~/css/style.css"), 636, 31, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(668, 22, true);
                WriteLiteral(" rel=\"stylesheet\" />\r\n");
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
            BeginContext(697, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(699, 3034, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fe3ee457aa7642828da32835c7c4cbd5", async() => {
                BeginContext(722, 165, true);
                WriteLiteral("\r\n    <!--Main Navigation-->\r\n    <header>\r\n        <nav class=\"navbar fixed-top navbar-expand-lg navbar-dark scrolling-navbar\">\r\n            <a class=\"navbar-brand\"");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 887, "\"", 924, 1);
#line 21 "C:\Users\Andrei_Kulbeda\source\repos\CitiesApp\CitiesApp\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 894, Url.Action("Index", "CIties"), 894, 30, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(925, 2166, true);
                WriteLiteral(@"><strong>Cities</strong></a>
            <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target=""#navbarSupportedContent""
                    aria-controls=""navbarSupportedContent"" aria-expanded=""false"" aria-label=""Toggle navigation"">
                <span class=""navbar-toggler-icon""></span>
            </button>
            <div class=""collapse navbar-collapse"" id=""navbarSupportedContent"">
                <ul class=""navbar-nav mr-auto"">
                    <li class=""nav-item active"">
                        <a class=""nav-link"" role=""button"" data-toggle=""modal"" data-target=""#sideModalTR"">Contact<span class=""sr-only"">(current)</span></a>
                    </li>
                </ul>
            </div>
        </nav>
    </header>
    <!--Main Navigation-->
    <!-- Side Modal Top Right -->
    <!-- To change the direction of the modal animation change .right class -->
    <div class=""modal fade right"" id=""sideModalTR"" tabindex=""-1"" role=""dialog"" aria-labelledby=""myM");
                WriteLiteral(@"odalLabel""
         aria-hidden=""true"">
        <div class=""modal-dialog modal-side modal-top-right"" role=""document"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h4 class=""modal-title w-100"" id=""myModalLabel"">Contact</h4>
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                        <span aria-hidden=""true"">&times;</span>
                    </button>
                </div>
                <div class=""modal-body"">
                    <i class=""far fa-envelope-open""> q_kul@mail.ru</i> |
                    <i class=""fas fa-phone""> +375333511035</i> |
                    <i class=""fab fa-vk""> vk.com/q_kul</i> |
                    <i class=""fab fa-skype""> Andrei Kulbeda</i> |
                </div>
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-elegant"" data-dismiss=""modal"">Close</button>
                </div>
            ");
                WriteLiteral("</div>\r\n        </div>\r\n    </div>\r\n    <!-- Side Modal Top Right -->\r\n\r\n\r\n    <main id=\"main\"  role=\"main\">\r\n        ");
                EndContext();
                BeginContext(3092, 12, false);
#line 64 "C:\Users\Andrei_Kulbeda\source\repos\CitiesApp\CitiesApp\Views\Shared\_Layout.cshtml"
   Write(RenderBody());

#line default
#line hidden
                EndContext();
                BeginContext(3104, 92, true);
                WriteLiteral("\r\n    </main>\r\n    <!-- SCRIPTS -->\r\n    <!-- JQuery -->\r\n    <script type=\"text/javascript\"");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 3196, "\"", 3242, 1);
#line 68 "C:\Users\Andrei_Kulbeda\source\repos\CitiesApp\CitiesApp\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 3202, Url.Content("~/js/jquery-3.3.1.min.js"), 3202, 40, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3243, 79, true);
                WriteLiteral("></script>\r\n    <!-- Bootstrap tooltips -->\r\n    <script type=\"text/javascript\"");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 3322, "\"", 3362, 1);
#line 70 "C:\Users\Andrei_Kulbeda\source\repos\CitiesApp\CitiesApp\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 3328, Url.Content("~/js/popper.min.js"), 3328, 34, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3363, 86, true);
                WriteLiteral("></script>\r\n    <!-- Bootstrap core JavaScript -->\r\n    <script type=\"text/javascript\"");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 3449, "\"", 3492, 1);
#line 72 "C:\Users\Andrei_Kulbeda\source\repos\CitiesApp\CitiesApp\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 3455, Url.Content("~/js/bootstrap.min.js"), 3455, 37, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3493, 80, true);
                WriteLiteral("></script>\r\n    <!-- MDB core JavaScript -->\r\n    <script type=\"text/javascript\"");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 3573, "\"", 3610, 1);
#line 74 "C:\Users\Andrei_Kulbeda\source\repos\CitiesApp\CitiesApp\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 3579, Url.Content("~/js/mdb.min.js"), 3579, 31, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3611, 66, true);
                WriteLiteral("></script>\r\n    <!-- Custom JavaScript (optional) -->\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 3677, "\"", 3713, 1);
#line 76 "C:\Users\Andrei_Kulbeda\source\repos\CitiesApp\CitiesApp\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 3683, Url.Content("~/js/script.js"), 3683, 30, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3714, 12, true);
                WriteLiteral("></script>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3733, 11, true);
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
