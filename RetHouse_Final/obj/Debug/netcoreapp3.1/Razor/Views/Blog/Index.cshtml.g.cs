#pragma checksum "C:\Users\Administrator\Desktop\RetHouse_Final\RetHouse_Final\Views\Blog\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3dff13dc04ea4b848a8b6e38c38c3e3cac3159a3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_Index), @"mvc.1.0.view", @"/Views/Blog/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3dff13dc04ea4b848a8b6e38c38c3e3cac3159a3", @"/Views/Blog/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c3a312bca82feb75033b3acff2b47ae74393e0f", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BlogPhase>>
    {
        private global::AspNetCore.Views_Blog_Index.__Generated__CategoryViewComponentTagHelper __CategoryViewComponentTagHelper;
        private global::AspNetCore.Views_Blog_Index.__Generated__LatestBlogViewComponentTagHelper __LatestBlogViewComponentTagHelper;
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-white"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "blog", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "blogsingle", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-primary "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\Administrator\Desktop\RetHouse_Final\RetHouse_Final\Views\Blog\Index.cshtml"
  
    ViewData["Title"] = "Blog Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- BREADCRUMB -->
<div class=""bg-theme-overlay"">
    <section class=""section__breadcrumb "">
        <div class=""container"">
            <div class=""row d-flex justify-content-center"">
                <div class=""col-md-8 text-center"">
                    <h2 class=""text-capitalize text-white"">bloq</h2>
                    <ul class=""list-inline "">
                        <li class=""list-inline-item"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3dff13dc04ea4b848a8b6e38c38c3e3cac3159a36151", async() => {
                WriteLiteral("\r\n                                ana səhifə\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </li>\r\n                        <li class=\"list-inline-item\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3dff13dc04ea4b848a8b6e38c38c3e3cac3159a37787", async() => {
                WriteLiteral("\r\n                                bloq\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        </li>

                    </ul>
                </div>
            </div>
        </div>
    </section>
</div>
<!-- END BREADCRUMB -->
<!-- BLOG -->
<section>
    <div class=""container"">
        <div class=""row"">
            <!-- BLOG START -->
            <div class=""col-lg-8"">
                <div class=""row"">
");
#nullable restore
#line 40 "C:\Users\Administrator\Desktop\RetHouse_Final\RetHouse_Final\Views\Blog\Index.cshtml"
                     foreach (var item in Model)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "C:\Users\Administrator\Desktop\RetHouse_Final\RetHouse_Final\Views\Blog\Index.cshtml"
                         foreach (var blog in item.Blogs)
                        {


#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <div class=""col-md-6 col-lg-6"">
                                <div class=""blog__grid mt-0"">
                                    <!-- BLOG  -->
                                    <div class=""card__image"">
                                        <div class=""card__image-header h-250"">
                                            <img");
            BeginWriteAttribute("src", " src=\"", 1845, "\"", 1891, 1);
#nullable restore
#line 50 "C:\Users\Administrator\Desktop\RetHouse_Final\RetHouse_Final\Views\Blog\Index.cshtml"
WriteAttributeValue("", 1851, _cloudinaryServise.BuildUrl(blog.Image), 1851, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1892, "\"", 1898, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""img-fluid w100 img-transition"">

                                        </div>
                                        <div class=""card__image-body"">
                                            <!-- <span class=""badge badge-secondary p-1 text-capitalize mb-3"">May 08, 2019
                            </span> -->
                                            <h6 class=""text-capitalize"">
                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3dff13dc04ea4b848a8b6e38c38c3e3cac3159a311545", async() => {
#nullable restore
#line 57 "C:\Users\Administrator\Desktop\RetHouse_Final\RetHouse_Final\Views\Blog\Index.cshtml"
                                                                                                                                                Write(blog.Title);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 57 "C:\Users\Administrator\Desktop\RetHouse_Final\RetHouse_Final\Views\Blog\Index.cshtml"
                                                                                                   WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 57 "C:\Users\Administrator\Desktop\RetHouse_Final\RetHouse_Final\Views\Blog\Index.cshtml"
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
            WriteLiteral("\r\n                                            </h6>\r\n                                            <p class=\" mb-0\">\r\n                                                ");
#nullable restore
#line 60 "C:\Users\Administrator\Desktop\RetHouse_Final\RetHouse_Final\Views\Blog\Index.cshtml"
                                           Write(blog.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                                            </p>


                                        </div>
                                        <div class=""card__image-footer"">
                                            <figure>
                                                <img src=""images/profile-blog.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 2955, "\"", 2961, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""img-fluid rounded-circle"">
                                            </figure>
                                            <ul class=""list-inline my-auto"">
                                                <li class=""list-inline-item"">

                                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3dff13dc04ea4b848a8b6e38c38c3e3cac3159a316252", async() => {
                WriteLiteral("\r\n                                                        ");
#nullable restore
#line 74 "C:\Users\Administrator\Desktop\RetHouse_Final\RetHouse_Final\Views\Blog\Index.cshtml"
                                                   Write(item.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 73 "C:\Users\Administrator\Desktop\RetHouse_Final\RetHouse_Final\Views\Blog\Index.cshtml"
                                                                                                       WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 73 "C:\Users\Administrator\Desktop\RetHouse_Final\RetHouse_Final\Views\Blog\Index.cshtml"
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
            WriteLiteral(@"

                                                </li>

                                            </ul>
                                            <ul class=""list-inline my-auto ml-auto"">
                                                <li class=""list-inline-item"">
                                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3dff13dc04ea4b848a8b6e38c38c3e3cac3159a320194", async() => {
                WriteLiteral(@"
                                                        <small class=""text-white "">
                                                            ətraflı <i class=""fa fa-angle-right ml-1""></i>
                                                        </small>
                                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 82 "C:\Users\Administrator\Desktop\RetHouse_Final\RetHouse_Final\Views\Blog\Index.cshtml"
                                                                                                       WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 82 "C:\Users\Administrator\Desktop\RetHouse_Final\RetHouse_Final\Views\Blog\Index.cshtml"
                                                                                                                                   WriteLiteral(blog.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["BlogId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-BlogId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["BlogId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                                </li>

                                            </ul>
                                        </div>
                                    </div>
                                    <!-- END BLOG -->
                                </div>
                            </div>
");
#nullable restore
#line 95 "C:\Users\Administrator\Desktop\RetHouse_Final\RetHouse_Final\Views\Blog\Index.cshtml"

                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 96 "C:\Users\Administrator\Desktop\RetHouse_Final\RetHouse_Final\Views\Blog\Index.cshtml"
                         

                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </div>
            </div>
            <!-- END BLOG  -->
            <!-- WIDGET BLOG -->
            <div class=""col-lg-4"">
                <div class=""sticky-top"">
                    <aside>
                        <div class=""widget__sidebar mt-0"">
                            <div class=""widget__sidebar__header"">
                                <h6 class=""text-capitalize"">axtarış</h6>
                            </div>
                            <div class=""widget__sidebar__body"">
                                <div class=""input-group"">
                                    <input type=""text"" name=""search_term_string"" class=""form-control""
                                           placeholder=""Yazı axtar..."">
                                    <span class=""input-group-btn"">
                                        <button type=""submit"" class=""btn-search btn"">
                                            <i class=""fa fa-search""></i>
                                        <");
            WriteLiteral(@"/button>
                                    </span>
                                </div>
                            </div>

                        </div>
                    </aside>
                    <aside>
                        <div class=""widget__sidebar"">
                            <div class=""widget__sidebar__header"">
                                <h6 class=""text-capitalize"">Kateqoriyalar</h6>
                            </div>
                            <div class=""widget__sidebar__body"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("vc:category", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3dff13dc04ea4b848a8b6e38c38c3e3cac3159a326248", async() => {
            }
            );
            __CategoryViewComponentTagHelper = CreateTagHelper<global::AspNetCore.Views_Blog_Index.__Generated__CategoryViewComponentTagHelper>();
            __tagHelperExecutionContext.Add(__CategoryViewComponentTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </div>\r\n\r\n                        </div>\r\n                    </aside>\r\n                    <aside>\r\n                  ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("vc:latest-blog", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3dff13dc04ea4b848a8b6e38c38c3e3cac3159a327306", async() => {
            }
            );
            __LatestBlogViewComponentTagHelper = CreateTagHelper<global::AspNetCore.Views_Blog_Index.__Generated__LatestBlogViewComponentTagHelper>();
            __tagHelperExecutionContext.Add(__LatestBlogViewComponentTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </aside>
                    <aside>
                        <div class=""widget__sidebar"">
                            <div class=""widget__sidebar__header"">
                                <h6 class=""text-capitalize"">taqlar</h6>
                            </div>
                            <div class=""widget__sidebar__body"">
                                <div class=""blog__tags p-0"">
                                    <ul class=""list-inline"">
");
#nullable restore
#line 146 "C:\Users\Administrator\Desktop\RetHouse_Final\RetHouse_Final\Views\Blog\Index.cshtml"
                                         foreach (var item in Model)
                                        {
                                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 148 "C:\Users\Administrator\Desktop\RetHouse_Final\RetHouse_Final\Views\Blog\Index.cshtml"
                                             foreach (var blog in item.Blogs)
                                            {
                                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 150 "C:\Users\Administrator\Desktop\RetHouse_Final\RetHouse_Final\Views\Blog\Index.cshtml"
                                                 foreach (var relate in blog.BlogTagRelates)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <li class=\"list-inline-item\">\r\n                                                        <a href=\"#\">\r\n                                                            #");
#nullable restore
#line 154 "C:\Users\Administrator\Desktop\RetHouse_Final\RetHouse_Final\Views\Blog\Index.cshtml"
                                                        Write(relate.BlogTag.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                        </a>\r\n                                                    </li>\r\n");
#nullable restore
#line 157 "C:\Users\Administrator\Desktop\RetHouse_Final\RetHouse_Final\Views\Blog\Index.cshtml"
                                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 157 "C:\Users\Administrator\Desktop\RetHouse_Final\RetHouse_Final\Views\Blog\Index.cshtml"
                                                 
                                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 158 "C:\Users\Administrator\Desktop\RetHouse_Final\RetHouse_Final\Views\Blog\Index.cshtml"
                                             
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    </ul>
                                </div>
                            </div>

                        </div>
                    </aside>
                </div>
            </div>
            <!-- END WIDGET BLOG -->
        </div>
    </div>
</section>
<!-- END LISTING LIST -->");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public ICloudinaryService _cloudinaryServise { get; private set; }
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
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("vc:category")]
        public class __Generated__CategoryViewComponentTagHelper : Microsoft.AspNetCore.Razor.TagHelpers.TagHelper
        {
            private readonly global::Microsoft.AspNetCore.Mvc.IViewComponentHelper __helper = null;
            public __Generated__CategoryViewComponentTagHelper(global::Microsoft.AspNetCore.Mvc.IViewComponentHelper helper)
            {
                __helper = helper;
            }
            [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNotBoundAttribute, global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewContextAttribute]
            public global::Microsoft.AspNetCore.Mvc.Rendering.ViewContext ViewContext { get; set; }
            public override async global::System.Threading.Tasks.Task ProcessAsync(Microsoft.AspNetCore.Razor.TagHelpers.TagHelperContext __context, Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput __output)
            {
                (__helper as global::Microsoft.AspNetCore.Mvc.ViewFeatures.IViewContextAware)?.Contextualize(ViewContext);
                var __helperContent = await __helper.InvokeAsync("Category", new {  });
                __output.TagName = null;
                __output.Content.SetHtmlContent(__helperContent);
            }
        }
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("vc:latest-blog")]
        public class __Generated__LatestBlogViewComponentTagHelper : Microsoft.AspNetCore.Razor.TagHelpers.TagHelper
        {
            private readonly global::Microsoft.AspNetCore.Mvc.IViewComponentHelper __helper = null;
            public __Generated__LatestBlogViewComponentTagHelper(global::Microsoft.AspNetCore.Mvc.IViewComponentHelper helper)
            {
                __helper = helper;
            }
            [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNotBoundAttribute, global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewContextAttribute]
            public global::Microsoft.AspNetCore.Mvc.Rendering.ViewContext ViewContext { get; set; }
            public override async global::System.Threading.Tasks.Task ProcessAsync(Microsoft.AspNetCore.Razor.TagHelpers.TagHelperContext __context, Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput __output)
            {
                (__helper as global::Microsoft.AspNetCore.Mvc.ViewFeatures.IViewContextAware)?.Contextualize(ViewContext);
                var __helperContent = await __helper.InvokeAsync("LatestBlog", new {  });
                __output.TagName = null;
                __output.Content.SetHtmlContent(__helperContent);
            }
        }
    }
}
#pragma warning restore 1591
