#pragma checksum "C:\Users\Andrei_Kulbeda\source\repos\CitiesApp\CitiesApp\Views\Cities\More.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b42e55384660df9587b578b3b94614349112026f"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b42e55384660df9587b578b3b94614349112026f", @"/Views/Cities/More.cshtml")]
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
            BeginContext(198, 46, true);
            WriteLiteral("</h1>\r\n        <h4><b>Description: </b></h4>\r\n");
            EndContext();
#line 11 "C:\Users\Andrei_Kulbeda\source\repos\CitiesApp\CitiesApp\Views\Cities\More.cshtml"
         if (Model.Description == null)
        {

#line default
#line hidden
            BeginContext(296, 35, true);
            WriteLiteral("            <h5><em>---</em></h5>\r\n");
            EndContext();
#line 14 "C:\Users\Andrei_Kulbeda\source\repos\CitiesApp\CitiesApp\Views\Cities\More.cshtml"
        }
        else
        {

#line default
#line hidden
            BeginContext(367, 20, true);
            WriteLiteral("            <h5><em>");
            EndContext();
            BeginContext(388, 17, false);
#line 17 "C:\Users\Andrei_Kulbeda\source\repos\CitiesApp\CitiesApp\Views\Cities\More.cshtml"
               Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(405, 12, true);
            WriteLiteral("</em></h5>\r\n");
            EndContext();
#line 18 "C:\Users\Andrei_Kulbeda\source\repos\CitiesApp\CitiesApp\Views\Cities\More.cshtml"
        }

#line default
#line hidden
            BeginContext(428, 12, true);
            WriteLiteral("    </div>\r\n");
            EndContext();
#line 20 "C:\Users\Andrei_Kulbeda\source\repos\CitiesApp\CitiesApp\Views\Cities\More.cshtml"
     if (Model.Photos.Count == 0)
    {

#line default
#line hidden
            BeginContext(482, 73, true);
            WriteLiteral("        <div>\r\n            <h3>There are no photos</h3>\r\n        </div>\r\n");
            EndContext();
#line 25 "C:\Users\Andrei_Kulbeda\source\repos\CitiesApp\CitiesApp\Views\Cities\More.cshtml"
    }
    else
    {

#line default
#line hidden
            BeginContext(579, 221, true);
            WriteLiteral("        <!-- First row -->\r\n        <div class=\"row\">\r\n            <!-- First column -->\r\n            <div class=\"col-md-12\">\r\n                <div id=\"mdb-lightbox-ui\"></div>\r\n                <div class=\"mdb-lightbox\">\r\n");
            EndContext();
#line 34 "C:\Users\Andrei_Kulbeda\source\repos\CitiesApp\CitiesApp\Views\Cities\More.cshtml"
                     foreach (var p in Model.Photos)
                    {

#line default
#line hidden
            BeginContext(877, 81, true);
            WriteLiteral("                        <figure class=\"col-md-4\">\r\n                            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 958, "\"", 1007, 1);
#line 37 "C:\Users\Andrei_Kulbeda\source\repos\CitiesApp\CitiesApp\Views\Cities\More.cshtml"
WriteAttributeValue("", 965, Url.Action("GetPhoto", new { id = p.Id }), 965, 42, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1008, "\"", 1019, 1);
#line 37 "C:\Users\Andrei_Kulbeda\source\repos\CitiesApp\CitiesApp\Views\Cities\More.cshtml"
WriteAttributeValue("", 1014, p.Id, 1014, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1020, 61, true);
            WriteLiteral(" data-size=\"1600x1067\">\r\n                                <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1081, "\"", 1129, 1);
#line 38 "C:\Users\Andrei_Kulbeda\source\repos\CitiesApp\CitiesApp\Views\Cities\More.cshtml"
WriteAttributeValue("", 1087, Url.Action("GetPhoto", new { id = p.Id }), 1087, 42, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1130, "\"", 1141, 1);
#line 38 "C:\Users\Andrei_Kulbeda\source\repos\CitiesApp\CitiesApp\Views\Cities\More.cshtml"
WriteAttributeValue("", 1136, p.Id, 1136, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1142, 139, true);
            WriteLiteral(" class=\"img-fluid z-depth-2\">\r\n                            </a>\r\n                            <figcaption>\r\n                                ");
            EndContext();
            BeginContext(1281, 270, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a3ef7476d33a4319a508bedf2a57c7c9", async() => {
                BeginContext(1333, 38, true);
                WriteLiteral("\r\n                                    ");
                EndContext();
                BeginContext(1371, 39, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2739cddf85ee463ab5d6eabb6d72da38", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 42 "C:\Users\Andrei_Kulbeda\source\repos\CitiesApp\CitiesApp\Views\Cities\More.cshtml"
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
                BeginContext(1410, 134, true);
                WriteLiteral("\r\n                                    <input type=\"submit\" value=\"Delete\" class=\"btn btn-primary\" />\r\n                                ");
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
#line 41 "C:\Users\Andrei_Kulbeda\source\repos\CitiesApp\CitiesApp\Views\Cities\More.cshtml"
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
            BeginContext(1551, 32, true);
            WriteLiteral("\r\n                              ");
            EndContext();
            BeginContext(1584, 11, false);
#line 45 "C:\Users\Andrei_Kulbeda\source\repos\CitiesApp\CitiesApp\Views\Cities\More.cshtml"
                         Write(p.PhotoInfo);

#line default
#line hidden
            EndContext();
            BeginContext(1595, 80, true);
            WriteLiteral("\r\n                            </figcaption>\r\n                        </figure>\r\n");
            EndContext();
#line 48 "C:\Users\Andrei_Kulbeda\source\repos\CitiesApp\CitiesApp\Views\Cities\More.cshtml"
                        
                    }

#line default
#line hidden
            BeginContext(1724, 123, true);
            WriteLiteral("                </div>\r\n            </div>\r\n            <!-- First column -->\r\n        </div>\r\n        <!-- First row -->\r\n");
            EndContext();
#line 55 "C:\Users\Andrei_Kulbeda\source\repos\CitiesApp\CitiesApp\Views\Cities\More.cshtml"
       
    }

#line default
#line hidden
            BeginContext(1863, 21, true);
            WriteLiteral("    <div>\r\n        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1884, "\"", 1937, 1);
#line 58 "C:\Users\Andrei_Kulbeda\source\repos\CitiesApp\CitiesApp\Views\Cities\More.cshtml"
WriteAttributeValue("", 1891, Url.Action("AddPhoto", new { id = Model.Id }), 1891, 46, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1938, 81, true);
            WriteLiteral(" class=\"btn btn-elegant\"><i class=\"far fa-image\"> Add new photo</i></a>\r\n        ");
            EndContext();
            BeginContext(2019, 62, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "92b21558f0004bfd82891487be0a90bc", async() => {
                BeginContext(2065, 12, true);
                WriteLiteral("Back to List");
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
            BeginContext(2081, 24, true);
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
