#pragma checksum "C:\Users\vivek.jaiswal\source\repos\MVCEmployee\MVCEmployee\Views\Employee\DeleteEmployeeDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d306699e8140127a206799edce1df3049bc25683"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_DeleteEmployeeDetail), @"mvc.1.0.view", @"/Views/Employee/DeleteEmployeeDetail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Employee/DeleteEmployeeDetail.cshtml", typeof(AspNetCore.Views_Employee_DeleteEmployeeDetail))]
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
#line 1 "C:\Users\vivek.jaiswal\source\repos\MVCEmployee\MVCEmployee\Views\_ViewImports.cshtml"
using MVCEmployee;

#line default
#line hidden
#line 2 "C:\Users\vivek.jaiswal\source\repos\MVCEmployee\MVCEmployee\Views\_ViewImports.cshtml"
using MVCEmployee.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d306699e8140127a206799edce1df3049bc25683", @"/Views/Employee/DeleteEmployeeDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f9ff888c810264bb667bb43333a6e970109dd005", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_DeleteEmployeeDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Employee.DTO.EmployeeDetail>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteEmployeeDetail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(36, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\vivek.jaiswal\source\repos\MVCEmployee\MVCEmployee\Views\Employee\DeleteEmployeeDetail.cshtml"
  
    ViewData["Title"] = "DeleteEmployeeDetail";

