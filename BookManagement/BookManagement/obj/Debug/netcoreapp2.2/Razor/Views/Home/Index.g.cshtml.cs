#pragma checksum "/Users/fengcu/Projects/BookManagement/BookManagement/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c2c3992ca95e596f244819c0c2dc2f971b628034"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "/Users/fengcu/Projects/BookManagement/BookManagement/Views/_ViewImports.cshtml"
using BookManagement;

#line default
#line hidden
#line 2 "/Users/fengcu/Projects/BookManagement/BookManagement/Views/_ViewImports.cshtml"
using BookManagement.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c2c3992ca95e596f244819c0c2dc2f971b628034", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a3096475496e018f050ad657f055d832dbd214d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BookManagement.Models.Book>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/fengcu/Projects/BookManagement/BookManagement/Views/Home/Index.cshtml"
  
    ViewBag.Title = "Home Page";

#line default
#line hidden
            BeginContext(76, 1111, true);
            WriteLiteral(@"
<div class=""jumbotron"">
    <h1>Book Management System.</h1>
</div>
<div class=""row"">
    <div class=""col-md-4"">
        <h2>Welcome to Book Management System</h2>
        <p>
            Book Management System is a sample application that
            demonstrates how to use Entity Framework 6 in an
            ASP.NET MVC 5 web application.
        </p>
    </div>
    <div class=""col-md-4"">
        <h2>Build it from scratch</h2>
        <p>You can build the application by following the steps in the tutorial series on the ASP.NET site.</p>
        <p><a class=""btn btn-default"" href=""http://www.asp.net/mvc/tutorials/getting-started-with-ef-using-mvc/"">See the tutorial &raquo;</a></p>
    </div>
    <div class=""col-md-4"">
        <h2>Download it</h2>
        <p>You can download the completed project.</p>
        <p><a class=""btn btn-default"" href=""https://webpifeed.blob.core.windows.net/webpifeed/Partners/ASP.NET%20MVC%20Application%20Using%20Entity%20Framework%20Code%20First.zip"">Download");
            WriteLiteral(" &raquo;</a></p>\r\n    </div>\r\n\r\n\r\n</div>\r\n<table>\r\n    <tr>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(1188, 38, false);
#line 34 "/Users/fengcu/Projects/BookManagement/BookManagement/Views/Home/Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(1226, 43, true);
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(1270, 40, false);
#line 37 "/Users/fengcu/Projects/BookManagement/BookManagement/Views/Home/Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1310, 43, true);
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(1354, 42, false);
#line 40 "/Users/fengcu/Projects/BookManagement/BookManagement/Views/Home/Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Author));

#line default
#line hidden
            EndContext();
            BeginContext(1396, 63, true);
            WriteLiteral("\r\n        </th>\r\n        <th></th>\r\n    </tr>\r\n\r\n\r\n</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BookManagement.Models.Book> Html { get; private set; }
    }
}
#pragma warning restore 1591