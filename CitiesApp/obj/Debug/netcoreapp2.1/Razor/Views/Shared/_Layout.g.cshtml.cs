#pragma checksum "C:\Users\Andrei_Kulbeda\source\repos\CitiesApp\CitiesApp\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "be59a0126384556305157fa2e86e6c5f333df824"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be59a0126384556305157fa2e86e6c5f333df824", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4de11caaa219ba123f530794408d48d009645a1e", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
            BeginContext(35, 664, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "00d7b86379364a25a74af1cfa08238aa", async() => {
                BeginContext(41, 365, true);
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
                BeginWriteAttribute("href", " href=\"", 406, "\"", 452, 1);
#line 12 "C:\Users\Andrei_Kulbeda\source\repos\CitiesApp\CitiesApp\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 413, Url.Content("~/css/bootstrap.min.css"), 413, 39, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(453, 69, true);
                WriteLiteral(" rel=\"stylesheet\">\r\n    <!-- Material Design Bootstrap -->\r\n    <link");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 522, "\"", 562, 1);
#line 14 "C:\Users\Andrei_Kulbeda\source\repos\CitiesApp\CitiesApp\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 529, Url.Content("~/css/mdb.min.css"), 529, 33, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(563, 68, true);
                WriteLiteral(" rel=\"stylesheet\">\r\n    <!-- Custom styles (optional) -->\r\n    <link");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 631, "\"", 669, 1);
#line 16 "C:\Users\Andrei_Kulbeda\source\repos\CitiesApp\CitiesApp\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 638, Url.Content("~/css/style.css"), 638, 31, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(670, 22, true);
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
            BeginContext(699, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(701, 1856, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3fe58a6c1d9f4e6a9acbd10289440234", async() => {
                BeginContext(707, 169, true);
                WriteLiteral("\r\n\r\n    <!--Main Navigation-->\r\n    <header>\r\n\r\n        <nav class=\"navbar fixed-top navbar-expand-lg navbar-dark scrolling-navbar\">\r\n            <a class=\"navbar-brand\"");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 876, "\"", 903, 1);
#line 24 "C:\Users\Andrei_Kulbeda\source\repos\CitiesApp\CitiesApp\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 883, Url.Action("Index"), 883, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(904, 902, true);
                WriteLiteral(@"><strong>Cities</strong></a>
            <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target=""#navbarSupportedContent""
                    aria-controls=""navbarSupportedContent"" aria-expanded=""false"" aria-label=""Toggle navigation"">
                <span class=""navbar-toggler-icon""></span>
            </button>
            <div class=""collapse navbar-collapse"" id=""navbarSupportedContent"">
                <ul class=""navbar-nav mr-auto"">
                    <li class=""nav-item active"">
                        <a class=""nav-link"" href=""#"">Contact <span class=""sr-only"">(current)</span></a>
                    </li>
                </ul>
            </div>
        </nav>

        <div class=""bg-header-img view intro-2"">
            <div class=""full-bg-img"">
                <div class=""mask rgba-purple-light flex-center"">         
                     ");
                EndContext();
                BeginContext(1807, 12, false);
#line 41 "C:\Users\Andrei_Kulbeda\source\repos\CitiesApp\CitiesApp\Views\Shared\_Layout.cshtml"
                Write(RenderBody());

#line default
#line hidden
                EndContext();
                BeginContext(1819, 199, true);
                WriteLiteral("             \r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n    </header>\r\n    <!--Main Navigation-->\r\n\r\n    <!-- SCRIPTS -->\r\n    <!-- JQuery -->\r\n    <script type=\"text/javascript\"");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 2018, "\"", 2064, 1);
#line 51 "C:\Users\Andrei_Kulbeda\source\repos\CitiesApp\CitiesApp\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 2024, Url.Content("~/js/jquery-3.3.1.min.js"), 2024, 40, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2065, 79, true);
                WriteLiteral("></script>\r\n    <!-- Bootstrap tooltips -->\r\n    <script type=\"text/javascript\"");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 2144, "\"", 2184, 1);
#line 53 "C:\Users\Andrei_Kulbeda\source\repos\CitiesApp\CitiesApp\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 2150, Url.Content("~/js/popper.min.js"), 2150, 34, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2185, 86, true);
                WriteLiteral("></script>\r\n    <!-- Bootstrap core JavaScript -->\r\n    <script type=\"text/javascript\"");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 2271, "\"", 2314, 1);
#line 55 "C:\Users\Andrei_Kulbeda\source\repos\CitiesApp\CitiesApp\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 2277, Url.Content("~/js/bootstrap.min.js"), 2277, 37, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2315, 80, true);
                WriteLiteral("></script>\r\n    <!-- MDB core JavaScript -->\r\n    <script type=\"text/javascript\"");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 2395, "\"", 2432, 1);
#line 57 "C:\Users\Andrei_Kulbeda\source\repos\CitiesApp\CitiesApp\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 2401, Url.Content("~/js/mdb.min.js"), 2401, 31, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2433, 66, true);
                WriteLiteral("></script>\r\n    <!-- Custom JavaScript (optional) -->\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 2499, "\"", 2535, 1);
#line 59 "C:\Users\Andrei_Kulbeda\source\repos\CitiesApp\CitiesApp\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 2505, Url.Content("~/js/script.js"), 2505, 30, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2536, 14, true);
                WriteLiteral("></script>\r\n\r\n");
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
            BeginContext(2557, 11, true);
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
