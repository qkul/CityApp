#pragma checksum "C:\Users\Andrei_Kulbeda\source\repos\CitiesApp\CitiesApp\Views\Cities\More.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "efdde18277b1da647b836ea447349682174a5532"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cities_More), @"mvc.1.0.view", @"/Views/Cities/More.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cities/More.cshtml", typeof(AspNetCore.Views_Cities_More))]
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
#line 2 "C:\Users\Andrei_Kulbeda\source\repos\CitiesApp\CitiesApp\Views\Cities\More.cshtml"
using CitiesApp.Models;

#line default
#line hidden
#line 1 "C:\Users\Andrei_Kulbeda\source\repos\CitiesApp\CitiesApp\Views\Cities\More.cshtml"
using CitiesApp.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"efdde18277b1da647b836ea447349682174a5532", @"/Views/Cities/More.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4de11caaa219ba123f530794408d48d009645a1e", @"/Views/_ViewImports.cshtml")]
    public class Views_Cities_More : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CityViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeletePhoto", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-elegant"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 4 "C:\Users\Andrei_Kulbeda\source\repos\CitiesApp\CitiesApp\Views\Cities\More.cshtml"
  
    ViewData["Title"] = "More";

#line default
#line hidden
            BeginContext(116, 71, true);
            WriteLiteral("<div class=\"container text-white text-center\">\r\n    <div>\r\n        <h1>");
            EndContext();
            BeginContext(188, 10, false);
#line 9 "C:\Users\Andrei_Kulbeda\source\repos\CitiesApp\CitiesApp\Views\Cities\More.cshtml"
       Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(198, 7, true);
            WriteLiteral("</h1>\r\n");
            EndContext();
#line 10 "C:\Users\Andrei_Kulbeda\source\repos\CitiesApp\CitiesApp\Views\Cities\More.cshtml"
         if (Model.Description == null)
        {

#line default
#line hidden
            BeginContext(257, 56, true);
            WriteLiteral("            <h5><b>Description: </b> <em>---</em></h5>\r\n");
            EndContext();
#line 13 "C:\Users\Andrei_Kulbeda\source\repos\CitiesApp\CitiesApp\Views\Cities\More.cshtml"
        }
        else
        {

#line default
#line hidden
            BeginContext(349, 40, true);
            WriteLiteral("            <h5><b>Description: </b><em>");
            EndContext();
            BeginContext(390, 17, false);
#line 16 "C:\Users\Andrei_Kulbeda\source\repos\CitiesApp\CitiesApp\Views\Cities\More.cshtml"
                                   Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(407, 12, true);
            WriteLiteral("</em></h5>\r\n");
            EndContext();
#line 17 "C:\Users\Andrei_Kulbeda\source\repos\CitiesApp\CitiesApp\Views\Cities\More.cshtml"
        }

#line default
#line hidden
            BeginContext(430, 12, true);
            WriteLiteral("    </div>\r\n");
            EndContext();
