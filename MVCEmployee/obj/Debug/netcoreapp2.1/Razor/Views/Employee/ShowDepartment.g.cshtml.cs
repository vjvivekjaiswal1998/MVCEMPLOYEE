#pragma checksum "C:\Users\vivek.jaiswal\source\repos\MVCEmployee\MVCEmployee\Views\Employee\ShowDepartment.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4e621759998cddef7e3db65f32c76668d0a3c52d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_ShowDepartment), @"mvc.1.0.view", @"/Views/Employee/ShowDepartment.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Employee/ShowDepartment.cshtml", typeof(AspNetCore.Views_Employee_ShowDepartment))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e621759998cddef7e3db65f32c76668d0a3c52d", @"/Views/Employee/ShowDepartment.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f9ff888c810264bb667bb43333a6e970109dd005", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_ShowDepartment : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Department.DTO.DepartmentDetail>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(53, 11, true);
            WriteLiteral("\r\n<p>\r\n    ");
            EndContext();
            BeginContext(64, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "06f2e72e619047b2a6934513dc639e84", async() => {
                BeginContext(87, 10, true);
                WriteLiteral("Create New");
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
            BeginContext(101, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(194, 48, false);
#line 10 "C:\Users\vivek.jaiswal\source\repos\MVCEmployee\MVCEmployee\Views\Employee\ShowDepartment.cshtml"
           Write(Html.DisplayNameFor(model => model.DepartmentId));

#line default
#line hidden
            EndContext();
            BeginContext(242, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(298, 50, false);
#line 13 "C:\Users\vivek.jaiswal\source\repos\MVCEmployee\MVCEmployee\Views\Employee\ShowDepartment.cshtml"
           Write(Html.DisplayNameFor(model => model.DepartmentName));

#line default
#line hidden
            EndContext();
            BeginContext(348, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 19 "C:\Users\vivek.jaiswal\source\repos\MVCEmployee\MVCEmployee\Views\Employee\ShowDepartment.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(483, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(544, 47, false);
#line 23 "C:\Users\vivek.jaiswal\source\repos\MVCEmployee\MVCEmployee\Views\Employee\ShowDepartment.cshtml"
               Write(Html.DisplayFor(modelItem => item.DepartmentId));

#line default
#line hidden
            EndContext();
            BeginContext(591, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(659, 49, false);
#line 26 "C:\Users\vivek.jaiswal\source\repos\MVCEmployee\MVCEmployee\Views\Employee\ShowDepartment.cshtml"
               Write(Html.DisplayFor(modelItem => item.DepartmentName));

#line default
#line hidden
            EndContext();
            BeginContext(708, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(776, 65, false);
#line 29 "C:\Users\vivek.jaiswal\source\repos\MVCEmployee\MVCEmployee\Views\Employee\ShowDepartment.cshtml"
               Write(Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(841, 24, true);
            WriteLiteral(" |\r\n                    ");
            EndContext();
            BeginContext(866, 71, false);
#line 30 "C:\Users\vivek.jaiswal\source\repos\MVCEmployee\MVCEmployee\Views\Employee\ShowDepartment.cshtml"
               Write(Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(937, 24, true);
            WriteLiteral(" |\r\n                    ");
            EndContext();
            BeginContext(962, 69, false);
#line 31 "C:\Users\vivek.jaiswal\source\repos\MVCEmployee\MVCEmployee\Views\Employee\ShowDepartment.cshtml"
               Write(Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1031, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 34 "C:\Users\vivek.jaiswal\source\repos\MVCEmployee\MVCEmployee\Views\Employee\ShowDepartment.cshtml"
        }

#line default
#line hidden
            BeginContext(1086, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
            EndContext();
            DefineSection("featured", async() => {
                BeginContext(1134, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(1140, 77, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7185a16b6cba498eada94a63ca37525b", async() => {
                    BeginContext(1163, 1, true);
                    WriteLiteral(" ");
                    EndContext();
                    BeginContext(1165, 48, false);
#line 39 "C:\Users\vivek.jaiswal\source\repos\MVCEmployee\MVCEmployee\Views\Employee\ShowDepartment.cshtml"
                       Write(Html.ActionLink("ADD", "AddDepartment", new { }));

#line default
#line hidden
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
                BeginContext(1217, 12, true);
                WriteLiteral("<br />\r\n    ");
                EndContext();
                BeginContext(1229, 79, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "58c5e59715d04fb9a512e79836a4a705", async() => {
                    BeginContext(1252, 1, true);
                    WriteLiteral(" ");
                    EndContext();
                    BeginContext(1254, 50, false);
#line 40 "C:\Users\vivek.jaiswal\source\repos\MVCEmployee\MVCEmployee\Views\Employee\ShowDepartment.cshtml"
                       Write(Html.ActionLink("SHOW", "ShowDepartment", new { }));

#line default
#line hidden
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
                BeginContext(1308, 2, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Department.DTO.DepartmentDetail>> Html { get; private set; }
    }
}
#pragma warning restore 1591
