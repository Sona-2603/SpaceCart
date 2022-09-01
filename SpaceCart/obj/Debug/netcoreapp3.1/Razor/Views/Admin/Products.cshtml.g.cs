#pragma checksum "D:\Space Cart - Application\SpaceCart\Views\Admin\Products.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "56de735c256da9dc6162401575fb89d4ddece50d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Products), @"mvc.1.0.view", @"/Views/Admin/Products.cshtml")]
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
#line 1 "D:\Space Cart - Application\SpaceCart\Views\_ViewImports.cshtml"
using SpaceCart;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Space Cart - Application\SpaceCart\Views\_ViewImports.cshtml"
using SpaceCart.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"56de735c256da9dc6162401575fb89d4ddece50d", @"/Views/Admin/Products.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"274956b85d33e36565017fa41040f7006fe4f387", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Admin_Products : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SpaceCart.Models.ViewModel.AdminProducts>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Space Cart - Application\SpaceCart\Views\Admin\Products.cshtml"
  
    ViewData["Title"] = "Products";
    Layout = "~/Views/Admin/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>Products</h1>\n<style>\n    .btn a {\n        margin-left: 3px;\n    }\n</style>\n<table class=\"table\">\n    <thead>\n        <tr>\n            <td>Name</td>\n            <td>Owner</td>\n            <td>Actions</td>\n        </tr>\n    </thead>\n    <tbody>\n");
#nullable restore
#line 22 "D:\Space Cart - Application\SpaceCart\Views\Admin\Products.cshtml"
         foreach (var i in Model.Products)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\n                <td>\n                    <a");
            BeginWriteAttribute("href", " href=\"", 501, "\"", 522, 2);
            WriteAttributeValue("", 508, "/product/", 508, 9, true);
#nullable restore
#line 26 "D:\Space Cart - Application\SpaceCart\Views\Admin\Products.cshtml"
WriteAttributeValue("", 517, i.Id, 517, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 26 "D:\Space Cart - Application\SpaceCart\Views\Admin\Products.cshtml"
                                        Write(i.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\n                </td>\n                <td>\n                    ");
#nullable restore
#line 29 "D:\Space Cart - Application\SpaceCart\Views\Admin\Products.cshtml"
               Write(i.CreatorUser.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 29 "D:\Space Cart - Application\SpaceCart\Views\Admin\Products.cshtml"
                                      Write(i.CreatorUser.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>\n                    <a class=\"btn btn-dark\"");
            BeginWriteAttribute("href", " href=\"", 728, "\"", 791, 4);
            WriteAttributeValue("", 735, "/api/product/remove/", 735, 20, true);
#nullable restore
#line 32 "D:\Space Cart - Application\SpaceCart\Views\Admin\Products.cshtml"
WriteAttributeValue("", 755, i.Id, 755, 5, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 760, "?redirect=", 760, 10, true);
#nullable restore
#line 32 "D:\Space Cart - Application\SpaceCart\Views\Admin\Products.cshtml"
WriteAttributeValue("", 770, Context.Request.Path, 770, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Remove</a>\n                    <a class=\"btn btn-info\"");
            BeginWriteAttribute("href", " href=\"", 847, "\"", 873, 2);
            WriteAttributeValue("", 854, "/product/edit/", 854, 14, true);
#nullable restore
#line 33 "D:\Space Cart - Application\SpaceCart\Views\Admin\Products.cshtml"
WriteAttributeValue("", 868, i.Id, 868, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a>\n                </td>\n            </tr>\n");
#nullable restore
#line 36 "D:\Space Cart - Application\SpaceCart\Views\Admin\Products.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n</table>\n<div class=\"container\">\n    <a class=\"btn btn-outline-success\" href=\"/product/edit/-10\">\n        New\n    </a>\n</div>\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SpaceCart.Models.ViewModel.AdminProducts> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591