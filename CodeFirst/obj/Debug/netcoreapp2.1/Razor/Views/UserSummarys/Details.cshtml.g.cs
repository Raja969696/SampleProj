#pragma checksum "C:\Users\rajad\Downloads\CRUD-Code-First--master\CRUD-Code-First--master\CodeFirst\Views\UserSummarys\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "55e7150291a976378125952823887f5b9dc3436b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_UserSummarys_Details), @"mvc.1.0.view", @"/Views/UserSummarys/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/UserSummarys/Details.cshtml", typeof(AspNetCore.Views_UserSummarys_Details))]
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
#line 1 "C:\Users\rajad\Downloads\CRUD-Code-First--master\CRUD-Code-First--master\CodeFirst\Views\_ViewImports.cshtml"
using CodeFirst;

#line default
#line hidden
#line 2 "C:\Users\rajad\Downloads\CRUD-Code-First--master\CRUD-Code-First--master\CodeFirst\Views\_ViewImports.cshtml"
using CodeFirst.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55e7150291a976378125952823887f5b9dc3436b", @"/Views/UserSummarys/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5fb4c61a05f7736d5c0602b16382377486d8daed", @"/Views/_ViewImports.cshtml")]
    public class Views_UserSummarys_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CodeFirst.Models.UserProfile>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(36, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "C:\Users\rajad\Downloads\CRUD-Code-First--master\CRUD-Code-First--master\CodeFirst\Views\UserSummarys\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(77, 117, true);
            WriteLiteral("\n<h2>Details</h2>\n\n<div>\n    <h4>UserProfile</h4>\n    <hr />\n    <dl class=\"dl-horizontal\">\n        <dt>\n            ");
            EndContext();
            BeginContext(195, 40, false);
#line 14 "C:\Users\rajad\Downloads\CRUD-Code-First--master\CRUD-Code-First--master\CodeFirst\Views\UserSummarys\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(235, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(276, 36, false);
#line 17 "C:\Users\rajad\Downloads\CRUD-Code-First--master\CRUD-Code-First--master\CodeFirst\Views\UserSummarys\Details.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(312, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(353, 43, false);
#line 20 "C:\Users\rajad\Downloads\CRUD-Code-First--master\CRUD-Code-First--master\CodeFirst\Views\UserSummarys\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Address));

#line default
#line hidden
            EndContext();
            BeginContext(396, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(437, 39, false);
#line 23 "C:\Users\rajad\Downloads\CRUD-Code-First--master\CRUD-Code-First--master\CodeFirst\Views\UserSummarys\Details.cshtml"
       Write(Html.DisplayFor(model => model.Address));

#line default
#line hidden
            EndContext();
            BeginContext(476, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(517, 39, false);
#line 26 "C:\Users\rajad\Downloads\CRUD-Code-First--master\CRUD-Code-First--master\CodeFirst\Views\UserSummarys\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Age));

#line default
#line hidden
            EndContext();
            BeginContext(556, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(597, 35, false);
#line 29 "C:\Users\rajad\Downloads\CRUD-Code-First--master\CRUD-Code-First--master\CodeFirst\Views\UserSummarys\Details.cshtml"
       Write(Html.DisplayFor(model => model.Age));

#line default
#line hidden
            EndContext();
            BeginContext(632, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(673, 39, false);
#line 32 "C:\Users\rajad\Downloads\CRUD-Code-First--master\CRUD-Code-First--master\CodeFirst\Views\UserSummarys\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Dob));

#line default
#line hidden
            EndContext();
            BeginContext(712, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(753, 35, false);
#line 35 "C:\Users\rajad\Downloads\CRUD-Code-First--master\CRUD-Code-First--master\CodeFirst\Views\UserSummarys\Details.cshtml"
       Write(Html.DisplayFor(model => model.Dob));

#line default
#line hidden
            EndContext();
            BeginContext(788, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(829, 41, false);
#line 38 "C:\Users\rajad\Downloads\CRUD-Code-First--master\CRUD-Code-First--master\CodeFirst\Views\UserSummarys\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Phone));

#line default
#line hidden
            EndContext();
            BeginContext(870, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(911, 37, false);
#line 41 "C:\Users\rajad\Downloads\CRUD-Code-First--master\CRUD-Code-First--master\CodeFirst\Views\UserSummarys\Details.cshtml"
       Write(Html.DisplayFor(model => model.Phone));

#line default
#line hidden
            EndContext();
            BeginContext(948, 42, true);
            WriteLiteral("\n        </dd>\n    </dl>\n</div>\n<div>\n    ");
            EndContext();
            BeginContext(990, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "55e7150291a976378125952823887f5b9dc3436b8728", async() => {
                BeginContext(1036, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 46 "C:\Users\rajad\Downloads\CRUD-Code-First--master\CRUD-Code-First--master\CodeFirst\Views\UserSummarys\Details.cshtml"
                           WriteLiteral(Model.Id);

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
            BeginContext(1044, 7, true);
            WriteLiteral(" |\n    ");
            EndContext();
            BeginContext(1051, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "55e7150291a976378125952823887f5b9dc3436b11084", async() => {
                BeginContext(1073, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
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
            BeginContext(1089, 8, true);
            WriteLiteral("\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CodeFirst.Models.UserProfile> Html { get; private set; }
    }
}
#pragma warning restore 1591