#pragma checksum "C:\Users\lioncub3\source\repos\ProjectBlogs\ProjectBlogs\Areas\Admin\Views\Blog\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "73004c054c3347db54e2c91e4a4683389351afc4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Blog_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Blog/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Blog/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_Blog_Index))]
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
#line 1 "C:\Users\lioncub3\source\repos\ProjectBlogs\ProjectBlogs\Areas\Admin\Views\_ViewImports.cshtml"
using ProjectBlogs;

#line default
#line hidden
#line 2 "C:\Users\lioncub3\source\repos\ProjectBlogs\ProjectBlogs\Areas\Admin\Views\_ViewImports.cshtml"
using ProjectBlogs.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"73004c054c3347db54e2c91e4a4683389351afc4", @"/Areas/Admin/Views/Blog/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"916ae79974f5680fff2e2a1332cc3710bb1403f1", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Blog_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ProjectBlogs.Models.Blog>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(46, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\lioncub3\source\repos\ProjectBlogs\ProjectBlogs\Areas\Admin\Views\Blog\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(89, 29, true);
            WriteLiteral("\r\n<h2>Блоги</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(118, 65, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "11f5e408425c42ac869c7a0a36708ac5", async() => {
                BeginContext(165, 14, true);
                WriteLiteral("Створити новий");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(183, 8, true);
            WriteLiteral("\r\n</p>\r\n");
            EndContext();
#line 12 "C:\Users\lioncub3\source\repos\ProjectBlogs\ProjectBlogs\Areas\Admin\Views\Blog\Index.cshtml"
 if (Model != null)
{

#line default
#line hidden
            BeginContext(215, 104, true);
            WriteLiteral("    <table class=\"table\">\r\n        <thead>\r\n            <tr>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(320, 40, false);
#line 18 "C:\Users\lioncub3\source\repos\ProjectBlogs\ProjectBlogs\Areas\Admin\Views\Blog\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(360, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(428, 47, false);
#line 21 "C:\Users\lioncub3\source\repos\ProjectBlogs\ProjectBlogs\Areas\Admin\Views\Blog\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(475, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(543, 43, false);
#line 24 "C:\Users\lioncub3\source\repos\ProjectBlogs\ProjectBlogs\Areas\Admin\Views\Blog\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Content));

#line default
#line hidden
            EndContext();
            BeginContext(586, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(654, 40, false);
#line 27 "C:\Users\lioncub3\source\repos\ProjectBlogs\ProjectBlogs\Areas\Admin\Views\Blog\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Date));

#line default
#line hidden
            EndContext();
            BeginContext(694, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(762, 44, false);
#line 30 "C:\Users\lioncub3\source\repos\ProjectBlogs\ProjectBlogs\Areas\Admin\Views\Blog\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.PhotoUrl));

#line default
#line hidden
            EndContext();
            BeginContext(806, 106, true);
            WriteLiteral("\r\n                </th>\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
            EndContext();
#line 36 "C:\Users\lioncub3\source\repos\ProjectBlogs\ProjectBlogs\Areas\Admin\Views\Blog\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
            BeginContext(969, 72, true);
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1042, 39, false);
#line 40 "C:\Users\lioncub3\source\repos\ProjectBlogs\ProjectBlogs\Areas\Admin\Views\Blog\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1081, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1161, 46, false);
#line 43 "C:\Users\lioncub3\source\repos\ProjectBlogs\ProjectBlogs\Areas\Admin\Views\Blog\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
            EndContext();
            BeginContext(1207, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1287, 42, false);
#line 46 "C:\Users\lioncub3\source\repos\ProjectBlogs\ProjectBlogs\Areas\Admin\Views\Blog\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Content));

#line default
#line hidden
            EndContext();
            BeginContext(1329, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1409, 39, false);
#line 49 "C:\Users\lioncub3\source\repos\ProjectBlogs\ProjectBlogs\Areas\Admin\Views\Blog\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Date));

#line default
#line hidden
            EndContext();
            BeginContext(1448, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1528, 43, false);
#line 52 "C:\Users\lioncub3\source\repos\ProjectBlogs\ProjectBlogs\Areas\Admin\Views\Blog\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.PhotoUrl));

#line default
#line hidden
            EndContext();
            BeginContext(1571, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1650, 53, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eb94efbfffde4812b941c7c449570a98", async() => {
                BeginContext(1695, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 55 "C:\Users\lioncub3\source\repos\ProjectBlogs\ProjectBlogs\Areas\Admin\Views\Blog\Index.cshtml"
                                               WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1703, 28, true);
            WriteLiteral(" |\r\n                        ");
            EndContext();
            BeginContext(1731, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f266068b82a44270b4fcc87134c35a1c", async() => {
                BeginContext(1779, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 56 "C:\Users\lioncub3\source\repos\ProjectBlogs\ProjectBlogs\Areas\Admin\Views\Blog\Index.cshtml"
                                                  WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1790, 28, true);
            WriteLiteral(" |\r\n                        ");
            EndContext();
            BeginContext(1818, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7c75fd8fc7a746dd88c8d2b7b19ea743", async() => {
                BeginContext(1865, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 57 "C:\Users\lioncub3\source\repos\ProjectBlogs\ProjectBlogs\Areas\Admin\Views\Blog\Index.cshtml"
                                                 WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1875, 52, true);
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 60 "C:\Users\lioncub3\source\repos\ProjectBlogs\ProjectBlogs\Areas\Admin\Views\Blog\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(1942, 32, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
            EndContext();
#line 63 "C:\Users\lioncub3\source\repos\ProjectBlogs\ProjectBlogs\Areas\Admin\Views\Blog\Index.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(1986, 92, true);
            WriteLiteral("    <div class=\"alert alert-info\">\r\n        <strong>Ще не має блогів!</strong>\r\n    </div>\r\n");
            EndContext();
#line 69 "C:\Users\lioncub3\source\repos\ProjectBlogs\ProjectBlogs\Areas\Admin\Views\Blog\Index.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ProjectBlogs.Models.Blog>> Html { get; private set; }
    }
}
#pragma warning restore 1591
