#pragma checksum "E:\Synesis IT Files\Learning Period\Project1\ExamStation\ExamStation\ExamStation\Views\OnlineExams\OnlineExamList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8c540d6d92c513f99b83c81c25942d47e3d2d53f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_OnlineExams_OnlineExamList), @"mvc.1.0.view", @"/Views/OnlineExams/OnlineExamList.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8c540d6d92c513f99b83c81c25942d47e3d2d53f", @"/Views/OnlineExams/OnlineExamList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d239386da5732ece16716508642bdb81a96d2caf", @"/Views/_ViewImports.cshtml")]
    public class Views_OnlineExams_OnlineExamList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ExamStation.Models.ViewModels.OnlineExamListViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("control-label"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "PurchaseLists", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\Synesis IT Files\Learning Period\Project1\ExamStation\ExamStation\ExamStation\Views\OnlineExams\OnlineExamList.cshtml"
  
    ViewData["Title"] = "Create";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Online Exam List</h2>\r\n<hr />\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8c540d6d92c513f99b83c81c25942d47e3d2d53f6097", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8c540d6d92c513f99b83c81c25942d47e3d2d53f6359", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#nullable restore
#line 10 "E:\Synesis IT Files\Learning Period\Project1\ExamStation\ExamStation\ExamStation\Views\OnlineExams\OnlineExamList.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.ModelOnly;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <div class=\"row\">\r\n        <div class=\"col-lg-3\">\r\n            <div class=\"form-group\">\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8c540d6d92c513f99b83c81c25942d47e3d2d53f8188", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 14 "E:\Synesis IT Files\Learning Period\Project1\ExamStation\ExamStation\ExamStation\Views\OnlineExams\OnlineExamList.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Keyword);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8c540d6d92c513f99b83c81c25942d47e3d2d53f9824", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 15 "E:\Synesis IT Files\Learning Period\Project1\ExamStation\ExamStation\ExamStation\Views\OnlineExams\OnlineExamList.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Keyword);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8c540d6d92c513f99b83c81c25942d47e3d2d53f11454", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
#nullable restore
#line 16 "E:\Synesis IT Files\Learning Period\Project1\ExamStation\ExamStation\ExamStation\Views\OnlineExams\OnlineExamList.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Keyword);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
            </div>
        </div>
    </div>
    <div class=""panel biz-boxed"">
        <div class=""panel-heading"">
            <h4 id=""OnlineExamList"">Details:</h4>
        </div>
        <table id=""tblOnlineExamList"" class=""table table-bordered table-hover"">
            <thead>
                <tr class=""active"">
                    <th>#</th>
                    <th>Exam Title</th>
                    <th>Published</th>
                    <th>Payment Status</th>
                    <th>Cost</th>
                    <th>Action</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 36 "E:\Synesis IT Files\Learning Period\Project1\ExamStation\ExamStation\ExamStation\Views\OnlineExams\OnlineExamList.cshtml"
                 foreach (var item in Model.OnlineExamList)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 39 "E:\Synesis IT Files\Learning Period\Project1\ExamStation\ExamStation\ExamStation\Views\OnlineExams\OnlineExamList.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 40 "E:\Synesis IT Files\Learning Period\Project1\ExamStation\ExamStation\ExamStation\Views\OnlineExams\OnlineExamList.cshtml"
                       Write(Html.DisplayFor(modelItem => item.ExamTitle));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 41 "E:\Synesis IT Files\Learning Period\Project1\ExamStation\ExamStation\ExamStation\Views\OnlineExams\OnlineExamList.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Published));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 42 "E:\Synesis IT Files\Learning Period\Project1\ExamStation\ExamStation\ExamStation\Views\OnlineExams\OnlineExamList.cshtml"
                       Write(Html.DisplayFor(modelItem => item.PaymentStatus));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 43 "E:\Synesis IT Files\Learning Period\Project1\ExamStation\ExamStation\ExamStation\Views\OnlineExams\OnlineExamList.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Cost));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td>\r\n                            <a");
                BeginWriteAttribute("href", " href=\"", 1730, "\"", 1776, 1);
#nullable restore
#line 45 "E:\Synesis IT Files\Learning Period\Project1\ExamStation\ExamStation\ExamStation\Views\OnlineExams\OnlineExamList.cshtml"
WriteAttributeValue("", 1737, Url.Action("_TakeExam", "OnlineExams"), 1737, 39, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-success\" target=\"_blank\"");
                BeginWriteAttribute("onclick", " onclick=\"", 1817, "\"", 1913, 3);
                WriteAttributeValue("", 1827, "window.open(\'", 1827, 13, true);
#nullable restore
#line 45 "E:\Synesis IT Files\Learning Period\Project1\ExamStation\ExamStation\ExamStation\Views\OnlineExams\OnlineExamList.cshtml"
WriteAttributeValue("", 1840, Url.Action("_TakeExam", "OnlineExams"), 1840, 39, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1879, "\',\'name\',\'width=1200,height=600,\')", 1879, 34, true);
                EndWriteAttribute();
                WriteLiteral(@">Take Exam</a>
                            <a href=""/Purchases/Create"" type=""submit"" id=""edit"" class=""btn btn-default"" value=""Edit"">Edit</a>
                            <a href=""/Purchases/Create"" type=""submit"" id=""Delete"" class=""btn btn-danger"" value=""Delete"">Delete</a>
                        </td>
                    </tr>
");
#nullable restore
#line 50 "E:\Synesis IT Files\Learning Period\Project1\ExamStation\ExamStation\ExamStation\Views\OnlineExams\OnlineExamList.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<div class=\"form-group row\">\r\n    <a");
            BeginWriteAttribute("href", " href=\"", 2363, "\"", 2370, 0);
            EndWriteAttribute();
            WriteLiteral(" type=\"submit\" id=\"btnCSVExport\" class=\"btn btn-success\" value=\"Export\">Export To CSV</a>\r\n    <a");
            BeginWriteAttribute("href", " href=\"", 2468, "\"", 2475, 0);
            EndWriteAttribute();
            WriteLiteral(" type=\"submit\" id=\"btnExcelExport\" class=\"btn btn-success\" value=\"Export\">Export To Excel</a>\r\n</div>\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 62 "E:\Synesis IT Files\Learning Period\Project1\ExamStation\ExamStation\ExamStation\Views\OnlineExams\OnlineExamList.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <script type=\"text/javascript\">\r\n        $(document).ready(function(){\r\n            //TokenInput Call\r\n            $(\"#Keyword\").tokenInput(\"");
#nullable restore
#line 67 "E:\Synesis IT Files\Learning Period\Project1\ExamStation\ExamStation\ExamStation\Views\OnlineExams\OnlineExamList.cshtml"
                                 Write(Url.Action("GetKeyword", "OnlineExams"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@""",
                    {
                        theme: 'facebook',
                        tokeLimit: 1,
                        preventDuplicates: true
                    });
            //SearchBy Value on TokenInput
            $(""#token-input-Keyword"").blur(function () {
                var selectedValues = $(""#Keyword"").tokenInput(""get"");
                //console.log(selectedValues);
                $(""#KeywordId"").val(selectedValues[0].Id);
            })

            //Table To Excel
            $(""#btnExcelExport"").click(function () {
                $(""#tblOnlineExamList"").table2excel({
                        filename: ""Table.xls""
                    });
                });

            //Table To CSV
            $(""#btnCSVExport"").click(function () {
                $(""#tblOnlineExamList"").table2csv({
                    filename: ""Table.csv""
                });
            });
        });
    </script>

");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ExamStation.Models.ViewModels.OnlineExamListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
