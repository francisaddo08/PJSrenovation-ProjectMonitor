#pragma checksum "C:\Users\Admin\Google Drive\pjs renovation ltd\PJSrenovationsSolution\PJSrenovationWeb\Pages\Clients\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "db3c38d7a265f70850ba26563dcffce218e03ce8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(PJSrenovationWeb.Pages.Clients.Pages_Clients_Details), @"mvc.1.0.razor-page", @"/Pages/Clients/Details.cshtml")]
namespace PJSrenovationWeb.Pages.Clients
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
#line 1 "C:\Users\Admin\Google Drive\pjs renovation ltd\PJSrenovationsSolution\PJSrenovationWeb\Pages\_ViewImports.cshtml"
using PJSrenovationWeb;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db3c38d7a265f70850ba26563dcffce218e03ce8", @"/Pages/Clients/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"361560c68f240a126124f6e8f876cbf9d14f1ff5", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Clients_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Properties/Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Projects/Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Projects/Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "C:\Users\Admin\Google Drive\pjs renovation ltd\PJSrenovationsSolution\PJSrenovationWeb\Pages\Clients\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Client Details</h1>\r\n\r\n<div>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "C:\Users\Admin\Google Drive\pjs renovation ltd\PJSrenovationsSolution\PJSrenovationWeb\Pages\Clients\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Client.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-4\">\r\n            ");
#nullable restore
#line 17 "C:\Users\Admin\Google Drive\pjs renovation ltd\PJSrenovationsSolution\PJSrenovationWeb\Pages\Clients\Details.cshtml"
       Write(Html.DisplayFor(model => model.Client.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 20 "C:\Users\Admin\Google Drive\pjs renovation ltd\PJSrenovationsSolution\PJSrenovationWeb\Pages\Clients\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Client.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-4\">\r\n            ");
#nullable restore
#line 23 "C:\Users\Admin\Google Drive\pjs renovation ltd\PJSrenovationsSolution\PJSrenovationWeb\Pages\Clients\Details.cshtml"
       Write(Html.DisplayFor(model => model.Client.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 26 "C:\Users\Admin\Google Drive\pjs renovation ltd\PJSrenovationsSolution\PJSrenovationWeb\Pages\Clients\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Client.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-4\">\r\n            ");
#nullable restore
#line 29 "C:\Users\Admin\Google Drive\pjs renovation ltd\PJSrenovationsSolution\PJSrenovationWeb\Pages\Clients\Details.cshtml"
       Write(Html.DisplayFor(model => model.Client.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 32 "C:\Users\Admin\Google Drive\pjs renovation ltd\PJSrenovationsSolution\PJSrenovationWeb\Pages\Clients\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Client.AddressLine1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-4\">\r\n            ");
#nullable restore
#line 35 "C:\Users\Admin\Google Drive\pjs renovation ltd\PJSrenovationsSolution\PJSrenovationWeb\Pages\Clients\Details.cshtml"
       Write(Html.DisplayFor(model => model.Client.AddressLine1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 38 "C:\Users\Admin\Google Drive\pjs renovation ltd\PJSrenovationsSolution\PJSrenovationWeb\Pages\Clients\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Client.AddressLine2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-4\">\r\n            ");
#nullable restore
#line 41 "C:\Users\Admin\Google Drive\pjs renovation ltd\PJSrenovationsSolution\PJSrenovationWeb\Pages\Clients\Details.cshtml"
       Write(Html.DisplayFor(model => model.Client.AddressLine2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 44 "C:\Users\Admin\Google Drive\pjs renovation ltd\PJSrenovationsSolution\PJSrenovationWeb\Pages\Clients\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Client.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-4\">\r\n            ");
#nullable restore
#line 47 "C:\Users\Admin\Google Drive\pjs renovation ltd\PJSrenovationsSolution\PJSrenovationWeb\Pages\Clients\Details.cshtml"
       Write(Html.DisplayFor(model => model.Client.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 50 "C:\Users\Admin\Google Drive\pjs renovation ltd\PJSrenovationsSolution\PJSrenovationWeb\Pages\Clients\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Client.County));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-4\">\r\n            ");
#nullable restore
#line 53 "C:\Users\Admin\Google Drive\pjs renovation ltd\PJSrenovationsSolution\PJSrenovationWeb\Pages\Clients\Details.cshtml"
       Write(Html.DisplayFor(model => model.Client.County));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 56 "C:\Users\Admin\Google Drive\pjs renovation ltd\PJSrenovationsSolution\PJSrenovationWeb\Pages\Clients\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Client.Postcode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-4\">\r\n            ");
#nullable restore
#line 59 "C:\Users\Admin\Google Drive\pjs renovation ltd\PJSrenovationsSolution\PJSrenovationWeb\Pages\Clients\Details.cshtml"
       Write(Html.DisplayFor(model => model.Client.Postcode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 62 "C:\Users\Admin\Google Drive\pjs renovation ltd\PJSrenovationsSolution\PJSrenovationWeb\Pages\Clients\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Client.Phone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-4\">\r\n            ");
#nullable restore
#line 65 "C:\Users\Admin\Google Drive\pjs renovation ltd\PJSrenovationsSolution\PJSrenovationWeb\Pages\Clients\Details.cshtml"
       Write(Html.DisplayFor(model => model.Client.Phone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 68 "C:\Users\Admin\Google Drive\pjs renovation ltd\PJSrenovationsSolution\PJSrenovationWeb\Pages\Clients\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Client.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-4\">\r\n            ");
#nullable restore
#line 71 "C:\Users\Admin\Google Drive\pjs renovation ltd\PJSrenovationsSolution\PJSrenovationWeb\Pages\Clients\Details.cshtml"
       Write(Html.DisplayFor(model => model.Client.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 74 "C:\Users\Admin\Google Drive\pjs renovation ltd\PJSrenovationsSolution\PJSrenovationWeb\Pages\Clients\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Client.EntryDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 77 "C:\Users\Admin\Google Drive\pjs renovation ltd\PJSrenovationsSolution\PJSrenovationWeb\Pages\Clients\Details.cshtml"
       Write(Html.DisplayFor(model => model.Client.EntryDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 80 "C:\Users\Admin\Google Drive\pjs renovation ltd\PJSrenovationsSolution\PJSrenovationWeb\Pages\Clients\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Client.Properties));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </dt>
        <dd class=""col-sm-10"">
            <table class=""table"">
                <tr>
                    <th>Address</th>
                    <th>Location</th>
                    <th>Postcode</th>
                    <th>Size</th>
                </tr>
");
#nullable restore
#line 90 "C:\Users\Admin\Google Drive\pjs renovation ltd\PJSrenovationsSolution\PJSrenovationWeb\Pages\Clients\Details.cshtml"
                 foreach (var item in Model.Client.Properties)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 94 "C:\Users\Admin\Google Drive\pjs renovation ltd\PJSrenovationsSolution\PJSrenovationWeb\Pages\Clients\Details.cshtml"
               Write(Html.DisplayFor(modelItem => item.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 97 "C:\Users\Admin\Google Drive\pjs renovation ltd\PJSrenovationsSolution\PJSrenovationWeb\Pages\Clients\Details.cshtml"
               Write(Html.DisplayFor(modelItem => item.Location));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 100 "C:\Users\Admin\Google Drive\pjs renovation ltd\PJSrenovationsSolution\PJSrenovationWeb\Pages\Clients\Details.cshtml"
               Write(Html.DisplayFor(modelItem => item.Postcode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 103 "C:\Users\Admin\Google Drive\pjs renovation ltd\PJSrenovationsSolution\PJSrenovationWeb\Pages\Clients\Details.cshtml"
               Write(Html.DisplayFor(modelltem => item.NumberOfRooms));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "db3c38d7a265f70850ba26563dcffce218e03ce815332", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 106 "C:\Users\Admin\Google Drive\pjs renovation ltd\PJSrenovationsSolution\PJSrenovationWeb\Pages\Clients\Details.cshtml"
                                                        WriteLiteral(item.PropertyID);

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
            WriteLiteral(" |\r\n");
#nullable restore
#line 107 "C:\Users\Admin\Google Drive\pjs renovation ltd\PJSrenovationsSolution\PJSrenovationWeb\Pages\Clients\Details.cshtml"
                     if (item.Project != null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <span>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "db3c38d7a265f70850ba26563dcffce218e03ce817907", async() => {
                WriteLiteral("Project");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 110 "C:\Users\Admin\Google Drive\pjs renovation ltd\PJSrenovationsSolution\PJSrenovationWeb\Pages\Clients\Details.cshtml"
                                                              WriteLiteral(item.Project.ProjectID);

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
            WriteLiteral("\r\n                        </span>\r\n");
#nullable restore
#line 112 "C:\Users\Admin\Google Drive\pjs renovation ltd\PJSrenovationsSolution\PJSrenovationWeb\Pages\Clients\Details.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <span>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "db3c38d7a265f70850ba26563dcffce218e03ce820529", async() => {
                WriteLiteral("New Project");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </span>\r\n");
#nullable restore
#line 118 "C:\Users\Admin\Google Drive\pjs renovation ltd\PJSrenovationsSolution\PJSrenovationWeb\Pages\Clients\Details.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </td>\r\n              \r\n\r\n            </tr>\r\n");
#nullable restore
#line 123 "C:\Users\Admin\Google Drive\pjs renovation ltd\PJSrenovationsSolution\PJSrenovationWeb\Pages\Clients\Details.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </table>\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "db3c38d7a265f70850ba26563dcffce218e03ce822368", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 129 "C:\Users\Admin\Google Drive\pjs renovation ltd\PJSrenovationsSolution\PJSrenovationWeb\Pages\Clients\Details.cshtml"
                           WriteLiteral(Model.Client.ID);

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
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "db3c38d7a265f70850ba26563dcffce218e03ce824553", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PJSrenovationWeb.Pages.Clients.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PJSrenovationWeb.Pages.Clients.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PJSrenovationWeb.Pages.Clients.DetailsModel>)PageContext?.ViewData;
        public PJSrenovationWeb.Pages.Clients.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
