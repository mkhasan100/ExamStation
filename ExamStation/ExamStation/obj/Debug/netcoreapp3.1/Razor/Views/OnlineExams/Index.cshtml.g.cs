#pragma checksum "E:\Synesis IT Files\Learning Period\Project1\ExamStation\ExamStation\ExamStation\Views\OnlineExams\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d4c96fdd4462f1c3929f4722489b58f185f8cf32"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_OnlineExams_Index), @"mvc.1.0.view", @"/Views/OnlineExams/Index.cshtml")]
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
#line 1 "E:\Synesis IT Files\Learning Period\Project1\ExamStation\ExamStation\ExamStation\Views\_ViewImports.cshtml"
using ExamStation;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Synesis IT Files\Learning Period\Project1\ExamStation\ExamStation\ExamStation\Views\_ViewImports.cshtml"
using ExamStation.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d4c96fdd4462f1c3929f4722489b58f185f8cf32", @"/Views/OnlineExams/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d239386da5732ece16716508642bdb81a96d2caf", @"/Views/_ViewImports.cshtml")]
    public class Views_OnlineExams_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ExamStation.Models.OnlineExam>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\Synesis IT Files\Learning Period\Project1\ExamStation\ExamStation\ExamStation\Views\OnlineExams\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d4c96fdd4462f1c3929f4722489b58f185f8cf324715", async() => {
                WriteLiteral("Create New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "E:\Synesis IT Files\Learning Period\Project1\ExamStation\ExamStation\ExamStation\Views\OnlineExams\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ExamTitle));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "E:\Synesis IT Files\Learning Period\Project1\ExamStation\ExamStation\ExamStation\Views\OnlineExams\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "E:\Synesis IT Files\Learning Period\Project1\ExamStation\ExamStation\ExamStation\Views\OnlineExams\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Class));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "E:\Synesis IT Files\Learning Period\Project1\ExamStation\ExamStation\ExamStation\Views\OnlineExams\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Section));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "E:\Synesis IT Files\Learning Period\Project1\ExamStation\ExamStation\ExamStation\Views\OnlineExams\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.StudentGroup));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 31 "E:\Synesis IT Files\Learning Period\Project1\ExamStation\ExamStation\ExamStation\Views\OnlineExams\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Subject));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 34 "E:\Synesis IT Files\Learning Period\Project1\ExamStation\ExamStation\ExamStation\Views\OnlineExams\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Instruction));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 37 "E:\Synesis IT Files\Learning Period\Project1\ExamStation\ExamStation\ExamStation\Views\OnlineExams\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ExamStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 40 "E:\Synesis IT Files\Learning Period\Project1\ExamStation\ExamStation\ExamStation\Views\OnlineExams\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ExamType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 43 "E:\Synesis IT Files\Learning Period\Project1\ExamStation\ExamStation\ExamStation\Views\OnlineExams\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Duration));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 46 "E:\Synesis IT Files\Learning Period\Project1\ExamStation\ExamStation\ExamStation\Views\OnlineExams\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.MarkType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 49 "E:\Synesis IT Files\Learning Period\Project1\ExamStation\ExamStation\ExamStation\Views\OnlineExams\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PassValue));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 52 "E:\Synesis IT Files\Learning Period\Project1\ExamStation\ExamStation\ExamStation\Views\OnlineExams\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PaymentStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 55 "E:\Synesis IT Files\Learning Period\Project1\ExamStation\ExamStation\ExamStation\Views\OnlineExams\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Published));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 61 "E:\Synesis IT Files\Learning Period\Project1\ExamStation\ExamStation\ExamStation\Views\OnlineExams\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 65 "E:\Synesis IT Files\Learning Period\Project1\ExamStation\ExamStation\ExamStation\Views\OnlineExams\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.ExamTitle));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 68 "E:\Synesis IT Files\Learning Period\Project1\ExamStation\ExamStation\ExamStation\Views\OnlineExams\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 71 "E:\Synesis IT Files\Learning Period\Project1\ExamStation\ExamStation\ExamStation\Views\OnlineExams\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Class));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 74 "E:\Synesis IT Files\Learning Period\Project1\ExamStation\ExamStation\ExamStation\Views\OnlineExams\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Section));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 77 "E:\Synesis IT Files\Learning Period\Project1\ExamStation\ExamStation\ExamStation\Views\OnlineExams\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.StudentGroup));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 80 "E:\Synesis IT Files\Learning Period\Project1\ExamStation\ExamStation\ExamStation\Views\OnlineExams\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Subject));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 83 "E:\Synesis IT Files\Learning Period\Project1\ExamStation\ExamStation\ExamStation\Views\OnlineExams\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Instruction));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 86 "E:\Synesis IT Files\Learning Period\Project1\ExamStation\ExamStation\ExamStation\Views\OnlineExams\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.ExamStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 89 "E:\Synesis IT Files\Learning Period\Project1\ExamStation\ExamStation\ExamStation\Views\OnlineExams\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.ExamType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 92 "E:\Synesis IT Files\Learning Period\Project1\ExamStation\ExamStation\ExamStation\Views\OnlineExams\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Duration));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 95 "E:\Synesis IT Files\Learning Period\Project1\ExamStation\ExamStation\ExamStation\Views\OnlineExams\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.MarkType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 98 "E:\Synesis IT Files\Learning Period\Project1\ExamStation\ExamStation\ExamStation\Views\OnlineExams\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.PassValue));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 101 "E:\Synesis IT Files\Learning Period\Project1\ExamStation\ExamStation\ExamStation\Views\OnlineExams\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.PaymentStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 104 "E:\Synesis IT Files\Learning Period\Project1\ExamStation\ExamStation\ExamStation\Views\OnlineExams\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Published));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 3378, "\"", 3424, 1);
