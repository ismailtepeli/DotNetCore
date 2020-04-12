#pragma checksum "C:\Users\ismai\Desktop\GitHub\Core\DotNetCore\DotNetCore\DemoProject\IT.MvcWebUI\Views\Category\GetCategories.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "94fdbe8087c5c4738867404992cb74ad24b17e6d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Category_GetCategories), @"mvc.1.0.view", @"/Views/Category/GetCategories.cshtml")]
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
#line 1 "C:\Users\ismai\Desktop\GitHub\Core\DotNetCore\DotNetCore\DemoProject\IT.MvcWebUI\Views\_ViewImports.cshtml"
using IT.MvcWebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ismai\Desktop\GitHub\Core\DotNetCore\DotNetCore\DemoProject\IT.MvcWebUI\Views\_ViewImports.cshtml"
using IT.MvcWebUI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"94fdbe8087c5c4738867404992cb74ad24b17e6d", @"/Views/Category/GetCategories.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fff90ec6fa5d75564ba9170a241c46f5c2631e18", @"/Views/_ViewImports.cshtml")]
    public class Views_Category_GetCategories : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IT.MvcWebUI.Models.CategoryViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\ismai\Desktop\GitHub\Core\DotNetCore\DotNetCore\DemoProject\IT.MvcWebUI\Views\Category\GetCategories.cshtml"
  
    ViewData["Title"] = "GetCategories";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    <div class=""content-header"">
        <div class=""container-fluid"">
            <div class=""row mb-2"">
                <div class=""col-sm-6"">
                    <h1 class=""m-0 text-dark"">Starter Page</h1>
                </div><!-- /.col -->
                <div class=""col-sm-6"">
                    <ol class=""breadcrumb float-sm-right"">
                        <li class=""breadcrumb-item""><a href=""#"">Home</a></li>
                        <li class=""breadcrumb-item active"">Starter Page</li>
                    </ol>
                </div><!-- /.col -->
            </div><!-- /.row -->
        </div><!-- /.container-fluid -->
    </div>
<!-- Main content -->
<section class=""content "">
    <div class=""container-fluid"">
        <div class=""row  mb-2"">
            <div class=""col-lg-12"">
                <!-- Default box -->
                <div class=""card"">
                    <div class=""card-header"">
                        <h3 class=""card-title"">Projects</h3>

                   ");
            WriteLiteral(@"     <div class=""card-tools"">
                            <button type=""button"" class=""btn btn-tool"" data-card-widget=""collapse"" data-toggle=""tooltip"" title=""Collapse"">
                                <i class=""fas fa-minus""></i>
                            </button>
                            <button type=""button"" class=""btn btn-tool"" data-card-widget=""remove"" data-toggle=""tooltip"" title=""Remove"">
                                <i class=""fas fa-times""></i>
                            </button>
                        </div>
                    </div>
                    <div class=""card-body p-0"">
                        <table class=""table table-striped projects"">
                            <thead>
                                <tr>
                                    <th style=""width: 1%"">
                                        #
                                    </th>
                                    <th style=""width: 20%"">
                                        Name
        ");
            WriteLiteral(@"                            </th>
                                    <th style=""width: 30%"">
                                        AddedBy
                                    </th>
                                    <th>
                                        AddedDate
                                    </th>
                                    <th style=""width: 8%"" class=""text-center"">
                                        Status
                                    </th>
                                    <th style=""width: 20%"">
                                        Event
                                    </th>
                                </tr>
                            </thead>
                            <tbody>
");
#nullable restore
#line 66 "C:\Users\ismai\Desktop\GitHub\Core\DotNetCore\DotNetCore\DemoProject\IT.MvcWebUI\Views\Category\GetCategories.cshtml"
                                 foreach (var category in Model.Categories)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <td>");
#nullable restore
#line 69 "C:\Users\ismai\Desktop\GitHub\Core\DotNetCore\DotNetCore\DemoProject\IT.MvcWebUI\Views\Category\GetCategories.cshtml"
                                       Write(category.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 70 "C:\Users\ismai\Desktop\GitHub\Core\DotNetCore\DotNetCore\DemoProject\IT.MvcWebUI\Views\Category\GetCategories.cshtml"
                                       Write(category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 71 "C:\Users\ismai\Desktop\GitHub\Core\DotNetCore\DotNetCore\DemoProject\IT.MvcWebUI\Views\Category\GetCategories.cshtml"
                                       Write(category.AddedBy);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 72 "C:\Users\ismai\Desktop\GitHub\Core\DotNetCore\DotNetCore\DemoProject\IT.MvcWebUI\Views\Category\GetCategories.cshtml"
                                       Write(category.AddedDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 73 "C:\Users\ismai\Desktop\GitHub\Core\DotNetCore\DotNetCore\DemoProject\IT.MvcWebUI\Views\Category\GetCategories.cshtml"
                                       Write(category.isActive);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                                        <td>
                                            <button class=""btn btn-primary"">Edit</button>
                                            <button class=""btn btn-danger"">Delete</button>
                                        </td>
                                    </tr>
");
#nullable restore
#line 79 "C:\Users\ismai\Desktop\GitHub\Core\DotNetCore\DotNetCore\DemoProject\IT.MvcWebUI\Views\Category\GetCategories.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            </tbody>
                        </table>
                    </div>
                    <!-- /.card-body -->
                </div>
                <!-- /.card -->
            </div>
        </div>
    </div>
</section>
<!-- /.content -->
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IT.MvcWebUI.Models.CategoryViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
