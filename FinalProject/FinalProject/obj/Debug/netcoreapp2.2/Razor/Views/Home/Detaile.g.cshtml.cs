#pragma checksum "/Users/fengcu/Projects/FinalProject/FinalProject/Views/Home/Detaile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "935c8ef4ef715826bcac82fccd7d6911439a6ffc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Detaile), @"mvc.1.0.view", @"/Views/Home/Detaile.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Detaile.cshtml", typeof(AspNetCore.Views_Home_Detaile))]
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
#line 1 "/Users/fengcu/Projects/FinalProject/FinalProject/Views/_ViewImports.cshtml"
using FinalProject;

#line default
#line hidden
#line 2 "/Users/fengcu/Projects/FinalProject/FinalProject/Views/_ViewImports.cshtml"
using FinalProject.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"935c8ef4ef715826bcac82fccd7d6911439a6ffc", @"/Views/Home/Detaile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f1cd403b176af46e85ea812cbc8b3a7a1a86d4d8", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Detaile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FinalProject.Models.Book>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/fengcu/Projects/FinalProject/FinalProject/Views/Home/Detaile.cshtml"
  
    ViewData["Title"] = "Book Details";

#line default
#line hidden
            BeginContext(81, 17, true);
            WriteLiteral("\r\n<div>\r\n    <h1>");
            EndContext();
            BeginContext(99, 17, false);
#line 7 "/Users/fengcu/Projects/FinalProject/FinalProject/Views/Home/Detaile.cshtml"
   Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(116, 196, true);
            WriteLiteral("</h1>\r\n    <h2>This is the concrete information.</h2>\r\n    <table colspan=\"2\" style=\"background-color:rgba(230,123,185,0.5);\" border=\"1\">\r\n        <tr>\r\n            <td>ID: </td>\r\n            <td>");
            EndContext();
            BeginContext(313, 8, false);
#line 12 "/Users/fengcu/Projects/FinalProject/FinalProject/Views/Home/Detaile.cshtml"
           Write(Model.Id);

#line default
#line hidden
            EndContext();
            BeginContext(321, 80, true);
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>Name:</td>\r\n            <td>");
            EndContext();
            BeginContext(402, 10, false);
#line 16 "/Users/fengcu/Projects/FinalProject/FinalProject/Views/Home/Detaile.cshtml"
           Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(412, 84, true);
            WriteLiteral("</td>  \r\n        </tr>\r\n        <tr>\r\n            <td>Genre: </td>\r\n            <td>");
            EndContext();
            BeginContext(497, 11, false);
#line 20 "/Users/fengcu/Projects/FinalProject/FinalProject/Views/Home/Detaile.cshtml"
           Write(Model.Genre);

#line default
#line hidden
            EndContext();
            BeginContext(508, 82, true);
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>Author:</td>\r\n            <td>");
            EndContext();
            BeginContext(591, 12, false);
#line 24 "/Users/fengcu/Projects/FinalProject/FinalProject/Views/Home/Detaile.cshtml"
           Write(Model.Author);

#line default
#line hidden
            EndContext();
            BeginContext(603, 82, true);
            WriteLiteral("</td> \r\n        </tr>\r\n        <tr>\r\n            <td>Price:</td>\r\n            <td>");
            EndContext();
            BeginContext(686, 11, false);
#line 28 "/Users/fengcu/Projects/FinalProject/FinalProject/Views/Home/Detaile.cshtml"
           Write(Model.Price);

#line default
#line hidden
            EndContext();
            BeginContext(697, 90, true);
            WriteLiteral("</td>  \r\n        </tr>\r\n        <tr>\r\n            <td>Description: </td>\r\n            <td>");
            EndContext();
            BeginContext(788, 17, false);
#line 32 "/Users/fengcu/Projects/FinalProject/FinalProject/Views/Home/Detaile.cshtml"
           Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(805, 45, true);
            WriteLiteral("</td> \r\n        </tr>\r\n    </table>\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FinalProject.Models.Book> Html { get; private set; }
    }
}
#pragma warning restore 1591
