#pragma checksum "C:\Users\Administrator\Desktop\RetHouse_Final\RetHouse_Final\Views\Shared\Components\BlogItem\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "40e5ed664401cb879d269626c06679389c6cdad5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_BlogItem_Default), @"mvc.1.0.view", @"/Views/Shared/Components/BlogItem/Default.cshtml")]
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
#line 1 "C:\Users\Administrator\Desktop\RetHouse_Final\RetHouse_Final\Views\_ViewImports.cshtml"
using RetHouse_Final;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Administrator\Desktop\RetHouse_Final\RetHouse_Final\Views\_ViewImports.cshtml"
using Repository.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Administrator\Desktop\RetHouse_Final\RetHouse_Final\Views\_ViewImports.cshtml"
using Repository.Services;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"40e5ed664401cb879d269626c06679389c6cdad5", @"/Views/Shared/Components/BlogItem/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c3a312bca82feb75033b3acff2b47ae74393e0f", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_BlogItem_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BlogPhase>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "blog", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "blogsingle", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-primary "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Administrator\Desktop\RetHouse_Final\RetHouse_Final\Views\Shared\Components\BlogItem\Default.cshtml"
 foreach (var item in Model)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Administrator\Desktop\RetHouse_Final\RetHouse_Final\Views\Shared\Components\BlogItem\Default.cshtml"
     foreach (var blog in item.Blogs)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-md-4\">\r\n            <!-- BLOG  -->\r\n            <div class=\"card__image\">\r\n                <div class=\"card__image-header h-250\">\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 336, "\"", 382, 1);
#nullable restore
#line 11 "C:\Users\Administrator\Desktop\RetHouse_Final\RetHouse_Final\Views\Shared\Components\BlogItem\Default.cshtml"
WriteAttributeValue("", 342, _cloudinaryService.BuildUrl(blog.Image), 342, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 383, "\"", 389, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid w100 img-transition\">\r\n");
#nullable restore
#line 12 "C:\Users\Administrator\Desktop\RetHouse_Final\RetHouse_Final\Views\Shared\Components\BlogItem\Default.cshtml"
                     foreach (var tag in blog.BlogTagRelates)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"info\"> ");
#nullable restore
#line 14 "C:\Users\Administrator\Desktop\RetHouse_Final\RetHouse_Final\Views\Shared\Components\BlogItem\Default.cshtml"
                                      Write(tag.BlogTag.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 15 "C:\Users\Administrator\Desktop\RetHouse_Final\RetHouse_Final\Views\Shared\Components\BlogItem\Default.cshtml"
                        break;
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </div>
                <div class=""card__image-body"">
                    <!-- <span class=""badge badge-secondary p-1 text-capitalize mb-3"">May 08, 2019 </span> -->
                    <h6 class=""text-capitalize"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "40e5ed664401cb879d269626c06679389c6cdad56793", async() => {
#nullable restore
#line 22 "C:\Users\Administrator\Desktop\RetHouse_Final\RetHouse_Final\Views\Shared\Components\BlogItem\Default.cshtml"
                                                                                                                        Write(blog.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 22 "C:\Users\Administrator\Desktop\RetHouse_Final\RetHouse_Final\Views\Shared\Components\BlogItem\Default.cshtml"
                                                                           WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 22 "C:\Users\Administrator\Desktop\RetHouse_Final\RetHouse_Final\Views\Shared\Components\BlogItem\Default.cshtml"
                                                                                                       WriteLiteral(blog.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["BlogId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-BlogId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["BlogId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </h6>\r\n                    <p class=\" mb-0\">\r\n                        ");
#nullable restore
#line 25 "C:\Users\Administrator\Desktop\RetHouse_Final\RetHouse_Final\Views\Shared\Components\BlogItem\Default.cshtml"
                   Write(blog.Text.Substring(0, 100));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ...\r\n\r\n                    </p>\r\n\r\n\r\n                </div>\r\n                <div class=\"card__image-footer\">\r\n                    <figure>\r\n                        <img src=\"images/profile-blog.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 1337, "\"", 1343, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid rounded-circle\">\r\n                    </figure>\r\n                    <ul class=\"list-inline my-auto\">\r\n                        <li class=\"list-inline-item \">\r\n                            <a href=\"#\">\r\n                                ");
#nullable restore
#line 38 "C:\Users\Administrator\Desktop\RetHouse_Final\RetHouse_Final\Views\Shared\Components\BlogItem\Default.cshtml"
                           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </a>\r\n\r\n                        </li>\r\n\r\n                    </ul>\r\n                    <ul class=\"list-inline my-auto ml-auto\">\r\n                        <li class=\"list-inline-item \">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "40e5ed664401cb879d269626c06679389c6cdad511871", async() => {
                WriteLiteral("\r\n                                <small class=\"text-white \">\r\n                                    ətraflı <i class=\"fa fa-angle-right ml-1\"></i>\r\n                                </small>\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 46 "C:\Users\Administrator\Desktop\RetHouse_Final\RetHouse_Final\Views\Shared\Components\BlogItem\Default.cshtml"
                                                                               WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 46 "C:\Users\Administrator\Desktop\RetHouse_Final\RetHouse_Final\Views\Shared\Components\BlogItem\Default.cshtml"
                                                                                                           WriteLiteral(blog.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["BlogId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-BlogId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["BlogId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </li>\r\n\r\n                    </ul>\r\n                </div>\r\n            </div>\r\n            <!-- END BLOG -->\r\n        </div>\r\n");
#nullable restore
#line 58 "C:\Users\Administrator\Desktop\RetHouse_Final\RetHouse_Final\Views\Shared\Components\BlogItem\Default.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 58 "C:\Users\Administrator\Desktop\RetHouse_Final\RetHouse_Final\Views\Shared\Components\BlogItem\Default.cshtml"
     

}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public ICloudinaryService _cloudinaryService { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BlogPhase>> Html { get; private set; }
    }
}
#pragma warning restore 1591