#nullable restore
#line 107 "E:\Synesis IT Files\Learning Period\Project1\ExamStation\ExamStation\ExamStation\Views\OnlineExams\Index.cshtml"
WriteAttributeValue("", 3385, Url.Action("_TakeExam", "OnlineExams"), 3385, 39, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\" target=\"_blank\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3465, "\"", 3561, 3);
            WriteAttributeValue("", 3475, "window.open(\'", 3475, 13, true);
#nullable restore
#line 107 "E:\Synesis IT Files\Learning Period\Project1\ExamStation\ExamStation\ExamStation\Views\OnlineExams\Index.cshtml"
WriteAttributeValue("", 3488, Url.Action("_TakeExam", "OnlineExams"), 3488, 39, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3527, "\',\'name\',\'width=1200,height=600,\')", 3527, 34, true);
            EndWriteAttribute();
            WriteLiteral(">Take Exam</a>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d4c96fdd4462f1c3929f4722489b58f185f8cf3217509", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 108 "E:\Synesis IT Files\Learning Period\Project1\ExamStation\ExamStation\ExamStation\Views\OnlineExams\Index.cshtml"
                                           WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
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
            WriteLiteral(" |\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d4c96fdd4462f1c3929f4722489b58f185f8cf3219716", async() => {
                WriteLiteral("Details");
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
#nullable restore
#line 109 "E:\Synesis IT Files\Learning Period\Project1\ExamStation\ExamStation\ExamStation\Views\OnlineExams\Index.cshtml"
                                              WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
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
            WriteLiteral(" |\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d4c96fdd4462f1c3929f4722489b58f185f8cf3221929", async() => {
                WriteLiteral("Delete");
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
#nullable restore
#line 110 "E:\Synesis IT Files\Learning Period\Project1\ExamStation\ExamStation\ExamStation\Views\OnlineExams\Index.cshtml"
                                             WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 113 "E:\Synesis IT Files\Learning Period\Project1\ExamStation\ExamStation\ExamStation\Views\OnlineExams\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n\r\n<!-- Modal -->\r\n");
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ExamStation.Models.OnlineExam>> Html { get; private set; }
    }
}
#pragma warning restore 1591