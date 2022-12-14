#pragma checksum "D:\Space Cart - Application\SpaceCart\Views\Admin\Users.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "93e7a9e3634700d3d919cc45377477614788cdb3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Users), @"mvc.1.0.view", @"/Views/Admin/Users.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"93e7a9e3634700d3d919cc45377477614788cdb3", @"/Views/Admin/Users.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"274956b85d33e36565017fa41040f7006fe4f387", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Admin_Users : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SpaceCart.Models.ViewModel.AdminUsers>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Space Cart - Application\SpaceCart\Views\Admin\Users.cshtml"
  
    ViewData["Title"] = "Users";
    Layout = "~/Views/Admin/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Users</h1>

<div class=""container"">
    <style>
        a{
            margin-left: 3px;
        }
    </style>
    <h3>Administrators</h3>
    <table class=""table"">
        <thead>
            <tr>
                <td>Name</td>
                <td>Action</td>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 24 "D:\Space Cart - Application\SpaceCart\Views\Admin\Users.cshtml"
             foreach (var i in Model.Admins)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\n                    <td>");
#nullable restore
#line 27 "D:\Space Cart - Application\SpaceCart\Views\Admin\Users.cshtml"
                   Write(i.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("  ");
#nullable restore
#line 27 "D:\Space Cart - Application\SpaceCart\Views\Admin\Users.cshtml"
                               Write(i.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td>\n                        <a class=\"btn btn-info\"");
            BeginWriteAttribute("href", " href=\"", 652, "\"", 727, 4);
            WriteAttributeValue("", 659, "/api/admin/user/", 659, 16, true);
#nullable restore
#line 29 "D:\Space Cart - Application\SpaceCart\Views\Admin\Users.cshtml"
WriteAttributeValue("", 675, i.Id, 675, 5, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 680, "?role=simpleuser&redirect=", 680, 26, true);
#nullable restore
#line 29 "D:\Space Cart - Application\SpaceCart\Views\Admin\Users.cshtml"
WriteAttributeValue("", 706, Context.Request.Path, 706, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Simple user</a>\n                        <a class=\"btn btn-dark\"");
            BeginWriteAttribute("href", " href=\"", 792, "\"", 866, 4);
            WriteAttributeValue("", 799, "/api/admin/user/", 799, 16, true);
#nullable restore
#line 30 "D:\Space Cart - Application\SpaceCart\Views\Admin\Users.cshtml"
WriteAttributeValue("", 815, i.Id, 815, 5, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 820, "?role=moderator&redirect=", 820, 25, true);
#nullable restore
#line 30 "D:\Space Cart - Application\SpaceCart\Views\Admin\Users.cshtml"
WriteAttributeValue("", 845, Context.Request.Path, 845, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Moderator</a>\n                    </td>\n                </tr>\n");
#nullable restore
#line 33 "D:\Space Cart - Application\SpaceCart\Views\Admin\Users.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\n    </table>\n    <hr />\n    <h3>Moderators</h3>\n    <table class=\"table\">\n        <thead>\n            <tr>\n                <td>Name</td>\n                <td>Action</td>\n            </tr>\n        </thead>\n        <tbody>\n");
#nullable restore
#line 46 "D:\Space Cart - Application\SpaceCart\Views\Admin\Users.cshtml"
             foreach (var i in Model.Moderators)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\n                    <td>");
#nullable restore
#line 49 "D:\Space Cart - Application\SpaceCart\Views\Admin\Users.cshtml"
                   Write(i.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("  ");
#nullable restore
#line 49 "D:\Space Cart - Application\SpaceCart\Views\Admin\Users.cshtml"
                               Write(i.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td>\n                        <a class=\"btn btn-info\"");
            BeginWriteAttribute("href", " href=\"", 1386, "\"", 1461, 4);
            WriteAttributeValue("", 1393, "/api/admin/user/", 1393, 16, true);
#nullable restore
#line 51 "D:\Space Cart - Application\SpaceCart\Views\Admin\Users.cshtml"
WriteAttributeValue("", 1409, i.Id, 1409, 5, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1414, "?role=simpleuser&redirect=", 1414, 26, true);
#nullable restore
#line 51 "D:\Space Cart - Application\SpaceCart\Views\Admin\Users.cshtml"
WriteAttributeValue("", 1440, Context.Request.Path, 1440, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Simple user</a>\n                        <a class=\"btn btn-dark\"");
            BeginWriteAttribute("href", " href=\"", 1526, "\"", 1596, 4);
            WriteAttributeValue("", 1533, "/api/admin/user/", 1533, 16, true);
#nullable restore
#line 52 "D:\Space Cart - Application\SpaceCart\Views\Admin\Users.cshtml"
WriteAttributeValue("", 1549, i.Id, 1549, 5, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1554, "?role=admin&redirect=", 1554, 21, true);
#nullable restore
#line 52 "D:\Space Cart - Application\SpaceCart\Views\Admin\Users.cshtml"
WriteAttributeValue("", 1575, Context.Request.Path, 1575, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Administrator</a>\n                    </td>\n                </tr>\n");
#nullable restore
#line 55 "D:\Space Cart - Application\SpaceCart\Views\Admin\Users.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\n    </table>\n    <hr />\n    <h3>Simple users</h3>\n    <table class=\"table\">\n        <thead>\n            <tr>\n                <td>Name</td>\n                <td>Action</td>\n            </tr>\n        </thead>\n        <tbody>\n");
#nullable restore
#line 68 "D:\Space Cart - Application\SpaceCart\Views\Admin\Users.cshtml"
             foreach (var i in Model.Users)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\n                    <td>");
#nullable restore
#line 71 "D:\Space Cart - Application\SpaceCart\Views\Admin\Users.cshtml"
                   Write(i.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("  ");
#nullable restore
#line 71 "D:\Space Cart - Application\SpaceCart\Views\Admin\Users.cshtml"
                               Write(i.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td>\n                        <a class=\"btn btn-info\"");
            BeginWriteAttribute("href", " href=\"", 2117, "\"", 2191, 4);
            WriteAttributeValue("", 2124, "/api/admin/user/", 2124, 16, true);
#nullable restore
#line 73 "D:\Space Cart - Application\SpaceCart\Views\Admin\Users.cshtml"
WriteAttributeValue("", 2140, i.Id, 2140, 5, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2145, "?role=moderator&redirect=", 2145, 25, true);
#nullable restore
#line 73 "D:\Space Cart - Application\SpaceCart\Views\Admin\Users.cshtml"
WriteAttributeValue("", 2170, Context.Request.Path, 2170, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Moderator</a>\n                        <a class=\"btn btn-dark\"");
            BeginWriteAttribute("href", " href=\"", 2254, "\"", 2324, 4);
            WriteAttributeValue("", 2261, "/api/admin/user/", 2261, 16, true);
#nullable restore
#line 74 "D:\Space Cart - Application\SpaceCart\Views\Admin\Users.cshtml"
WriteAttributeValue("", 2277, i.Id, 2277, 5, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2282, "?role=admin&redirect=", 2282, 21, true);
#nullable restore
#line 74 "D:\Space Cart - Application\SpaceCart\Views\Admin\Users.cshtml"
WriteAttributeValue("", 2303, Context.Request.Path, 2303, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Administrator</a>\n                    </td>\n                </tr>\n");
#nullable restore
#line 77 "D:\Space Cart - Application\SpaceCart\Views\Admin\Users.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\n    </table>\n\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SpaceCart.Models.ViewModel.AdminUsers> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