#line default
#line hidden
            BeginContext(94, 189, true);
            WriteLiteral("\r\n<h2>DeleteEmployeeDetail</h2>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>EmployeeDetail</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(284, 46, false);
#line 15 "C:\Users\vivek.jaiswal\source\repos\MVCEmployee\MVCEmployee\Views\Employee\DeleteEmployeeDetail.cshtml"
       Write(Html.DisplayNameFor(model => model.EmployeeId));

#line default
#line hidden
            EndContext();
            BeginContext(330, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(374, 42, false);
#line 18 "C:\Users\vivek.jaiswal\source\repos\MVCEmployee\MVCEmployee\Views\Employee\DeleteEmployeeDetail.cshtml"
       Write(Html.DisplayFor(model => model.EmployeeId));

#line default
#line hidden
            EndContext();
            BeginContext(416, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(460, 50, false);
#line 21 "C:\Users\vivek.jaiswal\source\repos\MVCEmployee\MVCEmployee\Views\Employee\DeleteEmployeeDetail.cshtml"
       Write(Html.DisplayNameFor(model => model.EmployeeNumber));

#line default
#line hidden
            EndContext();
            BeginContext(510, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(554, 46, false);
#line 24 "C:\Users\vivek.jaiswal\source\repos\MVCEmployee\MVCEmployee\Views\Employee\DeleteEmployeeDetail.cshtml"
       Write(Html.DisplayFor(model => model.EmployeeNumber));

#line default
#line hidden
            EndContext();
            BeginContext(600, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(644, 48, false);
#line 27 "C:\Users\vivek.jaiswal\source\repos\MVCEmployee\MVCEmployee\Views\Employee\DeleteEmployeeDetail.cshtml"
       Write(Html.DisplayNameFor(model => model.EmployeeName));

#line default
#line hidden
            EndContext();
            BeginContext(692, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(736, 44, false);
#line 30 "C:\Users\vivek.jaiswal\source\repos\MVCEmployee\MVCEmployee\Views\Employee\DeleteEmployeeDetail.cshtml"
       Write(Html.DisplayFor(model => model.EmployeeName));

#line default
#line hidden
            EndContext();
            BeginContext(780, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(824, 39, false);
#line 33 "C:\Users\vivek.jaiswal\source\repos\MVCEmployee\MVCEmployee\Views\Employee\DeleteEmployeeDetail.cshtml"
       Write(Html.DisplayNameFor(model => model.DOB));

#line default
#line hidden
            EndContext();
            BeginContext(863, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(907, 35, false);
#line 36 "C:\Users\vivek.jaiswal\source\repos\MVCEmployee\MVCEmployee\Views\Employee\DeleteEmployeeDetail.cshtml"
       Write(Html.DisplayFor(model => model.DOB));

#line default
#line hidden
            EndContext();
            BeginContext(942, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(986, 46, false);
#line 39 "C:\Users\vivek.jaiswal\source\repos\MVCEmployee\MVCEmployee\Views\Employee\DeleteEmployeeDetail.cshtml"
       Write(Html.DisplayNameFor(model => model.Experience));

#line default
#line hidden
            EndContext();
            BeginContext(1032, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1076, 42, false);
#line 42 "C:\Users\vivek.jaiswal\source\repos\MVCEmployee\MVCEmployee\Views\Employee\DeleteEmployeeDetail.cshtml"
       Write(Html.DisplayFor(model => model.Experience));

#line default
#line hidden
            EndContext();
            BeginContext(1118, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1162, 42, false);
#line 45 "C:\Users\vivek.jaiswal\source\repos\MVCEmployee\MVCEmployee\Views\Employee\DeleteEmployeeDetail.cshtml"
       Write(Html.DisplayNameFor(model => model.Gender));

#line default
#line hidden
            EndContext();
            BeginContext(1204, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1248, 38, false);
#line 48 "C:\Users\vivek.jaiswal\source\repos\MVCEmployee\MVCEmployee\Views\Employee\DeleteEmployeeDetail.cshtml"
       Write(Html.DisplayFor(model => model.Gender));

#line default
#line hidden
            EndContext();
            BeginContext(1286, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1330, 49, false);
#line 51 "C:\Users\vivek.jaiswal\source\repos\MVCEmployee\MVCEmployee\Views\Employee\DeleteEmployeeDetail.cshtml"
       Write(Html.DisplayNameFor(model => model.MarriedStatus));

#line default
#line hidden
            EndContext();
            BeginContext(1379, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1423, 45, false);
#line 54 "C:\Users\vivek.jaiswal\source\repos\MVCEmployee\MVCEmployee\Views\Employee\DeleteEmployeeDetail.cshtml"
       Write(Html.DisplayFor(model => model.MarriedStatus));

#line default
#line hidden
            EndContext();
            BeginContext(1468, 34, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n\r\n    ");
            EndContext();
            BeginContext(1502, 175, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3bca8876b3974552b32323aede317298", async() => {
                BeginContext(1542, 84, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-default\" /> |\r\n        ");
                EndContext();
                BeginContext(1626, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2998f949d1734021a60213a3f9da9466", async() => {
                    BeginContext(1648, 12, true);
                    WriteLiteral("Back to List");
                    EndContext();
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
                EndContext();
                BeginContext(1664, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1677, 10, true);
            WriteLiteral("\r\n</div>\r\n");
            EndContext();
            DefineSection("featured", async() => {
                BeginContext(1711, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(1717, 81, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "efd8dab4071c43bf9341090e10ef1bd6", async() => {
                    BeginContext(1740, 1, true);
                    WriteLiteral(" ");
                    EndContext();
                    BeginContext(1742, 52, false);
#line 65 "C:\Users\vivek.jaiswal\source\repos\MVCEmployee\MVCEmployee\Views\Employee\DeleteEmployeeDetail.cshtml"
                       Write(Html.ActionLink("ADD", "AddEmployeeDetail", new { }));

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1798, 12, true);
                WriteLiteral("<br />\r\n    ");
                EndContext();
                BeginContext(1810, 83, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "56de6169138e4e34b79bd4ae999c8578", async() => {
                    BeginContext(1833, 1, true);
                    WriteLiteral(" ");
                    EndContext();
                    BeginContext(1835, 54, false);
#line 66 "C:\Users\vivek.jaiswal\source\repos\MVCEmployee\MVCEmployee\Views\Employee\DeleteEmployeeDetail.cshtml"
                       Write(Html.ActionLink("SHOW", "ShowEmployeeDetail", new { }));

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1893, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Employee.DTO.EmployeeDetail> Html { get; private set; }
    }
}
#pragma warning restore 1591
