#pragma checksum "C:\Users\Andrei_Kulbeda\source\repos\CitiesApp\CitiesApp\Views\Cities\More.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4c4c744d53b80369690fc446a7489c1683f691ff"
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
#line 2 "C:\Users\Andrei_Kulbeda\source\repos\CitiesApp\CitiesApp\Views\_ViewImports.cshtml"
using CitiesApp.Models;

#line default
#line hidden
#line 1 "C:\Users\Andrei_Kulbeda\source\repos\CitiesApp\CitiesApp\Views\Cities\More.cshtml"
using CitiesApp.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c4c744d53b80369690fc446a7489c1683f691ff", @"/Views/Cities/More.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"40c4b011b3d68f662786a8c9e4fcff514c78aa06", @"/Views/_ViewImports.cshtml")]
    public class Views_Cities_More : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CityViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(51, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\Andrei_Kulbeda\source\repos\CitiesApp\CitiesApp\Views\Cities\More.cshtml"
  
    ViewData["Title"] = "More";

#line default
#line hidden
            BeginContext(93, 17, true);
            WriteLiteral("\r\n<div>\r\n    <h3>");
            EndContext();
            BeginContext(111, 8, false);
#line 9 "C:\Users\Andrei_Kulbeda\source\repos\CitiesApp\CitiesApp\Views\Cities\More.cshtml"
   Write(Model.Id);

#line default
#line hidden
            EndContext();
            BeginContext(119, 15, true);
            WriteLiteral("</h3>\r\n    <h3>");
            EndContext();
            BeginContext(135, 10, false);
#line 10 "C:\Users\Andrei_Kulbeda\source\repos\CitiesApp\CitiesApp\Views\Cities\More.cshtml"
   Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(145, 17, true);
            WriteLiteral("</h3>\r\n</div>\r\n\r\n");
            EndContext();
#line 13 "C:\Users\Andrei_Kulbeda\source\repos\CitiesApp\CitiesApp\Views\Cities\More.cshtml"
 if (Model.Photos == null)
{

#line default
#line hidden
            BeginContext(193, 56, true);
            WriteLiteral("    <div>\r\n        <h3>Фотографий нет</h3>\r\n    </div>\r\n");
            EndContext();
#line 18 "C:\Users\Andrei_Kulbeda\source\repos\CitiesApp\CitiesApp\Views\Cities\More.cshtml"
}
else
{
    

#line default
#line hidden
#line 21 "C:\Users\Andrei_Kulbeda\source\repos\CitiesApp\CitiesApp\Views\Cities\More.cshtml"
     foreach (var p in Model.Photos)
    {
        

#line default
#line hidden
#line 23 "C:\Users\Andrei_Kulbeda\source\repos\CitiesApp\CitiesApp\Views\Cities\More.cshtml"
         if (p.Image != null)
        {

#line default
#line hidden
            BeginContext(348, 51, true);
            WriteLiteral("            <img style=\'width:300px; height:250px;\'");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 399, "\"", 462, 2);
            WriteAttributeValue("", 405, "data:image/jpeg;base64,", 405, 23, true);
#line 25 "C:\Users\Andrei_Kulbeda\source\repos\CitiesApp\CitiesApp\Views\Cities\More.cshtml"
WriteAttributeValue("", 428, Convert.ToBase64String(p.Image), 428, 34, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(463, 5, true);
            WriteLiteral(" />\r\n");
            EndContext();
#line 26 "C:\Users\Andrei_Kulbeda\source\repos\CitiesApp\CitiesApp\Views\Cities\More.cshtml"
        }

#line default
#line hidden
#line 26 "C:\Users\Andrei_Kulbeda\source\repos\CitiesApp\CitiesApp\Views\Cities\More.cshtml"
         
    }

#line default
#line hidden
#line 27 "C:\Users\Andrei_Kulbeda\source\repos\CitiesApp\CitiesApp\Views\Cities\More.cshtml"
     
}

#line default
#line hidden
            BeginContext(489, 21, true);
            WriteLiteral("    <div>\r\n        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 510, "\"", 563, 1);
#line 30 "C:\Users\Andrei_Kulbeda\source\repos\CitiesApp\CitiesApp\Views\Cities\More.cshtml"
WriteAttributeValue("", 517, Url.Action("AddPhoto", new { id = Model.Id }), 517, 46, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(564, 42, true);
            WriteLiteral(">Добавить новую фотографию</a>\r\n    </div>");
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
