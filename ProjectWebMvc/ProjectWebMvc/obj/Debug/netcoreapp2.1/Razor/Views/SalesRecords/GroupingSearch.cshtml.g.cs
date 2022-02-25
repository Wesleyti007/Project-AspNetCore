#pragma checksum "C:\Users\Wesley\Projetos\Project-AspNetCore\ProjectWebMvc\ProjectWebMvc\Views\SalesRecords\GroupingSearch.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4978de3e1651a5e2fa00ec7c46de7542939f1ae7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SalesRecords_GroupingSearch), @"mvc.1.0.view", @"/Views/SalesRecords/GroupingSearch.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/SalesRecords/GroupingSearch.cshtml", typeof(AspNetCore.Views_SalesRecords_GroupingSearch))]
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
#line 1 "C:\Users\Wesley\Projetos\Project-AspNetCore\ProjectWebMvc\ProjectWebMvc\Views\_ViewImports.cshtml"
using ProjectWebMvc;

#line default
#line hidden
#line 2 "C:\Users\Wesley\Projetos\Project-AspNetCore\ProjectWebMvc\ProjectWebMvc\Views\_ViewImports.cshtml"
using ProjectWebMvc.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4978de3e1651a5e2fa00ec7c46de7542939f1ae7", @"/Views/SalesRecords/GroupingSearch.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e0db6e33ec371cd9884e734f51d0b766a393706f", @"/Views/_ViewImports.cshtml")]
    public class Views_SalesRecords_GroupingSearch : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<IGrouping<Department, SalesRecord>>>
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
            BeginContext(56, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Wesley\Projetos\Project-AspNetCore\ProjectWebMvc\ProjectWebMvc\Views\SalesRecords\GroupingSearch.cshtml"
   
    ViewData["Title"] = "Grouping Search";
    DateTime minDate = DateTime.Parse(ViewData["minDate"] as string);
    DateTime maxDate = DateTime.Parse(ViewData["maxDate"] as string);

#line default
#line hidden
            BeginContext(252, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(259, 17, false);
#line 9 "C:\Users\Wesley\Projetos\Project-AspNetCore\ProjectWebMvc\ProjectWebMvc\Views\SalesRecords\GroupingSearch.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(276, 91, true);
            WriteLiteral("</h2>\r\n\r\n\r\n<nav class=\"navbar navbar-inverse\">\r\n    <div class=\"container-fluid\">\r\n        ");
            EndContext();
            BeginContext(367, 669, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4b0b0e056b0f407ebde943f8a893cc24", async() => {
                BeginContext(419, 218, true);
                WriteLiteral("\r\n            <div class=\"form-group\">\r\n                <div class=\"form-group\">\r\n                    <label form=\"minDate\"> Min Date </label>\r\n                    <input type=\"date\" class=\"form-control\" name=\"minDate\"");
                EndContext();
                BeginWriteAttribute("value", " value=", 637, "", 664, 1);
#line 18 "C:\Users\Wesley\Projetos\Project-AspNetCore\ProjectWebMvc\ProjectWebMvc\Views\SalesRecords\GroupingSearch.cshtml"
WriteAttributeValue("", 644, ViewData["minDate"], 644, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(664, 207, true);
                WriteLiteral(" />\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <label form=\"maxDate\"> Max Date </label>\r\n                    <input type=\"date\" class=\"form-control\" name=\"maxDate\"");
                EndContext();
                BeginWriteAttribute("value", " value=", 871, "", 898, 1);
#line 22 "C:\Users\Wesley\Projetos\Project-AspNetCore\ProjectWebMvc\ProjectWebMvc\Views\SalesRecords\GroupingSearch.cshtml"
WriteAttributeValue("", 878, ViewData["maxDate"], 878, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(898, 131, true);
                WriteLiteral(" />\r\n                </div>\r\n            </div>\r\n            <button type=\"submit\" class=\"btn btn-danger\">Filter</button>\r\n        ");
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
            BeginContext(1036, 24, true);
            WriteLiteral("\r\n    </div>\r\n</nav>\r\n\r\n");
            EndContext();
#line 30 "C:\Users\Wesley\Projetos\Project-AspNetCore\ProjectWebMvc\ProjectWebMvc\Views\SalesRecords\GroupingSearch.cshtml"
 foreach (var departmentGroup in Model)
{

#line default
#line hidden
            BeginContext(1104, 114, true);
            WriteLiteral("<div class=\"panel panel-primary\">\r\n    <div class=\"panel-heading\">\r\n        <h3 class=\"panel-title\"> Department = ");
            EndContext();
            BeginContext(1219, 24, false);
#line 34 "C:\Users\Wesley\Projetos\Project-AspNetCore\ProjectWebMvc\ProjectWebMvc\Views\SalesRecords\GroupingSearch.cshtml"
                                         Write(departmentGroup.Key.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1243, 16, true);
            WriteLiteral(", Total Sales = ");
            EndContext();
            BeginContext(1260, 63, false);
#line 34 "C:\Users\Wesley\Projetos\Project-AspNetCore\ProjectWebMvc\ProjectWebMvc\Views\SalesRecords\GroupingSearch.cshtml"
                                                                                  Write(departmentGroup.Key.TotalSales(minDate, maxDate).ToString("F2"));

#line default
#line hidden
            EndContext();
            BeginContext(1323, 568, true);
            WriteLiteral(@"</h3>
    </div>
    <div class=""panel-body"">
        <table class=""table table-striped table-hover"">
            <thead>
                <tr class=""success"">
                    <th>
                        Date
                    </th>
                    <th>
                        Amount
                    </th>
                    <th>
                        Seller
                    </th>
                    <th>
                       Status
                    </th>
                </tr>
            </thead>
            <tbody>
");
            EndContext();
#line 55 "C:\Users\Wesley\Projetos\Project-AspNetCore\ProjectWebMvc\ProjectWebMvc\Views\SalesRecords\GroupingSearch.cshtml"
                 foreach (var item in departmentGroup)
                {

#line default
#line hidden
            BeginContext(1966, 84, true);
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2051, 39, false);
#line 59 "C:\Users\Wesley\Projetos\Project-AspNetCore\ProjectWebMvc\ProjectWebMvc\Views\SalesRecords\GroupingSearch.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Date));

#line default
#line hidden
            EndContext();
            BeginContext(2090, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2182, 41, false);
#line 62 "C:\Users\Wesley\Projetos\Project-AspNetCore\ProjectWebMvc\ProjectWebMvc\Views\SalesRecords\GroupingSearch.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Amount));

#line default
#line hidden
            EndContext();
            BeginContext(2223, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2315, 46, false);
#line 65 "C:\Users\Wesley\Projetos\Project-AspNetCore\ProjectWebMvc\ProjectWebMvc\Views\SalesRecords\GroupingSearch.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Seller.Name));

#line default
#line hidden
            EndContext();
            BeginContext(2361, 116, true);
            WriteLiteral("\r\n                        </td>\r\n                       \r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2478, 41, false);
#line 69 "C:\Users\Wesley\Projetos\Project-AspNetCore\ProjectWebMvc\ProjectWebMvc\Views\SalesRecords\GroupingSearch.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Status));

#line default
#line hidden
            EndContext();
            BeginContext(2519, 60, true);
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 72 "C:\Users\Wesley\Projetos\Project-AspNetCore\ProjectWebMvc\ProjectWebMvc\Views\SalesRecords\GroupingSearch.cshtml"
                }

#line default
#line hidden
            BeginContext(2598, 60, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n");
            EndContext();
#line 77 "C:\Users\Wesley\Projetos\Project-AspNetCore\ProjectWebMvc\ProjectWebMvc\Views\SalesRecords\GroupingSearch.cshtml"
}

#line default
#line hidden
            BeginContext(2661, 4, true);
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<IGrouping<Department, SalesRecord>>> Html { get; private set; }
    }
}
#pragma warning restore 1591
