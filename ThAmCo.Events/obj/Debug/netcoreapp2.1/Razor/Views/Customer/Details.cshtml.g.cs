#pragma checksum "C:\Users\Souchys\Desktop\Uni\Year 2\Web Apps and Services\WebAppsICA\ThAmCo.Events\Views\Customer\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f2245a58adfeb905d301b63bbe6e3dbc06e4f44e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_Details), @"mvc.1.0.view", @"/Views/Customer/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Customer/Details.cshtml", typeof(AspNetCore.Views_Customer_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f2245a58adfeb905d301b63bbe6e3dbc06e4f44e", @"/Views/Customer/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"003e11b98f4e83258e7425222a5fc2043b9ee1d9", @"/Views/_ViewImports.cshtml")]
    public class Views_Customer_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ThAmCo.Events.Models.CustomerViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(47, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(56, 183, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>Customer</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            Customer Full Name\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(240, 41, false);
#line 16 "C:\Users\Souchys\Desktop\Uni\Year 2\Web Apps and Services\WebAppsICA\ThAmCo.Events\Views\Customer\Details.cshtml"
       Write(Html.DisplayFor(model => model.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(281, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(296, 39, false);
#line 17 "C:\Users\Souchys\Desktop\Uni\Year 2\Web Apps and Services\WebAppsICA\ThAmCo.Events\Views\Customer\Details.cshtml"
       Write(Html.DisplayFor(model => model.Surname));

#line default
#line hidden
            EndContext();
            BeginContext(335, 108, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            Customer Email Address\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(444, 52, false);
#line 23 "C:\Users\Souchys\Desktop\Uni\Year 2\Web Apps and Services\WebAppsICA\ThAmCo.Events\Views\Customer\Details.cshtml"
       Write(Html.DisplayFor(model => model.CustomerEmailAddress));

#line default
#line hidden
            EndContext();
            BeginContext(496, 341, true);
            WriteLiteral(@"
        </dd>
    </dl>
</div>
<div>
    <table class=""table"">
        <thead>
            <tr>
                <th>
                    Event Title
                </th>
                <th>
                    Event Date
                </th>
                <th></th>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 41 "C:\Users\Souchys\Desktop\Uni\Year 2\Web Apps and Services\WebAppsICA\ThAmCo.Events\Views\Customer\Details.cshtml"
             foreach (var item in Model.Event) //Loops through each customer booking and displays event title, date and attended.
            {

#line default
#line hidden
            BeginContext(983, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1044, 40, false);
#line 45 "C:\Users\Souchys\Desktop\Uni\Year 2\Web Apps and Services\WebAppsICA\ThAmCo.Events\Views\Customer\Details.cshtml"
               Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
            EndContext();
            BeginContext(1084, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1152, 39, false);
#line 48 "C:\Users\Souchys\Desktop\Uni\Year 2\Web Apps and Services\WebAppsICA\ThAmCo.Events\Views\Customer\Details.cshtml"
               Write(Html.DisplayFor(modelItem => item.Date));

#line default
#line hidden
            EndContext();
            BeginContext(1191, 25, true);
            WriteLiteral("\r\n                </td>\r\n");
            EndContext();
            BeginContext(1546, 19, true);
            WriteLiteral("            </tr>\r\n");
            EndContext();
#line 57 "C:\Users\Souchys\Desktop\Uni\Year 2\Web Apps and Services\WebAppsICA\ThAmCo.Events\Views\Customer\Details.cshtml"
            }

#line default
#line hidden
            BeginContext(1580, 51, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1631, 62, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6e68540ee8a740059a339605c7d78d4b", async() => {
                BeginContext(1685, 4, true);
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
#line 62 "C:\Users\Souchys\Desktop\Uni\Year 2\Web Apps and Services\WebAppsICA\ThAmCo.Events\Views\Customer\Details.cshtml"
                           WriteLiteral(Model.CustomerID);

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
            BeginContext(1693, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1701, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "566b02513a50443aaadb0165e7ad9e6f", async() => {
                BeginContext(1723, 12, true);
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
            BeginContext(1739, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ThAmCo.Events.Models.CustomerViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