#line 19 "C:\Users\Andrei_Kulbeda\source\repos\CitiesApp\CitiesApp\Views\Cities\More.cshtml"
     if (Model.Photos.Count == 0)
    {

#line default
#line hidden
            BeginContext(484, 74, true);
            WriteLiteral("        <div>\r\n            <h3>Places not yet added</h3>\r\n        </div>\r\n");
            EndContext();
#line 24 "C:\Users\Andrei_Kulbeda\source\repos\CitiesApp\CitiesApp\Views\Cities\More.cshtml"
    }
    else
    {

#line default
#line hidden
            BeginContext(582, 221, true);
            WriteLiteral("        <!-- First row -->\r\n        <div class=\"row\">\r\n            <!-- First column -->\r\n            <div class=\"col-md-12\">\r\n                <div id=\"mdb-lightbox-ui\"></div>\r\n                <div class=\"mdb-lightbox\">\r\n");
            EndContext();
#line 33 "C:\Users\Andrei_Kulbeda\source\repos\CitiesApp\CitiesApp\Views\Cities\More.cshtml"
                     foreach (var p in Model.Photos)
                    {

#line default
#line hidden
            BeginContext(880, 81, true);
            WriteLiteral("                        <figure class=\"col-md-4\">\r\n                            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 961, "\"", 1010, 1);
#line 36 "C:\Users\Andrei_Kulbeda\source\repos\CitiesApp\CitiesApp\Views\Cities\More.cshtml"
WriteAttributeValue("", 968, Url.Action("GetPhoto", new { id = p.Id }), 968, 42, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1011, "\"", 1022, 1);
#line 36 "C:\Users\Andrei_Kulbeda\source\repos\CitiesApp\CitiesApp\Views\Cities\More.cshtml"
WriteAttributeValue("", 1017, p.Id, 1017, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1023, 61, true);
            WriteLiteral(" data-size=\"1600x1067\">\r\n                                <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1084, "\"", 1132, 1);
#line 37 "C:\Users\Andrei_Kulbeda\source\repos\CitiesApp\CitiesApp\Views\Cities\More.cshtml"
WriteAttributeValue("", 1090, Url.Action("GetPhoto", new { id = p.Id }), 1090, 42, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1133, "\"", 1144, 1);
#line 37 "C:\Users\Andrei_Kulbeda\source\repos\CitiesApp\CitiesApp\Views\Cities\More.cshtml"
WriteAttributeValue("", 1139, p.Id, 1139, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1145, 139, true);
            WriteLiteral(" class=\"img-fluid z-depth-2\">\r\n                            </a>\r\n                            <figcaption>\r\n                                ");
            EndContext();
            BeginContext(1284, 270, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3e958698129b436e8bf999c700b18f20", async() => {
                BeginContext(1336, 38, true);
                WriteLiteral("\r\n                                    ");
                EndContext();
                BeginContext(1374, 39, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b7b8c953bcc245d8b356934c37cc4be3", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 41 "C:\Users\Andrei_Kulbeda\source\repos\CitiesApp\CitiesApp\Views\Cities\More.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => p.Id);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1413, 134, true);
                WriteLiteral("\r\n                                    <input type=\"submit\" value=\"Delete\" class=\"btn btn-elegant\" />\r\n                                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 40 "C:\Users\Andrei_Kulbeda\source\repos\CitiesApp\CitiesApp\Views\Cities\More.cshtml"
                                                                 WriteLiteral(p.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1554, 80, true);
            WriteLiteral("\r\n                                <div>\r\n                                   <h5>");
            EndContext();
            BeginContext(1635, 11, false);
#line 45 "C:\Users\Andrei_Kulbeda\source\repos\CitiesApp\CitiesApp\Views\Cities\More.cshtml"
                                  Write(p.PhotoInfo);

#line default
#line hidden
            EndContext();
            BeginContext(1646, 126, true);
            WriteLiteral("</h5> \r\n                                </div>\r\n                            </figcaption>\r\n                        </figure>\r\n");
            EndContext();
#line 49 "C:\Users\Andrei_Kulbeda\source\repos\CitiesApp\CitiesApp\Views\Cities\More.cshtml"
                        
                    }

#line default
#line hidden
            BeginContext(1821, 123, true);
            WriteLiteral("                </div>\r\n            </div>\r\n            <!-- First column -->\r\n        </div>\r\n        <!-- First row -->\r\n");
            EndContext();
#line 56 "C:\Users\Andrei_Kulbeda\source\repos\CitiesApp\CitiesApp\Views\Cities\More.cshtml"
       
    }

#line default
#line hidden
            BeginContext(1960, 21, true);
            WriteLiteral("    <div>\r\n        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1981, "\"", 2034, 1);
#line 59 "C:\Users\Andrei_Kulbeda\source\repos\CitiesApp\CitiesApp\Views\Cities\More.cshtml"
WriteAttributeValue("", 1988, Url.Action("AddPhoto", new { id = Model.Id }), 1988, 46, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2035, 81, true);
            WriteLiteral(" class=\"btn btn-elegant\"><i class=\"far fa-image\"> Add new photo</i></a>\r\n        ");
            EndContext();
            BeginContext(2116, 96, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8dafbca2b0d440de946dcf502a6fc021", async() => {
                BeginContext(2162, 46, true);
                WriteLiteral(" <i class=\"far fa-list-alt\"> Back to list</i> ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2212, 24, true);
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CityViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
