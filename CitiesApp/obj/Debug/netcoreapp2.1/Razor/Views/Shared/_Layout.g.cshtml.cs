#pragma checksum "C:\Users\Andrei_Kulbeda\source\repos\CitiesApp\CitiesApp\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a360cfb20e3d9d3e49cf18e8f37cf2244edb59f1"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a360cfb20e3d9d3e49cf18e8f37cf2244edb59f1", @"/Views/Shared/_Layout.cshtml")]
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
            BeginContext(0, 33, true);
            WriteLiteral("<!DOCTYPE html>\n<html lang=\"en\">\n");
            EndContext();
            BeginContext(33, 649, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9a96a50f07a143359c6a647d2a675408", async() => {
                BeginContext(39, 355, true);
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
                BeginWriteAttribute("href", " href=\"", 394, "\"", 440, 1);
#line 11 "C:\Users\Andrei_Kulbeda\source\repos\CitiesApp\CitiesApp\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 401, Url.Content("~/css/bootstrap.min.css"), 401, 39, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(441, 67, true);
                WriteLiteral(" rel=\"stylesheet\">\n    <!-- Material Design Bootstrap -->\n    <link");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 508, "\"", 548, 1);
#line 13 "C:\Users\Andrei_Kulbeda\source\repos\CitiesApp\CitiesApp\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 515, Url.Content("~/css/mdb.min.css"), 515, 33, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(549, 66, true);
                WriteLiteral(" rel=\"stylesheet\">\n    <!-- Custom styles (optional) -->\n    <link");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 615, "\"", 653, 1);
#line 15 "C:\Users\Andrei_Kulbeda\source\repos\CitiesApp\CitiesApp\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 622, Url.Content("~/css/style.css"), 622, 31, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(654, 21, true);
                WriteLiteral(" rel=\"stylesheet\" />\n");
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
            BeginContext(682, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(683, 2964, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "49a91a171dab4d84a9d6c229be742e8b", async() => {
                BeginContext(706, 161, true);
                WriteLiteral("\n    <!--Main Navigation-->\n    <header>\n        <nav class=\"navbar fixed-top navbar-expand-lg navbar-dark scrolling-navbar\">\n            <a class=\"navbar-brand\"");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 867, "\"", 894, 1);
#line 21 "C:\Users\Andrei_Kulbeda\source\repos\CitiesApp\CitiesApp\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 874, Url.Action("Index"), 874, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(895, 2123, true);
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
    <div class=""modal fade right"" id=""sideModalTR"" tabindex=""-1"" role=""dialog"" aria-labelledby=""myModalLabel""
      ");
                WriteLiteral(@"   aria-hidden=""true"">
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
            </div>
        </div>
    </div>
   ");
                WriteLiteral(" <!-- Side Modal Top Right -->\n\n\n    <main id=\"main\"  role=\"main\">\n        ");
                EndContext();
                BeginContext(3019, 12, false);
#line 64 "C:\Users\Andrei_Kulbeda\source\repos\CitiesApp\CitiesApp\Views\Shared\_Layout.cshtml"
   Write(RenderBody());

#line default
#line hidden
                EndContext();
                BeginContext(3031, 88, true);
                WriteLiteral("\n    </main>\n    <!-- SCRIPTS -->\n    <!-- JQuery -->\n    <script type=\"text/javascript\"");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 3119, "\"", 3165, 1);
#line 68 "C:\Users\Andrei_Kulbeda\source\repos\CitiesApp\CitiesApp\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 3125, Url.Content("~/js/jquery-3.3.1.min.js"), 3125, 40, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3166, 77, true);
                WriteLiteral("></script>\n    <!-- Bootstrap tooltips -->\n    <script type=\"text/javascript\"");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 3243, "\"", 3283, 1);
#line 70 "C:\Users\Andrei_Kulbeda\source\repos\CitiesApp\CitiesApp\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 3249, Url.Content("~/js/popper.min.js"), 3249, 34, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3284, 84, true);
                WriteLiteral("></script>\n    <!-- Bootstrap core JavaScript -->\n    <script type=\"text/javascript\"");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 3368, "\"", 3411, 1);
#line 72 "C:\Users\Andrei_Kulbeda\source\repos\CitiesApp\CitiesApp\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 3374, Url.Content("~/js/bootstrap.min.js"), 3374, 37, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3412, 78, true);
                WriteLiteral("></script>\n    <!-- MDB core JavaScript -->\n    <script type=\"text/javascript\"");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 3490, "\"", 3527, 1);
#line 74 "C:\Users\Andrei_Kulbeda\source\repos\CitiesApp\CitiesApp\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 3496, Url.Content("~/js/mdb.min.js"), 3496, 31, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3528, 64, true);
                WriteLiteral("></script>\n    <!-- Custom JavaScript (optional) -->\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 3592, "\"", 3628, 1);
#line 76 "C:\Users\Andrei_Kulbeda\source\repos\CitiesApp\CitiesApp\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 3598, Url.Content("~/js/script.js"), 3598, 30, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3629, 11, true);
                WriteLiteral("></script>\n");
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
            BeginContext(3647, 9, true);
            WriteLiteral("\n</html>\n");
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
