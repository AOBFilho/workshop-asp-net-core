#pragma checksum "/Users/aobfilho/Documents/workspace/visual-studio/SalesWebMvc2/Views/SalesRecords/SimpleSearch.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "093d594bedccd458ea93b5a4e0089474930b98e1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SalesRecords_SimpleSearch), @"mvc.1.0.view", @"/Views/SalesRecords/SimpleSearch.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/SalesRecords/SimpleSearch.cshtml", typeof(AspNetCore.Views_SalesRecords_SimpleSearch))]
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
#line 1 "/Users/aobfilho/Documents/workspace/visual-studio/SalesWebMvc2/Views/_ViewImports.cshtml"
using SalesWebMvc2;

#line default
#line hidden
#line 2 "/Users/aobfilho/Documents/workspace/visual-studio/SalesWebMvc2/Views/_ViewImports.cshtml"
using SalesWebMvc2.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"093d594bedccd458ea93b5a4e0089474930b98e1", @"/Views/SalesRecords/SimpleSearch.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb0f58c19f066f7be5df120000c77f895f75bf77", @"/Views/_ViewImports.cshtml")]
    public class Views_SalesRecords_SimpleSearch : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SalesWebMvc2.Models.SalesRecord>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("navbar-form navbar-left"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(52, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "/Users/aobfilho/Documents/workspace/visual-studio/SalesWebMvc2/Views/SalesRecords/SimpleSearch.cshtml"
  
    ViewData["Title"] = "Simple Search";

#line default
#line hidden
            BeginContext(99, 5, true);
            WriteLiteral("\n<h2>");
            EndContext();
            BeginContext(105, 17, false);
#line 7 "/Users/aobfilho/Documents/workspace/visual-studio/SalesWebMvc2/Views/SalesRecords/SimpleSearch.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(122, 85, true);
            WriteLiteral("</h2>\n\n<nav class=\"navbar navbar-inverse\">\n    <div class=\"container-fluid\">\n        ");
            EndContext();
            BeginContext(207, 652, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "093d594bedccd458ea93b5a4e0089474930b98e14848", async() => {
                BeginContext(259, 211, true);
                WriteLiteral("\n            <div class=\"form-group\">\n                <div class=\"form-group\">\n                    <label for=\"minDate\">Min Date</label>\n                    <input type=\"date\" class=\"form-control\" name=\"minDate\"");
                EndContext();
                BeginWriteAttribute("value", " value=", 470, "", 497, 1);
#line 15 "/Users/aobfilho/Documents/workspace/visual-studio/SalesWebMvc2/Views/SalesRecords/SimpleSearch.cshtml"
WriteAttributeValue("", 477, ViewData["minDate"], 477, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(497, 200, true);
                WriteLiteral(" />\n                </div>\n                <div class=\"form-group\">\n                    <label for=\"maxDate\">Max Date</label>\n                    <input type=\"date\" class=\"form-control\" name=\"maxDate\"");
                EndContext();
                BeginWriteAttribute("value", " value=", 697, "", 724, 1);
#line 19 "/Users/aobfilho/Documents/workspace/visual-studio/SalesWebMvc2/Views/SalesRecords/SimpleSearch.cshtml"
WriteAttributeValue("", 704, ViewData["maxDate"], 704, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(724, 128, true);
                WriteLiteral(" />\n                </div>\n            </div>\n            <button type=\"submit\" class=\"btn btn-primary\">Filter</button>\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(859, 131, true);
            WriteLiteral("\n    </div>\n</nav>\n<div class=\"panel panel-primary\">\n    <div class=\"panel-heading\">\n        <h3 class=\"panel-title\">Total sales = ");
            EndContext();
            BeginContext(991, 43, false);
#line 28 "/Users/aobfilho/Documents/workspace/visual-studio/SalesWebMvc2/Views/SalesRecords/SimpleSearch.cshtml"
                                         Write(Model.Sum(obj => obj.Amount).ToString("F2"));

#line default
#line hidden
            EndContext();
            BeginContext(1034, 208, true);
            WriteLiteral("</h3>\n    </div>\n    <div class=\"panel-body\">\n        <table class=\"table table-striped table-hover\">\n            <thead>\n                <tr class=\"success\">\n                    <th>\n                        ");
            EndContext();
            BeginContext(1243, 38, false);
#line 35 "/Users/aobfilho/Documents/workspace/visual-studio/SalesWebMvc2/Views/SalesRecords/SimpleSearch.cshtml"
                   Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(1281, 76, true);
            WriteLiteral("\n                    </th>\n                    <th>\n                        ");
            EndContext();
            BeginContext(1358, 40, false);
#line 38 "/Users/aobfilho/Documents/workspace/visual-studio/SalesWebMvc2/Views/SalesRecords/SimpleSearch.cshtml"
                   Write(Html.DisplayNameFor(model => model.Date));

#line default
#line hidden
            EndContext();
            BeginContext(1398, 76, true);
            WriteLiteral("\n                    </th>\n                    <th>\n                        ");
            EndContext();
            BeginContext(1475, 42, false);
#line 41 "/Users/aobfilho/Documents/workspace/visual-studio/SalesWebMvc2/Views/SalesRecords/SimpleSearch.cshtml"
                   Write(Html.DisplayNameFor(model => model.Seller));

#line default
#line hidden
            EndContext();
            BeginContext(1517, 76, true);
            WriteLiteral("\n                    </th>\n                    <th>\n                        ");
            EndContext();
            BeginContext(1594, 53, false);
#line 44 "/Users/aobfilho/Documents/workspace/visual-studio/SalesWebMvc2/Views/SalesRecords/SimpleSearch.cshtml"
                   Write(Html.DisplayNameFor(model => model.Seller.Department));

#line default
#line hidden
            EndContext();
            BeginContext(1647, 76, true);
            WriteLiteral("\n                    </th>\n                    <th>\n                        ");
            EndContext();
            BeginContext(1724, 42, false);
#line 47 "/Users/aobfilho/Documents/workspace/visual-studio/SalesWebMvc2/Views/SalesRecords/SimpleSearch.cshtml"
                   Write(Html.DisplayNameFor(model => model.Amount));

#line default
#line hidden
            EndContext();
            BeginContext(1766, 76, true);
            WriteLiteral("\n                    </th>\n                    <th>\n                        ");
            EndContext();
            BeginContext(1843, 42, false);
#line 50 "/Users/aobfilho/Documents/workspace/visual-studio/SalesWebMvc2/Views/SalesRecords/SimpleSearch.cshtml"
                   Write(Html.DisplayNameFor(model => model.Status));

#line default
#line hidden
            EndContext();
            BeginContext(1885, 90, true);
            WriteLiteral("\n                    </th>\n                </tr>\n            </thead>\n            <tbody>\n");
            EndContext();
#line 55 "/Users/aobfilho/Documents/workspace/visual-studio/SalesWebMvc2/Views/SalesRecords/SimpleSearch.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
            BeginContext(2038, 82, true);
            WriteLiteral("                    <tr>\n                        <td>\n                            ");
            EndContext();
            BeginContext(2121, 37, false);
#line 59 "/Users/aobfilho/Documents/workspace/visual-studio/SalesWebMvc2/Views/SalesRecords/SimpleSearch.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
            EndContext();
            BeginContext(2158, 88, true);
            WriteLiteral("\n                        </td>\n                        <td>\n                            ");
            EndContext();
            BeginContext(2247, 39, false);
#line 62 "/Users/aobfilho/Documents/workspace/visual-studio/SalesWebMvc2/Views/SalesRecords/SimpleSearch.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Date));

#line default
#line hidden
            EndContext();
            BeginContext(2286, 88, true);
            WriteLiteral("\n                        </td>\n                        <td>\n                            ");
            EndContext();
            BeginContext(2375, 46, false);
#line 65 "/Users/aobfilho/Documents/workspace/visual-studio/SalesWebMvc2/Views/SalesRecords/SimpleSearch.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Seller.Name));

#line default
#line hidden
            EndContext();
            BeginContext(2421, 88, true);
            WriteLiteral("\n                        </td>\n                        <td>\n                            ");
            EndContext();
            BeginContext(2510, 57, false);
#line 68 "/Users/aobfilho/Documents/workspace/visual-studio/SalesWebMvc2/Views/SalesRecords/SimpleSearch.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Seller.Department.Name));

#line default
#line hidden
            EndContext();
            BeginContext(2567, 88, true);
            WriteLiteral("\n                        </td>\n                        <td>\n                            ");
            EndContext();
            BeginContext(2656, 41, false);
#line 71 "/Users/aobfilho/Documents/workspace/visual-studio/SalesWebMvc2/Views/SalesRecords/SimpleSearch.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Amount));

#line default
#line hidden
            EndContext();
            BeginContext(2697, 88, true);
            WriteLiteral("\n                        </td>\n                        <td>\n                            ");
            EndContext();
            BeginContext(2786, 41, false);
#line 74 "/Users/aobfilho/Documents/workspace/visual-studio/SalesWebMvc2/Views/SalesRecords/SimpleSearch.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Status));

#line default
#line hidden
            EndContext();
            BeginContext(2827, 57, true);
            WriteLiteral("\n                        </td>\n                    </tr>\n");
            EndContext();
#line 77 "/Users/aobfilho/Documents/workspace/visual-studio/SalesWebMvc2/Views/SalesRecords/SimpleSearch.cshtml"
                }

#line default
#line hidden
            BeginContext(2902, 56, true);
            WriteLiteral("            </tbody>\n        </table>\n    </div>\n</div> ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SalesWebMvc2.Models.SalesRecord>> Html { get; private set; }
    }
}
#pragma warning restore 1591