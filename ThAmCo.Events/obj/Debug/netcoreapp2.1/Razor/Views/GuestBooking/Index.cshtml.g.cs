#pragma checksum "C:\Users\Souchys\Desktop\Uni\Year 2\Web Apps and Services\WebAppsICA\ThAmCo.Events\Views\GuestBooking\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "26afc0a2e371cab2f97995531737153432841135"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_GuestBooking_Index), @"mvc.1.0.view", @"/Views/GuestBooking/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/GuestBooking/Index.cshtml", typeof(AspNetCore.Views_GuestBooking_Index))]
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
#line 1 "C:\Users\Souchys\Desktop\Uni\Year 2\Web Apps and Services\WebAppsICA\ThAmCo.Events\Views\_ViewImports.cshtml"
using ThAmCo.Events;

#line default
#line hidden
#line 2 "C:\Users\Souchys\Desktop\Uni\Year 2\Web Apps and Services\WebAppsICA\ThAmCo.Events\Views\_ViewImports.cshtml"
using ThAmCo.Events.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"26afc0a2e371cab2f97995531737153432841135", @"/Views/GuestBooking/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"003e11b98f4e83258e7425222a5fc2043b9ee1d9", @"/Views/_ViewImports.cshtml")]
    public class Views_GuestBooking_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ThAmCo.Events.Data.GuestBooking>>
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
            BeginContext(53, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Souchys\Desktop\Uni\Year 2\Web Apps and Services\WebAppsICA\ThAmCo.Events\Views\GuestBooking\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(96, 29, true);
            WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(125, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0042f56490c24dd1bf3e89e949b523f1", async() => {
                BeginContext(148, 10, true);
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
            BeginContext(162, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(255, 44, false);
#line 16 "C:\Users\Souchys\Desktop\Uni\Year 2\Web Apps and Services\WebAppsICA\ThAmCo.Events\Views\GuestBooking\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Customer));

#line default
#line hidden
            EndContext();
            BeginContext(299, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(355, 41, false);
#line 19 "C:\Users\Souchys\Desktop\Uni\Year 2\Web Apps and Services\WebAppsICA\ThAmCo.Events\Views\GuestBooking\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Event));

#line default
#line hidden
            EndContext();
            BeginContext(396, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(452, 44, false);
#line 22 "C:\Users\Souchys\Desktop\Uni\Year 2\Web Apps and Services\WebAppsICA\ThAmCo.Events\Views\GuestBooking\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Attended));

#line default
#line hidden
            EndContext();
            BeginContext(496, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 28 "C:\Users\Souchys\Desktop\Uni\Year 2\Web Apps and Services\WebAppsICA\ThAmCo.Events\Views\GuestBooking\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(614, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(663, 49, false);
#line 31 "C:\Users\Souchys\Desktop\Uni\Year 2\Web Apps and Services\WebAppsICA\ThAmCo.Events\Views\GuestBooking\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Customer.Email));

#line default
#line hidden
            EndContext();
            BeginContext(712, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(768, 46, false);
#line 34 "C:\Users\Souchys\Desktop\Uni\Year 2\Web Apps and Services\WebAppsICA\ThAmCo.Events\Views\GuestBooking\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Event.Title));

#line default
#line hidden
            EndContext();
            BeginContext(814, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(870, 43, false);
#line 37 "C:\Users\Souchys\Desktop\Uni\Year 2\Web Apps and Services\WebAppsICA\ThAmCo.Events\Views\GuestBooking\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Attended));

#line default
#line hidden
            EndContext();
            BeginContext(913, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(969, 65, false);
#line 40 "C:\Users\Souchys\Desktop\Uni\Year 2\Web Apps and Services\WebAppsICA\ThAmCo.Events\Views\GuestBooking\Index.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1034, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1055, 71, false);
#line 41 "C:\Users\Souchys\Desktop\Uni\Year 2\Web Apps and Services\WebAppsICA\ThAmCo.Events\Views\GuestBooking\Index.cshtml"
           Write(Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1126, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1147, 69, false);
#line 42 "C:\Users\Souchys\Desktop\Uni\Year 2\Web Apps and Services\WebAppsICA\ThAmCo.Events\Views\GuestBooking\Index.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1216, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 45 "C:\Users\Souchys\Desktop\Uni\Year 2\Web Apps and Services\WebAppsICA\ThAmCo.Events\Views\GuestBooking\Index.cshtml"
}

#line default
#line hidden
            BeginContext(1255, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ThAmCo.Events.Data.GuestBooking>> Html { get; private set; }
    }
}
#pragma warning restore 1591
